using System;

namespace SerializeDemo

{

    [Serializable]

    public class Circle : Shape

    {

        public double Radius { get; set; }

        // circle Area = pi * radius^2

        public override double Area { get { return 3.14 * Radius * Radius; } }

    }

}