using System;
namespace project
{
    class test1
    {
        public static void Main()
        {
            int X= Convert.ToInt32(Console.ReadLine());
            int Y= Convert.ToInt32(Console.ReadLine());
            calc (X,Y);
            private void calc (int x, int y)
            {
                double Result= Math.Sqrt(Math.Abs(x) + Math.Pow (y,2));
                Console.WriteLine(Result);


            }

        }//end function
    }//end class
}//end namespace