using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SmashBrosMatchMaker.Database
{
    class DatabaseController
    {
        private const string CONNECTION_STRING = "Host=   ;Username=   ;Password=   ;Database=  "; //these need to be filled in
        private NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING);

    }
}
