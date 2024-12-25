namespace QL_QuanCafe
{
    partial class Frm_Manager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fLPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_select_food = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cb_select_category = new System.Windows.Forms.ComboBox();
            this.btn_Add_food = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_TTable = new System.Windows.Forms.ListView();
            this.namfood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_Pay_Bill = new System.Windows.Forms.Button();
            this.btn_Resfesh = new System.Windows.Forms.Button();
            this.btn_Add_TTable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem1,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.thôngTinToolStripMenuItem.Text = "Cá nhân";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem1
            // 
            this.thôngTinToolStripMenuItem1.Name = "thôngTinToolStripMenuItem1";
            this.thôngTinToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.thôngTinToolStripMenuItem1.Text = "Thông tin";
            this.thôngTinToolStripMenuItem1.Click += new System.EventHandler(this.thôngTinToolStripMenuItem1_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(5, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 576);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fLPanel1);
            this.groupBox3.Location = new System.Drawing.Point(8, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 565);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bàn";
            // 
            // fLPanel1
            // 
            this.fLPanel1.AutoScroll = true;
            this.fLPanel1.Location = new System.Drawing.Point(6, 13);
            this.fLPanel1.Name = "fLPanel1";
            this.fLPanel1.Size = new System.Drawing.Size(635, 546);
            this.fLPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(678, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 394);
            this.panel3.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_select_food);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.cb_select_category);
            this.groupBox4.Controls.Add(this.btn_Add_food);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(5, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 161);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Menu";
            // 
            // cb_select_food
            // 
            this.cb_select_food.FormattingEnabled = true;
            this.cb_select_food.Location = new System.Drawing.Point(86, 60);
            this.cb_select_food.Name = "cb_select_food";
            this.cb_select_food.Size = new System.Drawing.Size(181, 21);
            this.cb_select_food.TabIndex = 8;
            this.cb_select_food.SelectedIndexChanged += new System.EventHandler(this.cb_select_food_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên món :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(167, 96);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cb_select_category
            // 
            this.cb_select_category.FormattingEnabled = true;
            this.cb_select_category.Location = new System.Drawing.Point(86, 19);
            this.cb_select_category.Name = "cb_select_category";
            this.cb_select_category.Size = new System.Drawing.Size(181, 21);
            this.cb_select_category.TabIndex = 1;
            this.cb_select_category.SelectedIndexChanged += new System.EventHandler(this.cb_select_category_SelectedIndexChanged);
            // 
            // btn_Add_food
            // 
            this.btn_Add_food.Location = new System.Drawing.Point(187, 122);
            this.btn_Add_food.Name = "btn_Add_food";
            this.btn_Add_food.Size = new System.Drawing.Size(80, 33);
            this.btn_Add_food.TabIndex = 0;
            this.btn_Add_food.Text = "Thêm món";
            this.btn_Add_food.UseVisualStyleBackColor = true;
            this.btn_Add_food.Click += new System.EventHandler(this.btn_Add_food_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_TTable);
            this.groupBox2.Location = new System.Drawing.Point(3, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 217);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // lv_TTable
            // 
            this.lv_TTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namfood,
            this.count,
            this.price,
            this.totalprice});
            this.lv_TTable.GridLines = true;
            this.lv_TTable.HideSelection = false;
            this.lv_TTable.Location = new System.Drawing.Point(11, 21);
            this.lv_TTable.Name = "lv_TTable";
            this.lv_TTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lv_TTable.Size = new System.Drawing.Size(321, 190);
            this.lv_TTable.TabIndex = 0;
            this.lv_TTable.UseCompatibleStateImageBehavior = false;
            this.lv_TTable.View = System.Windows.Forms.View.Details;
            // 
            // namfood
            // 
            this.namfood.Text = "Food";
            // 
            // count
            // 
            this.count.Text = "Số Lượng";
            // 
            // price
            // 
            this.price.Text = "Giá";
            // 
            // totalprice
            // 
            this.totalprice.Text = "Thành tiền";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(678, 428);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(344, 176);
            this.panel4.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_total);
            this.groupBox1.Controls.Add(this.btn_Pay_Bill);
            this.groupBox1.Controls.Add(this.btn_Resfesh);
            this.groupBox1.Controls.Add(this.btn_Add_TTable);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác vụ";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(104, 56);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(181, 20);
            this.txt_total.TabIndex = 8;
            this.txt_total.Text = "0";
            // 
            // btn_Pay_Bill
            // 
            this.btn_Pay_Bill.Location = new System.Drawing.Point(246, 128);
            this.btn_Pay_Bill.Name = "btn_Pay_Bill";
            this.btn_Pay_Bill.Size = new System.Drawing.Size(80, 33);
            this.btn_Pay_Bill.TabIndex = 5;
            this.btn_Pay_Bill.Text = "Thanh Toán";
            this.btn_Pay_Bill.UseVisualStyleBackColor = true;
            this.btn_Pay_Bill.Click += new System.EventHandler(this.btn_Pay_Bill_Click);
            // 
            // btn_Resfesh
            // 
            this.btn_Resfesh.Location = new System.Drawing.Point(138, 128);
            this.btn_Resfesh.Name = "btn_Resfesh";
            this.btn_Resfesh.Size = new System.Drawing.Size(80, 33);
            this.btn_Resfesh.TabIndex = 4;
            this.btn_Resfesh.Text = "Đặt lại";
            this.btn_Resfesh.UseVisualStyleBackColor = true;
            this.btn_Resfesh.Click += new System.EventHandler(this.btn_Resfesh_Click);
            // 
            // btn_Add_TTable
            // 
            this.btn_Add_TTable.Location = new System.Drawing.Point(18, 128);
            this.btn_Add_TTable.Name = "btn_Add_TTable";
            this.btn_Add_TTable.Size = new System.Drawing.Size(80, 33);
            this.btn_Add_TTable.TabIndex = 3;
            this.btn_Add_TTable.Text = "Gộp bàn";
            this.btn_Add_TTable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tạm tính :";
            // 
            // Frm_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1029, 611);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Manager_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Pay_Bill;
        private System.Windows.Forms.Button btn_Resfesh;
        private System.Windows.Forms.Button btn_Add_TTable;
        private System.Windows.Forms.Button btn_Add_food;
        private System.Windows.Forms.ListView lv_TTable;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_select_category;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel fLPanel1;
        private System.Windows.Forms.ColumnHeader namfood;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader totalprice;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.ComboBox cb_select_food;
        private System.Windows.Forms.Label label2;
    }
}