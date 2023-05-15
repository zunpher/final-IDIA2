using System;
namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter current balance: ");
            double[] balance = new double[3];
            for (int i = 0; i < 3; ++i)
            {
                balance[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Enter payment list: ");
            double[] payment = new double[100];
            int count = 0;

            double input;
            do
            {
                input = double.Parse(Console.ReadLine());

                if (input <= 0)
                    break;

                payment[count] = input;
                count++;
            } while (true);

            for (int j = 0; j < 3; j++) {
                if (payment[j] <= balance[j])
                {
                    balance[0] -= payment[0];
                    Console.WriteLine("Balance 1 : {0}", balance[0]);
                }
            }
        }
    }
}