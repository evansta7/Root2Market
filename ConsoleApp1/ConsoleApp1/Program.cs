using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] A = new int[5] { 1,3,5,7,9};
            Console.WriteLine(solution(A).ToString());
            Console.ReadLine();
        }
        public static int solution(int[] A)
        {
            int stable = 0;
            int index = 0;
            int[] velocity = new int[A.Length];
            if (A.Length < 2)
            {
                return 0;
            }
            for (int i = 0; i < A.Length; i++)
            {

                if (i + 1 < A.Length)
                {
                    
                    velocity[index] = A[i + 1] - A[i];
                    Console.WriteLine("A + 1: " + A[i + 1].ToString());
                    Console.WriteLine("A: " + A[i].ToString());
                    Console.WriteLine(" VELOCITY: " + velocity[index].ToString());
                    index++;
                }
            }
            for (int i = 0; i < velocity.Length; i++)
            {
                Console.WriteLine("Velocity x 2" + velocity[i]);
                if (i + 1 < A.Length && velocity[i] == velocity[i + 1])
                {
                    stable += 1;
                }
            }
            if (stable > 1000000000)
            {
                return -1;
            }
            return stable;
        }
    }
}
