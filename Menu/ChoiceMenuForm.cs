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
        public ChoiceMenuForm()
        {
            InitializeComponent();

            this.Fill();
        }

        public void Fill()
        {
            List<ClassMenu> cm = DBConnection.Entities.ClassMenus.ToList();
            foreach (ClassMenu item in cm)
            {
                foreach (ClassMenu value in data_menu_list.Items)
                {
                    if (value.Class == item.Class)
                        goto st;
                }
                data_menu_list.Items.Add(item);
            st:
                continue;
            }
        }
    }
}
