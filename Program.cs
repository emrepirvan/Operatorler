using System;


namespace oparatorler
{
    class Program 
    {
        public static void Main(string[] args)
        {
            // atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y +2 ;
            Console.WriteLine(y);
            y +=2;
            Console.WriteLine(y);
            y /=2;
            Console.WriteLine(y);
            x *=2; 
            Console.WriteLine(x);

Console.WriteLine("\n\n\n Mantıksal operatorler");
            //Mantıksal oparatörler
            // || , && , ! 

            bool isSuccess= true;
            bool isComplated = false;


            if (isSuccess && isComplated)
            Console.WriteLine("perfect");

            if (isSuccess || isComplated )
            Console.WriteLine("Great!");

            if (isSuccess && !isComplated)
            Console.WriteLine("Fine!");

            //İlişkisel oparatörler
            // < , > , <=, >=, !=
Console.WriteLine("\n\n\n İlişkisel operatorler");
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
             Console.WriteLine(sonuc);
            sonuc = a > b;                        
             Console.WriteLine(sonuc);
            sonuc = a <= b;             
             Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            
Console.WriteLine("\n\n\n Aritmatik operatorler");
            // / ,+,-,*
            int sayi = 10;
            int sayi2 = 5;
            int sonuc1 = sayi / sayi2;
Console.WriteLine("{0} bölüm " ,sonuc1);
            sonuc1 = sayi * sayi2;
Console.WriteLine("{0} carpım " ,sonuc1);
            sonuc1 = sayi+ sayi2;
Console.WriteLine("{0} toplam " ,sonuc1);
            sonuc1 = sayi - sayi2;
Console.WriteLine("{0} fark " ,sonuc1);
                    // % mod alma
            int sonuc2 = 20%18;
            Console.WriteLine("{0} kalanı " ,sonuc2);





Console.ReadLine();
        }
    }
}