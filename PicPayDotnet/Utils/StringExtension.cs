using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PicPayDotnet.Utils
{
    public static class StringExtension
    {
        public static bool NulaVazia(this string value)
        {
            if(string.IsNullOrEmpty(value)) return true;
            return false;
        }
    }
}