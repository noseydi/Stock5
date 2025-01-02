using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class CityEntity
    {
        [Key] public int CityID { get; set; }
        public string CityName { get; set; }
    }
}
