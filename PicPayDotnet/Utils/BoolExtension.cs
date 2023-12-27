using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PicPayDotnet.Utils
{
    public static class BoolExtension
    {
        public static bool ToBoolean(this object value)
        {
            if (value != null) return Convert.ToBoolean(value);
            return false;
        }
    }
}