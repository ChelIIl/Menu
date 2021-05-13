namespace Menu
{
    partial class ChoiceMenuForm
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
            this.class_lbl = new System.Windows.Forms.Label();
            this.choice_class_combox = new System.Windows.Forms.ComboBox();
            this.SearchClass_btn = new System.Windows.Forms.Button();
            this.menu_lbl = new System.Windows.Forms.Label();
            this.data_menu_list = new System.Windows.Forms.ListBox();
            this.Choose_btn = new System.Windows.Forms.Button();
            this.Detail_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // class_lbl
            // 
            this.class_lbl.AutoSize = true;
            this.class_lbl.Location = new System.Drawing.Point(8, 16);
            this.class_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.class_lbl.Name = "class_lbl";
            this.class_lbl.Size = new System.Drawing.Size(41, 13);
            this.class_lbl.TabIndex = 0;
            this.class_lbl.Text = "Класс:";
            // 
            // choice_class_combox
            // 
            this.choice_class_combox.FormattingEnabled = true;
            this.choice_class_combox.Items.AddRange(new object[] {
            "1 - 4 классы",
            "5 - 9 классы",
            "10 - 11 классы"});
            this.choice_class_combox.Location = new System.Drawing.Point(51, 14);
            this.choice_class_combox.Margin = new System.Windows.Forms.Padding(2);
            this.choice_class_combox.Name = "choice_class_combox";
            this.choice_class_combox.Size = new System.Drawing.Size(132, 21);
            this.choice_class_combox.TabIndex = 1;
            // 
            // SearchClass_btn
            // 
            this.SearchClass_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SearchClass_btn.Location = new System.Drawing.Point(200, 9);
            this.SearchClass_btn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchClass_btn.Name = "SearchClass_btn";
            this.SearchClass_btn.Size = new System.Drawing.Size(99, 27);
            this.SearchClass_btn.TabIndex = 2;
            this.SearchClass_btn.Text = "Найти";
            this.SearchClass_btn.UseVisualStyleBackColor = false;
            this.SearchClass_btn.Click += new System.EventHandler(this.SearchClass_btn_Click);
            // 
            // menu_lbl
            // 
            this.menu_lbl.AutoSize = true;
            this.menu_lbl.Location = new System.Drawing.Point(8, 49);
            this.menu_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.menu_lbl.Name = "menu_lbl";
            this.menu_lbl.Size = new System.Drawing.Size(131, 13);
            this.menu_lbl.TabIndex = 3;
            this.menu_lbl.Text = "Меню, составленное за:";
            // 
            // data_menu_list
            // 
            this.data_menu_list.FormattingEnabled = true;
            this.data_menu_list.Location = new System.Drawing.Point(9, 65);
            this.data_menu_list.Margin = new System.Windows.Forms.Padding(2);
            this.data_menu_list.Name = "data_menu_list";
            this.data_menu_list.Size = new System.Drawing.Size(174, 160);
            this.data_menu_list.TabIndex = 4;
            // 
            // Choose_btn
            // 
            this.Choose_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Choose_btn.Location = new System.Drawing.Point(200, 86);
            this.Choose_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Choose_btn.Name = "Choose_btn";
            this.Choose_btn.Size = new System.Drawing.Size(99, 27);
            this.Choose_btn.TabIndex = 5;
            this.Choose_btn.Text = "Выбрать";
            this.Choose_btn.UseVisualStyleBackColor = false;
            this.Choose_btn.Click += new System.EventHandler(this.Choose_btn_Click);
            // 
            // Detail_btn
            // 
            this.Detail_btn.Location = new System.Drawing.Point(200, 132);
            this.Detail_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Detail_btn.Name = "Detail_btn";
            this.Detail_btn.Size = new System.Drawing.Size(99, 27);
            this.Detail_btn.TabIndex = 6;
            this.Detail_btn.Text = "Подробнее";
            this.Detail_btn.UseVisualStyleBackColor = true;
            this.Detail_btn.Click += new System.EventHandler(this.Detail_btn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Back_btn.Location = new System.Drawing.Point(200, 183);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(99, 27);
            this.Back_btn.TabIndex = 7;
            this.Back_btn.Text = "Удалить";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // ChoiceMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 240);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Detail_btn);
            this.Controls.Add(this.Choose_btn);
            this.Controls.Add(this.data_menu_list);
            this.Controls.Add(this.menu_lbl);
            this.Controls.Add(this.SearchClass_btn);
            this.Controls.Add(this.choice_class_combox);
            this.Controls.Add(this.class_lbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChoiceMenuForm";
            this.Text = "Готовые меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label class_lbl;
        private System.Windows.Forms.ComboBox choice_class_combox;
        private System.Windows.Forms.Button SearchClass_btn;
        private System.Windows.Forms.Label menu_lbl;
        private System.Windows.Forms.ListBox data_menu_list;
        private System.Windows.Forms.Button Choose_btn;
        private System.Windows.Forms.Button Detail_btn;
        private System.Windows.Forms.Button Back_btn;
    }
}