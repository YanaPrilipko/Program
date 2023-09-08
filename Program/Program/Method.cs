using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Method
    {

        //2 
        public static int MaxNumber(int x, int y)
        {
            int result = Math.Max(x, y);
            return result;
        }

        public static int MinNumber(int x, int y)
        {
            int result = Math.Min(x, y);

            return result;
        }
        //3
        public static int MaxNumber(int x, int y,int z)
        {
            int result = Math.Max(Math.Max(x, y), z);
            return result;
        }
        public static int MinNumber(int x, int y, int z)
        {
            int result = Math.Min(Math.Min(x, y), z);
            return result;
        }
        //4
        public static int MaxNumber(int x, int y, int z,int c)
        {
            int result = Math.Max(Math.Max(Math.Max(x, y), z),c);
            return result;
        }
        public static int MinNumber(int x, int y, int z,int c)
        {
            int result = Math.Min(Math.Min(Math.Min(x, y),z),c);
            return result;
        }

    }
}
