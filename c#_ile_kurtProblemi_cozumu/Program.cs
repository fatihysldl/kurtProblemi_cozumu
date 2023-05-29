using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__ile_kurtProblemi_cozumu
{
    internal class kurtProblemi

    {
        static void Main()
        {
            Console.Write("Dizi boyutunu girin: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Dizi elemanlarını girin (Her rakamdan sonra bir boşluk bırakınız): ");
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int[] counts = new int[6]; // Her bir ID'nin tekrar sayısını tutan dizi

            // Her bir elemanın tekrar sayısını hesapla
            foreach (int num in array)
            {
                counts[num]++;
            }

            int maxCount = 0;
            int minID = int.MaxValue;

            // En fazla tekrar eden ve en küçük ID'ye sahip olanı bul
            for (int i = 1; i <= 5; i++)
            {
                int count = counts[i];
                if (count > maxCount || (count == maxCount && i < minID))
                {
                    maxCount = count;
                    minID = i;
                }
            }

            Console.WriteLine("ÇIKTI: " + minID);

            Console.WriteLine("Eğer uygulamadan çıkmak istiyorsanız herhangi bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
