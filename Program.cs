using System;
using System.Collections;

namespace Koleksiyonlar_Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz=");
            string cumle = Console.ReadLine();
            string sesliharfler = "aeıioöuü";
            ArrayList cumledekiSesliHarfler = new ArrayList();
            cumle.ToLower();
            if (!string.IsNullOrEmpty(cumle))
            {
                for(int i = 0; i < cumle.Length; i++)
                {
                    if (sesliharfler.Contains(cumle[i]))
                    {
                        cumledekiSesliHarfler.Add(cumle[i]);
                    }
                }
            }
            Console.WriteLine("Cumledeki sesli harfler= ");
            cumledekiSesliHarfler.Sort();
            foreach (var item in cumledekiSesliHarfler)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
