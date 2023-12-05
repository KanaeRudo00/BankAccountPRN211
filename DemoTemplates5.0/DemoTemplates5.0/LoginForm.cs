using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Windows.Forms;

namespace DemoTemplates5._0
{
    public partial class LoginForm : Form
    {
        UserRepo UserRepo { get; set; }
        BankAccountTypeContext _context;
        public LoginForm()
        {
            InitializeComponent();
            _context = new BankAccountTypeContext();
            UserRepo = new UserRepo(_context);
        }

        private void Login(object sender, System.EventArgs e)
        {
            try
            {
                var item = UserRepo.Login(tbUserId.Text, tbPassword.Text);
                if (item != null)
                {
                    ManagementForm mn = new ManagementForm(_context);
                    this.Hide();
                    mn.Show();
                    mn.Closed += (s, args) => this.Close();
                }
                else lbMessage.Text = "You are not allowed to access this function!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
