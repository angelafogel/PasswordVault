using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordVaultNS
{
    public partial class Vault : Form
    {
        public Vault()
        {
            InitializeComponent();
        }

        public void userTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vaultDBDataSet);

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vaultDBDataSet.VaultTable' table. You can move, or remove it, as needed.
            this.vaultTableTableAdapter.Fill(this.vaultDBDataSet.VaultTable);
            // TODO: This line of code loads data into the 'vaultDBDataSet.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.vaultDBDataSet.UserTable);

        }

        private void vaultTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newAccountButton_Click(object sender, EventArgs e)
        {
            this.vaultTableTableAdapter.Fill(this.vaultDBDataSet.VaultTable); 
            this.vaultTableBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.vaultDBDataSet);
        }

        private void saveEditButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vaultTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vaultDBDataSet);
        }

        private void removeAccountButton_Click(object sender, EventArgs e)
        {
            this.vaultTableBindingSource.RemoveCurrent();
        }

        private void toolstripTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vaultTableTableAdapter.SearchName(this.vaultDBDataSet.VaultTable, onlineAccountNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.vaultTableTableAdapter.SearchName(this.vaultDBDataSet.VaultTable, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void refreshDataButton_Click(object sender, EventArgs e)
        {
            this.vaultTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vaultDBDataSet);
            this.vaultTableTableAdapter.Fill(this.vaultDBDataSet.VaultTable);
            
        }
    }
}
