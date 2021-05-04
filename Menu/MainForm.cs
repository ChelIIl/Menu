using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Menu
{
    public partial class MainForm : Form
    {

        double break_norm = 0;
        double din_norm = 0;
        double aft_norm = 0;
        double car = 0;
        double fat = 0;
        double prot = 0;
        double sum;

        public MainForm()
        {
            InitializeComponent();

            rec_din_kal_lbl.Text = din_norm.ToString();
            rec_break_kal_lbl.Text = break_norm.ToString();
            rec_aft_kal_lbl.Text = aft_norm.ToString();

            //break_day_kal_lbl.Text = "450"; // было
            //din_day_kal_lbl.Text = "750";
            //aft_day_kal_lbl.Text = "300";

            break_day_kal_lbl.Text = "0"; // стало
            din_day_kal_lbl.Text = "0";
            aft_day_kal_lbl.Text = "0";

            this.Fill();
        }

        private void add_dish_btn_Click(object sender, EventArgs e)
        {
            AddDishForm ad = new AddDishForm();
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
            //List<ClassMenu> l2 = new List<ClassMenu>();
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

        //private void add_break_dish_btn_Click(object sender, EventArgs e) // было
        //{
        //    Dish obj = (Dish)all_dish_list.SelectedItem;

        //    if (obj == null) { MessageBox.Show("Выберите блюдо из списка!"); }
        //    else
        //    {
        //        break_norm += obj.Calories;

        //        if (Convert.ToDouble(break_day_kal_lbl.Text) < break_norm)
        //        {
        //            break_norm -= obj.Calories;

        //            MessageBox.Show("Вы превысили норму ккал!!!");
        //        }

        //        else
        //        {
        //            break_dish_list.Items.Add((Dish)all_dish_list.SelectedItem);

        //            rec_break_kal_lbl.Text = break_norm.ToString();
        //        }
        //    }
        //}

        private void add_break_dish_btn_Click(object sender, EventArgs e) // стало
        {
            Dish obj = (Dish)all_dish_list.SelectedItem;

            if (obj == null) { MessageBox.Show("Выберите блюдо из списка!"); }
            else
            {
                car += obj.Carbohydrates;
                fat += obj.Fats;
                prot += obj.Protein;
                break_norm += obj.Calories;
                sum += obj.Calories;

                if (Convert.ToDouble(break_day_kal_lbl.Text) < break_norm || Convert.ToDouble(norm_carbohydrates_lbl.Text) < car || Convert.ToDouble(norm_fats_lbl.Text) < fat || Convert.ToDouble(norm_proteins_lbl.Text) < prot)
                {
                    car -= obj.Carbohydrates;
                    fat -= obj.Fats;
                    prot -= obj.Protein;
                    break_norm -= obj.Calories;
                    sum -= obj.Calories;

                    MessageBox.Show("Вы превысили норму!!!");
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

        private void del_break_dish_btn_Click(object sender, EventArgs e)
        {
            Dish obj = (Dish)break_dish_list.SelectedItem;

            if (obj == null) { MessageBox.Show("Выберите блюдо для удаления!"); }
            else
            {
                car -= obj.Carbohydrates;
                fat -= obj.Fats;
                prot -= obj.Protein;
                break_norm -= obj.Calories;
                sum -= obj.Calories;

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
            else
            {
                car += obj.Carbohydrates;
                fat += obj.Fats;
                prot += obj.Protein;
                din_norm += obj.Calories;
                sum += obj.Calories;

                if (Convert.ToDouble(din_day_kal_lbl.Text) < din_norm || Convert.ToDouble(norm_carbohydrates_lbl.Text) < car || Convert.ToDouble(norm_fats_lbl.Text) < fat || Convert.ToDouble(norm_proteins_lbl.Text) < prot)
                {
                    car -= obj.Carbohydrates;
                    fat -= obj.Fats;
                    prot -= obj.Protein;
                    din_norm -= obj.Calories;
                    sum -= obj.Calories;

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

        private void del_din_dish_btn_Click(object sender, EventArgs e)
        {
            Dish obj = (Dish)din_dish_list.SelectedItem;

            if (obj == null) { MessageBox.Show("Выберите блюдо для удаления!"); }
            else
            {
                car -= obj.Carbohydrates;
                fat -= obj.Fats;
                prot -= obj.Protein;
                din_norm -= obj.Calories;
                sum -= obj.Calories;

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
            else
            {
                car += obj.Carbohydrates;
                fat += obj.Fats;
                prot += obj.Protein;
                aft_norm += obj.Calories;
                sum += obj.Calories;

                if (Convert.ToDouble(aft_day_kal_lbl.Text) < aft_norm || Convert.ToDouble(norm_carbohydrates_lbl.Text) < car || Convert.ToDouble(norm_fats_lbl.Text) < fat || Convert.ToDouble(norm_proteins_lbl.Text) < prot)
                {
                    car -= obj.Carbohydrates;
                    fat -= obj.Fats;
                    prot -= obj.Protein;
                    aft_norm -= obj.Calories;
                    sum -= obj.Calories;

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

        private void del_aft_dish_btn_Click(object sender, EventArgs e)
        {
            Dish obj = (Dish)aft_dish_list.SelectedItem;

            if (obj == null) { MessageBox.Show("Выберите блюдо для удаления!"); }
            else
            {
                car -= obj.Carbohydrates;
                fat -= obj.Fats;
                prot -= obj.Protein;
                aft_norm -= obj.Calories;
                sum -= obj.Calories;

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

            foreach (Dish d in clm)
            {
                cm.IdDish = d.DishId;

                if (first_call_tlstr.Checked || second_call_tlstr.Checked || third_call_tlstr.Checked || four_call_tlstr.Checked)
                {
                    foreach (Class c in cli)
                    {
                        if (c.Num == 1 || c.Num == 2 || c.Num == 3 || c.Num == 4)
                        {
                            cm.ClassId = c.ClassId;
                            cli.Remove(c);
                            break;
                        }
                    }
                }

                else if (fifth_call_tlstr.Checked || six_call_tlstr.Checked || seventh_call_tlstr.Checked || eighth_call_tlstr.Checked || ninth_call_tlstr.Checked)
                {
                    foreach (Class c in cli)
                    {
                        if (c.Num == 5 || c.Num == 6 || c.Num == 7 || c.Num == 8 || c.Num == 9)
                        {
                            cm.ClassId = c.ClassId;
                            cli.Remove(c);
                            break;
                        }
                    }
                }

                else if (tenth_call_tlstr.Checked || eleventh_call_tlstr.Checked)
                {
                    foreach (Class c in cli)
                    {
                        if (c.Num == 10 || c.Num == 11)
                        {
                            cm.ClassId = c.ClassId;
                            cli.Remove(c);
                            break;
                        }
                    }
                }

                DBConnection.Entities.ClassMenus.Add(cm);
                DBConnection.Entities.SaveChanges();
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
                four_call_tlstr.Checked = false;
                fifth_call_tlstr.Checked = false;
                six_call_tlstr.Checked = false;
                seventh_call_tlstr.Checked = false;
                eighth_call_tlstr.Checked = false;
                ninth_call_tlstr.Checked = false;
                tenth_call_tlstr.Checked = false;
                eleventh_call_tlstr.Checked = false;
            }
            else if (second_call_tlstr.Selected)
            {
                first_call_tlstr.Checked = false;
                second_call_tlstr.Checked = true;
                third_call_tlstr.Checked = false;
                four_call_tlstr.Checked = false;
                fifth_call_tlstr.Checked = false;
                six_call_tlstr.Checked = false;
                seventh_call_tlstr.Checked = false;
                eighth_call_tlstr.Checked = false;
                ninth_call_tlstr.Checked = false;
                tenth_call_tlstr.Checked = false;
                eleventh_call_tlstr.Checked = false;
            }
            else if (third_call_tlstr.Selected)
            {
                first_call_tlstr.Checked = false;
                second_call_tlstr.Checked = false;
                third_call_tlstr.Checked = true;
                four_call_tlstr.Checked = false;
                fifth_call_tlstr.Checked = false;
                six_call_tlstr.Checked = false;
                seventh_call_tlstr.Checked = false;
                eighth_call_tlstr.Checked = false;
                ninth_call_tlstr.Checked = false;
                tenth_call_tlstr.Checked = false;
                eleventh_call_tlstr.Checked = false;
            }
            else if (four_call_tlstr.Selected)
            {
                first_call_tlstr.Checked = false;
                second_call_tlstr.Checked = false;
                third_call_tlstr.Checked = false;
                four_call_tlstr.Checked = true;
                fifth_call_tlstr.Checked = false;
                six_call_tlstr.Checked = false;
                seventh_call_tlstr.Checked = false;
                eighth_call_tlstr.Checked = false;
                ninth_call_tlstr.Checked = false;
                tenth_call_tlstr.Checked = false;
                eleventh_call_tlstr.Checked = false;
            }
            else if (fifth_call_tlstr.Selected)
            {
                first_call_tlstr.Checked = false;
                second_call_tlstr.Checked = false;
                third_call_tlstr.Checked = false;
                four_call_tlstr.Checked = false;
                fifth_call_tlstr.Checked = true;
                six_call_tlstr.Checked = false;
                seventh_call_tlstr.Checked = false;
                eighth_call_tlstr.Checked = false;
                ninth_call_tlstr.Checked = false;
                tenth_call_tlstr.Checked = false;
                eleventh_call_tlstr.Checked = false;
            }
            else if (six_call_tlstr.Selected)
            {
                first_call_tlstr.Checked = false;
                second_call_tlstr.Checked = false;
                third_call_tlstr.Checked = false;
                four_call_tlstr.Checked = false;
                fifth_call_tlstr.Checked = false;
                six_call_tlstr.Checked = true;
                seventh_call_tlstr.Checked = false;
                eighth_call_tlstr.Checked = false;
                ninth_call_tlstr.Checked = false;
                tenth_call_tlstr.Checked = false;
                eleventh_call_tlstr.Checked = false;
            }
            else if (seventh_call_tlstr.Selected)
            {
                first_call_tlstr.Checked = false;
                second_call_tlstr.Checked = false;
                third_call_tlstr.Checked = false;
                four_call_tlstr.Checked = false;
                fifth_call_tlstr.Checked = false;
                six_call_tlstr.Checked = false;
                seventh_call_tlstr.Checked = true;
                eighth_call_tlstr.Checked = false;
                ninth_call_tlstr.Checked = false;
                tenth_call_tlstr.Checked = false;
                eleventh_call_tlstr.Checked = false;
            }
            else if (eighth_call_tlstr.Selected)
            {
                first_call_tlstr.Checked = false;
                second_call_tlstr.Checked = false;
                third_call_tlstr.Checked = false;
                four_call_tlstr.Checked = false;
                fifth_call_tlstr.Checked = false;
                six_call_tlstr.Checked = false;
                seventh_call_tlstr.Checked = false;
                eighth_call_tlstr.Checked = true;
                ninth_call_tlstr.Checked = false;
                tenth_call_tlstr.Checked = false;
                eleventh_call_tlstr.Checked = false;
            }
            else if (ninth_call_tlstr.Selected)
            {
                first_call_tlstr.Checked = false;
                second_call_tlstr.Checked = false;
                third_call_tlstr.Checked = false;
                four_call_tlstr.Checked = false;
                fifth_call_tlstr.Checked = false;
                six_call_tlstr.Checked = false;
                seventh_call_tlstr.Checked = false;
                eighth_call_tlstr.Checked = false;
                ninth_call_tlstr.Checked = true;
                tenth_call_tlstr.Checked = false;
                eleventh_call_tlstr.Checked = false;
            }
            else if (tenth_call_tlstr.Selected)
            {
                first_call_tlstr.Checked = false;
                second_call_tlstr.Checked = false;
                third_call_tlstr.Checked = false;
                four_call_tlstr.Checked = false;
                fifth_call_tlstr.Checked = false;
                six_call_tlstr.Checked = false;
                seventh_call_tlstr.Checked = false;
                eighth_call_tlstr.Checked = false;
                ninth_call_tlstr.Checked = false;
                tenth_call_tlstr.Checked = true;
                eleventh_call_tlstr.Checked = false;
            }
            else if (eleventh_call_tlstr.Selected)
            {
                first_call_tlstr.Checked = false;
                second_call_tlstr.Checked = false;
                third_call_tlstr.Checked = false;
                four_call_tlstr.Checked = false;
                fifth_call_tlstr.Checked = false;
                six_call_tlstr.Checked = false;
                seventh_call_tlstr.Checked = false;
                eighth_call_tlstr.Checked = false;
                ninth_call_tlstr.Checked = false;
                tenth_call_tlstr.Checked = false;
                eleventh_call_tlstr.Checked = true;
            }
        }

        private void class_toolstr_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            List<Class> cl = DBConnection.Entities.Classes.ToList();

            if (first_call_tlstr.Selected || second_call_tlstr.Selected || third_call_tlstr.Selected || four_call_tlstr.Selected)
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

            else if (fifth_call_tlstr.Selected || six_call_tlstr.Selected || seventh_call_tlstr.Selected || eighth_call_tlstr.Selected || ninth_call_tlstr.Selected)
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

            else if (tenth_call_tlstr.Selected || eleventh_call_tlstr.Selected)
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
            ChoiceMenuForm cf = new ChoiceMenuForm();
            cf.ShowDialog();

            this.Fill();
        }
    }
}
