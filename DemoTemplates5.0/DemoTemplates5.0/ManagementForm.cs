using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoTemplates5._0
{
    public partial class ManagementForm : Form
    {
        BankAccountRepo repo;
        BankAccountTypeContext _context;
        public ManagementForm(BankAccountTypeContext context)
        {
            _context = context;
            repo = new BankAccountRepo(context);
            InitializeComponent();
            try
            {
                refreshData();
                dgvAccounts.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Somthing went wrong!", MessageBoxButtons.OK);
                dgvAccounts.DataSource = null;
                dgvAccounts.DataSource = repo.GetAccounts(a => a != null);
            }
        }

        private void Search(object sender, EventArgs e)
        {
            refreshData();
        }

        private void Add(object sender, EventArgs e)
        {
            ModifyForm add = new ModifyForm("Add", "", _context);
            add.Show();
            add.Closed += (e, args) => refreshData();
        }

        private void Delete(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccounts.SelectedRows.Count > 0)
                {
                    for (int i = 0; i < dgvAccounts.SelectedRows.Count; i++)
                    {
                        if (MessageBox.Show("Do you realy want to delete Account " + dgvAccounts.SelectedRows[i].Cells[0].Value.ToString() + " ?", "Notice!", MessageBoxButtons.YesNo).ToString().Equals("Yes"))
                            repo.RemoveAccount(dgvAccounts.SelectedRows[i].Cells[0].Value.ToString());
                    }
                    refreshData();
                }
                else
                {
                    MessageBox.Show("Please select at least 1 row to delete", "Notice!", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice!", MessageBoxButtons.OK);

            }
        }

        private void Update(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccounts.SelectedRows.Count == 1)
                {
                    ModifyForm update = new ModifyForm("Update", dgvAccounts.SelectedRows[0].Cells[0].Value.ToString(), _context);
                    update.Show();
                    update.Closed += (e, args) => refreshData();


                }
                else
                {
                    MessageBox.Show("Please select 1 row to update", "Notice!", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Somthing went wrong!", "Notice!", MessageBoxButtons.OK);

            }
        }

        private void refreshData()
        {
            dgvAccounts.DataSource = null;
            dgvAccounts.DataSource = repo.GetAccounts(u => u.BranchName.Contains(tbSearch.Text)).Select(u => new { u.AccountId, u.BranchName, u.AccountName, Type = u.Type.TypeDesc }).ToList();

        }
    }
}
