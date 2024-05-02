using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lub_44
{
    public class Cars
    {
        
            public string Name { get; set; }
            public string Country { get; set; }
            public string Motor { get; set; }
            public double ObDviguna { get; set; }
            public double PotugDviguna { get; set; }
            public double MaxSpeed { get; set; }
            public double Rnasto { get; set; }
            public double DiameterDisk { get; set; }
            public bool NewCar { get; set; }
            public bool Automaticgearbox { get; set; }

            
            public Cars(string name, string country, string motor, double obDviguna, int potugDviguna,
                        double maxSpeed, double rnasto, double diameterDisk, bool newCar, bool automaticgearbox)
            {
                Name = name;
                Country = country;
                Motor = motor;
                ObDviguna = obDviguna;
                PotugDviguna = potugDviguna;
                MaxSpeed = maxSpeed;
                Rnasto = rnasto;
                DiameterDisk = diameterDisk;
                NewCar = newCar;
                Automaticgearbox = automaticgearbox;
            }
        

    }

}
