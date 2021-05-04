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
            throw new NotImplementedException();
        }

        public void Update ( int id, Character character )
        {
            throw new NotImplementedException();
        }
        private readonly string _connectionString;
    }
}
