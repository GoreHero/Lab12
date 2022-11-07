using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Circle
    {
        static public double Lengh(double r)
        {
            return Math.PI * r * r;
        }
        static public double Square(double r)
        {
            return 2*Math.PI*r;
        }
        double x;
        double y;
        private bool checkPoint = false;
        double r;

        public bool CheckPoint(double x,double y,double r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
            if (Math.Sqrt((x*x)+(y*y))<r)
            {
                return true;
            }
            else return false;
        }

        
        
        
    }
}
