using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual2OPT.GraphAlgorithms
{



    public class Christofides1
    {
        //https://stackoverflow.com/questions/2927469/traveling-salesman-problem-2-opt-algorithm-c-sharp-implementation
        //        So I got bored and wrote it.It looks like it works,
        //        but I haven't tested it very thoroughly.
        //        It assumes triangle inequality, all edges exist, that sort of thing.
        //        It works largely like the answer I outlined.
        //        It prints each iteration; the last one is the 2-optimized one.

        //          I'm sure it can be improved in a zillion ways.


        public Christofides1()
        {
            //create an initial tour out of nearest neighbors
            var stops = Enumerable.Range(1, 10)
                                  .Select(i => new Stop(new City(i)))
                                  .NearestNeighbors()
                                  .ToList();

            //create next pointers between them
            stops.Connect(true);

            //wrap in a tour object
            Tour startingTour = new Tour(stops);

            //the actual algorithm
            while (true)
            {
                Console.WriteLine(startingTour);
                var newTour = startingTour.GenerateMutations()
                                          .MinBy(tour => tour.Cost());
                if (newTour.Cost() < startingTour.Cost()) startingTour = newTour;
                else break;
            }
        }


    }
}
