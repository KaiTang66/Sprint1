using System;

namespace Versuch
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Willkommen");
            Console.WriteLine("Bitte geben Sie Teilkreidurchmesser d ein.");
            double d;
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie Zaehnezahl z ein.");
            int z;
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie Kopfspiel c ein.");
            double c;
            c = Convert.ToDouble(Console.ReadLine());
            while (c < 0.1 ^ c > 0.3)
            {
                Console.WriteLine("Der Wert von c muss von 0,1 bis 0,3.");
                Console.WriteLine("Bitte geben Sie eine neuer c ein.");
                c = Convert.ToDouble(Console.ReadLine());
            }
            double m, p, da, ha, hf, df, h;
            m = d / z;
            p = Math.PI * m;
            da = d + 2 * m;
            ha = m;
            hf = m + c;
            df = d - 2 * (m + c);
            h = 2 * m + c;
            Console.WriteLine("d ="+Convert.ToString(d));
            Console.WriteLine("z="+Convert.ToString(z));
            Console.WriteLine("m="+Convert.ToString(m));
            Console.WriteLine("p="+Convert.ToString(p));
            Console.WriteLine("h="+Convert.ToString(h));
            Console.WriteLine("da="+Convert.ToString(da));
            Console.WriteLine("df="+Convert.ToString(df));
            Console.WriteLine("ha="+Convert.ToString(ha));
            Console.WriteLine("hf="+Convert.ToString(hf));
            Console.ReadKey();
        }
    }
}
