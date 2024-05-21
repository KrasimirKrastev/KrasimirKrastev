// room for one person - 18 lv
// apartment - 25 lv
// president apartment - 35 lv
// room for one - no dicount
// apartment = days < 10 - 30% dicount, days == 10 || <=15 - discount - 35%, days > 15 - discount = 50%
// president apartment = days < 10 - discount 10%, days == 10 || <= 15 - discount - 15%, days > 15 - discount - 20%

        int days = int.Parse(Console.ReadLine());
        string roomType = Console.ReadLine();
        string rating = Console.ReadLine();

        double price = 0;

        if (roomType == "room for one person")
        {
            price = 18.00;
        }
        else if (roomType == "apartment")
        {
            price = 25.00;
            if (days > 15)
                price *= 0.5;
            else if (days >= 10)
                price *= 0.65;
        }
        else if (roomType == "president apartment")
        {
            price = 35.00;
            if (days > 15)
                price *= 0.8; // 20%
            else if (days >= 10)
                price *= 0.85; 
        }

        double totalPrice = price * (days - 1); // Subtract 1 day for the check-out day

        if (rating == "positive")
            totalPrice *= 1.25; // Add 25% for positive rating
        else if (rating == "negative")
            totalPrice *= 0.9; // Subtract 10% for negative rating

        Console.WriteLine($"{totalPrice:f2}");
    