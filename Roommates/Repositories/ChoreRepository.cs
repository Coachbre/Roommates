using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Roommates.Models;


namespace Roommates.Repositories

///<summary>
///Responsible for interacting with chores data, it also inherits
 ///the base repo class (for connection property purposes)
 ///</summary>

 public class ChoreRepository : BaseRepository
 {}
 // public so it can be used outside of this class

 ///<summary>
 /// when new instance of chore repository is created, its connection string is passed into the BaseRepository constructor
 ///</summary>

 public ChoreRepository(string connectionString) :
 base(connectionString)
 {   
 }

 ///<summary>
 ///Get full list of chores in database
 ///</summary>

 public List<Chore> GetAll()
 // Open() connections when need, and Close() them when done!
 // a 'using' block doesnt Open()e, but it ensures correct disconnection from resources (ex: database)
 using (SqlConnection conn = Connection)
 {
     conn.Open();
     using (SqlCommand cmd = conn.CreateCommand())
     {}
 }



