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
    public partial class CompiledMenuForm : Form
    {
        public List<ClassMenu> dishli { get; set; }
        double break_sum = 0;
        double din_sum = 0;
        double aft_sum = 0;

        public CompiledMenuForm()
        {
            InitializeComponent();
        }

        public CompiledMenuForm(ClassMenu cm)
        {
            InitializeComponent();
            List<ClassMenu> cl = DBConnection.Entities.ClassMenus.ToList();
            List<Dish> d = DBConnection.Entities.Dishes.ToList();

            foreach (ClassMenu item in cl)
            {
                if(cm.ClassId == item.ClassId)
                {
                    foreach (Dish val in d)
                    {
                        if(val.DishId == item.IdDish)
                        {
                            if(val.MealTime.ToLower() == "завтрак")
                            {
                                break_dish_list.Items.Add(val);
                                break_sum += Convert.ToDouble(val.Calories) * Convert.ToDouble(item.Gramm / 100);
                            }

                            else if(val.MealTime.ToLower() == "обед")
                            {
                                din_dish_list.Items.Add(val);
                                din_sum += Convert.ToDouble(val.Calories) * Convert.ToDouble(item.Gramm / 100);
                            }

                            else if (val.MealTime.ToLower() == "полдник")
                            {
                                aft_dish_list.Items.Add(val);
                                aft_sum += Convert.ToDouble(val.Calories) * Convert.ToDouble(item.Gramm / 100);
                            }
                        }
                    }
                }
            }

            rec_aft_kal_lbl.Text = aft_sum.ToString();
            rec_break_kal_lbl.Text = break_sum.ToString();
            rec_din_kal_lbl.Text = din_sum.ToString();
        }

        private void Back_to_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Select_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
