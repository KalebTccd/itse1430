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
            using (var conn = OpenConnection())
            {
                var cmd = new SqlCommand("AddCharacter", conn) {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@name", character.Name));
                cmd.Parameters.AddWithValue("@Description", character.Biography);
                cmd.Parameters.AddWithValue("@Profession", character.Profession);
                cmd.Parameters.AddWithValue("@Race", character.Race);
                cmd.Parameters.AddWithValue("@Attribute1", character.Strength);
                cmd.Parameters.AddWithValue("@Attribute2", character.Intelligence);
                cmd.Parameters.AddWithValue("@Attribute3", character.Agility);
                cmd.Parameters.AddWithValue("@Attribute4", character.Constitution);
                cmd.Parameters.AddWithValue("@Attribute5", character.Charisma);

                object result = cmd.ExecuteScalar();

                character.Id = Convert.ToInt32(result);
            };

            return character;
        }

        public void Delete ( int id )
        {
            using (var conn = OpenConnection())
            {
                var cmd = new SqlCommand("DeleteCharacter", conn) {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            };
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
                            Biography = row.IsNull(2) ? null : row.Field<string>("Description"),
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
            using (var conn = OpenConnection())
            {
                var cmd = new SqlCommand("UpdateCharacter", conn) {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.Add(new SqlParameter("@name", character.Name));
                cmd.Parameters.AddWithValue("@Description", character.Biography);
                cmd.Parameters.AddWithValue("@Profession", character.Profession);
                cmd.Parameters.AddWithValue("@Race", character.Race);
                cmd.Parameters.AddWithValue("@Attribute1", character.Strength);
                cmd.Parameters.AddWithValue("@Attribute2", character.Intelligence);
                cmd.Parameters.AddWithValue("@Attribute3", character.Agility);
                cmd.Parameters.AddWithValue("@Attribute4", character.Constitution);
                cmd.Parameters.AddWithValue("@Attribute5", character.Charisma);
                cmd.Parameters.AddWithValue("@id", id);


                cmd.ExecuteNonQuery();
            };
        }
        private readonly string _connectionString;
    }
}
