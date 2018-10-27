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
        public string GetData() {

            // tracks will be populated with the result of the query.

            // GetFullPath will complete the path for the file named passed in as a string.

            // Initialize the connection to the .db file.

                // create a string to hold the SQL command.

                // create a new SQL command by combining the location and command string.

                    // read each value that comes back from the query and do something to it.

                    // Loop through query exit when no more objects are left.

                    // map the data to the Track model.

                            // add each track to the list of tracks.

                        }
                    }
                }
                // close the connection
            }
            return "We need data!";
        }
    }
}