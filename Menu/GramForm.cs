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
    public partial class GramForm : Form
    {
        public Dish Dish { get; set; }
        public double gram { get; set; }

        public GramForm()
        {
            InitializeComponent();
        }

        public GramForm(Dish d)
        {
            InitializeComponent();

            this.Dish = d;
        }

        private void add_dish_btn_Click(object sender, EventArgs e)
        {
            this.gram = Convert.ToDouble(gram_dish_txtb.Text);
            MainForm main = this.Owner as MainForm;

            if (main.first_call_tlstr.Checked)
            {
                if(gram <= 200)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Вы превысили норму!");
                }
            }

            else if (main.second_call_tlstr.Checked)
            {
                if (gram <= 250)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Вы превысили норму!");
                }
            }

            else if (main.third_call_tlstr.Checked)
            {
                if (gram <= 300)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Вы превысили норму!");
                }
            }

            else
            {
                MessageBox.Show("Выберите для каких классов добавляется блюдо!");
                this.Close();
            }
        }
    }
}
