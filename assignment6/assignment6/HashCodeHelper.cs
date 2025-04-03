using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    public static class HashCodeHelper
    {
        public static int Combine(params object[] objects)
        {
            unchecked
            {
                int hash = 17;
                foreach (var obj in objects)
                {
                    hash = hash * 23 + (obj?.GetHashCode() ?? 0);
                }
                return hash;
            }
        }
    }

}
