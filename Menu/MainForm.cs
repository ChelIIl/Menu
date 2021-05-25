using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Menu
{
    public partial class MainForm : Form
    {
        private DataTable tbl;
        private DataSet dataSet;
        List<DishGram> dg = new List<DishGram>();
        double break_norm = 0;
        double din_norm = 0;
        double aft_norm = 0;
        double car = 0;
        double fat = 0;
        double prot = 0;
        double sum;
        double num;

        public MainForm()
        {
            InitializeComponent();

            rec_din_kal_lbl.Text = din_norm.ToString();
            rec_break_kal_lbl.Text = break_norm.ToString();
            rec_aft_kal_lbl.Text = aft_norm.ToString();

            break_day_kal_lbl.Text = "0";
            din_day_kal_lbl.Text = "0";
            aft_day_kal_lbl.Text = "0";

            this.Fill();
        }

        public MainForm(double n)
        {
            InitializeComponent();

            rec_din_kal_lbl.Text = din_norm.ToString();
            rec_break_kal_lbl.Text = break_norm.ToString();
            rec_aft_kal_lbl.Text = aft_norm.ToString();

            break_day_kal_lbl.Text = "0";
            din_day_kal_lbl.Text = "0";
            aft_day_kal_lbl.Text = "0";

            this.Fill();
        }

        private void add_dish_btn_Click(object sender, EventArgs e)
        {
            Dish obj = (Dish)all_dish_list.SelectedItem;
            AddDishForm ad = new AddDishForm(obj);
            ad.ShowDialog();

            this.Fill();
        }

        public void Fill()
        {
            all_dish_list.Items.Clear();

            List<Dish> li = DBConnection.Entities.Dishes.ToList();

            foreach (Dish d in li)
            {
                all_dish_list.Items.Add(d);
            }
        }

        public void Fill(List<Dish> li)
        {
            all_dish_list.Items.Clear();

            foreach (Dish d in li)
            {
                all_dish_list.Items.Add(d);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Search();
        }

        public void Search()
        {
            List<Dish> li = DBConnection.Entities.Dishes.ToList();
            List<Dish> l = new List<Dish>();

            if (choose_search_par_combox.Text == "Ккал")
            {
                foreach (Dish d in li)
                {
                    if (d.Calories <= Convert.ToDouble(search_txt.Text))
                        l.Add(d);
                }

                this.Fill(l);
            }

            else if (choose_search_par_combox.Text == "Названию")
            {
                foreach (Dish d in li)
                {
                    if (d.DishName.ToLower().Contains(search_txt.Text.ToLower()))
                        l.Add(d);
                }

                this.Fill(l);
            }

            else if (choose_search_par_combox.Text == "Времени приёма")
            {
                foreach (Dish d in li)
                {
                    if (d.MealTime.ToLower().Contains(search_txt.Text.ToLower()))
                    {
                        l.Add(d);
                    }
                }

                this.Fill(l);
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            search_txt.Text = null;
            this.Fill();
        }

        private void del_dish_btn_Click(object sender, EventArgs e)
        {
            Dish dd = (Dish)all_dish_list.SelectedItem;
            DelDish(dd);
        }

        public void DelDish(Dish di)
        {
            List<Dish> li = DBConnection.Entities.Dishes.ToList();
            List<ClassMenu> dm = DBConnection.Entities.ClassMenus.ToList();

            if (di == null) { MessageBox.Show("Выберите блюдо для удаления!"); }
            else
            {
                foreach (Dish d in li)
                {
                    if (d.DishId == di.DishId)
                    {
                        foreach (ClassMenu dmt in dm)
                        {
                            if (dmt.IdDish == d.DishId)
                            {
                                DBConnection.Entities.ClassMenus.Remove(dmt);
                                DBConnection.Entities.Dishes.Remove(d);
                                DBConnection.Entities.SaveChanges();
                            }
                        }
                    }
                }

                this.Fill();
                MessageBox.Show("Блюдо успешно удалено!");
            }
        }

        private void add_break_dish_btn_Click(object sender, EventArgs e)
        {
            Dish obj = (Dish)all_dish_list.SelectedItem;
            if (obj == null) { MessageBox.Show("Выберите блюдо из списка!"); }
            else if (obj.MealTime.ToLower() != "завтрак") { MessageBox.Show("Это блюдо нельзя добавить в завтрак!"); }
            else
            { 
                DishGram dishGram = new DishGram();
                using (var f = new GramForm(obj))
                {
                    f.Owner = this;
                    var res = f.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        num = f.gram;
                        dishGram.d = obj;
                        dishGram.gramm = num;
                        dg.Add(dishGram);
                        car += obj.Carbohydrates * (num / 100);
                        fat += obj.Fats * (num / 100);
                        prot += obj.Protein * (num / 100);
                        break_norm += obj.Calories * (num / 100);
                        sum += obj.Calories * (num / 100);

                        if (Convert.ToDouble(break_day_kal_lbl.Text) < break_norm || Convert.ToDouble(norm_carbohydrates_lbl.Text) < car || Convert.ToDouble(norm_fats_lbl.Text) < fat || Convert.ToDouble(norm_proteins_lbl.Text) < prot)
                        {
                            car -= obj.Carbohydrates * (num / 100);
                            fat -= obj.Fats * (num / 100);
                            prot -= obj.Protein * (num / 100);
                            break_norm -= obj.Calories * (num / 100);
                            sum -= obj.Calories * (num / 100);

                            MessageBox.Show("Вы превысили норму углеводов!!!");
                        }

                        else
                        {
                            break_dish_list.Items.Add((Dish)all_dish_list.SelectedItem);

                            typed_carbohydrates_lbl.Text = car.ToString();
                            typed_fats_lbl.Text = fat.ToString();
                            typed_proteins_lbl.Text = prot.ToString();
                            rec_break_kal_lbl.Text = break_norm.ToString();
                        }

                        earn_day_kal_lbl.Text = sum.ToString();
                    }
                }
            }
        }

        private void del_break_dish_btn_Click(object sender, EventArgs e)
        {
            Dish obj = (Dish)break_dish_list.SelectedItem;

            if (obj == null) { MessageBox.Show("Выберите блюдо для удаления!"); }
            else
            {
                car -= obj.Carbohydrates * (num / 100);
                fat -= obj.Fats * (num / 100);
                prot -= obj.Protein * (num / 100);
                break_norm -= obj.Calories * (num / 100);
                sum -= obj.Calories * (num / 100);

                typed_carbohydrates_lbl.Text = car.ToString();
                typed_fats_lbl.Text = fat.ToString();
                typed_proteins_lbl.Text = prot.ToString();

                rec_break_kal_lbl.Text = break_norm.ToString();

                earn_day_kal_lbl.Text = sum.ToString();

                break_dish_list.Items.RemoveAt(break_dish_list.SelectedIndex);
            }

            earn_day_kal_lbl.Text = sum.ToString();
        }

        private void add_din_dish_btn_Click(object sender, EventArgs e)
        {
            Dish obj = (Dish)all_dish_list.SelectedItem;
            if (obj == null) { MessageBox.Show("Выберите блюдо из списка!"); }
            else if (obj.MealTime.ToLower() != "обед") { MessageBox.Show("Это блюдо нельзя добавить в обед!"); }
            else
            { 
                DishGram dishGram = new DishGram();
                using (var f = new GramForm(obj))
                {
                    f.Owner = this;
                    var res = f.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        double num = f.gram;
                        dishGram.d = obj;
                        dishGram.gramm = num;
                        dg.Add(dishGram);
                        car += obj.Carbohydrates * (num / 100);
                        fat += obj.Fats * (num / 100);
                        prot += obj.Protein * (num / 100);
                        din_norm += obj.Calories * (num / 100);
                        sum += obj.Calories * (num / 100);

                        if (Convert.ToDouble(din_day_kal_lbl.Text) < din_norm || Convert.ToDouble(norm_carbohydrates_lbl.Text) < car || Convert.ToDouble(norm_fats_lbl.Text) < fat || Convert.ToDouble(norm_proteins_lbl.Text) < prot)
                        {
                            car -= obj.Carbohydrates * (num / 100);
                            fat -= obj.Fats * (num / 100);
                            prot -= obj.Protein * (num / 100);
                            break_norm -= obj.Calories * (num / 100);
                            sum -= obj.Calories * (num / 100);

                            MessageBox.Show("Вы превысили норму!!!");
                        }

                        else
                        {
                            typed_carbohydrates_lbl.Text = car.ToString();
                            typed_fats_lbl.Text = fat.ToString();
                            typed_proteins_lbl.Text = prot.ToString();

                            din_dish_list.Items.Add(all_dish_list.SelectedItem);

                            rec_din_kal_lbl.Text = din_norm.ToString();
                        }

                        earn_day_kal_lbl.Text = sum.ToString();
                    }
                }
            }
        }

        private void del_din_dish_btn_Click(object sender, EventArgs e)
        {
            Dish obj = (Dish)din_dish_list.SelectedItem;

            if (obj == null) { MessageBox.Show("Выберите блюдо для удаления!"); }
            else
            {
                car -= obj.Carbohydrates * (num / 100);
                fat -= obj.Fats * (num / 100);
                prot -= obj.Protein * (num / 100);
                break_norm -= obj.Calories * (num / 100);
                sum -= obj.Calories * (num / 100);

                typed_carbohydrates_lbl.Text = car.ToString();
                typed_fats_lbl.Text = fat.ToString();
                typed_proteins_lbl.Text = prot.ToString();

                rec_din_kal_lbl.Text = din_norm.ToString();

                earn_day_kal_lbl.Text = sum.ToString();

                din_dish_list.Items.RemoveAt(din_dish_list.SelectedIndex);
            }
        }

        private void add_aft_dish_btn_Click(object sender, EventArgs e)
        {
            Dish obj = (Dish)all_dish_list.SelectedItem;
            if (obj == null) { MessageBox.Show("Выберите блюдо из списка!"); }
            else if (obj.MealTime.ToLower() != "полдник") { MessageBox.Show("Это блюдо нельзя добавить в полдник!"); }
            else
            {
                DishGram dishGram = new DishGram();
                using (var f = new GramForm(obj))
                {
                    f.Owner = this;
                    var res = f.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        double num = f.gram;
                        dishGram.d = obj;
                        dishGram.gramm = num;
                        dg.Add(dishGram);

                        car += obj.Carbohydrates * (num / 100);
                        fat += obj.Fats * (num / 100);
                        prot += obj.Protein * (num / 100);
                        aft_norm += obj.Calories * (num / 100);
                        sum += obj.Calories * (num / 100);

                        if (Convert.ToDouble(aft_day_kal_lbl.Text) < aft_norm || Convert.ToDouble(norm_carbohydrates_lbl.Text) < car || Convert.ToDouble(norm_fats_lbl.Text) < fat || Convert.ToDouble(norm_proteins_lbl.Text) < prot)
                        {
                            car -= obj.Carbohydrates * (num / 100);
                            fat -= obj.Fats * (num / 100);
                            prot -= obj.Protein * (num / 100);
                            break_norm -= obj.Calories * (num / 100);
                            sum -= obj.Calories * (num / 100);

                            MessageBox.Show("Вы превысили норму!!!");
                        }

                        else
                        {
                            typed_carbohydrates_lbl.Text = car.ToString();
                            typed_fats_lbl.Text = fat.ToString();
                            typed_proteins_lbl.Text = prot.ToString();

                            aft_dish_list.Items.Add(all_dish_list.SelectedItem);

                            rec_aft_kal_lbl.Text = aft_norm.ToString();
                        }

                        earn_day_kal_lbl.Text = sum.ToString();

                    }
                }
            }
        }

        private void del_aft_dish_btn_Click(object sender, EventArgs e)
        {
            Dish obj = (Dish)aft_dish_list.SelectedItem;

            if (obj == null) { MessageBox.Show("Выберите блюдо для удаления!"); }
            else
            {
                car -= obj.Carbohydrates * (num / 100);
                fat -= obj.Fats * (num / 100);
                prot -= obj.Protein * (num / 100);
                break_norm -= obj.Calories * (num / 100);
                sum -= obj.Calories * (num / 100);

                typed_carbohydrates_lbl.Text = car.ToString();
                typed_fats_lbl.Text = fat.ToString();
                typed_proteins_lbl.Text = prot.ToString();

                earn_day_kal_lbl.Text = sum.ToString();

                rec_aft_kal_lbl.Text = aft_norm.ToString();

                aft_dish_list.Items.RemoveAt(aft_dish_list.SelectedIndex);
            }
        }

        public double CalPercent(double cal, double per)
        {
            double res = cal * (per / 100);

            return res;
        }

        private void save_all_btn_Click(object sender, EventArgs e)
        {
            ClassMenu cm = new ClassMenu();
            List<Class> cli = DBConnection.Entities.Classes.ToList();
            List<Dish> clm = new List<Dish>();

            foreach (Dish d in break_dish_list.Items)
            {
                clm.Add(d);
            }

            foreach (Dish d in din_dish_list.Items)
            {
                clm.Add(d);
            }

            foreach (Dish d in aft_dish_list.Items)
            {
                clm.Add(d);
            }

            cm.Date = menu_date.Value;

            foreach (Class c in cli)
            {
                if (first_call_tlstr.Checked)
                {
                    if (c.Num < 5)
                    {
                        cm.ClassId = c.ClassId;

                        foreach (var d in clm)
                        {
                            foreach (DishGram item in dg)
                            {
                                if (d.DishId == item.d.DishId)
                                {
                                    cm.Gramm = item.gramm;
                                    cm.IdDish = d.DishId;
                                    break;
                                }
                            }

                            DBConnection.Entities.ClassMenus.Add(cm);
                            DBConnection.Entities.SaveChanges();
                        }
                    }
                }

                else if (second_call_tlstr.Checked)
                {
                    if (c.Num > 4 && c.Num < 10)
                    {
                        cm.ClassId = c.ClassId;

                        foreach (var d in clm)
                        {
                            foreach (DishGram item in dg)
                            {
                                if (d.DishId == item.d.DishId)
                                {
                                    cm.Gramm = item.gramm;
                                    cm.IdDish = d.DishId;
                                    break;
                                }
                            }

                            DBConnection.Entities.ClassMenus.Add(cm);
                            DBConnection.Entities.SaveChanges();
                        }
                    }
                }

                else if (third_call_tlstr.Checked)
                {
                    if (c.Num > 9)
                    {
                        cm.ClassId = c.ClassId;

                        foreach (var d in clm)
                        {
                            foreach (DishGram item in dg)
                            {
                                if (d.DishId == item.d.DishId)
                                {
                                    cm.Gramm = item.gramm;
                                    cm.IdDish = d.DishId;
                                    break;
                                }
                            }

                            DBConnection.Entities.ClassMenus.Add(cm);
                            DBConnection.Entities.SaveChanges();
                        }
                    }
                }
            }

            MessageBox.Show("Меню успешно сохранено!");
        }

        public void CheckDel()
        {
            if (first_call_tlstr.Selected)
            {
                first_call_tlstr.Checked = true;
                second_call_tlstr.Checked = false;
                third_call_tlstr.Checked = false;
            }
            else if (second_call_tlstr.Selected)
            {
                first_call_tlstr.Checked = false;
                second_call_tlstr.Checked = true;
                third_call_tlstr.Checked = false;
            }
            else if (third_call_tlstr.Selected)
            {
                first_call_tlstr.Checked = false;
                second_call_tlstr.Checked = false;
                third_call_tlstr.Checked = true;
            }
        }

        private void class_toolstr_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            List<Class> cl = DBConnection.Entities.Classes.ToList();

            if (first_call_tlstr.Selected)
            {
                foreach (Class c in cl)
                {
                    if (c.Num == 1 || c.Num == 2 || c.Num == 3 || c.Num == 4)
                    {
                        norm_carbohydrates_lbl.Text = c.Norm.NormCarbohydrates.ToString();
                        norm_fats_lbl.Text = c.Norm.NormFats.ToString();
                        norm_proteins_lbl.Text = c.Norm.NormProteins.ToString();
                        glob_day_kal_lbl.Text = c.Norm.DaylyRate.ToString();
                        CheckDel();
                        break;
                    }
                }
            }

            else if (second_call_tlstr.Selected)
            {
                foreach (Class c in cl)
                {
                    if (c.Num == 5 || c.Num == 6 || c.Num == 7 || c.Num == 8 || c.Num == 9)
                    {
                        norm_carbohydrates_lbl.Text = c.Norm.NormCarbohydrates.ToString();
                        norm_fats_lbl.Text = c.Norm.NormFats.ToString();
                        norm_proteins_lbl.Text = c.Norm.NormProteins.ToString();
                        glob_day_kal_lbl.Text = c.Norm.DaylyRate.ToString();
                        CheckDel();
                        break;
                    }
                }
            }

            else if (third_call_tlstr.Selected)
            {
                foreach (Class c in cl)
                {
                    if (c.Num == 10 || c.Num == 11)
                    {
                        norm_carbohydrates_lbl.Text = c.Norm.NormCarbohydrates.ToString();
                        norm_fats_lbl.Text = c.Norm.NormFats.ToString();
                        norm_proteins_lbl.Text = c.Norm.NormProteins.ToString();
                        glob_day_kal_lbl.Text = c.Norm.DaylyRate.ToString();
                        CheckDel();
                        break;
                    }
                }
            }

            break_day_kal_lbl.Text = CalPercent(Convert.ToDouble(glob_day_kal_lbl.Text), 25).ToString();
            din_day_kal_lbl.Text = CalPercent(Convert.ToDouble(glob_day_kal_lbl.Text), 35).ToString();
            aft_day_kal_lbl.Text = CalPercent(Convert.ToDouble(glob_day_kal_lbl.Text), 15).ToString();
        }

        private void choose_comp_menu_btn_Click(object sender, EventArgs e)
        {
            using (var f = new ChoiceMenuForm())
            {
                var res = f.ShowDialog();
                if (res == DialogResult.OK)
                {
                    break_dish_list.Items.Clear();
                    din_dish_list.Items.Clear();
                    aft_dish_list.Items.Clear();

                    if (f.classm == null)
                        this.Fill();
                    else
                    {
                        ClassMenu cm = f.classm;

                        List<ClassMenu> cl = DBConnection.Entities.ClassMenus.ToList();
                        List<Dish> d = DBConnection.Entities.Dishes.ToList();
                        menu_date.Value = cm.Date;

                        foreach (ClassMenu item in cl)
                        {
                            if (cm.ClassId == item.ClassId)
                            {
                                foreach (Dish val in d)
                                {
                                    if (val.DishId == item.IdDish)
                                    {
                                        if (val.MealTime.ToLower() == "завтрак")
                                        {
                                            break_dish_list.Items.Add(val);
                                            break_norm += val.Calories * Convert.ToDouble(item.Gramm / 100);
                                            car += val.Carbohydrates * Convert.ToDouble(item.Gramm / 100);
                                            fat += val.Fats * Convert.ToDouble(item.Gramm / 100);
                                            prot += val.Protein * Convert.ToDouble(item.Gramm / 100);
                                        }

                                        else if (val.MealTime.ToLower() == "обед")
                                        {
                                            din_dish_list.Items.Add(val);
                                            din_norm += val.Calories * Convert.ToDouble(item.Gramm / 100);
                                            car += val.Carbohydrates * Convert.ToDouble(item.Gramm / 100);
                                            fat += val.Fats * Convert.ToDouble(item.Gramm / 100);
                                            prot += val.Protein * Convert.ToDouble(item.Gramm / 100);
                                        }

                                        else if (val.MealTime.ToLower() == "полдник")
                                        {
                                            aft_dish_list.Items.Add(val);
                                            aft_norm += val.Calories * Convert.ToDouble(item.Gramm / 100);
                                            car += val.Carbohydrates * Convert.ToDouble(item.Gramm / 100);
                                            fat += val.Fats * Convert.ToDouble(item.Gramm / 100);
                                            prot += val.Protein * Convert.ToDouble(item.Gramm / 100);
                                        }
                                    }
                                }
                            }
                        }

                        rec_aft_kal_lbl.Text = aft_norm.ToString();
                        rec_break_kal_lbl.Text = break_norm.ToString();
                        rec_din_kal_lbl.Text = din_norm.ToString();
                        typed_carbohydrates_lbl.Text = car.ToString();
                        typed_fats_lbl.Text = fat.ToString();
                        typed_proteins_lbl.Text = prot.ToString();
                        earn_day_kal_lbl.Text = Convert.ToString(sum = break_norm + aft_norm + din_norm);
                    }
                }
            }

            this.Fill();
        }

        private void all_dish_list_DoubleClick(object sender, EventArgs e)
        {
            Dish obj = (Dish)all_dish_list.SelectedItem;
            AddDishForm adf = new AddDishForm(obj);

            adf.ShowDialog();

            this.Fill();
        }

        private void excel_btn_Click(object sender, EventArgs e)
        {
            List<Dish> li = new List<Dish>();
            GetAllDish(li);
            CreateDataTable(li);

            var excelApp = new Excel.Application();
            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            for (var i = 0; i < tbl.Columns.Count; i++)
            {
                workSheet.Cells[1, i + 1] = tbl.Columns[i].ColumnName;
            }

            for (var i = 0; i < tbl.Rows.Count; i++)
            {
                // to do: format datetime values before printing
                for (var j = 0; j < tbl.Columns.Count; j++)
                {
                    workSheet.Cells[i + 2, j + 1] = tbl.Rows[i][j];
                }
            }

            excelApp.Visible = true;
        }

        private void GetAllDish(List<Dish> li)
        {
            foreach(Dish dish in break_dish_list.Items)
            {
                li.Add(dish);
            }

            foreach (Dish dish in din_dish_list.Items)
            {
                li.Add(dish);
            }

            foreach (Dish dish in aft_dish_list.Items)
            {
                li.Add(dish);
            }
        }

        private void CreateDataTable(List<Dish> li)
        {

            tbl = new DataTable("DishTable");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Прием пищи,\n наименование блюда";
            column.Caption = "DishName";
            column.ReadOnly = true;
            column.Unique = false;
            tbl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "Белки";
            column.AutoIncrement = false;
            column.Caption = "Protein";
            column.ReadOnly = false;
            column.Unique = false;
            tbl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "Жиры";
            column.AutoIncrement = false;
            column.Caption = "Fats";
            column.ReadOnly = false;
            column.Unique = false;
            tbl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "Углеводы";
            column.AutoIncrement = false;
            column.Caption = "Carbohydrates";
            column.ReadOnly = false;
            column.Unique = false;
            tbl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "Калории";
            column.AutoIncrement = false;
            column.Caption = "Calories";
            column.ReadOnly = false;
            column.Unique = false;
            tbl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "Масса блюда";
            column.AutoIncrement = false;
            column.Caption = "Weight";
            column.ReadOnly = false;
            column.Unique = false;
            tbl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "Ca";
            column.AutoIncrement = false;
            column.Caption = "Ca";
            column.ReadOnly = false;
            column.Unique = false;
            tbl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "P";
            column.AutoIncrement = false;
            column.Caption = "P";
            column.ReadOnly = false;
            column.Unique = false;
            tbl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "Mg";
            column.AutoIncrement = false;
            column.Caption = "Mg";
            column.ReadOnly = false;
            column.Unique = false;
            tbl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "Fe";
            column.AutoIncrement = false;
            column.Caption = "Fe";
            column.ReadOnly = false;
            column.Unique = false;
            tbl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "B1";
            column.AutoIncrement = false;
            column.Caption = "B1";
            column.ReadOnly = false;
            column.Unique = false;
            tbl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "C";
            column.AutoIncrement = false;
            column.Caption = "C";
            column.ReadOnly = false;
            column.Unique = false;
            tbl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "A";
            column.AutoIncrement = false;
            column.Caption = "A";
            column.ReadOnly = false;
            column.Unique = false;
            tbl.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "E";
            column.AutoIncrement = false;
            column.Caption = "E";
            column.ReadOnly = false;
            column.Unique = false;
            tbl.Columns.Add(column);

            dataSet = new DataSet();
            dataSet.Tables.Add(tbl);


            row = tbl.NewRow();
            string txt = "ЗАВТРАК";
            row["Прием пищи,\n наименование блюда"] = txt;
            tbl.Rows.Add(row);
            foreach (var dish in li)
            {
                if (dish.MealTime == "Завтрак")
                {
                    row = tbl.NewRow();
                    row["Прием пищи,\n наименование блюда"] = dish.DishName;
                    row["Белки"] = dish.Protein;
                    row["Жиры"] = dish.Fats;
                    row["Углеводы"] = dish.Carbohydrates;
                    row["Калории"] = dish.Calories;
                    row["Масса блюда"] = dish.Weight;
                    row["Ca"] = dish.Ca;
                    row["P"] = dish.P;
                    row["Mg"] = dish.Mg;
                    row["Fe"] = dish.Fe;
                    row["B1"] = dish.B1;
                    row["C"] = dish.C;
                    row["A"] = dish.A;
                    row["E"] = dish.E;
                    tbl.Rows.Add(row);
                }
            }

            row = tbl.NewRow();
            row["Прием пищи,\n наименование блюда"] = "ОБЕД";
            tbl.Rows.Add(row);
            foreach (var dish in li)
            {
                if (dish.MealTime == "Обед")
                {
                    row = tbl.NewRow();
                    row["Прием пищи,\n наименование блюда"] = dish.DishName;
                    row["Белки"] = dish.Protein;
                    row["Жиры"] = dish.Fats;
                    row["Углеводы"] = dish.Carbohydrates;
                    row["Калории"] = dish.Calories;
                    row["Масса блюда"] = dish.Weight;
                    row["Ca"] = dish.Ca;
                    row["P"] = dish.P;
                    row["Mg"] = dish.Mg;
                    row["Fe"] = dish.Fe;
                    row["B1"] = dish.B1;
                    row["C"] = dish.C;
                    row["A"] = dish.A;
                    row["E"] = dish.E;
                    tbl.Rows.Add(row);
                }
            }

            row = tbl.NewRow();
            row["Прием пищи,\n наименование блюда"] = "ПОЛДНИК";
            tbl.Rows.Add(row);
            foreach (var dish in li)
            {
                if (dish.MealTime == "Полдник")
                {
                    row = tbl.NewRow();
                    row["Прием пищи,\n наименование блюда"] = dish.DishName;
                    row["Белки"] = dish.Protein;
                    row["Жиры"] = dish.Fats;
                    row["Углеводы"] = dish.Carbohydrates;
                    row["Калории"] = dish.Calories;
                    row["Масса блюда"] = dish.Weight;
                    row["Ca"] = dish.Ca;
                    row["P"] = dish.P;
                    row["Mg"] = dish.Mg;
                    row["Fe"] = dish.Fe;
                    row["B1"] = dish.B1;
                    row["C"] = dish.C;
                    row["A"] = dish.A;
                    row["E"] = dish.E;
                    tbl.Rows.Add(row);
                }
            }
        }
    }
}
