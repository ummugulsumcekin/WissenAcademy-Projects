
    string[] seats = new string[20];

    
        while (true)
        {
            Console.WriteLine("1. Business Class bölümü için 1 tuşuna basın");
            Console.WriteLine("2. Economy Class bölümü için 2 tuşuna basın");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                MakeReservation("Business");
            }
            else if (choice == "2")
            {
                MakeReservation("Economy");
            }
            else
            {
                Console.WriteLine("Geçersiz seçenek! Lütfen tekrar deneyin.");
                continue;
            }

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
            Console.Clear();


    void MakeReservation(string seatClass)
    {
        int startSeat, endSeat;

        if (seatClass == "Business")
        {
            startSeat = 0;
            endSeat = 7;
        }
        else // Economy
        {
            startSeat = 8;
            endSeat = 19;
        }

        bool seatsAvailable = false;

        for (int i = startSeat; i <= endSeat; i++)
        {
            if (seats[i] == null)
            {
                seatsAvailable = true;
                Console.WriteLine($"- {i + 1}");
            }
        }

        if (!seatsAvailable)
        {
            Console.WriteLine($"Seçtiğiniz {seatClass} Class bölümünde boş koltuk kalmamıştır.");
            Console.WriteLine("Economy Class bölümündeki boş koltukları görmek ister misiniz? (E/H)");

            string response = Console.ReadLine();

            if (response == "E" || response == "e")
            {
                MakeReservation("Economy");
            }
            else
            {
                Console.WriteLine("Bir sonraki uçuş kayıtları 4 saat sonradır.");
            }

            return;
        }

        Console.WriteLine($"Lütfen {seatClass} Class bölümünden bir koltuk seçin:");

        int selectedSeat=0;
        bool validSeat = false;

        while (!validSeat)
        {
            if (int.TryParse(Console.ReadLine(), out selectedSeat))
            {
                if (selectedSeat < startSeat + 1 || selectedSeat > endSeat + 1)
                {
                    Console.WriteLine("Geçersiz koltuk numarası! Lütfen tekrar deneyin:");
                }
                else if (seats[selectedSeat - 1] != null)
                {
                    Console.WriteLine($"{selectedSeat} Numaralı koltuğu daha önce \"{seats[selectedSeat - 1]}\" isimli yolcuya rezerve ettiniz!");
                    Console.WriteLine("Lütfen boş koltuklardan birisini seçiniz.");
                }
                else
                {
                    validSeat = true;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz koltuk numarası! Lütfen tekrar deneyin:");
            }
        }

        Console.WriteLine("Lütfen yolcunun Adı ve Soyadını yazın:");
        string passengerName = Console.ReadLine();

        seats[selectedSeat - 1] = passengerName;

        Console.WriteLine($"{seatClass} Class bölümündeki {selectedSeat} Numaralı koltuğu {passengerName} isimli yolcuya rezerve ettiniz.");
    }


}

