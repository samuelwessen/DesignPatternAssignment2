using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DataRepositoryB : IDataRepository
    {
        public string DatabaseType()
        {
            return "Dataset B";
        }

        public string GetAnimal()
        {
            return "From Table Animal Where Owner==Samuel";
        }

        public string GetCustomer()
        {
            return "From Table Customer Where Name == Samuel";
        }
    }
}
