using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class ChoiceMenuForm : Form
    {
        public ClassMenu classm { get; set; }
        //public List<ClassMenu> dli { get; set; }

        public ChoiceMenuForm()
        {
            InitializeComponent();

            this.Fill();
        }

        public void Fill()
        {
            List<ClassMenu> cm = DBConnection.Entities.ClassMenus.ToList();

            var un = cm.GroupBy(x => x.ClassId).Select(x => x.First()).ToList();

            data_menu_list.DataSource = un;
        }

        public void Fill(List<ClassMenu> cm)
        {
            var un = cm.GroupBy(x => x.ClassId).Select(x => x.First()).ToList();

            data_menu_list.DataSource = un;
        }

        private void Detail_btn_Click(object sender, EventArgs e)
        {
            ClassMenu obj = (ClassMenu)data_menu_list.SelectedItem;

            using (var f = new CompiledMenuForm(obj))
            {
                var res = f.ShowDialog();
                if(res == DialogResult.OK)
                {               
                    this.classm = obj;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

            this.Fill();
        }

        private void SearchClass_btn_Click(object sender, EventArgs e)
        {
            List<ClassMenu> li = new List<ClassMenu>();
            List<ClassMenu> alli = DBConnection.Entities.ClassMenus.ToList();

            if(choice_class_combox.Text == "1 - 4 классы")
            {
                foreach (ClassMenu item in alli)
                {
                    if (item.Class.Num < 5)
                        li.Add(item);
                }
            }

            else if (choice_class_combox.Text == "5 - 9 классы")
            {
                foreach (ClassMenu item in alli)
                {
                    if (item.Class.Num > 4 && item.Class.Num < 10)
                        li.Add(item);
                }
            }

            else if (choice_class_combox.Text == "10 - 11 классы")
            {
                foreach (ClassMenu item in alli)
                {
                    if (item.Class.Num > 9)
                        li.Add(item);
                }
            }

            this.Fill(li);
        }

        private void Choose_btn_Click(object sender, EventArgs e)
        {
            this.classm = (ClassMenu)data_menu_list.SelectedItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            ClassMenu cm = (ClassMenu)data_menu_list.SelectedItem;
            List<ClassMenu> cmlist = DBConnection.Entities.ClassMenus.ToList();
            if (cm == null)
                MessageBox.Show("Выберите меню для удаления!");
            else
            {
                if (cm.Class.Num < 5)
                {
                    foreach (var item in cmlist)
                    {
                        if (item.Class.Num < 5)
                        {
                            DBConnection.Entities.ClassMenus.Remove(item);
                            DBConnection.Entities.SaveChanges();
                        }
                    }
                }

                if (cm.Class.Num < 10 && cm.Class.Num > 4)
                {
                    foreach (var item in cmlist)
                    {
                        if (item.Class.Num < 10 && item.Class.Num > 4)
                        {
                            DBConnection.Entities.ClassMenus.Remove(item);
                            DBConnection.Entities.SaveChanges();
                        }
                    }
                }

                if (cm.Class.Num > 9)
                {
                    foreach (var item in cmlist)
                    {
                        if (item.Class.Num > 9)
                        {
                            DBConnection.Entities.ClassMenus.Remove(item);
                            DBConnection.Entities.SaveChanges();
                        }
                    }
                }

                MessageBox.Show("Меню удалено!");
                this.Fill();
            }
        }
    }
}
