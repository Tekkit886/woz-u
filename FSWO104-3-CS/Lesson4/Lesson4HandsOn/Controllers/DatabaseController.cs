using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

namespace SqliteFromScratch.Controllers {
    // MVC is handling the routing for us.
    [Route("api/[Controller]")]
    public class DatabaseController : Controller {

        // api/database
        [HttpGet]
        // change return type of GetData to List<Track>.
            public List<Track> GetData() {

            List<Track> tracks = new List<Track>();

            string dataSource = "Data Source=" + Path.GetFullPath("chinook.db");

            using(SqliteConnection conn = new SqliteConnection(dataSource)) {

                conn.Open();

                string sql = $"select * from tracks limit 200;";

                using(SqliteCommand command = new SqliteCommand(sql, conn)) {

                    using(SqliteDataReader reader = command.ExecuteReader()) {

                        while (reader.Read()) {

                    Track newTrack = new Track() {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        AlbumId = reader.GetInt32(2),
                        MediaTypeId = reader.GetInt32(3),
                        GenreId = reader.GetInt32(4),
                        Composer = reader.GetValue(5).ToString(),
                        Milliseconds = reader.GetInt32(6),
                        Bytes = reader.GetInt32(7),
                        UnitPrice = reader.GetInt32(8)
                    };

                    // add each one to the list.
                    tracks.Add(newTrack);
                        }
                    }
                }
                conn.Close();
            }
            return tracks;
            }

        public List<Customers> GetData() {
            string dataSource = "Data Source=" + Path.GetFullPath("chinook.db");

            using(SqliteConnection conn = new SqliteConnection(dataSource)) {

                conn.Open();

                string sql = $"select * from customers limit 20;";

                using(SqliteCommand command = new SqliteCommand(sql, conn)) {

                    using(SqliteDataReader reader = command.ExecuteReader()) {

                        while (reader.Read()) {

                    Customers newCustomers = new Customers() {
                        CustomerId = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Company = reader.GetString(3),
                        Address = reader.GetString(4),
                        City = reader.GetString(5),
                        State = reader.GetString(6),
                        Country = reader.GetString(7),
                        PostalCode = reader.GetValue(8),
                        Phone = reader.GetInt32(9),
                        Fax = reader.GetInt32(10),
                        Email = reader.GetString(11),
                        SupportRepId = reader.GetString(12),
                    };

                    // add each one to the list.
                    customers.Add(newCustomers);
                        }
                    }
                }
                conn.Close();
            }
            return customers;
        }

        public List<Employees> GetData() {
            string dataSource = "Data Source=" + Path.GetFullPath("chinook.db");

            using(SqliteConnection conn = new SqliteConnection(dataSource)) {

                conn.Open();

                string sql = $"select * from employees limit 200;";

                using(SqliteCommand command = new SqliteCommand(sql, conn)) {

                    using(SqliteDataReader reader = command.ExecuteReader()) {

                        while (reader.Read()) {

                    Employees newEmployees = new Employees() {
                        EmployeeId = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Title = reader.GetString(3),
                        ReportsTo = reader.GetString(4),
                        BirthDate = reader.GetValue(5),
                        HireDate = reader.GetValue(6),
                        Address = reader.GetString(7),
                        City = reader.GetString(8),
                        State = reader.GetString(9),
                        PostalCode = reader.GetValue(10),
                        Phone = reader.GetValue(11),
                        Fax = reader.GetValue(12),
                        Email = reader.GetString(13),

                    };

                    // add each one to the list.
                    employee.Add(newEmployees);
                        }
                    }
                }
                conn.Close();
            }
            return employees;
        }

    }

}