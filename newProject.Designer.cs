namespace Calculator
{
    partial class newProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newProject));
            this.username = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.input2 = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.robot = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Heading = new System.Windows.Forms.Label();
            this.subheading = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Red;
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.username.Location = new System.Drawing.Point(252, 205);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(102, 20);
            this.username.TabIndex = 0;
            this.username.Text = "User Name";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(438, 297);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 1;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(378, 243);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(190, 23);
            this.input2.TabIndex = 2;
            this.input2.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.Red;
            this.pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pass.Location = new System.Drawing.Point(252, 243);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(102, 20);
            this.pass.TabIndex = 0;
            this.pass.Text = "Password";
            this.pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pass.Click += new System.EventHandler(this.label1_Click);
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(378, 205);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(190, 23);
            this.input1.TabIndex = 2;
            this.input1.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // robot
            // 
            this.robot.AutoSize = true;
            this.robot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.robot.ForeColor = System.Drawing.Color.White;
            this.robot.Location = new System.Drawing.Point(420, 272);
            this.robot.Name = "robot";
            this.robot.Size = new System.Drawing.Size(105, 19);
            this.robot.TabIndex = 3;
            this.robot.Text = "I\'m not a robot";
            this.robot.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 94);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Heading
            // 
            this.Heading.BackColor = System.Drawing.Color.DarkBlue;
            this.Heading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Heading.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Heading.Location = new System.Drawing.Point(197, 21);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(596, 71);
            this.Heading.TabIndex = 5;
            this.Heading.Text = "KIST College and SS";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Heading.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // subheading
            // 
            this.subheading.BackColor = System.Drawing.Color.Navy;
            this.subheading.Location = new System.Drawing.Point(350, 101);
            this.subheading.Name = "subheading";
            this.subheading.Size = new System.Drawing.Size(227, 23);
            this.subheading.TabIndex = 6;
            this.subheading.Text = "Kamalpokhari,Kathmandu";
            this.subheading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.comboBox1.Location = new System.Drawing.Point(404, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 7;
            // 
            // newProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.subheading);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.robot);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "newProject";
            this.Text = "newProject";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label username;
        private Button login;
        private TextBox input2;
        private Label pass;
        private TextBox input1;
        private CheckBox robot;
        private PictureBox pictureBox1;
        private Label Heading;
        private Label subheading;
        private ComboBox comboBox1;
    }
}