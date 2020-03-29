using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.SqlServer.Types;

namespace DatabaseManagement.Data.Models
{
    public class City
    {
        string city;
        string country;
        SqlGeography coordinates;

        public City()
        {

        }
    }
}
