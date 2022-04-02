using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {    
            //ekrandan girilen sayiya kadar girilen tek sayilari yazdir
            Console.WriteLine("lutfen bir sayi giriniz");
            int sayac=int.Parse(Console.ReadLine());

            for(int i=1; i<=sayac; i++)
            {   
                if(i%2==1)
                Console.WriteLine(i);
            }

            //1 ile 1000 arasindakki tek ve cift sayilarin kendi aralarinda toplamlarini ekrana yazdir
            int tektoplam=0;
            int cifttoplam;
            for(int i = 1; i<=1000; i++)
            {
                if(i%2==1)
                    tektoplam+=1;
                else
                    cifttoplam+=1;
            }
             Console.WriteLine("tek toplam: "+tektoplam);
             Console.WriteLine("cift toplam: "+cifttoplamm);

             //break,continue

             for( int i=1; i<10;i++)
             {
                 if(i==4)
                    break;
                Console.WriteLine(i);    
             }   
             for( int i=1; i<10;i++)
             {
                 if(i==4)
                    break;
                Console.WriteLine(i);    
             }  
        }
    }
}
