namespace Organization_Profile
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            txtContactNo = new TextBox();
            cbProgram = new ComboBox();
            cbGender = new ComboBox();
            datePickerBirthday = new DateTimePicker();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(121, 157);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(129, 23);
            txtStudentNo.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(121, 210);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(129, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(121, 253);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(87, 23);
            txtAge.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(365, 205);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(146, 23);
            txtFirstName.TabIndex = 3;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(558, 205);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(54, 23);
            txtMiddleInitial.TabIndex = 4;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(458, 294);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(154, 23);
            txtContactNo.TabIndex = 5;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(355, 157);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(257, 23);
            cbProgram.TabIndex = 6;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male" });
            cbGender.Location = new Point(365, 253);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(100, 23);
            cbGender.TabIndex = 7;
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(121, 294);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(200, 23);
            datePickerBirthday.TabIndex = 8;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightSeaGreen;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.Transparent;
            btnRegister.Location = new Point(256, 373);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(135, 37);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 157);
            label1.Name = "label1";
            label1.Size = new Size(79, 18);
            label1.TabIndex = 10;
            label1.Text = "Student No. ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 210);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 11;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(286, 157);
            label3.Name = "label3";
            label3.Size = new Size(60, 18);
            label3.TabIndex = 12;
            label3.Text = "Program";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(286, 210);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 13;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(528, 210);
            label5.Name = "label5";
            label5.Size = new Size(24, 18);
            label5.TabIndex = 14;
            label5.Text = "M.I";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(38, 258);
            label6.Name = "label6";
            label6.Size = new Size(30, 18);
            label6.TabIndex = 15;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(299, 258);
            label7.Name = "label7";
            label7.Size = new Size(50, 18);
            label7.TabIndex = 16;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(373, 300);
            label8.Name = "label8";
            label8.Size = new Size(79, 18);
            label8.TabIndex = 17;
            label8.Text = "Contact No. ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiCondensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(38, 300);
            label9.Name = "label9";
            label9.Size = new Size(56, 18);
            label9.TabIndex = 18;
            label9.Text = "Birthday";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(140, 71);
            label10.Name = "label10";
            label10.Size = new Size(181, 29);
            label10.TabIndex = 19;
            label10.Text = "Registration Form";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            ClientSize = new Size(647, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(datePickerBirthday);
            Controls.Add(cbGender);
            Controls.Add(cbProgram);
            Controls.Add(txtContactNo);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            HelpButton = true;
            Name = "frmRegistration";
            ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            Style = MetroFramework.MetroColorStyle.Teal;
            Text = "Organization Profile";
            Theme = MetroFramework.MetroThemeStyle.Default;
            TransparencyKey = Color.SkyBlue;
            Load += frmRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private TextBox txtContactNo;
        private ComboBox cbProgram;
        private ComboBox cbGender;
        private DateTimePicker datePickerBirthday;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
    }
}