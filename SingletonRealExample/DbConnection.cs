using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonRealExample
{
    class DbConnection
    {
        private static DbConnection Connection;

        public string Configuration { get; private set; }

        protected DbConnection(string configuration)
        {
            Configuration = configuration;
        }

        ///<summary>
        ///реализация синглтона не позволяет нам положить новые объекты, если объект уже существует
        /// </summary>
        public static DbConnection GetConnectionInstance(string dbServer)
        {
            if (Connection == null)
                Connection = new DbConnection(dbServer);
            return Connection;
        }
    }
}
