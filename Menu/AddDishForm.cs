using System;
using System.Windows.Forms;

namespace Menu
{
    public partial class AddDishForm : Form
    {
        public AddDishForm()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Save();
        }

        public void Save()
        {
            Dish dish = new Dish();

            dish.Calories = Convert.ToDouble(cal_txtb.Text);
            dish.DishName = dish_txtb.Text;
            dish.Carbohydrates = Convert.ToDouble(carb_txtb.Text);
            dish.Descr = desc_txtb.Text;
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
            this.Close();
        }

        private void cal_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
