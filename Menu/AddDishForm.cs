using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Menu
{
    public partial class AddDishForm : Form
    {
        Dish o = new Dish();

        public AddDishForm(Dish d)
        {
            InitializeComponent();

            o = d;

            if (d != null)
            {
                cal_txtb.Text = d.Calories.ToString();
                dish_txtb.Text = d.DishName;
                carb_txtb.Text = d.Carbohydrates.ToString();
                fat_txtb.Text = d.Fats.ToString();
                gram_txtb.Text = d.Weight.ToString();
                prot__txtb.Text = d.Protein.ToString();
                ca_txtb.Text = d.Ca.ToString();
                p_txtb.Text = d.P.ToString();
                mg_txtb.Text = d.Mg.ToString();
                fe_txtb.Text = d.Fe.ToString();
                b1_txtb.Text = d.B1.ToString();
                c_txtb.Text = d.C.ToString();
                a_txtb.Text = d.A.ToString();
                e_txtb.Text = d.E.ToString();
                meal_combox.SelectedItem = d.MealTime;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            if (o == null)
            {
                Dish dish = new Dish();

                dish.Calories = Convert.ToDouble(cal_txtb.Text);
                dish.DishName = dish_txtb.Text;
                dish.Carbohydrates = Convert.ToDouble(carb_txtb.Text);
                dish.Fats = Convert.ToDouble(fat_txtb.Text);
                dish.Weight = Convert.ToDouble(gram_txtb.Text);
                dish.Protein = Convert.ToDouble(prot__txtb.Text);
                dish.Ca = Convert.ToDouble(ca_txtb.Text);
                dish.P = Convert.ToDouble(p_txtb.Text);
                dish.Mg = Convert.ToDouble(mg_txtb.Text);
                dish.Fe = Convert.ToDouble(fe_txtb.Text);
                dish.B1 = Convert.ToDouble(b1_txtb.Text);
                dish.C = Convert.ToDouble(c_txtb.Text);
                dish.A = Convert.ToDouble(a_txtb.Text);
                dish.E = Convert.ToDouble(e_txtb.Text);
                dish.MealTime = meal_combox.Text;

                DBConnection.Entities.Dishes.Add(dish);
                DBConnection.Entities.SaveChanges();
                MessageBox.Show("Блюдо добалено!");
                this.Close();
            }
            else
            {
                List<Dish> li = DBConnection.Entities.Dishes.ToList();

                foreach (Dish item in li)
                {
                    if(item.DishId == o.DishId)
                    {
                        item.Calories = Convert.ToDouble(cal_txtb.Text);
                        item.DishName = dish_txtb.Text;
                        item.Carbohydrates = Convert.ToDouble(carb_txtb.Text);
                        item.Fats = Convert.ToDouble(fat_txtb.Text);
                        item.Weight = Convert.ToDouble(gram_txtb.Text);
                        item.Protein = Convert.ToDouble(prot__txtb.Text);
                        item.Ca = Convert.ToDouble(ca_txtb.Text);
                        item.P = Convert.ToDouble(p_txtb.Text);
                        item.Mg = Convert.ToDouble(mg_txtb.Text);
                        item.Fe = Convert.ToDouble(fe_txtb.Text);
                        item.B1 = Convert.ToDouble(b1_txtb.Text);
                        item.C = Convert.ToDouble(c_txtb.Text);
                        item.A = Convert.ToDouble(a_txtb.Text);
                        item.E = Convert.ToDouble(e_txtb.Text);
                        item.MealTime = meal_combox.Text;

                        DBConnection.Entities.SaveChanges();
                        MessageBox.Show("Блюдо изменено!");
                        break;
                    }
                }

                this.Close();
            }
        }
    }
}
