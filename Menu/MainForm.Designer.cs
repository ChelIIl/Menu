namespace Menu
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.class_toolstr = new System.Windows.Forms.ToolStrip();
            this.first_call_tlstr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.second_call_tlstr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.third_call_tlstr = new System.Windows.Forms.ToolStripButton();
            this.earn_day_kal_lbl = new System.Windows.Forms.Label();
            this.gran = new System.Windows.Forms.Label();
            this.glob_day_kal_lbl = new System.Windows.Forms.Label();
            this.week_day_lbl = new System.Windows.Forms.Label();
            this.menu_date = new System.Windows.Forms.DateTimePicker();
            this.break_lbl = new System.Windows.Forms.Label();
            this.dinner_lbl = new System.Windows.Forms.Label();
            this.aft_lbl = new System.Windows.Forms.Label();
            this.rec_break_kal_lbl = new System.Windows.Forms.Label();
            this.gran2 = new System.Windows.Forms.Label();
            this.break_day_kal_lbl = new System.Windows.Forms.Label();
            this.rec_din_kal_lbl = new System.Windows.Forms.Label();
            this.gran3 = new System.Windows.Forms.Label();
            this.din_day_kal_lbl = new System.Windows.Forms.Label();
            this.rec_aft_kal_lbl = new System.Windows.Forms.Label();
            this.gran4 = new System.Windows.Forms.Label();
            this.aft_day_kal_lbl = new System.Windows.Forms.Label();
            this.break_dish_list = new System.Windows.Forms.ListBox();
            this.din_dish_list = new System.Windows.Forms.ListBox();
            this.aft_dish_list = new System.Windows.Forms.ListBox();
            this.add_break_dish_btn = new System.Windows.Forms.Button();
            this.del_break_dish_btn = new System.Windows.Forms.Button();
            this.add_din_dish_btn = new System.Windows.Forms.Button();
            this.del_din_dish_btn = new System.Windows.Forms.Button();
            this.add_aft_dish_btn = new System.Windows.Forms.Button();
            this.del_aft_dish_btn = new System.Windows.Forms.Button();
            this.choose_comp_menu_btn = new System.Windows.Forms.Button();
            this.save_all_btn = new System.Windows.Forms.Button();
            this.all_dish_list = new System.Windows.Forms.ListBox();
            this.search_lbl = new System.Windows.Forms.Label();
            this.choose_search_par_combox = new System.Windows.Forms.ComboBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.add_dish_btn = new System.Windows.Forms.Button();
            this.del_dish_btn = new System.Windows.Forms.Button();
            this.proteins_lbl = new System.Windows.Forms.Label();
            this.fats_lbl = new System.Windows.Forms.Label();
            this.carbohydrates_lbl = new System.Windows.Forms.Label();
            this.norm_lbl = new System.Windows.Forms.Label();
            this.typed_lbl = new System.Windows.Forms.Label();
            this.norm_proteins_lbl = new System.Windows.Forms.Label();
            this.norm_fats_lbl = new System.Windows.Forms.Label();
            this.norm_carbohydrates_lbl = new System.Windows.Forms.Label();
            this.typed_proteins_lbl = new System.Windows.Forms.Label();
            this.typed_fats_lbl = new System.Windows.Forms.Label();
            this.typed_carbohydrates_lbl = new System.Windows.Forms.Label();
            this.excel_btn = new System.Windows.Forms.Button();
            this.class_toolstr.SuspendLayout();
            this.SuspendLayout();
            // 
            // class_toolstr
            // 
            resources.ApplyResources(this.class_toolstr, "class_toolstr");
            this.class_toolstr.BackColor = System.Drawing.Color.LightSteelBlue;
            this.class_toolstr.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.class_toolstr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.first_call_tlstr,
            this.toolStripSeparator2,
            this.second_call_tlstr,
            this.toolStripSeparator3,
            this.third_call_tlstr});
            this.class_toolstr.Name = "class_toolstr";
            this.class_toolstr.Stretch = true;
            this.class_toolstr.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.class_toolstr_ItemClicked_1);
            // 
            // first_call_tlstr
            // 
            resources.ApplyResources(this.first_call_tlstr, "first_call_tlstr");
            this.first_call_tlstr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.first_call_tlstr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.first_call_tlstr.Name = "first_call_tlstr";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // second_call_tlstr
            // 
            this.second_call_tlstr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.second_call_tlstr, "second_call_tlstr");
            this.second_call_tlstr.Name = "second_call_tlstr";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // third_call_tlstr
            // 
            this.third_call_tlstr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.third_call_tlstr, "third_call_tlstr");
            this.third_call_tlstr.Name = "third_call_tlstr";
            // 
            // earn_day_kal_lbl
            // 
            resources.ApplyResources(this.earn_day_kal_lbl, "earn_day_kal_lbl");
            this.earn_day_kal_lbl.Name = "earn_day_kal_lbl";
            // 
            // gran
            // 
            resources.ApplyResources(this.gran, "gran");
            this.gran.Name = "gran";
            // 
            // glob_day_kal_lbl
            // 
            resources.ApplyResources(this.glob_day_kal_lbl, "glob_day_kal_lbl");
            this.glob_day_kal_lbl.Name = "glob_day_kal_lbl";
            // 
            // week_day_lbl
            // 
            resources.ApplyResources(this.week_day_lbl, "week_day_lbl");
            this.week_day_lbl.Name = "week_day_lbl";
            // 
            // menu_date
            // 
            resources.ApplyResources(this.menu_date, "menu_date");
            this.menu_date.Name = "menu_date";
            // 
            // break_lbl
            // 
            resources.ApplyResources(this.break_lbl, "break_lbl");
            this.break_lbl.Name = "break_lbl";
            // 
            // dinner_lbl
            // 
            resources.ApplyResources(this.dinner_lbl, "dinner_lbl");
            this.dinner_lbl.Name = "dinner_lbl";
            // 
            // aft_lbl
            // 
            resources.ApplyResources(this.aft_lbl, "aft_lbl");
            this.aft_lbl.Name = "aft_lbl";
            // 
            // rec_break_kal_lbl
            // 
            resources.ApplyResources(this.rec_break_kal_lbl, "rec_break_kal_lbl");
            this.rec_break_kal_lbl.Name = "rec_break_kal_lbl";
            // 
            // gran2
            // 
            resources.ApplyResources(this.gran2, "gran2");
            this.gran2.Name = "gran2";
            // 
            // break_day_kal_lbl
            // 
            resources.ApplyResources(this.break_day_kal_lbl, "break_day_kal_lbl");
            this.break_day_kal_lbl.Name = "break_day_kal_lbl";
            // 
            // rec_din_kal_lbl
            // 
            resources.ApplyResources(this.rec_din_kal_lbl, "rec_din_kal_lbl");
            this.rec_din_kal_lbl.Name = "rec_din_kal_lbl";
            // 
            // gran3
            // 
            resources.ApplyResources(this.gran3, "gran3");
            this.gran3.Name = "gran3";
            // 
            // din_day_kal_lbl
            // 
            resources.ApplyResources(this.din_day_kal_lbl, "din_day_kal_lbl");
            this.din_day_kal_lbl.Name = "din_day_kal_lbl";
            // 
            // rec_aft_kal_lbl
            // 
            resources.ApplyResources(this.rec_aft_kal_lbl, "rec_aft_kal_lbl");
            this.rec_aft_kal_lbl.Name = "rec_aft_kal_lbl";
            // 
            // gran4
            // 
            resources.ApplyResources(this.gran4, "gran4");
            this.gran4.Name = "gran4";
            // 
            // aft_day_kal_lbl
            // 
            resources.ApplyResources(this.aft_day_kal_lbl, "aft_day_kal_lbl");
            this.aft_day_kal_lbl.Name = "aft_day_kal_lbl";
            // 
            // break_dish_list
            // 
            resources.ApplyResources(this.break_dish_list, "break_dish_list");
            this.break_dish_list.FormattingEnabled = true;
            this.break_dish_list.Name = "break_dish_list";
            // 
            // din_dish_list
            // 
            resources.ApplyResources(this.din_dish_list, "din_dish_list");
            this.din_dish_list.FormattingEnabled = true;
            this.din_dish_list.Name = "din_dish_list";
            // 
            // aft_dish_list
            // 
            resources.ApplyResources(this.aft_dish_list, "aft_dish_list");
            this.aft_dish_list.FormattingEnabled = true;
            this.aft_dish_list.Name = "aft_dish_list";
            // 
            // add_break_dish_btn
            // 
            this.add_break_dish_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.add_break_dish_btn, "add_break_dish_btn");
            this.add_break_dish_btn.Name = "add_break_dish_btn";
            this.add_break_dish_btn.UseVisualStyleBackColor = false;
            this.add_break_dish_btn.Click += new System.EventHandler(this.add_break_dish_btn_Click);
            // 
            // del_break_dish_btn
            // 
            this.del_break_dish_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.del_break_dish_btn, "del_break_dish_btn");
            this.del_break_dish_btn.Name = "del_break_dish_btn";
            this.del_break_dish_btn.UseVisualStyleBackColor = false;
            this.del_break_dish_btn.Click += new System.EventHandler(this.del_break_dish_btn_Click);
            // 
            // add_din_dish_btn
            // 
            this.add_din_dish_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.add_din_dish_btn, "add_din_dish_btn");
            this.add_din_dish_btn.Name = "add_din_dish_btn";
            this.add_din_dish_btn.UseVisualStyleBackColor = false;
            this.add_din_dish_btn.Click += new System.EventHandler(this.add_din_dish_btn_Click);
            // 
            // del_din_dish_btn
            // 
            this.del_din_dish_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.del_din_dish_btn, "del_din_dish_btn");
            this.del_din_dish_btn.Name = "del_din_dish_btn";
            this.del_din_dish_btn.UseVisualStyleBackColor = false;
            this.del_din_dish_btn.Click += new System.EventHandler(this.del_din_dish_btn_Click);
            // 
            // add_aft_dish_btn
            // 
            this.add_aft_dish_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.add_aft_dish_btn, "add_aft_dish_btn");
            this.add_aft_dish_btn.Name = "add_aft_dish_btn";
            this.add_aft_dish_btn.UseVisualStyleBackColor = false;
            this.add_aft_dish_btn.Click += new System.EventHandler(this.add_aft_dish_btn_Click);
            // 
            // del_aft_dish_btn
            // 
            this.del_aft_dish_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.del_aft_dish_btn, "del_aft_dish_btn");
            this.del_aft_dish_btn.Name = "del_aft_dish_btn";
            this.del_aft_dish_btn.UseVisualStyleBackColor = false;
            this.del_aft_dish_btn.Click += new System.EventHandler(this.del_aft_dish_btn_Click);
            // 
            // choose_comp_menu_btn
            // 
            this.choose_comp_menu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.choose_comp_menu_btn, "choose_comp_menu_btn");
            this.choose_comp_menu_btn.Name = "choose_comp_menu_btn";
            this.choose_comp_menu_btn.UseVisualStyleBackColor = false;
            this.choose_comp_menu_btn.Click += new System.EventHandler(this.choose_comp_menu_btn_Click);
            // 
            // save_all_btn
            // 
            this.save_all_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.save_all_btn, "save_all_btn");
            this.save_all_btn.Name = "save_all_btn";
            this.save_all_btn.UseVisualStyleBackColor = false;
            this.save_all_btn.Click += new System.EventHandler(this.save_all_btn_Click);
            // 
            // all_dish_list
            // 
            resources.ApplyResources(this.all_dish_list, "all_dish_list");
            this.all_dish_list.FormattingEnabled = true;
            this.all_dish_list.Name = "all_dish_list";
            this.all_dish_list.DoubleClick += new System.EventHandler(this.all_dish_list_DoubleClick);
            // 
            // search_lbl
            // 
            resources.ApplyResources(this.search_lbl, "search_lbl");
            this.search_lbl.Name = "search_lbl";
            // 
            // choose_search_par_combox
            // 
            this.choose_search_par_combox.FormattingEnabled = true;
            this.choose_search_par_combox.Items.AddRange(new object[] {
            resources.GetString("choose_search_par_combox.Items"),
            resources.GetString("choose_search_par_combox.Items1"),
            resources.GetString("choose_search_par_combox.Items2")});
            resources.ApplyResources(this.choose_search_par_combox, "choose_search_par_combox");
            this.choose_search_par_combox.Name = "choose_search_par_combox";
            // 
            // search_txt
            // 
            resources.ApplyResources(this.search_txt, "search_txt");
            this.search_txt.Name = "search_txt";
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.refresh_btn, "refresh_btn");
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            resources.ApplyResources(this.search_btn, "search_btn");
            this.search_btn.Name = "search_btn";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // add_dish_btn
            // 
            this.add_dish_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.add_dish_btn, "add_dish_btn");
            this.add_dish_btn.Name = "add_dish_btn";
            this.add_dish_btn.UseVisualStyleBackColor = false;
            this.add_dish_btn.Click += new System.EventHandler(this.add_dish_btn_Click);
            // 
            // del_dish_btn
            // 
            this.del_dish_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.del_dish_btn, "del_dish_btn");
            this.del_dish_btn.Name = "del_dish_btn";
            this.del_dish_btn.UseVisualStyleBackColor = false;
            this.del_dish_btn.Click += new System.EventHandler(this.del_dish_btn_Click);
            // 
            // proteins_lbl
            // 
            resources.ApplyResources(this.proteins_lbl, "proteins_lbl");
            this.proteins_lbl.Name = "proteins_lbl";
            // 
            // fats_lbl
            // 
            resources.ApplyResources(this.fats_lbl, "fats_lbl");
            this.fats_lbl.Name = "fats_lbl";
            // 
            // carbohydrates_lbl
            // 
            resources.ApplyResources(this.carbohydrates_lbl, "carbohydrates_lbl");
            this.carbohydrates_lbl.Name = "carbohydrates_lbl";
            // 
            // norm_lbl
            // 
            resources.ApplyResources(this.norm_lbl, "norm_lbl");
            this.norm_lbl.Name = "norm_lbl";
            // 
            // typed_lbl
            // 
            resources.ApplyResources(this.typed_lbl, "typed_lbl");
            this.typed_lbl.Name = "typed_lbl";
            // 
            // norm_proteins_lbl
            // 
            resources.ApplyResources(this.norm_proteins_lbl, "norm_proteins_lbl");
            this.norm_proteins_lbl.Name = "norm_proteins_lbl";
            // 
            // norm_fats_lbl
            // 
            resources.ApplyResources(this.norm_fats_lbl, "norm_fats_lbl");
            this.norm_fats_lbl.Name = "norm_fats_lbl";
            // 
            // norm_carbohydrates_lbl
            // 
            resources.ApplyResources(this.norm_carbohydrates_lbl, "norm_carbohydrates_lbl");
            this.norm_carbohydrates_lbl.Name = "norm_carbohydrates_lbl";
            // 
            // typed_proteins_lbl
            // 
            resources.ApplyResources(this.typed_proteins_lbl, "typed_proteins_lbl");
            this.typed_proteins_lbl.Name = "typed_proteins_lbl";
            // 
            // typed_fats_lbl
            // 
            resources.ApplyResources(this.typed_fats_lbl, "typed_fats_lbl");
            this.typed_fats_lbl.Name = "typed_fats_lbl";
            // 
            // typed_carbohydrates_lbl
            // 
            resources.ApplyResources(this.typed_carbohydrates_lbl, "typed_carbohydrates_lbl");
            this.typed_carbohydrates_lbl.Name = "typed_carbohydrates_lbl";
            // 
            // excel_btn
            // 
            this.excel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.excel_btn, "excel_btn");
            this.excel_btn.Name = "excel_btn";
            this.excel_btn.UseVisualStyleBackColor = false;
            this.excel_btn.Click += new System.EventHandler(this.excel_btn_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.excel_btn);
            this.Controls.Add(this.typed_carbohydrates_lbl);
            this.Controls.Add(this.typed_fats_lbl);
            this.Controls.Add(this.typed_proteins_lbl);
            this.Controls.Add(this.norm_carbohydrates_lbl);
            this.Controls.Add(this.norm_fats_lbl);
            this.Controls.Add(this.norm_proteins_lbl);
            this.Controls.Add(this.typed_lbl);
            this.Controls.Add(this.norm_lbl);
            this.Controls.Add(this.carbohydrates_lbl);
            this.Controls.Add(this.fats_lbl);
            this.Controls.Add(this.proteins_lbl);
            this.Controls.Add(this.del_dish_btn);
            this.Controls.Add(this.add_dish_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.choose_search_par_combox);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.all_dish_list);
            this.Controls.Add(this.save_all_btn);
            this.Controls.Add(this.choose_comp_menu_btn);
            this.Controls.Add(this.del_aft_dish_btn);
            this.Controls.Add(this.add_aft_dish_btn);
            this.Controls.Add(this.del_din_dish_btn);
            this.Controls.Add(this.add_din_dish_btn);
            this.Controls.Add(this.del_break_dish_btn);
            this.Controls.Add(this.add_break_dish_btn);
            this.Controls.Add(this.aft_dish_list);
            this.Controls.Add(this.din_dish_list);
            this.Controls.Add(this.break_dish_list);
            this.Controls.Add(this.aft_day_kal_lbl);
            this.Controls.Add(this.gran4);
            this.Controls.Add(this.rec_aft_kal_lbl);
            this.Controls.Add(this.din_day_kal_lbl);
            this.Controls.Add(this.gran3);
            this.Controls.Add(this.rec_din_kal_lbl);
            this.Controls.Add(this.break_day_kal_lbl);
            this.Controls.Add(this.gran2);
            this.Controls.Add(this.rec_break_kal_lbl);
            this.Controls.Add(this.aft_lbl);
            this.Controls.Add(this.dinner_lbl);
            this.Controls.Add(this.break_lbl);
            this.Controls.Add(this.menu_date);
            this.Controls.Add(this.week_day_lbl);
            this.Controls.Add(this.glob_day_kal_lbl);
            this.Controls.Add(this.gran);
            this.Controls.Add(this.earn_day_kal_lbl);
            this.Controls.Add(this.class_toolstr);
            this.Name = "MainForm";
            this.class_toolstr.ResumeLayout(false);
            this.class_toolstr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip class_toolstr;
        private System.Windows.Forms.Label earn_day_kal_lbl;
        private System.Windows.Forms.Label gran;
        private System.Windows.Forms.Label glob_day_kal_lbl;
        private System.Windows.Forms.Label week_day_lbl;
        private System.Windows.Forms.DateTimePicker menu_date;
        private System.Windows.Forms.Label break_lbl;
        private System.Windows.Forms.Label dinner_lbl;
        private System.Windows.Forms.Label aft_lbl;
        private System.Windows.Forms.Label rec_break_kal_lbl;
        private System.Windows.Forms.Label gran2;
        private System.Windows.Forms.Label break_day_kal_lbl;
        private System.Windows.Forms.Label rec_din_kal_lbl;
        private System.Windows.Forms.Label gran3;
        private System.Windows.Forms.Label din_day_kal_lbl;
        private System.Windows.Forms.Label rec_aft_kal_lbl;
        private System.Windows.Forms.Label gran4;
        private System.Windows.Forms.Label aft_day_kal_lbl;
        private System.Windows.Forms.ListBox break_dish_list;
        private System.Windows.Forms.ListBox din_dish_list;
        private System.Windows.Forms.ListBox aft_dish_list;
        private System.Windows.Forms.Button add_break_dish_btn;
        private System.Windows.Forms.Button del_break_dish_btn;
        private System.Windows.Forms.Button add_din_dish_btn;
        private System.Windows.Forms.Button del_din_dish_btn;
        private System.Windows.Forms.Button add_aft_dish_btn;
        private System.Windows.Forms.Button del_aft_dish_btn;
        private System.Windows.Forms.Button choose_comp_menu_btn;
        private System.Windows.Forms.Button save_all_btn;
        private System.Windows.Forms.ListBox all_dish_list;
        private System.Windows.Forms.Label search_lbl;
        private System.Windows.Forms.ComboBox choose_search_par_combox;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button add_dish_btn;
        private System.Windows.Forms.Button del_dish_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label proteins_lbl;
        private System.Windows.Forms.Label fats_lbl;
        private System.Windows.Forms.Label carbohydrates_lbl;
        private System.Windows.Forms.Label norm_lbl;
        private System.Windows.Forms.Label typed_lbl;
        private System.Windows.Forms.Label norm_proteins_lbl;
        private System.Windows.Forms.Label norm_fats_lbl;
        private System.Windows.Forms.Label norm_carbohydrates_lbl;
        private System.Windows.Forms.Label typed_proteins_lbl;
        private System.Windows.Forms.Label typed_fats_lbl;
        private System.Windows.Forms.Label typed_carbohydrates_lbl;
        public System.Windows.Forms.ToolStripButton second_call_tlstr;
        public System.Windows.Forms.ToolStripButton third_call_tlstr;
        public System.Windows.Forms.ToolStripButton first_call_tlstr;
        private System.Windows.Forms.Button excel_btn;
    }
}

