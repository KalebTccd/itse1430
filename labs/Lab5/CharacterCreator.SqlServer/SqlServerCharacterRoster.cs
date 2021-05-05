/*
 * Charcter Creator
 * ITSE 1430
 * Spring 2021
 * Kaleb Dreier
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CharacterCreator.SqlServer
{
    /// <summary>Provides an implementation of <see cref="ICharacterRoster"/> using SQL Server.</summary>
    /// <remarks>
    /// Relies on ADO.NET for database access.
    /// </remarks>
    public class SqlServerCharacterRoster : ICharacterRoster
    {
        public SqlServerCharacterRoster ( string connectionString )
        {
            _connectionString = connectionString;
        }
        private SqlConnection OpenConnection ()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();

            return conn;
        }
        public Character Add ( Character character )
        {
            throw new NotImplementedException();
        }

        public void Delete ( int id )
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Character> GetAll ()
        {
            using (var conn = OpenConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "GetAllCharacters";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                var ds = new DataSet();
                var da = new SqlDataAdapter() {
                    SelectCommand = cmd   
                };
                da.Fill(ds);
                var table = ds.Tables.OfType<DataTable>().FirstOrDefault();
                if (table != null)
                {
                    foreach (var row in table.Rows.OfType<DataRow>())
                    {
                        yield return new Character() {
                            Id = row.Field<int>("Id"),
                            Name = row.Field<string>("Name"), 
                            Biography = row.IsNull(2) ? null : (string)row[2],
                            Profession = row.Field<string>("Profession"),
                            Race = row.Field<string>("Race"),
                            Strength = row.Field<int>("Attribute1"),
                            Intelligence = row.Field<int>("Attribute2"),
                            Agility = row.Field<int>("Attribute3"),
                            Constitution = row.Field<int>("Attribute4"),
                            Charisma = row.Field<int>("Attribute5"),
                        };
                    };
                };
            };
        }

        public void Update ( int id, Character character )
        {
            throw new NotImplementedException();
        }
        private readonly string _connectionString;
    }
}
