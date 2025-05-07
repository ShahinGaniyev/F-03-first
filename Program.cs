namespace DataTypesAndMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // ===== VALUE TYPES (stack) =====
            //int yas = 25;
            //float boy = 1.78f;
            //double ortalama = 88.7;
            //bool aktiv = true;
            //char simvol = 'a';
            //decimal maas = 1250.75m;
            //byte xal = 255;
            //long nufus = 9000000000;

            //// ===== REFERENCE TYPES (Heap) =====   
            //string ad = "Shahin";
            //object qarisiq = 45.6; // istenilen tip tutan deyisen 
            //int[] reqemler = { 1, 2, 3 };


            //// ===== ÇAP (Ekrana çıxarılır) =====

            //Console.WriteLine("==== VALUE TYPES (Stack) ====");
            //Console.WriteLine("int (yas) : " + yas);
            //Console.WriteLine("float (boy):" + boy);
            //Console.WriteLine("double (ortalama):" + ortalama);
            //Console.WriteLine("bool (aktiv):" + aktiv);
            //Console.WriteLine("char (simvol): " + simvol);
            //Console.WriteLine("decimal (maas) :" + maas);
            //Console.WriteLine("byte (xal):" + xal);
            //Console.WriteLine("long (nufus):" + nufus);


            //Console.WriteLine("\n===== REFERENCE TYPES (Heap) =====");
            //Console.WriteLine("string (ad):" + ad);
            //Console.WriteLine("object (qarisiq):" + qarisiq);
            //Console.WriteLine("array (reqemler):" + string.Join(", ", reqemler));


            //int first_number = 5;
            //int second_number = 6;

            //int total = first_number + second_number;

            //Console.WriteLine($"Total: " +total);




            //int first_number = 3;
            //int second_number = 5;

            //int total = first_number + second_number;


            //Console.WriteLine($"total; " + total);


            //int first_number = 2;
            //int second_number = 3;

            //int total=second_number * first_number;

            //Console.WriteLine($"result: { total}" );


            //int first_number=10; int second_number= 5;

            //int total=first_number / second_number;

            //Console.WriteLine($"result; {total}");

            //int first_number = 22;
            //int second_number = 11;
            //int total = first_number - second_number;

            //Console.WriteLine($"result: {total}");



            //int first_number = 10;
            //int second_number = 3;
            //int result = first_number % second_number;
            //Console.WriteLine(result);

            //int first_number = 12;
            //int second_number = 6;

            //first_number += second_number; 
            //Console.WriteLine(first_number);


            //int first_number = 8;
            //int second_number = 4;

            //first_number -= second_number;
            //Console.WriteLine(first_number);

            //int first_number = 6;
            //int second_number = 3;

            //first_number *= second_number;
            //Console.WriteLine(first_number);

            //int first_number = 11;
            //int second_number = 5;

            //first_number %= second_number;
            //Console.WriteLine(first_number);


            //Console.WriteLine(" eded daxil edin:");
            //int reqem = Convert.ToInt32(Console.ReadLine());


            //if (reqem % 2 == 0)
            //{
            //    Console.WriteLine("eded cutdur");
            //}
            //else
            //{

            //    Console.WriteLine("eded tekdir");
            //}

            //Bugunun taski

            //Console.WriteLine("Adinizi daxil edin: ");
            //string ad = Console.ReadLine();

            //Console.WriteLine("Soyadinizi daxil edin: ");
            //string soyad = Console.ReadLine();

            //Console.WriteLine("Yasinizi daxil edin: ");
            //string yas = Console.ReadLine();


            //Console.WriteLine($"Salam {ad} {soyad}. Sizin yasiniz {yas}");



            //Console.WriteLine("Doguldugunuz ili daxil edin: ");
            //int dogumIli = Convert.ToInt32(Console.ReadLine());

            //int cariIl = DateTime.Now.Year;

            //int yas = cariIl - dogumIli;


            //Console.WriteLine($"Sizin yasiniz: {yas}");

            //Console.WriteLine("Havanin temperaturunu daxil edin:");
            //int temperatur = Convert.ToInt32(Console.ReadLine());


            //if (temperatur < 15)
            //{
            //    Console.WriteLine("Hava soyuqdur.");
            //}
            //else
            //{
            //    Console.WriteLine("Hava istidir.");
            //}


            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    Console.WriteLine(cars[i]);


            //string[] adlar = { "sahin", "parviz" "farid", "isa" };

            //foreach (string ad in adlar) ;
            //{
            //    console.writeline(ad);

            //}

            //string[] adlar = { "sahin", "parviz" "farid", "isa" };

            //for (int i = 0; i < adlar.length; i++) ;
            //{
            //    Console.writeline(ad);

            //}
            #endregion

            #region Number Finder 
            //Console.WriteLine("Adinizi daxil edin"); //task 3
            //string daxilOlunmaliAD = Console.ReadLine();

            //string[] adlar = { "Farid", "Shahin", "Parviz", "Isa" };

            //bool dogruCavab = false;

            //for (int i = 0; i < adlar.Length; i++)
            //{
            //    if (daxilOlunmaliAD == adlar[i])
            //    {
            //        dogruCavab = true;
            //        break;
            //    }
            //}
            //if (dogruCavab)
            //{
            //    Console.WriteLine("Adınız sistemdə tapıldı.");
            //}
            //else
            //{
            ////    Console.WriteLine("Daxil etdiyiniz ad sistemdə yoxdur.");
            ///
            //}





            //int number = 100;
            //int guess;
            //int attempt = 0;
            //int maxattempt = 5;


            //do
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine($"{maxattempt - attempt} cəhd qalıb");
            //    Console.ResetColor();

            //    Console.WriteLine("Guess the number");
            //    guess = Convert.ToInt32(Console.ReadLine());

            //    attempt++;
            //    if (number < guess)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        Console.WriteLine("Down!");

            //    }
            //    else if (attempt == 5)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("You lost");
            //        break;
            //    }
            //    else if (number == guess)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine($"You guessed the number! {number}");

            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Up!");
            //    }

            //}
            //while (number != guess);

            #endregion

            //int x = 1;


            //while (x <= 10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}


            //string[] name = { "Sahin", "Farid", "Parviz" };

            //foreach (string adlar in name)
            //{
            //    Console.WriteLine(adlar);
            //}

            //for (int i = 0; i < name.Length; i++)

            //{ Console.WriteLine(name[i]); }

            //int i = 0;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //string[] name = { "Yeti", "Yetka", "Mans" };

            //foreach (string adlar in name)

            //{ Console.WriteLine(adlar); }


            //for (int i = 0; i < name.Length; i++)

            //{ Console.WriteLine(name[i]); }

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;

            //}

            //int i=0
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i <= 10);


            //int number = 0;
            //while (number <= 10)
            //{
            //    Console.WriteLine(number);

            //    if (number == 5)
            //    {
            //        Console.WriteLine("5 tapildi");
            //        break;
            //    }
            //    number++;
            //}


            //int a = 1;
            //while (a <= 10)
            //{
            //    a++;
            //    if (a == 3)
            //    {
            //        continue;
            //    }
            //    else if (a == 8)
            //    {
            //        Console.WriteLine("8 tapildi");
            //        break;
            //    }

            //    Console.WriteLine(a);
            //}

            Console.WriteLine("Adinizi daxil edin");
            string daxilad = Console.ReadLine();

            string[] adlar = { "Sahin", "Farid", "Parviz" };

            bool dogrucavab = false;
            for (int i = 0; i < adlar.Length; i++)
            {
                if (daxilad = adlar[i])
                {
                    dogrucavab = true;
                    break;
                }
            }
            if (dogrucavab)
            {
                Console.WriteLine("Adiniz tapildi");
            }
            else
            {
                Console.WriteLine("daxxil etdiyiniz ad tapilmadi");
            }


        }
    }

}