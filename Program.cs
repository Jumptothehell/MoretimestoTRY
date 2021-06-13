using System;

namespace Tester
{
    class Program
    {
        struct Item
        {
            public string nameofItem;
            public string TypeofItem;

            public Item(string Name, string Type)
            {
                nameofItem = Name;
                TypeofItem = Type;
            }

        }

        static void Main(string[] args)
        {
            int Itembox = int.Parse(Console.ReadLine());
            Item[] listofItem = new Item[Itembox];
            for (int i = 0; i < Itembox; i++)
            {
                listofItem[i].nameofItem = Console.ReadLine();
                listofItem[i].TypeofItem = Console.ReadLine();
            }
            
            bool maiyaktamlaew = false;
            string message = Console.ReadLine();
            while (maiyaktamlaew == false)
            {
                for (int i = 0; i < Itembox; i++)
                {
                    if (message == "ShowAll")
                    {
                        Console.WriteLine(listofItem[i].nameofItem);
                        Console.WriteLine(listofItem[i].TypeofItem);
                        Console.WriteLine();
                        message = Console.ReadLine();
                    }
                    else if (message == listofItem[i].TypeofItem)
                    {
                        Console.WriteLine(listofItem[i].nameofItem);
                        Console.WriteLine();
                        message = Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("End");
                        maiyaktamlaew = true;
                    }
                }
            } 
            Console.ReadLine();
        }
    }
}
