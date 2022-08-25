namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_GV = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.comb_dept = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_add = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // data_GV
            // 
            this.data_GV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.data_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_GV.GridColor = System.Drawing.Color.WhiteSmoke;
            this.data_GV.Location = new System.Drawing.Point(12, 172);
            this.data_GV.Name = "data_GV";
            this.data_GV.RowHeadersWidth = 51;
            this.data_GV.RowTemplate.Height = 29;
            this.data_GV.Size = new System.Drawing.Size(684, 367);
            this.data_GV.TabIndex = 0;
            this.data_GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_GV_CellContentClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(362, 70);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(94, 29);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(514, 70);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(94, 29);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // comb_dept
            // 
            this.comb_dept.FormattingEnabled = true;
            this.comb_dept.Location = new System.Drawing.Point(936, 346);
            this.comb_dept.Name = "comb_dept";
            this.comb_dept.Size = new System.Drawing.Size(125, 28);
            this.comb_dept.TabIndex = 3;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(12, 70);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(291, 27);
            this.txt_search.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(776, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(776, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(776, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(776, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dept";
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.Location = new System.Drawing.Point(776, 411);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(0, 20);
            this.lbl_add.TabIndex = 10;
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(936, 165);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(125, 27);
            this.txt_Id.TabIndex = 14;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(936, 209);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(125, 27);
            this.txt_Name.TabIndex = 15;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(936, 300);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(125, 27);
            this.txt_address.TabIndex = 16;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.Location = new System.Drawing.Point(946, 402);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Age";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(936, 259);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(125, 27);
            this.txt_age.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 566);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.lbl_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.comb_dept);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.data_GV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_GV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView data_GV;
        private Button btn_search;
        private Button Reset;
        private ComboBox comb_dept;
        private TextBox txt_search;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbl_add;
        private TextBox txt_Id;
        private TextBox txt_Name;
        private TextBox txt_address;
        private Button btn_add;
        private Label label1;
        private TextBox txt_age;
        private Label label6;
    }
}