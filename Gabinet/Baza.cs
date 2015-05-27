using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabinet
{
    public class Baza
    {
        public string datasource = "localhost";
        public string database = "gabinet";
        public string port = "3306";
        public string user = "root";
        public string password = "";

        public string Datasource
        {
            get
            {
                return datasource;
            }
            set
            {
                datasource = value;
            }
        }

        public string Database
        {
            get
            {
                return database;
            }
            set
            {
                database = value;
            }
        }

        public string Port
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
