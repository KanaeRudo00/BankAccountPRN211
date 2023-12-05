using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoTemplates5._0
{
    public partial class ModifyForm : Form
    {
        BankAccountRepo repo;
        AccountTypeRepo typerepo;
        public ModifyForm(string type, string id, BankAccountTypeContext context)
        {
            try
            {
                InitializeComponent();
                repo = new BankAccountRepo(context);
                typerepo = new AccountTypeRepo(context);
                btnSubmit.Text = type;
                ipId.Text = id;
                ipType.DataSource = typerepo.GetAccountTypes().Select(u => new { Text = u.TypeDesc, Value = u.TypeId }).ToList();
                ipType.DisplayMember = "Text";
                ipType.ValueMember = "Value";
                if (type == "Update")
                {

                    ipId.ReadOnly = true;
                    var item = repo.GetAccount(ipId.Text);
                    ipAccountName.Text = item.AccountName;
                    ipBranchName.Text = item.BranchName;
                    ipOpenDate.Value = item.OpenDate ?? DateTime.Now;
                    ipType.SelectedValue = typerepo.GetAccountType(item.TypeId).TypeId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing went wrong!", "Notice!", MessageBoxButtons.OK);
            }


        }

        private void Submit(object sender, EventArgs e)
        {
            if (
                ipId.Text == null ||
                ipAccountName.Text == null ||
                ipBranchName.Text == null ||
                ipOpenDate.Text == null ||
                ipType.SelectedValue == null
            )
                MessageBox.Show("Invalid Input!", "Notice!", MessageBoxButtons.OK);
            else if (btnSubmit.Text == "Add")
            {
                if (!repo.AddAccount(new BankAccount
                {
                    AccountId = ipId.Text,
                    BranchName = ipBranchName.Text,
                    OpenDate = ipOpenDate.Value,
                    AccountName = ipAccountName.Text,
                    TypeId = ipType.SelectedValue.ToString()
                }))
                    MessageBox.Show("Invalid Input!", "Notice!", MessageBoxButtons.OK);
            }
            else if (btnSubmit.Text == "Update")
                if (!repo.UpdateAccount(new BankAccount
                {
                    AccountId = ipId.Text,
                    BranchName = ipBranchName.Text,
                    OpenDate = ipOpenDate.Value,
                    AccountName = ipAccountName.Text,
                    TypeId = ipType.SelectedValue.ToString()
                }))
                    MessageBox.Show("Invalid Input!", "Notice!", MessageBoxButtons.OK);

            this.Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
