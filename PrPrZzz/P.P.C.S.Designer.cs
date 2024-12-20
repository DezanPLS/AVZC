namespace PrPrZzz
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
            tabControl1 = new TabControl();
            Registration = new TabPage();
            Parol = new Label();
            Login = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            buttonRegister = new Button();
            materials_tab = new TabPage();
            DltBtnM = new Button();
            textBox1 = new TextBox();
            AddBtnM = new Button();
            dataGridView1 = new DataGridView();
            WatchBtnM = new Button();
            employee_tab = new TabPage();
            DltBtnE = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            dataGridView2 = new DataGridView();
            AddBtnE = new Button();
            WatchBtnE = new Button();
            details_tab = new TabPage();
            DltBtnD = new Button();
            WatchBtnD = new Button();
            textBox4 = new TextBox();
            dataGridView3 = new DataGridView();
            AddBtnD = new Button();
            process_tab = new TabPage();
            DltBtnP = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label = new Label();
            textBoxTime = new TextBox();
            comboBoxD = new ComboBox();
            comboBoxE = new ComboBox();
            comboBoxM = new ComboBox();
            textBox5 = new TextBox();
            CrtBtnP = new Button();
            WatchBtnP = new Button();
            dataGridView4 = new DataGridView();
            tabControl1.SuspendLayout();
            Registration.SuspendLayout();
            materials_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            employee_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            details_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            process_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Registration);
            tabControl1.Controls.Add(materials_tab);
            tabControl1.Controls.Add(employee_tab);
            tabControl1.Controls.Add(details_tab);
            tabControl1.Controls.Add(process_tab);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 451);
            tabControl1.TabIndex = 0;
            // 
            // Registration
            // 
            Registration.BackColor = Color.PeachPuff;
            Registration.Controls.Add(Parol);
            Registration.Controls.Add(Login);
            Registration.Controls.Add(textBox8);
            Registration.Controls.Add(textBox7);
            Registration.Controls.Add(buttonRegister);
            Registration.Location = new Point(4, 24);
            Registration.Name = "Registration";
            Registration.Size = new Size(793, 423);
            Registration.TabIndex = 4;
            Registration.Text = "Вход";
            // 
            // Parol
            // 
            Parol.AutoSize = true;
            Parol.Location = new Point(211, 154);
            Parol.Name = "Parol";
            Parol.Size = new Size(49, 15);
            Parol.TabIndex = 4;
            Parol.Text = "Пароль";
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Location = new Point(211, 94);
            Login.Name = "Login";
            Login.Size = new Size(41, 15);
            Login.TabIndex = 3;
            Login.Text = "Логин";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(271, 154);
            textBox8.Name = "textBox8";
            textBox8.PasswordChar = '*';
            textBox8.Size = new Size(229, 23);
            textBox8.TabIndex = 2;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Window;
            textBox7.Location = new Point(271, 94);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(229, 23);
            textBox7.TabIndex = 1;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(312, 199);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(134, 41);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "Войти";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // materials_tab
            // 
            materials_tab.BackColor = Color.DarkSlateGray;
            materials_tab.Controls.Add(DltBtnM);
            materials_tab.Controls.Add(textBox1);
            materials_tab.Controls.Add(AddBtnM);
            materials_tab.Controls.Add(dataGridView1);
            materials_tab.Controls.Add(WatchBtnM);
            materials_tab.Location = new Point(4, 24);
            materials_tab.Name = "materials_tab";
            materials_tab.Padding = new Padding(3);
            materials_tab.Size = new Size(793, 423);
            materials_tab.TabIndex = 0;
            materials_tab.Text = "Материалы";
            // 
            // DltBtnM
            // 
            DltBtnM.Location = new Point(441, 152);
            DltBtnM.Name = "DltBtnM";
            DltBtnM.Size = new Size(186, 49);
            DltBtnM.TabIndex = 4;
            DltBtnM.Text = "Удаление материала ";
            DltBtnM.UseVisualStyleBackColor = true;
            DltBtnM.Click += DltBtnM_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(441, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 55);
            textBox1.TabIndex = 3;
            // 
            // AddBtnM
            // 
            AddBtnM.Location = new Point(441, 95);
            AddBtnM.Name = "AddBtnM";
            AddBtnM.Size = new Size(186, 51);
            AddBtnM.TabIndex = 2;
            AddBtnM.Text = "Добавить материал";
            AddBtnM.UseVisualStyleBackColor = true;
            AddBtnM.Click += AddBtnM_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(429, 352);
            dataGridView1.TabIndex = 1;
            // 
            // WatchBtnM
            // 
            WatchBtnM.Location = new Point(6, 364);
            WatchBtnM.Name = "WatchBtnM";
            WatchBtnM.Size = new Size(186, 50);
            WatchBtnM.TabIndex = 0;
            WatchBtnM.Text = "Посмотреть материалы";
            WatchBtnM.UseVisualStyleBackColor = true;
            WatchBtnM.Click += WatchBtnD_Click;
            // 
            // employee_tab
            // 
            employee_tab.BackColor = Color.DarkKhaki;
            employee_tab.Controls.Add(DltBtnE);
            employee_tab.Controls.Add(label3);
            employee_tab.Controls.Add(label2);
            employee_tab.Controls.Add(textBox3);
            employee_tab.Controls.Add(label1);
            employee_tab.Controls.Add(textBox2);
            employee_tab.Controls.Add(dataGridView2);
            employee_tab.Controls.Add(AddBtnE);
            employee_tab.Controls.Add(WatchBtnE);
            employee_tab.Location = new Point(4, 24);
            employee_tab.Name = "employee_tab";
            employee_tab.Padding = new Padding(3);
            employee_tab.Size = new Size(793, 423);
            employee_tab.TabIndex = 1;
            employee_tab.Text = "Сотрудники";
            // 
            // DltBtnE
            // 
            DltBtnE.Location = new Point(461, 189);
            DltBtnE.Name = "DltBtnE";
            DltBtnE.Size = new Size(226, 44);
            DltBtnE.TabIndex = 6;
            DltBtnE.Text = "Удаление сотрудника";
            DltBtnE.UseVisualStyleBackColor = true;
            DltBtnE.Click += DltBtnE_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(463, 61);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 0;
            label3.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 7);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "Имя";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(462, 82);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(265, 23);
            textBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 3);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 4;
            label1.Text = "Список сотрудников";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(462, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 23);
            textBox2.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(8, 21);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(447, 328);
            dataGridView2.TabIndex = 2;
            // 
            // AddBtnE
            // 
            AddBtnE.Location = new Point(463, 124);
            AddBtnE.Name = "AddBtnE";
            AddBtnE.Size = new Size(224, 47);
            AddBtnE.TabIndex = 1;
            AddBtnE.Text = "Добавить сотрудника";
            AddBtnE.UseVisualStyleBackColor = true;
            AddBtnE.Click += AddBtnE_Click;
            // 
            // WatchBtnE
            // 
            WatchBtnE.Location = new Point(8, 367);
            WatchBtnE.Name = "WatchBtnE";
            WatchBtnE.Size = new Size(197, 50);
            WatchBtnE.TabIndex = 0;
            WatchBtnE.Text = "Посмотреть сотрудников";
            WatchBtnE.UseVisualStyleBackColor = true;
            WatchBtnE.Click += WatchBtnE_Click;
            // 
            // details_tab
            // 
            details_tab.BackColor = Color.DimGray;
            details_tab.Controls.Add(DltBtnD);
            details_tab.Controls.Add(WatchBtnD);
            details_tab.Controls.Add(textBox4);
            details_tab.Controls.Add(dataGridView3);
            details_tab.Controls.Add(AddBtnD);
            details_tab.Location = new Point(4, 24);
            details_tab.Name = "details_tab";
            details_tab.Size = new Size(793, 423);
            details_tab.TabIndex = 2;
            details_tab.Text = "Детали";
            // 
            // DltBtnD
            // 
            DltBtnD.Location = new Point(484, 171);
            DltBtnD.Name = "DltBtnD";
            DltBtnD.Size = new Size(156, 41);
            DltBtnD.TabIndex = 4;
            DltBtnD.Text = "Удаление детали";
            DltBtnD.UseVisualStyleBackColor = true;
            DltBtnD.Click += DltBtnD_Click;
            // 
            // WatchBtnD
            // 
            WatchBtnD.Location = new Point(8, 373);
            WatchBtnD.Name = "WatchBtnD";
            WatchBtnD.Size = new Size(166, 41);
            WatchBtnD.TabIndex = 3;
            WatchBtnD.Text = "Посмотреть деталь";
            WatchBtnD.UseVisualStyleBackColor = true;
            WatchBtnD.Click += WatchBtnD_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(484, 62);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(254, 43);
            textBox4.TabIndex = 2;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(478, 367);
            dataGridView3.TabIndex = 1;
            // 
            // AddBtnD
            // 
            AddBtnD.Location = new Point(484, 124);
            AddBtnD.Name = "AddBtnD";
            AddBtnD.Size = new Size(156, 41);
            AddBtnD.TabIndex = 0;
            AddBtnD.Text = "Добавить деталь";
            AddBtnD.UseVisualStyleBackColor = true;
            AddBtnD.Click += AddBtnD_Click;
            // 
            // process_tab
            // 
            process_tab.BackColor = Color.Honeydew;
            process_tab.Controls.Add(DltBtnP);
            process_tab.Controls.Add(label9);
            process_tab.Controls.Add(label8);
            process_tab.Controls.Add(label7);
            process_tab.Controls.Add(label6);
            process_tab.Controls.Add(label);
            process_tab.Controls.Add(textBoxTime);
            process_tab.Controls.Add(comboBoxD);
            process_tab.Controls.Add(comboBoxE);
            process_tab.Controls.Add(comboBoxM);
            process_tab.Controls.Add(textBox5);
            process_tab.Controls.Add(CrtBtnP);
            process_tab.Controls.Add(WatchBtnP);
            process_tab.Controls.Add(dataGridView4);
            process_tab.Location = new Point(4, 24);
            process_tab.Name = "process_tab";
            process_tab.Size = new Size(793, 423);
            process_tab.TabIndex = 3;
            process_tab.Text = "Процессы";
            // 
            // DltBtnP
            // 
            DltBtnP.Location = new Point(503, 327);
            DltBtnP.Name = "DltBtnP";
            DltBtnP.Size = new Size(160, 48);
            DltBtnP.TabIndex = 17;
            DltBtnP.Text = "Удаление процесса";
            DltBtnP.UseVisualStyleBackColor = true;
            DltBtnP.Click += DltBtnP_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(503, 200);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 16;
            label9.Text = "Время";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(503, 154);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 15;
            label8.Text = "Продукт";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(503, 110);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 14;
            label7.Text = "Работник";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(503, 67);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 13;
            label6.Text = "Материал";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(497, 3);
            label.Name = "label";
            label.Size = new Size(114, 15);
            label.TabIndex = 12;
            label.Text = "Название процесса";
            // 
            // textBoxTime
            // 
            textBoxTime.Location = new Point(503, 223);
            textBoxTime.Name = "textBoxTime";
            textBoxTime.Size = new Size(100, 23);
            textBoxTime.TabIndex = 11;
            // 
            // comboBoxD
            // 
            comboBoxD.FormattingEnabled = true;
            comboBoxD.Location = new Point(503, 174);
            comboBoxD.Name = "comboBoxD";
            comboBoxD.Size = new Size(121, 23);
            comboBoxD.TabIndex = 10;
            // 
            // comboBoxE
            // 
            comboBoxE.FormattingEnabled = true;
            comboBoxE.Location = new Point(503, 128);
            comboBoxE.Name = "comboBoxE";
            comboBoxE.Size = new Size(121, 23);
            comboBoxE.TabIndex = 9;
            // 
            // comboBoxM
            // 
            comboBoxM.FormattingEnabled = true;
            comboBoxM.Location = new Point(503, 85);
            comboBoxM.Name = "comboBoxM";
            comboBoxM.Size = new Size(121, 23);
            comboBoxM.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(503, 25);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(227, 38);
            textBox5.TabIndex = 6;
            // 
            // CrtBtnP
            // 
            CrtBtnP.Location = new Point(503, 263);
            CrtBtnP.Name = "CrtBtnP";
            CrtBtnP.Size = new Size(160, 46);
            CrtBtnP.TabIndex = 5;
            CrtBtnP.Text = "Создание процесса";
            CrtBtnP.UseVisualStyleBackColor = true;
            CrtBtnP.Click += CrtBtnP_Click;
            // 
            // WatchBtnP
            // 
            WatchBtnP.Location = new Point(8, 375);
            WatchBtnP.Name = "WatchBtnP";
            WatchBtnP.Size = new Size(195, 39);
            WatchBtnP.TabIndex = 4;
            WatchBtnP.Text = "Посмотреть процесс";
            WatchBtnP.UseVisualStyleBackColor = true;
            WatchBtnP.Click += WatchBtnP_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(6, 9);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(491, 360);
            dataGridView4.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "P.P.S.C";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            Registration.ResumeLayout(false);
            Registration.PerformLayout();
            materials_tab.ResumeLayout(false);
            materials_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            employee_tab.ResumeLayout(false);
            employee_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            details_tab.ResumeLayout(false);
            details_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            process_tab.ResumeLayout(false);
            process_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage materials_tab;
        private TabPage employee_tab;
        private TabPage details_tab;
        private TabPage process_tab;
        private TextBox textBox1;
        private Button AddBtnM;
        private DataGridView dataGridView1;
        private Button WatchBtnM;
        private Button AddBtnE;
        private Button WatchBtnE;
        private TextBox textBox2;
        private DataGridView dataGridView2;
        private Button AddBtnD;
        private Label label1;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private Button WatchBtnD;
        private TextBox textBox4;
        private DataGridView dataGridView3;
        private TextBox textBox5;
        private Button CrtBtnP;
        private Button WatchBtnP;
        private DataGridView dataGridView4;
        private ComboBox comboBoxM;
        private TabPage Registration;
        private Button buttonRegister;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label Parol;
        private Label Login;
        private Button DltBtnM;
        private ComboBox comboBoxD;
        private ComboBox comboBoxE;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label;
        private TextBox textBoxTime;
        private Button DltBtnE;
        private Button DltBtnD;
        private Button DltBtnP;
    }
}