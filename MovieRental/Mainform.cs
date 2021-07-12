using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoRentalProject;

namespace VideoRental
{
    public partial class Mainform : Form
    {
        public object Database { get; private set; }

        public partial class MainForm : Form
        {
            DB Database = new DB();

            string RMID = "";

            
        }

        public void LoadButton_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadCustomers();
        }

        public void LoadMov_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadMovies();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Database.AddCustomer(FNTBox.Text, LNTBox.Text, PhTBox.Text, AdTBox.Text);
            LoadButton_Click(null, null);
        }
    }
}
