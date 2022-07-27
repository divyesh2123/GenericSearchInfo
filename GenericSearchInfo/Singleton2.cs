using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSearchInfo
{
    internal sealed class Singleton2
    {
        Singleton2() { }
        private static readonly object lock1 = new object ();  
        private static Singleton2 instance = null;

        public int test = 45;
        public static Singleton2 Instance
        {
          get
            {
                lock (lock1)
                {
                    if (instance == null)
                    {
                        instance = new Singleton2();
                    }

                    return instance;
                }
            }
        }
    }
}
