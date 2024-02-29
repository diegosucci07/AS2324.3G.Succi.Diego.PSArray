﻿namespace AS2324._3G.Succi.Diego.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diego Succi 3G 29/02/2024");
            Console.WriteLine("inserire il numero di voti");
            int nVoti = Convert.ToInt32(Console.ReadLine());
            double[]voti = new double[nVoti];
            int[]pesi = new int[nVoti];
            CaricaVettori(ref voti, ref pesi, nVoti);
            StampaVotiPesi(voti, pesi, nVoti);
            StampaVotiDispariMaggiori4(ref voti, ref pesi,nVoti);
            double max = 0;
            double min = 0;
            double posmax = 0;
            double posmin = 0;
            double mediaponderata = MediaPonderata(voti, pesi, nVoti,ref max,ref posmax,ref min,ref posmin);

        }
        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            Console.WriteLine(" voti  -  pesi ");
            for (int i = 0; i < voti.Length; i++)
            {
                Console.WriteLine($"    {voti[i]}  -  {pesi[i]} ");
            }
            
        }
        static void CaricaVettori(ref double[] voti, ref int[]pesi, int nVoti)
        {
            Random random = new Random();
            for(int i = 0; i< nVoti; i++)
            {
                voti[i] = random.Next(0,11);
                pesi[i] = random.Next(0, 101);
            }
        }
        static void StampaVotiDispariMaggiori4(ref double[] voti, ref int[] pesi, int nVoti)
        {
            for(int i = 0; i< nVoti; i += 2)
            {
                if (voti[i] > 4)
                {
                    Console.WriteLine($"i voti maggiori di 4 sono: {voti[i]} ed il peso di esso è: {pesi[i]}");
                }
            }
        }
        static double MediaPonderata(double[] voti, int[] pesi, int nVoti, ref double max, ref int posmax, ref double min, ref int posmin)
        {
            double mediaponderata = 0;
            double sommavotipesi = 0;
            int somma = 0;
            for(int i = 0;i<nVoti; i++)
            {
                somma += pesi[i];
                sommavotipesi = voti[i] + pesi[i];
            }
            mediaponderata = sommavotipesi / somma;
            min = voti[0];
            max = voti[0];
            for(int i = 0; i< nVoti; i++ )
            {
                if (voti[i] > max)
                {
                    max= voti[i];
                    posmax = i;
                }
                if (voti[i] < min)
                {
                    min= voti[i];
                    posmin = i;
                }
            }
            return mediaponderata;
        }
        
    }
}