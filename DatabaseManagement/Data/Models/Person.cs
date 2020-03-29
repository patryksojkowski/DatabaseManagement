using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagement.Data.Models
{
    public class Person
    {
        string name { get; set; }
        string lastname { get; set; }
        DateTime birthdate { get; set; }
        int idcity { get; set; }

        public Person()
        {

        }
    }
}
