using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class SetUnion
    {
        public int[] p { get; set; }
        public int[] size { get; set; }
        public int n { get; set; }
    }

    public class SetUnionFactory
    {
        public SetUnion GetSetUnion(int n)
        {
            SetUnion setUnion = new SetUnion() { p= new int[n], size=new int[n],n=n};

            for (int i = 0; i < n; i++)
            {
                setUnion.p[i] = i;
                setUnion.size[i] = 1;
            }

            return setUnion;
        }
    }

    public static class SetUnionExtensions
    {
        public static int Find(this SetUnion s, int x)
        {
            if (s.p[x] == x) return x;
            else
                return (s.Find(s.p[x]));
        }
        public static void UnionSets(this SetUnion s, int s1, int s2)
        {
            int r1 = s.Find(s1);
            int r2 = s.Find(s2);

            if (r1 == r2) return; //already the same set
            if (s.size[r1] >= s.size[r2])
            {
                s.size[r1] += s.size[r2];
                s.p[r2] = r1;
            }
            else
            {
                s.size[r2] += s.size[r1];
                s.p[r1] = r2;
            }
        }
        public static bool IsSameComponent(this SetUnion s, int s1, int s2)
        {
            return s.Find(s1) == s.Find(s2);
        }
    }
}
