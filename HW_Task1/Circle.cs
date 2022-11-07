using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    static class Circle
    {
        static public double Lengh(double r)
        {
            return Math.PI * r * r;
        }
        static public double Square(double r)
        {
            return 2*Math.PI*r;
        }


        static public bool CheckPoint(double x,double y,double r)
        {
            if (Math.Sqrt((x*x)+(y*y))<r)
            {
                return true;
            }
            else return false;
        }

        
        
        
    }
}
