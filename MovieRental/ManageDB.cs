using System;

using System.Configuration;
using System.Data.SqlClient;


namespace MovieRentalStore
{
    // database layer class    
    public class ManageDB // Class to manager DB operations
    {

        public static SqlConnection sqlConnection { get; set; } = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString) ;
        // add customer func
        public void AddCustomer(string FN, string LN, string ADDR, string Phone)
        {
                sqlConnection.Open();
            // sql command to add customer
                using (SqlCommand cmd = new SqlCommand("insert into Customer(FirstName,LastName,Address,Phone)values(@FirstName,@LastName,@Address,@Phone)", sqlConnection))
                {
                // adding parameters
                    cmd.Parameters.AddWithValue("@FirstName", FN);
                    cmd.Parameters.AddWithValue("@LastName", LN);
                    cmd.Parameters.AddWithValue("@Address", ADDR);
                    cmd.Parameters.AddWithValue("@Phone", Phone);

                    cmd.ExecuteNonQuery();

                }
                sqlConnection.Close();
                
        }
        // edit customer func
        public void EditCustomer(int CustomerID,string FN, string LN, string ADDR, string Phone)
        {

                sqlConnection.Open();
            // sql command to edit customer
                using (SqlCommand cmd = new SqlCommand("update Customer set FirstName=@FirstName,LastName=@LastName,Address=@Address,Phone=@Phone  where CustId=@CustId", sqlConnection))
                {
                // adding parameters
                cmd.Parameters.AddWithValue("@CustId", CustomerID);
                cmd.Parameters.AddWithValue("@FirstName", FN);
                    cmd.Parameters.AddWithValue("@LastName", LN);
                    cmd.Parameters.AddWithValue("@Address", ADDR);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                   
                    cmd.ExecuteNonQuery();

                }
                sqlConnection.Close();
               
        }

        // delete customer func
        public void DeleteCustomer(int CustomerID)
        {

                sqlConnection.Open();
            // sql command to delete customer
                using (SqlCommand cmd = new SqlCommand("delete from Customer where CustId=@CustId", sqlConnection))
                {
                // adding parameters
                cmd.Parameters.AddWithValue("@CustId", CustomerID);
                    cmd.ExecuteNonQuery();

                }
                sqlConnection.Close();
               
        }
        // add movie func
        public void AddMovie(string MovieName, DateTime MovieReleasedDate, decimal CostOfMovie, string GenreOfMovie, string PlotOFMovie)
        {

            
                sqlConnection.Open();
            // sql command to add mvie
                using (SqlCommand cmd = new SqlCommand("insert into Movie(Title,ReleaseDate,RentalCost,Genre,Plot)values(@Title,@ReleaseDate,@RentalCost,@Genre,@Plot)", sqlConnection))
                {
                // adding parameters
                    cmd.Parameters.AddWithValue("@Title", MovieName);
                    cmd.Parameters.AddWithValue("@ReleaseDate", MovieReleasedDate);
                    cmd.Parameters.AddWithValue("@RentalCost", CostOfMovie);
                    cmd.Parameters.AddWithValue("@Genre", GenreOfMovie);
                    cmd.Parameters.AddWithValue("@Plot", PlotOFMovie);
                    cmd.ExecuteNonQuery();

                }
                sqlConnection.Close();
                
        }
        // edit movie func
        public void ModifyMovie(int MovieID,string MovieName, DateTime MovieReleasedDate, decimal CostOfMovie, string GenreOfMovie, string PlotOfMovie)
        {

           
                sqlConnection.Open();
            // sql command to edit movie
                using (SqlCommand cmd = new SqlCommand("update Movie set Title=@Title,ReleaseDate=@ReleaseDate,RentalCost=@RentalCost,Genre=@Genre,Plot=@Plot where MovieId=@MovieId", sqlConnection))
                {
                // adding parameters
                    cmd.Parameters.AddWithValue("@MovieId", MovieID);
                    cmd.Parameters.AddWithValue("@Title", MovieName);
                    cmd.Parameters.AddWithValue("@ReleaseDate", MovieReleasedDate);
                    cmd.Parameters.AddWithValue("@RentalCost", CostOfMovie);
                    cmd.Parameters.AddWithValue("@Genre", GenreOfMovie);
                    cmd.Parameters.AddWithValue("@Plot", PlotOfMovie);
                    cmd.ExecuteNonQuery();

                }
                sqlConnection.Close();
               
        }
        // delete movie func
        public void DeleteMovie(int MovieID)
        {
                sqlConnection.Open();
            // sql command to del movie
                using (SqlCommand cmd = new SqlCommand("delete from Movie where MovieId=@MovieId", sqlConnection))
                {
                //adding parameters
                    cmd.Parameters.AddWithValue("@MovieId", MovieID);

                    cmd.ExecuteNonQuery();

                }
                sqlConnection.Close();
              
        }
        // add rented movie func
        public void AddRentalMovie(int MovieID, int CustomerID)
        {

                sqlConnection.Open();
            // sql command to add rented movie
                using (SqlCommand cmd = new SqlCommand("insert into RentedMovies(MovieId,CustId,DateRented)values(@MovieId,@CustId,@DateRented)", sqlConnection))
                {
                // adding parameters
                    cmd.Parameters.AddWithValue("@MovieId", MovieID);
                    cmd.Parameters.AddWithValue("@CustId", CustomerID);
                    cmd.Parameters.AddWithValue("@DateRented", DateTime.Now);

                    cmd.ExecuteNonQuery();

                }
                sqlConnection.Close();
                
        }
        // return movie func
        public void ReternAMovie(int MovieReturnID)
        {

                sqlConnection.Open();
            // sql command to return movie
                using (SqlCommand cmd = new SqlCommand("update RentedMovies set DateReturned=@DateReturned where RentedMovieId=@RentedMovieId", sqlConnection))
                {
                // adding parameters
                    cmd.Parameters.AddWithValue("@RentedMovieId", MovieReturnID);
                    cmd.Parameters.AddWithValue("@DateReturned", DateTime.Now);

                    cmd.ExecuteNonQuery();

                }
                sqlConnection.Close();
               
        }
    }
}
