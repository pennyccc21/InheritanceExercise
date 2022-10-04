using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animals
    {
        public Bird()
        {
            IsAlive = true;
            LegCount = 2;
            LandSeaAir = "Air";
            Age = 0;




        }
    
        public string WingColor { get; set; }
        public bool CanFLy { get; set; }
        public bool DoMigarte { get; set; }
        public double BeakLength { get; set; }
}
