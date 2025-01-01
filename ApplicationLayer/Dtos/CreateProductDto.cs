using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Dtos
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public int Dimensions { get; set; }
    }
}
