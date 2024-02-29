﻿namespace AS2324._3G.Succi.Diego.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diego Succi 3G 29/02/2024");
            Console.WriteLine("inserire il numero di voti");
            int nvoti = Convert.ToInt32(Console.ReadLine());
            double[]voti = new double[nvoti];
            int[]pesi = new int[nvoti];
            CaricaVettori(ref voti, ref pesi, nvoti);
            StampaVotiPesi(voti, pesi, nvoti);
            StampaVotiDispariMaggiori4(ref voti, ref pesi,nvoti);


        }
        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            Console.WriteLine(" voti  -  pesi ");
            for (int i = 0; i < voti.Length; i++)
            {
                Console.WriteLine($"    {voti[i]}  -  {pesi[i]} ");
            }
            
        }
        static void CaricaVettori(ref double[] voti, ref int[]pesi, int nvoti)
        {
            Random random = new Random();
            for(int i = 0; i< nvoti; i++)
            {
                voti[i] = random.Next(0,11);
                pesi[i] = random.Next(0, 101);
            }
        }
        static void StampaVotiDispariMaggiori4(ref double[] voti, ref int[] pesi, int nvoti)
        {
            for(int i = 0; i< nvoti; i += 2)
            {
                if (voti[i] > 4)
                {
                    Console.WriteLine($"i voti maggiori di 4 sono: {voti[i]} ed il peso di esso è: {pesi[i]}");
                }
            }
        }
        
    }
}