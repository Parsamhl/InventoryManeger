namespace InventoryManeger
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            TabPage = new TabPage();
            LoginPasswordTxt = new TextBox();
            passwordLabel = new Label();
            LoginUserNameTxt = new TextBox();
            UserNameLabel = new Label();
            button1 = new Button();
            SignInPage = new TabPage();
            RegisterBtn = new Button();
            RegisterPassTxt = new TextBox();
            passLabel = new Label();
            RegisterUserNameTxt = new TextBox();
            UserNameLabe = new Label();
            RegisterLNameTxt = new TextBox();
            LastNameLabel = new Label();
            RegisterNameTxt = new TextBox();
            NameLabel = new Label();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            TabPage.SuspendLayout();
            SignInPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPage);
            tabControl1.Controls.Add(SignInPage);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 5;
            // 
            // TabPage
            // 
            TabPage.Controls.Add(LoginPasswordTxt);
            TabPage.Controls.Add(passwordLabel);
            TabPage.Controls.Add(LoginUserNameTxt);
            TabPage.Controls.Add(UserNameLabel);
            TabPage.Controls.Add(button1);
            TabPage.Location = new Point(4, 24);
            TabPage.Name = "TabPage";
            TabPage.Padding = new Padding(3);
            TabPage.Size = new Size(768, 398);
            TabPage.TabIndex = 0;
            TabPage.Text = "Login";
            TabPage.UseVisualStyleBackColor = true;
            // 
            // LoginPasswordTxt
            // 
            LoginPasswordTxt.Location = new Point(61, 166);
            LoginPasswordTxt.Name = "LoginPasswordTxt";
            LoginPasswordTxt.PasswordChar = '*';
            LoginPasswordTxt.PlaceholderText = "Enter your password please";
            LoginPasswordTxt.Size = new Size(310, 23);
            LoginPasswordTxt.TabIndex = 4;
            LoginPasswordTxt.TextChanged += textBox2_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(61, 139);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(63, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password :";
            // 
            // LoginUserNameTxt
            // 
            LoginUserNameTxt.Location = new Point(61, 94);
            LoginUserNameTxt.Name = "LoginUserNameTxt";
            LoginUserNameTxt.PlaceholderText = "enter your user name please ";
            LoginUserNameTxt.Size = new Size(310, 23);
            LoginUserNameTxt.TabIndex = 2;
            LoginUserNameTxt.TextChanged += textBox1_TextChanged;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(61, 65);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(69, 15);
            UserNameLabel.TabIndex = 1;
            UserNameLabel.Text = "User name :";
            // 
            // button1
            // 
            button1.Location = new Point(127, 246);
            button1.Name = "button1";
            button1.Size = new Size(429, 33);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // SignInPage
            // 
            SignInPage.Controls.Add(RegisterBtn);
            SignInPage.Controls.Add(RegisterPassTxt);
            SignInPage.Controls.Add(passLabel);
            SignInPage.Controls.Add(RegisterUserNameTxt);
            SignInPage.Controls.Add(UserNameLabe);
            SignInPage.Controls.Add(RegisterLNameTxt);
            SignInPage.Controls.Add(LastNameLabel);
            SignInPage.Controls.Add(RegisterNameTxt);
            SignInPage.Controls.Add(NameLabel);
            SignInPage.Location = new Point(4, 24);
            SignInPage.Name = "SignInPage";
            SignInPage.Padding = new Padding(3);
            SignInPage.Size = new Size(768, 398);
            SignInPage.TabIndex = 1;
            SignInPage.Text = "Register";
            SignInPage.UseVisualStyleBackColor = true;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(110, 285);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(472, 23);
            RegisterBtn.TabIndex = 8;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // RegisterPassTxt
            // 
            RegisterPassTxt.Location = new Point(333, 190);
            RegisterPassTxt.Name = "RegisterPassTxt";
            RegisterPassTxt.Size = new Size(224, 23);
            RegisterPassTxt.TabIndex = 7;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new Point(333, 150);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(63, 15);
            passLabel.TabIndex = 6;
            passLabel.Text = "Password :";
            // 
            // RegisterUserNameTxt
            // 
            RegisterUserNameTxt.Location = new Point(46, 190);
            RegisterUserNameTxt.Name = "RegisterUserNameTxt";
            RegisterUserNameTxt.Size = new Size(211, 23);
            RegisterUserNameTxt.TabIndex = 5;
            // 
            // UserNameLabe
            // 
            UserNameLabe.AutoSize = true;
            UserNameLabe.Location = new Point(46, 150);
            UserNameLabe.Name = "UserNameLabe";
            UserNameLabe.Size = new Size(71, 15);
            UserNameLabe.TabIndex = 4;
            UserNameLabe.Text = "User Name :";
            UserNameLabe.Click += label1_Click;
            // 
            // RegisterLNameTxt
            // 
            RegisterLNameTxt.Location = new Point(333, 54);
            RegisterLNameTxt.Name = "RegisterLNameTxt";
            RegisterLNameTxt.Size = new Size(224, 23);
            RegisterLNameTxt.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(333, 16);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(66, 15);
            LastNameLabel.TabIndex = 2;
            LastNameLabel.Text = "LastName :";
            // 
            // RegisterNameTxt
            // 
            RegisterNameTxt.Location = new Point(46, 54);
            RegisterNameTxt.Name = "RegisterNameTxt";
            RegisterNameTxt.Size = new Size(211, 23);
            RegisterNameTxt.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(46, 16);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(45, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            TabPage.ResumeLayout(false);
            TabPage.PerformLayout();
            SignInPage.ResumeLayout(false);
            SignInPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TabPage;
        private Button button1;
        private TabPage SignInPage;
        private TextBox LoginUserNameTxt;
        private Label UserNameLabel;
        private TextBox LoginPasswordTxt;
        private Label passwordLabel;
        private Label UserNameLabe;
        private TextBox RegisterLNameTxt;
        private Label LastNameLabel;
        private TextBox RegisterNameTxt;
        private Label NameLabel;
        private TextBox RegisterPassTxt;
        private Label passLabel;
        private TextBox RegisterUserNameTxt;
        private ErrorProvider errorProvider1;
        private Button RegisterBtn;
    }
}
