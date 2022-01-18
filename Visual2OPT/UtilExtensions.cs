using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual2OPT
{
    public static class UtilExtensions
    {
        public static string PrintToString(this List<List<int>> arr)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var list in arr)
            {
                foreach (var item in list)
                {
                    sb.Append(item.ToString());
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
