using InventoryManeger.Services;
using Microsoft.IdentityModel.Tokens;

namespace InventoryManeger
{
    public partial class Form1 : Form
    {

        private readonly UserService _userService;
        public Form1()
        {
            _userService = new UserService();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (LoginUserNameTxt.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(LoginUserNameTxt, "UserName can not be null");
            }
            if (LoginPasswordTxt.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(LoginPasswordTxt, "password can not be null");
            }
            else
            {
                errorProvider1.Clear();
                bool login = _userService.Login(LoginUserNameTxt.Text, LoginPasswordTxt.Text);
                if (login) {

                    MainForm mainForm = new MainForm();

                    mainForm.Show();
                    this.Hide();
                }
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (RegisterNameTxt.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(RegisterNameTxt, "This field must be fill");
            }
            if (RegisterLNameTxt.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(RegisterLNameTxt, "This field must be fill");
            }
            if (RegisterUserNameTxt.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(RegisterUserNameTxt, "This field must be fill");
            }
            if (RegisterPassTxt.Text.IsNullOrEmpty())
            {
                errorProvider1.SetError(RegisterPassTxt, "This field must be fill");
            }
            _userService.Register(RegisterNameTxt.Text, RegisterLNameTxt.Text, RegisterUserNameTxt.Text, RegisterPassTxt.Text);

            MainForm mainForm = new MainForm();

            mainForm.Show();
            this.Hide();


        }
    }
}
