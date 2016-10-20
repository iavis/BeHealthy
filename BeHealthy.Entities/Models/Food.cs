using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeHealthy.Entities.Models
{
    public class Food : EntityModel
    {
        
        public string Name { get; set; }

        public double Protein { get; set; }
        
        public double Carbohydrate { get; set; }

        public double Fat { get; set; }

        public double Caloric { get; set; }

    }


}
