using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const float Pi = 3.14f;
            float num = 1.2f;
            decimal number2 = 1.2m;
            byte number3 = 255;
            Console.WriteLine(number3+1);
            number3 += 1;
            Console.WriteLine(number3);
            Console.WriteLine("{0},{1}",byte.MinValue,byte.MaxValue);//0,255
            Console.WriteLine("{0},{1}", float.MinValue, float.MaxValue);//0,255
            byte l = 1;
            int i = l;
            string s = "1";
            byte intToByte = (byte)i;
            byte intToByte2 = Convert.ToByte(s);
            int stringToInt = Convert.ToInt32(s);
            int stringToInt2 = int.Parse(s);

            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("the number cannot be converted to byte");
            }

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("the true cannot be converted to 1");
            }
        }
    }
}
