namespace Menu
{
    partial class AddDishForm
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
            this.dish_lbl = new System.Windows.Forms.Label();
            this.dish_txtb = new System.Windows.Forms.TextBox();
            this.meal_combox = new System.Windows.Forms.ComboBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.prot_lbl = new System.Windows.Forms.Label();
            this.prot__txtb = new System.Windows.Forms.TextBox();
            this.fat_lbl = new System.Windows.Forms.Label();
            this.fat_txtb = new System.Windows.Forms.TextBox();
            this.carb_lbl = new System.Windows.Forms.Label();
            this.carb_txtb = new System.Windows.Forms.TextBox();
            this.cal_lbl = new System.Windows.Forms.Label();
            this.cal_txtb = new System.Windows.Forms.TextBox();
            this.gram_lbl = new System.Windows.Forms.Label();
            this.gram_txtb = new System.Windows.Forms.TextBox();
            this.meal_lbl = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.minerals_groupB = new System.Windows.Forms.GroupBox();
            this.fe_txtb = new System.Windows.Forms.TextBox();
            this.fe_lbl = new System.Windows.Forms.Label();
            this.mg_txtb = new System.Windows.Forms.TextBox();
            this.p_txtb = new System.Windows.Forms.TextBox();
            this.ca_txtb = new System.Windows.Forms.TextBox();
            this.mg_lbl = new System.Windows.Forms.Label();
            this.p_lbl = new System.Windows.Forms.Label();
            this.ca_lbl = new System.Windows.Forms.Label();
            this.vitamins_groupB = new System.Windows.Forms.GroupBox();
            this.e_txtb = new System.Windows.Forms.TextBox();
            this.e_lbl = new System.Windows.Forms.Label();
            this.a_txtb = new System.Windows.Forms.TextBox();
            this.c_txtb = new System.Windows.Forms.TextBox();
            this.b1_txtb = new System.Windows.Forms.TextBox();
            this.a_lbl = new System.Windows.Forms.Label();
            this.c_lbl = new System.Windows.Forms.Label();
            this.b1_lbl = new System.Windows.Forms.Label();
            this.minerals_groupB.SuspendLayout();
            this.vitamins_groupB.SuspendLayout();
            this.SuspendLayout();
            // 
            // dish_lbl
            // 
            this.dish_lbl.AutoSize = true;
            this.dish_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dish_lbl.Location = new System.Drawing.Point(7, 7);
            this.dish_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dish_lbl.Name = "dish_lbl";
            this.dish_lbl.Size = new System.Drawing.Size(157, 15);
            this.dish_lbl.TabIndex = 0;
            this.dish_lbl.Text = "Наименование блюда:";
            // 
            // dish_txtb
            // 
            this.dish_txtb.Location = new System.Drawing.Point(9, 26);
            this.dish_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dish_txtb.Name = "dish_txtb";
            this.dish_txtb.Size = new System.Drawing.Size(338, 20);
            this.dish_txtb.TabIndex = 1;
            // 
            // meal_combox
            // 
            this.meal_combox.FormattingEnabled = true;
            this.meal_combox.Items.AddRange(new object[] {
            "Завтрак",
            "Обед",
            "Полдник"});
            this.meal_combox.Location = new System.Drawing.Point(229, 132);
            this.meal_combox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.meal_combox.Name = "meal_combox";
            this.meal_combox.Size = new System.Drawing.Size(109, 21);
            this.meal_combox.TabIndex = 2;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.back_btn.Location = new System.Drawing.Point(13, 314);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(115, 39);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = false;
            // 
            // prot_lbl
            // 
            this.prot_lbl.AutoSize = true;
            this.prot_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prot_lbl.Location = new System.Drawing.Point(10, 60);
            this.prot_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prot_lbl.Name = "prot_lbl";
            this.prot_lbl.Size = new System.Drawing.Size(140, 13);
            this.prot_lbl.TabIndex = 4;
            this.prot_lbl.Text = "Количество белков, г:";
            // 
            // prot__txtb
            // 
            this.prot__txtb.Location = new System.Drawing.Point(162, 58);
            this.prot__txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prot__txtb.Name = "prot__txtb";
            this.prot__txtb.Size = new System.Drawing.Size(46, 20);
            this.prot__txtb.TabIndex = 5;
            // 
            // fat_lbl
            // 
            this.fat_lbl.AutoSize = true;
            this.fat_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fat_lbl.Location = new System.Drawing.Point(10, 85);
            this.fat_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fat_lbl.Name = "fat_lbl";
            this.fat_lbl.Size = new System.Drawing.Size(135, 13);
            this.fat_lbl.TabIndex = 6;
            this.fat_lbl.Text = "Количество жиров, г:";
            // 
            // fat_txtb
            // 
            this.fat_txtb.Location = new System.Drawing.Point(162, 83);
            this.fat_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fat_txtb.Name = "fat_txtb";
            this.fat_txtb.Size = new System.Drawing.Size(46, 20);
            this.fat_txtb.TabIndex = 7;
            // 
            // carb_lbl
            // 
            this.carb_lbl.AutoSize = true;
            this.carb_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carb_lbl.Location = new System.Drawing.Point(10, 110);
            this.carb_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carb_lbl.Name = "carb_lbl";
            this.carb_lbl.Size = new System.Drawing.Size(159, 13);
            this.carb_lbl.TabIndex = 8;
            this.carb_lbl.Text = "Количество углеводов, г:";
            // 
            // carb_txtb
            // 
            this.carb_txtb.Location = new System.Drawing.Point(162, 107);
            this.carb_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.carb_txtb.Name = "carb_txtb";
            this.carb_txtb.Size = new System.Drawing.Size(46, 20);
            this.carb_txtb.TabIndex = 9;
            // 
            // cal_lbl
            // 
            this.cal_lbl.AutoSize = true;
            this.cal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cal_lbl.Location = new System.Drawing.Point(10, 136);
            this.cal_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cal_lbl.Name = "cal_lbl";
            this.cal_lbl.Size = new System.Drawing.Size(126, 13);
            this.cal_lbl.TabIndex = 10;
            this.cal_lbl.Text = "Количество ккал, г:";
            // 
            // cal_txtb
            // 
            this.cal_txtb.Location = new System.Drawing.Point(162, 133);
            this.cal_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cal_txtb.Name = "cal_txtb";
            this.cal_txtb.Size = new System.Drawing.Size(46, 20);
            this.cal_txtb.TabIndex = 11;
            // 
            // gram_lbl
            // 
            this.gram_lbl.AutoSize = true;
            this.gram_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gram_lbl.Location = new System.Drawing.Point(225, 60);
            this.gram_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gram_lbl.Name = "gram_lbl";
            this.gram_lbl.Size = new System.Drawing.Size(133, 13);
            this.gram_lbl.TabIndex = 12;
            this.gram_lbl.Text = "Граммовка блюда, г:";
            // 
            // gram_txtb
            // 
            this.gram_txtb.Location = new System.Drawing.Point(229, 83);
            this.gram_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gram_txtb.Name = "gram_txtb";
            this.gram_txtb.Size = new System.Drawing.Size(109, 20);
            this.gram_txtb.TabIndex = 13;
            // 
            // meal_lbl
            // 
            this.meal_lbl.AutoSize = true;
            this.meal_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.meal_lbl.Location = new System.Drawing.Point(226, 110);
            this.meal_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.meal_lbl.Name = "meal_lbl";
            this.meal_lbl.Size = new System.Drawing.Size(97, 13);
            this.meal_lbl.TabIndex = 14;
            this.meal_lbl.Text = "Время приёма:";
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.save_btn.Location = new System.Drawing.Point(235, 314);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(115, 39);
            this.save_btn.TabIndex = 17;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // minerals_groupB
            // 
            this.minerals_groupB.Controls.Add(this.fe_txtb);
            this.minerals_groupB.Controls.Add(this.fe_lbl);
            this.minerals_groupB.Controls.Add(this.mg_txtb);
            this.minerals_groupB.Controls.Add(this.p_txtb);
            this.minerals_groupB.Controls.Add(this.ca_txtb);
            this.minerals_groupB.Controls.Add(this.mg_lbl);
            this.minerals_groupB.Controls.Add(this.p_lbl);
            this.minerals_groupB.Controls.Add(this.ca_lbl);
            this.minerals_groupB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minerals_groupB.Location = new System.Drawing.Point(12, 175);
            this.minerals_groupB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minerals_groupB.Name = "minerals_groupB";
            this.minerals_groupB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minerals_groupB.Size = new System.Drawing.Size(190, 122);
            this.minerals_groupB.TabIndex = 20;
            this.minerals_groupB.TabStop = false;
            this.minerals_groupB.Text = "Минеральные вещества (мг):";
            // 
            // fe_txtb
            // 
            this.fe_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fe_txtb.Location = new System.Drawing.Point(34, 94);
            this.fe_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fe_txtb.Name = "fe_txtb";
            this.fe_txtb.Size = new System.Drawing.Size(146, 19);
            this.fe_txtb.TabIndex = 7;
            // 
            // fe_lbl
            // 
            this.fe_lbl.AutoSize = true;
            this.fe_lbl.Location = new System.Drawing.Point(5, 97);
            this.fe_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fe_lbl.Name = "fe_lbl";
            this.fe_lbl.Size = new System.Drawing.Size(25, 13);
            this.fe_lbl.TabIndex = 6;
            this.fe_lbl.Text = "Fe:";
            // 
            // mg_txtb
            // 
            this.mg_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mg_txtb.Location = new System.Drawing.Point(34, 71);
            this.mg_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mg_txtb.Name = "mg_txtb";
            this.mg_txtb.Size = new System.Drawing.Size(146, 19);
            this.mg_txtb.TabIndex = 5;
            // 
            // p_txtb
            // 
            this.p_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.p_txtb.Location = new System.Drawing.Point(34, 48);
            this.p_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.p_txtb.Name = "p_txtb";
            this.p_txtb.Size = new System.Drawing.Size(146, 19);
            this.p_txtb.TabIndex = 4;
            // 
            // ca_txtb
            // 
            this.ca_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ca_txtb.Location = new System.Drawing.Point(34, 24);
            this.ca_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ca_txtb.Name = "ca_txtb";
            this.ca_txtb.Size = new System.Drawing.Size(146, 19);
            this.ca_txtb.TabIndex = 3;
            // 
            // mg_lbl
            // 
            this.mg_lbl.AutoSize = true;
            this.mg_lbl.Location = new System.Drawing.Point(5, 73);
            this.mg_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mg_lbl.Name = "mg_lbl";
            this.mg_lbl.Size = new System.Drawing.Size(28, 13);
            this.mg_lbl.TabIndex = 2;
            this.mg_lbl.Text = "Mg:";
            // 
            // p_lbl
            // 
            this.p_lbl.AutoSize = true;
            this.p_lbl.Location = new System.Drawing.Point(5, 50);
            this.p_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p_lbl.Name = "p_lbl";
            this.p_lbl.Size = new System.Drawing.Size(19, 13);
            this.p_lbl.TabIndex = 1;
            this.p_lbl.Text = "P:";
            // 
            // ca_lbl
            // 
            this.ca_lbl.AutoSize = true;
            this.ca_lbl.Location = new System.Drawing.Point(5, 27);
            this.ca_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ca_lbl.Name = "ca_lbl";
            this.ca_lbl.Size = new System.Drawing.Size(26, 13);
            this.ca_lbl.TabIndex = 0;
            this.ca_lbl.Text = "Ca:";
            // 
            // vitamins_groupB
            // 
            this.vitamins_groupB.Controls.Add(this.e_txtb);
            this.vitamins_groupB.Controls.Add(this.e_lbl);
            this.vitamins_groupB.Controls.Add(this.a_txtb);
            this.vitamins_groupB.Controls.Add(this.c_txtb);
            this.vitamins_groupB.Controls.Add(this.b1_txtb);
            this.vitamins_groupB.Controls.Add(this.a_lbl);
            this.vitamins_groupB.Controls.Add(this.c_lbl);
            this.vitamins_groupB.Controls.Add(this.b1_lbl);
            this.vitamins_groupB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vitamins_groupB.Location = new System.Drawing.Point(217, 175);
            this.vitamins_groupB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vitamins_groupB.Name = "vitamins_groupB";
            this.vitamins_groupB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vitamins_groupB.Size = new System.Drawing.Size(133, 122);
            this.vitamins_groupB.TabIndex = 21;
            this.vitamins_groupB.TabStop = false;
            this.vitamins_groupB.Text = "Витамины (мг):";
            // 
            // e_txtb
            // 
            this.e_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.e_txtb.Location = new System.Drawing.Point(45, 94);
            this.e_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.e_txtb.Name = "e_txtb";
            this.e_txtb.Size = new System.Drawing.Size(76, 19);
            this.e_txtb.TabIndex = 8;
            // 
            // e_lbl
            // 
            this.e_lbl.AutoSize = true;
            this.e_lbl.Location = new System.Drawing.Point(10, 97);
            this.e_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.e_lbl.Name = "e_lbl";
            this.e_lbl.Size = new System.Drawing.Size(19, 13);
            this.e_lbl.TabIndex = 7;
            this.e_lbl.Text = "E:";
            // 
            // a_txtb
            // 
            this.a_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a_txtb.Location = new System.Drawing.Point(45, 71);
            this.a_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.a_txtb.Name = "a_txtb";
            this.a_txtb.Size = new System.Drawing.Size(76, 19);
            this.a_txtb.TabIndex = 6;
            // 
            // c_txtb
            // 
            this.c_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.c_txtb.Location = new System.Drawing.Point(45, 48);
            this.c_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_txtb.Name = "c_txtb";
            this.c_txtb.Size = new System.Drawing.Size(76, 19);
            this.c_txtb.TabIndex = 5;
            // 
            // b1_txtb
            // 
            this.b1_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b1_txtb.Location = new System.Drawing.Point(45, 24);
            this.b1_txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b1_txtb.Name = "b1_txtb";
            this.b1_txtb.Size = new System.Drawing.Size(76, 19);
            this.b1_txtb.TabIndex = 4;
            // 
            // a_lbl
            // 
            this.a_lbl.AutoSize = true;
            this.a_lbl.Location = new System.Drawing.Point(10, 73);
            this.a_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.a_lbl.Name = "a_lbl";
            this.a_lbl.Size = new System.Drawing.Size(19, 13);
            this.a_lbl.TabIndex = 3;
            this.a_lbl.Text = "A:";
            // 
            // c_lbl
            // 
            this.c_lbl.AutoSize = true;
            this.c_lbl.Location = new System.Drawing.Point(10, 50);
            this.c_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.c_lbl.Name = "c_lbl";
            this.c_lbl.Size = new System.Drawing.Size(19, 13);
            this.c_lbl.TabIndex = 2;
            this.c_lbl.Text = "C:";
            // 
            // b1_lbl
            // 
            this.b1_lbl.AutoSize = true;
            this.b1_lbl.Location = new System.Drawing.Point(10, 27);
            this.b1_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.b1_lbl.Name = "b1_lbl";
            this.b1_lbl.Size = new System.Drawing.Size(33, 13);
            this.b1_lbl.TabIndex = 1;
            this.b1_lbl.Text = "B_1:";
            // 
            // AddDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 364);
            this.Controls.Add(this.vitamins_groupB);
            this.Controls.Add(this.minerals_groupB);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.meal_lbl);
            this.Controls.Add(this.gram_txtb);
            this.Controls.Add(this.gram_lbl);
            this.Controls.Add(this.cal_txtb);
            this.Controls.Add(this.cal_lbl);
            this.Controls.Add(this.carb_txtb);
            this.Controls.Add(this.carb_lbl);
            this.Controls.Add(this.fat_txtb);
            this.Controls.Add(this.fat_lbl);
            this.Controls.Add(this.prot__txtb);
            this.Controls.Add(this.prot_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.meal_combox);
            this.Controls.Add(this.dish_txtb);
            this.Controls.Add(this.dish_lbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddDishForm";
            this.Text = "Добавление/Изменение блюда";
            this.minerals_groupB.ResumeLayout(false);
            this.minerals_groupB.PerformLayout();
            this.vitamins_groupB.ResumeLayout(false);
            this.vitamins_groupB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dish_lbl;
        private System.Windows.Forms.TextBox dish_txtb;
        private System.Windows.Forms.ComboBox meal_combox;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label prot_lbl;
        private System.Windows.Forms.TextBox prot__txtb;
        private System.Windows.Forms.Label fat_lbl;
        private System.Windows.Forms.TextBox fat_txtb;
        private System.Windows.Forms.Label carb_lbl;
        private System.Windows.Forms.TextBox carb_txtb;
        private System.Windows.Forms.Label cal_lbl;
        private System.Windows.Forms.TextBox cal_txtb;
        private System.Windows.Forms.Label gram_lbl;
        private System.Windows.Forms.TextBox gram_txtb;
        private System.Windows.Forms.Label meal_lbl;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.GroupBox minerals_groupB;
        private System.Windows.Forms.TextBox fe_txtb;
        private System.Windows.Forms.Label fe_lbl;
        private System.Windows.Forms.TextBox mg_txtb;
        private System.Windows.Forms.TextBox p_txtb;
        private System.Windows.Forms.TextBox ca_txtb;
        private System.Windows.Forms.Label mg_lbl;
        private System.Windows.Forms.Label p_lbl;
        private System.Windows.Forms.Label ca_lbl;
        private System.Windows.Forms.GroupBox vitamins_groupB;
        private System.Windows.Forms.TextBox e_txtb;
        private System.Windows.Forms.Label e_lbl;
        private System.Windows.Forms.TextBox a_txtb;
        private System.Windows.Forms.TextBox c_txtb;
        private System.Windows.Forms.TextBox b1_txtb;
        private System.Windows.Forms.Label a_lbl;
        private System.Windows.Forms.Label c_lbl;
        private System.Windows.Forms.Label b1_lbl;
    }
}