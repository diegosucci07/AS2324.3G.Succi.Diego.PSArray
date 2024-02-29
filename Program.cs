namespace AS2324._3G.Succi.Diego.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diego Succi 3G 29/02/2024");
            Console.WriteLine("inserire il numero di voti");
            int nvoti = Convert.ToInt32(Console.ReadLine());
            StampaVotiPesi(voti, pesi, nvoti);
            
        }
        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            Console.WriteLine(" voti  -  pesi ");
            for (int i = 0; i < voti.Length; i++)
            {
                Console.WriteLine(voti[i] + pesi[i]);
            }
            
        }
    }
}