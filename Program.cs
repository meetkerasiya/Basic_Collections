class MyClass
{
    static void Main(string[] args)
    {
        DateTime[] Holidays = new DateTime[]
        {
            new DateTime(2023,1,26),
            new DateTime(2023,3,8),
            new DateTime(2023,8,15),
            new DateTime(2023,8,30),
            new DateTime(2023,9,7),
            new DateTime(2023,10,2),
            new DateTime(2023,10,24),
            new DateTime(2023,11,13),
            new DateTime(2023,11,14),
            new DateTime(2023,11,15),
        };
        DateTime[] Holidays2 = new DateTime[]
        {
            new DateTime(2023,1,26),
            new DateTime(2023,3,8),
            new DateTime(2023,8,15),
            new DateTime(2023,8,30),
            new DateTime(2023,9,7),
            new DateTime(2023,10,2),
            new DateTime(2023,10,24),
            new DateTime(2023,11,13),
            new DateTime(2023,11,14),
            new DateTime(2023,11,15),
        };
        DateTime[] Holidays3 = Holidays;

        Console.WriteLine("Holidays==Holidays2 ? "+(Holidays==Holidays2));
        Console.WriteLine("Holidays2==Holidays3 ? " + (Holidays2 == Holidays3));
        Console.WriteLine("Holidays==Holidays3 ? " + (Holidays == Holidays3));

        Console.WriteLine("Using SequenceEqual " + (Holidays.SequenceEqual(Holidays2)));


        var BankHolidays = new List<DateTime>
        {
            new DateTime(2023,1,26),
            new DateTime(2023,3,8),
            new DateTime(2023,8,15),
            new DateTime(2023,8,30),
            new DateTime(2023,9,7),
            new DateTime(2023,10,2),
            new DateTime(2023,10,24),
            new DateTime(2023,11,13),
            new DateTime(2023,11,14),
            new DateTime(2023,11,15),
        };
        //accessing perticular element in list
        Console.WriteLine("The second element of the list is " + BankHolidays[1]);

        //iterating through list
        for(int i=0;i<BankHolidays.Count;i++)
        {
            Console.WriteLine(BankHolidays[i]);
        }

        //Add element
        BankHolidays.Add(new DateTime(2023, 4, 1));
        Console.WriteLine("Last adeed holiday is " + BankHolidays[BankHolidays.Count-1]);

        //Insert Element at given index
        BankHolidays.Insert(5, new DateTime(2023, 6, 6));
        Console.WriteLine("Holiday added at index 5 is " + BankHolidays[5]);

        //Remove and RemoveAt
        BankHolidays.RemoveAt(5);
        BankHolidays.Remove(new DateTime(2023,4, 1));

        Console.WriteLine("After removing data");
        foreach (var item in BankHolidays)
        {
            Console.WriteLine(item);

        }
        
    }
}