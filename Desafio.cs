using System;
using System.Collections.Generic;

namespace stone
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> emails = new List<string>();
            List<Item> items = new List<Item>();

            Dictionary<string, int> splitBill = new Dictionary<string, int>();


            int total = 0;
            int value = 0;
            int rest = 0;
            
            foreach(Item item in items)
            {
                total += item.CalculateItem();
            }

            value = total / emails.Count;
            rest = total % emails.Count;
            
            for(int index = 0; index < emails.Count; index++)
            {
                int valueToPay = value;
                if(index == 0) 
                {
                    valueToPay += rest;
                }
                splitBill.Add(emails[index], valueToPay);
            }
        }
    }
}
