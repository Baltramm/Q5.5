using System;


namespace Q5._5
{
    class Program
    {
        static void Main(string[] args)
        {

        }


        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
                return 1;
            else if (pow == 1)
                return N;
            else return N * PowerUp(N,--pow);

        }
    }
}
