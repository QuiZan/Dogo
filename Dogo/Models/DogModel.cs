using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Dogo.Models
{
    public class DogModel
    {
        public int DogID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Weight { get; set; }
        public string Race { get; set; }
        public DateTime BdDate { get; set; }

    }
}
