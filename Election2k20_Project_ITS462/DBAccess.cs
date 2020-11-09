/* PNW ITS462 
 * Fall 2020
 * Final Project
 *
 * Jeremy Batterbee
 * 
 * This class currently contains several methods with SQL statements that are vulnerable to SQL injection,
 * but as it is nonsensitive, and localy stored for the user, this will not be fixed.
 */
using System;
using System.Globalization;
using Microsoft.Data.Sqlite;

namespace Election2k20_Project_ITS462 {
	/// <summary> Class <c>DBAccess</c> handles a connection to the project database.
	/// </summary>
	public class DBAccess {
		public string ConnectionString { get; set; }
		private SqliteCommand Cmd { get; set; }
		private SqliteConnection Conn { get; set; }

		/// <summary>
		/// Creates a <c>DBAccess</c> object to handle interfacing with the project database.
		/// </summary>
		public DBAccess() : this(@"../../votes.sqlite") { }

		/// <summary>
		/// Instantiates a <c>DBAccess</c> object to handle interfacing with the project database.
		/// </summary>
		/// <param name="databasePath">File path to the sqlite database.</param>
		private DBAccess(string databasePath) {
			Conn = new SqliteConnection("Data Source=" + databasePath + ";");
			Cmd = new SqliteCommand();
			Cmd.Connection = Conn;
		}

		/// <summary>
		/// Store the vote information for a state into the database.
		/// </summary>
		/// <param name="state">State object containing the vote information.</param>
		public void StoreVotes(State state) {
			string command = "INSERT INTO Votes(state,winner,candidate1,candidate2,party1,party2,votes1,votes2,percent1,percent2) " +
				"VALUES('" + state.Name + "','" + state.Winner + "','" + state.Candidate1 + "','" + state.Candidate2 + "','" + state.Party1 
				+ "','" + state.Party2 + "'," + state.Votes1.ToString() + "," + state.Votes2.ToString() + "," + state.Percent1.ToString() + "," + state.Percent2.ToString() + ")";

			Cmd.CommandText = command;
			Cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Retrieve the data from a state.
		/// </summary>
		/// <param name="state">Name of the state.</param>
		/// <returns>A <c>State</c> object containing the data. Returns null if no data was found.</returns>
		public State GetState(string state) {
			string command = "SELECT * FROM Votes WHERE name='" + state + "'";

			Cmd.CommandText = command;
			SqliteDataReader dr = Cmd.ExecuteReader();

			// If the query returned rows
			if (dr.HasRows) {
				State s;
				// Attempt to read the first returned row and populate a State object
				try {
					dr.Read();
					s = new State(dr.GetString(0));
					s.Winner = dr.GetString(1);
					s.Candidate1 = dr.GetString(2);
					s.Candidate2 = dr.GetString(3);
					s.Party1 = dr.GetString(4);
					s.Party2 = dr.GetString(5);
					s.Votes1 = dr.GetInt32(6);
					s.Votes1 = dr.GetInt32(7);
					s.Percent1 = dr.GetFloat(8);
					s.Percent1 = dr.GetFloat(9);
				}
				catch (Exception ex) {
					s = null;
                }

				return s;
			}
			else {
				return null;
			}
		}

		/// <summary>
		/// Gets the total votes for a candidate.
		/// </summary>
		/// <param name="candidate">Candidate to fetch total votes for.</param>
		/// <returns>An <c>int</c> of the total candidate votes. A return of -1 indicates a candidate was found in the data.</returns>
		public int GetVotes(string candidate) {
			string command = "SELECT candidate1,candidate2,votes1,votes2 FROM Votes WHERE candidate1='" + candidate + "' OR candidate2='" + candidate + "'";

			Cmd.CommandText = command;
			SqliteDataReader dr = Cmd.ExecuteReader();

			// we start with -1 incase we have a database error, or the candidate is not found.
			int votes = -1;
			if (dr.HasRows) {
				// we had rows, so the candidate was found, so set votes to 0;
				votes = 0;
				
				// parse the returned rows
				while (dr.Read()) {
					// Now we need to determine which vote column to get data for, based on which column the candidate was in.
					// If they are candidate1 (column 0) we want votes1 (column 2)
					// Otherwise we want votes2 (column 3)
					if (dr.GetString(0) == candidate) {
						votes += dr.GetInt32(2);
                    } else {
						votes += dr.GetInt32(3);
					}
                }
            }

			return votes;
        }

		/// <summary>
		/// Opens the connection to the database.
		/// </summary>
		public void OpenConnection() {
			Conn.Open();
		}

		/// <summary>
		/// Closes the connection to the database.
		/// </summary>
		public void CloseConnection() {
			Conn.Close();
        }
	}
}