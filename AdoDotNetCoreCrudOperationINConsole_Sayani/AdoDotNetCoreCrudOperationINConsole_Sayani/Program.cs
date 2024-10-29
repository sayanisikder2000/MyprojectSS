using Microsoft.Data.SqlClient;
using System.Data;
//using System.Data.SqlClient;
using System.IO;

namespace AdoDotNetCoreCrudOperationINConsole_Sayani
{
    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {
                string connectionString = "Server = DESKTOP-5E9DNII\\SAYANIDATABASE;Database = EmployeeDB;User " +
         "Id = sa;Password=user123;Trusted_Connection=True;" +
         "TrustServerCertificate = True;";
                //Console.WriteLine("Connection Succesfull");


                GetAllEmployees(connectionString);



                int EmployeeId = 1;
                GetEmployeesByID(connectionString, EmployeeId);

                string firstName = "Sayani";
                string lastName = "Sikder";
                string email = "sayanisikder20082000@gmail.com";
                string street = "g/24 vidyasagar sarani";
                string city = "Kolkata";
                string state = "India";
                string postalCode = "700154";

                CreateEmployeesWithAddresses(connectionString, firstName, lastName, email, street, city, state, postalCode);

                int employeeID = 3; //int employeeID = 3;
                firstName = "Hema";
                lastName = "Mangali";
                email = "hemalathamangali2@gmail.com";
                street = "123 Anantapur";
                city = "Hyderabad";
                state = "India";
                postalCode = "515001";
                int AddressID = 3;


                UpdateEmployeeWithAddress(connectionString, employeeID, firstName, lastName, email, street, city, state, postalCode, AddressID);

                employeeID = 2;
                DeleteEmployees(connectionString, employeeID);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");
            }

        }
        static void GetAllEmployees(string connectionString)
        {
            Console.WriteLine("GetAllEmployees stored procedure Called");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("GetAllEmployees", connection);
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"EmployeeID:{reader["EmployeeID"]},FirstName:{reader["FirstName"]},LastName:{reader["LastName"]},Email:{reader["Email"]}");
                    Console.WriteLine($"Addresses:{reader["Street"]},{reader["City"]},{reader["States"]},PostalCode:{reader["PostalCode"]}\n");
                }
                reader.Close();
                //connection.Close();
            }
        }
        static void GetEmployeesByID(string connectionString, int employeeID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("GetEmployeesByID stored procedure called");
                SqlCommand command = new SqlCommand("GetEmployeesByID", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Employee: {reader["FirstName"]}, {reader["LastName"]}, Email: {reader["Email"]}");
                    Console.WriteLine($"Address: {reader["Street"]}, {reader["City"]}, {reader["States"]}, {reader["PostalCode"]}");
                }
                reader.Close();
                connection.Close();
            }
        }

        static void CreateEmployeesWithAddresses(string connectionString, string firstName, string lastName, string email, string street, string city, string states, string postalCode)
        {
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    Console.WriteLine("Create EmployeeWithAddress Stored Procedure Called");
                    SqlCommand command = new SqlCommand("CreateEmployeesWithAddresses", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    // Add parameters for Employee and Address

                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Street", street);
                    command.Parameters.AddWithValue("@City", city);
                    command.Parameters.AddWithValue("@States", states);
                    command.Parameters.AddWithValue("@PostalCode", postalCode);
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Employee and Address created successfully.");
                    connection.Close();
                }
            }
        }
        static void UpdateEmployeeWithAddress(string connectionString, int employeeID, string firstName, string lastName, string email, string street, string city, string states, string postalCode, int addressID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Update Employee WithAddress Stored Procedure Called");
                SqlCommand command = new SqlCommand("UpdateEmployeeWithAddress", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameters for Employee and Address
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Street", street);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@States", states);
                command.Parameters.AddWithValue("@PostalCode", postalCode);
                command.Parameters.AddWithValue("@AddressID", addressID);
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Employee and Addressesiupdated successfully.");
                connection.Close();
            }
        }
        static void DeleteEmployees(string connectionString, int employeeID)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                Console.WriteLine(value: "Delete Employee Stored Procedure Called");
                SqlCommand command = new SqlCommand("DeleteEmployees", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Add parameter for EmployeeID
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine(value: "Employee and their Address deleted successfully.");
                }
                else
                {
                    Console.WriteLine(value: "Employee not found.");
                }
                connection.Close();

            }

        }

    }
}
    

