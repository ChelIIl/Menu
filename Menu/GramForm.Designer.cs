
namespace Menu
{
    partial class GramForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gram_lbl = new System.Windows.Forms.Label();
            this.gram_dish_txtb = new System.Windows.Forms.TextBox();
            this.add_dish_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gram_lbl
            // 
            this.gram_lbl.AutoSize = true;
            this.gram_lbl.Location = new System.Drawing.Point(36, 9);
            this.gram_lbl.Name = "gram_lbl";
            this.gram_lbl.Size = new System.Drawing.Size(129, 13);
            this.gram_lbl.TabIndex = 0;
            this.gram_lbl.Text = "Выберите массу блюда:";
            // 
            // gram_dish_txtb
            // 
            this.gram_dish_txtb.Location = new System.Drawing.Point(39, 25);
            this.gram_dish_txtb.Name = "gram_dish_txtb";
            this.gram_dish_txtb.Size = new System.Drawing.Size(124, 20);
            this.gram_dish_txtb.TabIndex = 1;
            // 
            // add_dish_btn
            // 
            this.add_dish_btn.Location = new System.Drawing.Point(53, 51);
            this.add_dish_btn.Name = "add_dish_btn";
            this.add_dish_btn.Size = new System.Drawing.Size(98, 26);
            this.add_dish_btn.TabIndex = 2;
            this.add_dish_btn.Text = "Добавить";
            this.add_dish_btn.UseVisualStyleBackColor = true;
            this.add_dish_btn.Click += new System.EventHandler(this.add_dish_btn_Click);
            // 
            // GramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 86);
            this.Controls.Add(this.add_dish_btn);
            this.Controls.Add(this.gram_dish_txtb);
            this.Controls.Add(this.gram_lbl);
            this.Name = "GramForm";
            this.Text = "Масса блюда";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gram_lbl;
        private System.Windows.Forms.TextBox gram_dish_txtb;
        private System.Windows.Forms.Button add_dish_btn;
    }
}