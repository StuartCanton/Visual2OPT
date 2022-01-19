using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public static partial class Extensions
    {
        //public static string QueueToString(this PriorityQueue<TElement, TPriority> queue)
        public static string QueueToString(this PriorityQueue<Edge, int> queue)
        {
            StringBuilder sb = new StringBuilder();
            PriorityQueue<Edge, int> result = new PriorityQueue<Edge, int>();
            result.EnqueueRange(queue.UnorderedItems);

            while (result.TryDequeue(out Edge item, out int priority))
            {
                string start = $"{(char)(item.Start + 65)}";
                string end = $"{(char)(item.End + 65)}";
                sb.AppendLine($"Item : {start}:{end}. Priority Was : {priority}");
            }
            return sb.ToString();
        }
    }
}
