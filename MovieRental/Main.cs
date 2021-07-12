using System;

using System.Data;
using System.Drawing;

using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;

namespace MovieRentalStore
{
    public partial class Main : Form
    {
        // All SQl Classes instances
        SqlConnection sqlConnObj = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
        // sql command 
        SqlCommand sqlComObj = new SqlCommand();
        // sql reader and adapter
        SqlDataReader sqlDataRdrObj;
        SqlDataAdapter sqlDataAdptObj = new SqlDataAdapter();
        //  database funcions class object
        ManageDB managerDB = new ManageDB();


        // importing gdl32.dll library for creating roungd corners of main frame
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        // some expernal round values
        private static extern IntPtr CreateRoundRectRgn
         (
            // corners
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
               // w and h
              int nWidthEllipse,
              int nHeightEllipse

          );
        public Main()
        {

            InitializeComponent();
            // setting region with rounded corner
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            // setting nav effect values
            pnlNav.Top = btnCustomers.Top;
            pnlNav.Left = btnCustomers.Left;
            pnlNav.Height = btnCustomers.Height;
            btnCustomers.BackColor = Color.FromArgb(215, 215, 215);
        }

        private void Main_Load(object sender, EventArgs e)
        {
             // hide all datagrids on starts
      
            gridMostRented.Hide();
            gridFamousMovies.Hide();
            gridRentedMovies.Hide();
            gridMovies.Hide();

            //fill all data into data grids at loading

            FillDataInCustomerGrid();
            FillDataInMovieGrid();
            FillDataInRentedMovieGrid();
            TotalRentedMovies();
            MoviesRentedMostTime();
            

            // setting autosizemode for each colums of data grids

            // for customer data grid
            for(int i=0;i<custGrid.Columns.Count; i++)
            {
                custGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                
            }
            // for most rented data grid
            for (int i = 0; i < gridMostRented.Columns.Count; i++)
            {
                gridMostRented.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            // for famous movies data grid
            for (int i = 0; i < gridFamousMovies.Columns.Count; i++)
            {
                gridFamousMovies.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            // for rented movies data grid
            for (int i = 0; i < gridRentedMovies.Columns.Count; i++)
            {
                gridRentedMovies.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            // for movies data grid
            for (int i = 0; i < gridMovies.Columns.Count; i++)
            {
                gridMovies.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            // when customers click event occurs 
            // setting nav
            pnlNav.Top = btnCustomers.Top;
            pnlNav.Left = btnCustomers.Left;
            pnlNav.Height = btnCustomers.Height;
            btnCustomers.BackColor = Color.FromArgb(215,215,215);
            // hide all other data grids and show customer data grid
            gridFamousMovies.Hide();
            gridMostRented.Hide();
            custGrid.Show();
            gridRentedMovies.Hide();
            gridMovies.Hide();

        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            // setting nav 
            pnlNav.Top = btnMovies.Top;
            pnlNav.Left = btnMovies.Left;
            pnlNav.Height = btnMovies.Height;
            btnMovies.BackColor = Color.FromArgb(215, 215, 215);
            // hide all other data grids and show movies data grid
            gridMovies.Show();
            custGrid.Hide();
            gridMostRented.Hide();
            gridFamousMovies.Hide();
            gridRentedMovies.Hide();
        }

        private void btnRentedMovies_Click(object sender, EventArgs e)
        {
            // setting nav
            pnlNav.Top = btnRentedMovies.Top;
            pnlNav.Left = btnRentedMovies.Left;
            pnlNav.Height = btnRentedMovies.Height;
            btnRentedMovies.BackColor = Color.FromArgb(215, 215, 215);

            // hide all other data grids and show rented movies data grid
            gridRentedMovies.Show();
            custGrid.Hide();
            gridMostRented.Hide();
            gridFamousMovies.Hide();
            gridMovies.Hide();
        }
        private void btnShowRentedVideo_Click(object sender, EventArgs e)
        {
            // fill data in rented movies grid
           
            FillDataInRentedMovieGrid();
        }

        private void btnMostRented_Click(object sender, EventArgs e)
        {
            // setting nav
            pnlNav.Top = btnMostRented.Top;
            pnlNav.Left = btnMostRented.Left;
            pnlNav.Height = btnMostRented.Height;
            btnMostRented.BackColor = Color.FromArgb(215, 215, 215);
            // hide all other data grids and show most rented data grid
            gridMostRented.Show();
            custGrid.Hide();
            gridFamousMovies.Hide();
            gridRentedMovies.Hide();
            gridMovies.Hide();
        }

        private void btnMostFamous_Click(object sender, EventArgs e)
        {
            // setting nav
            pnlNav.Top = btnMostFamous.Top;
            pnlNav.Left = btnMostFamous.Left;
            pnlNav.Height = btnMostFamous.Height;
            btnMostFamous.BackColor = Color.FromArgb(215, 215, 215);
            // hide all other data grids and show famous movies data grid
            gridFamousMovies.Show();
            gridMostRented.Hide();
            custGrid.Show();
            gridRentedMovies.Hide();
            gridMovies.Hide();
            custGrid.Hide();
        }

        // leave event of mouse
        private void btnCustomers_Leave(object sender, EventArgs e)
        {
            // reseting bg color
            btnCustomers.BackColor = Color.White;
        }

        private void btnMovies_Leave(object sender, EventArgs e)
        {
            // reseting bg color
            btnMovies.BackColor = Color.White;
        }

        private void btnRentedMovies_Leave(object sender, EventArgs e)
        {
            // reseting bg color
            btnRentedMovies.BackColor = Color.White;
        }

        private void btnMostRented_Leave(object sender, EventArgs e)
        {
            // reseting bg color
            btnMostRented.BackColor = Color.White;
        }

        private void btnMostFamous_Leave(object sender, EventArgs e)
        {
            // reseting bg color
            btnMostFamous.BackColor = Color.White;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //  exit application on exit button click
            Application.Exit();
        }
        private void btnExit_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customer_Leave(object sender, EventArgs e)
        {
            //setting color on leave event
            btnDeleteCustomer.BackColor = Color.FromArgb(0, 30, 54);
        }


        // method to fill customer grid
        public void FillDataInCustomerGrid()
        {
            DataSet datasetCustomers = new DataSet();
            sqlComObj = new SqlCommand("select * from Customer", sqlConnObj); // sql command
            sqlDataAdptObj.SelectCommand = sqlComObj; 
            datasetCustomers.Clear();
            sqlDataAdptObj.Fill(datasetCustomers, "Customer"); // fill dataset
            custGrid.DataSource = datasetCustomers.Tables["Customer"]; // bind data source
        }
        // to fill video grid
        private void FillDataInMovieGrid()
        {
            DataSet datasetMovies = new DataSet();
            sqlComObj = new SqlCommand("select * from Movie", sqlConnObj); // sql command
            sqlDataAdptObj.SelectCommand = sqlComObj;
            datasetMovies.Clear();
            sqlDataAdptObj.Fill(datasetMovies, "Movie"); // fill dataset
            gridMovies.DataSource = datasetMovies.Tables["Movie"]; // bind data source
        }
        // to fill rented video grid
        private void FillDataInRentedMovieGrid()
        {
            DataSet datasetRentedMovies = new DataSet();
            sqlComObj = new SqlCommand("select * from RentedMoviesView", sqlConnObj); //sql command
            sqlDataAdptObj.SelectCommand = sqlComObj;
            datasetRentedMovies.Clear();
            sqlDataAdptObj.Fill(datasetRentedMovies, "RentedMoviesView"); // fill dataset
            gridRentedMovies.DataSource = datasetRentedMovies.Tables["RentedMoviesView"]; // bind data source
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            ValidateAndAddNewCustomer(); // Insert a new Customer in db

        }
        public void ValidateAndAddNewCustomer()
        {
            // check for emtpy fields and act accordingly
            // isNullOrEmpty FirstNAme
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please Enter First Name");
                return;
            }
            // isNullOrEmpty LastNAme
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please Enter Last Name");
                return;
            }
            // isNullOrEmpty Address
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please Enter Address");
                return;
            }
            // isNullOrEmpty phone
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please Enter Phone No");
                return;
            }
            // add customer and clear txt boxes
            try
            {
                // calling add function
                managerDB.AddCustomer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhone.Text);
                //reseting txt boxes
                lblId.Text = "";
                lblMovieId.Text = "";
                lblRMID.Text = "";
                // empty controls
                EmptyTextControls();
                // updating data grid
                FillDataInCustomerGrid();
          
                MessageBox.Show("Customer Added successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        //datagrid rows click event
        private void custGrid_Click(object sender, EventArgs e)
        {
            // select customer from grid
            if (custGrid.Rows.Count > 0) // if there are any rows
            {
                // get values from rows and set in their respective fields
                lblId.Text = custGrid.CurrentRow.Cells[0].Value.ToString();
                txtFirstName.Text = custGrid.CurrentRow.Cells[1].Value.ToString();
                txtLastName.Text = custGrid.CurrentRow.Cells[2].Value.ToString();
                txtAddress.Text = custGrid.CurrentRow.Cells[3].Value.ToString();
                txtPhone.Text = custGrid.CurrentRow.Cells[4].Value.ToString();

            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

            try
            { // first check for id field
                if (string.IsNullOrEmpty(lblId.Text))
                {
                    MessageBox.Show("Please Select Customer First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // then edit the customer
                managerDB.EditCustomer(Convert.ToInt32(lblId.Text), txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhone.Text);
                // reset fields
                lblId.Text = "";
                EmptyTextControls();
                FillDataInCustomerGrid();
           
                MessageBox.Show("Customer Updated Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }




        }
        // merthod to clear text boxes
        private void EmptyTextControls()
        {
            Action<Control.ControlCollection> func = null;
            // for every control if it is a textbox clear its content
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
                }
            };

            func(Controls);
            // set cost to auto
            txtCost.Text = "Auto";
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            //check for id
            if (string.IsNullOrEmpty(lblId.Text))
            {

                MessageBox.Show("Please Select Customer First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            // confirm deletion dialog box
            DialogResult dialogResult = MessageBox.Show("Confirm Delete ?", "Customer Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // delete customer
                    managerDB.DeleteCustomer(Convert.ToInt32(lblId.Text));

                    MessageBox.Show("Customer Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // reset controls
                    EmptyTextControls();
                    lblId.Text = "";
                    FillDataInCustomerGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }


            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }


        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            // check for title
            if (string.IsNullOrEmpty(txtTitle.Text))
            {

                MessageBox.Show("Please EnterMovie Title", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            // check for cost which auto
            else if (string.IsNullOrEmpty(txtCost.Text))
            {

                MessageBox.Show("Tental Cost is not selected using default", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCost.Text = "2"; // setting default cost if not date is selected
                return;
            }

            try
            {
                // add movie to table
                managerDB.AddMovie(txtTitle.Text, dtpReleaseDate.Value.Date, Convert.ToDecimal(txtCost.Text), txtGenre.Text, txtPlot.Text);
                // reset text boxes
                lblId.Text = "";
                lblMovieId.Text = "";
                lblRMID.Text = "";
                EmptyTextControls();
                FillDataInMovieGrid();
            

                MessageBox.Show("Movie Added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void gridVideo_Click(object sender, EventArgs e)
        {
            // if movies have rows
            if (gridMovies.Rows.Count > 0)
            {
                // get values and set in their respective fields
                lblMovieId.Text = gridMovies.CurrentRow.Cells[0].Value.ToString();
                txtTitle.Text = gridMovies.CurrentRow.Cells[1].Value.ToString();
                dtpReleaseDate.Text = gridMovies.CurrentRow.Cells[2].Value.ToString();
                txtCost.Text = gridMovies.CurrentRow.Cells[3].Value.ToString();
                txtGenre.Text = gridMovies.CurrentRow.Cells[4].Value.ToString();
                txtPlot.Text = gridMovies.CurrentRow.Cells[5].Value.ToString();

            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            // check for movie id
            if (string.IsNullOrEmpty(lblMovieId.Text))
            {

                MessageBox.Show("Please Select Movie First", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            try
            {
                // modigy the movie
                managerDB.ModifyMovie(Convert.ToInt32(lblMovieId.Text), txtTitle.Text, dtpReleaseDate.Value.Date, Convert.ToDecimal(txtCost.Text), txtGenre.Text, txtPlot.Text);
                //  reset the fields
                lblMovieId.Text = "";
                EmptyTextControls();
                FillDataInMovieGrid();
          

                MessageBox.Show("movie updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            // check for movie id
            if (string.IsNullOrEmpty(lblMovieId.Text))
            {

                MessageBox.Show("Please Select the movie", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // make sure user wants to delete
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS Video ?", "Record Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    //delete movie
                    managerDB.DeleteMovie(Convert.ToInt32(lblMovieId.Text));

                    MessageBox.Show("movie Deleted Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // reset controls
                    EmptyTextControls();
                    lblMovieId.Text = "";
                    FillDataInMovieGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            // result is no do nothing
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            // check for id and movie id
            if (string.IsNullOrEmpty(lblId.Text) || string.IsNullOrEmpty(lblMovieId.Text))
            {

                MessageBox.Show("Please select a customer and movie for renting purposes", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            // check if movie is rented
            var alreadyRental = 0;
            sqlConnObj.Open();
            sqlComObj = new SqlCommand("Select * from RentedMovies where MovieId=@MovieId and DateReturned is NULL", sqlConnObj); // querry to check for already rented movies
            sqlComObj.Parameters.AddWithValue("@MovieId", lblMovieId.Text);
            sqlDataRdrObj = sqlComObj.ExecuteReader();
            if (sqlDataRdrObj.Read()) // if any data found
            {
                alreadyRental = 1; // is rented
            }
            else
            {
                alreadyRental = 0; // is not rented
            }
            sqlDataRdrObj.Close();
            sqlConnObj.Close();
            if (alreadyRental == 1)
            {

                MessageBox.Show("movie Alreaded Rented", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            // add rented movie if not rented previously
            try
            {
                 // add rented movie
                managerDB.AddRentalMovie(Convert.ToInt32(lblMovieId.Text), Convert.ToInt32(lblId.Text));

                MessageBox.Show("movie Rented Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clear fields content
                lblId.Text = "";
                lblMovieId.Text = "";
                EmptyTextControls();
                FillDataInRentedMovieGrid();
                TotalRentedMovies();
                MoviesRentedMostTime();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void gridRentedMovie_Click(object sender, EventArgs e)
        {
            // select rented movie from view
            if (gridRentedMovies.Rows.Count > 0)
            {
                // get values and set in theur respective field
                lblMovieId.Text = gridRentedMovies.CurrentRow.Cells["MovieId"].Value.ToString();
                txtTitle.Text = gridRentedMovies.CurrentRow.Cells["Title"].Value.ToString();
                dtpReleaseDate.Text = gridRentedMovies.CurrentRow.Cells["ReleaseDate"].Value.ToString();
                txtCost.Text = gridRentedMovies.CurrentRow.Cells["RentalCost"].Value.ToString();
                txtGenre.Text = gridRentedMovies.CurrentRow.Cells["Genre"].Value.ToString();
                txtPlot.Text = gridRentedMovies.CurrentRow.Cells["Plot"].Value.ToString();
                lblRMID.Text = gridRentedMovies.CurrentRow.Cells["RMID"].Value.ToString();
                lblId.Text = gridRentedMovies.CurrentRow.Cells["CustId"].Value.ToString();
                txtFirstName.Text = gridRentedMovies.CurrentRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = gridRentedMovies.CurrentRow.Cells["LastName"].Value.ToString();
                txtAddress.Text = gridRentedMovies.CurrentRow.Cells["Address"].Value.ToString();
                txtPhone.Text = gridRentedMovies.CurrentRow.Cells["Phone"].Value.ToString();

            }
        }

        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            // return a movie by usng rented movie id
            if (string.IsNullOrEmpty(lblRMID.Text))
            {

                MessageBox.Show("Please Select the rented movie", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;
            }
            sqlConnObj.Open();
            // check if movie is rented
            // OR Not rented
            var alreadyReturned = 0;
            sqlComObj = new SqlCommand("Select * from RentedMovies where RentedMovieId=@RentedMovieId and DateReturned is Not NULL", sqlConnObj);
            sqlComObj.Parameters.AddWithValue("@RentedMovieId", lblRMID.Text);
            sqlDataRdrObj = sqlComObj.ExecuteReader();
            if (sqlDataRdrObj.Read()) //if any data found
            {
                alreadyReturned = 1; // means not rented
            }
            else
            {
                alreadyReturned = 0; // means rented
            }
            sqlDataRdrObj.Close();
            sqlConnObj.Close();
            if (alreadyReturned == 1) // if not rented then movie is already returned
            {

                MessageBox.Show("movie Alreaded Reterned", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // otherwise return a movie
            try
            {
                // return a movie
                managerDB.ReternAMovie(Convert.ToInt32(lblRMID.Text));


                MessageBox.Show("movie renturned successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               //reset fields
                lblId.Text = "";
                lblMovieId.Text = "";
                lblRMID.Text = "";
                EmptyTextControls();
                
                FillDataInRentedMovieGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            // if movie is released 5 years ago then rent is 2 else 5
            if (dtpReleaseDate.Value.Date <= DateTime.Now.Date.AddYears(-5))
            {
                txtCost.Text = "2";
            }
            else
            {
                txtCost.Text = "5";
            }
        }
        // mehtod to get total rented movies
        private void TotalRentedMovies()
        {
            DataSet dsTotalRented = new DataSet();
            // sql query to get total rented movies
            sqlComObj = new SqlCommand("select CustId,FirstName,LastName,Address,Phone,Count(*) as 'Total Rented' from RentedMoviesView group by CustId,FirstName,LastName,Address,Phone order by 'Total Rented' desc", sqlConnObj);
            sqlDataAdptObj.SelectCommand = sqlComObj;
            dsTotalRented.Clear();
            sqlDataAdptObj.Fill(dsTotalRented, "RentedMoviesView"); // fill the dataset
            gridMostRented.DataSource = dsTotalRented.Tables["RentedMoviesView"]; // bind the data source
        }
        // method to find the movies rented most time
        private void MoviesRentedMostTime()
        {
            DataSet ds = new DataSet();
            //query  to find the movies rented most time
            sqlComObj = new SqlCommand("select MovieId,Title,ReleaseDate,RentalCost,Genre,Count(*) as 'Total Rented By' from RentedMoviesView group by MovieId,Title,ReleaseDate,RentalCost,Genre order by 'Total Rented By' desc", sqlConnObj);
            sqlDataAdptObj.SelectCommand = sqlComObj;
            ds.Clear();
            sqlDataAdptObj.Fill(ds, "RentedMoviesView"); // fill dataset
            gridFamousMovies.DataSource = ds.Tables["RentedMoviesView"]; // binding the data source
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // input validation done on phone filed
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // input validation done on cost field
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void btnRentedOut_Click(object sender, EventArgs e)
        {
           // find rented movies
            DataSet dsRentedMovie = new DataSet();
            sqlComObj = new SqlCommand("select * from RentedMoviesView where DateReturned is Null", sqlConnObj); // check if movie is rented
            sqlDataAdptObj.SelectCommand = sqlComObj;
            dsRentedMovie.Clear();
            sqlDataAdptObj.Fill(dsRentedMovie, "RentedMoviesView"); // fill dataset
            gridRentedMovies.DataSource = dsRentedMovie.Tables["RentedMoviesView"]; // bind data source
        }

        private void btnMostborrow_Click(object sender, EventArgs e)
        {
          // call the function  
            TotalRentedMovies();
        }

        private void btnMostPopular_Click(object sender, EventArgs e)
        {
            // call the function 
            MoviesRentedMostTime();
        }

    }
}
