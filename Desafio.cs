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
            int valor = 0;
            int resto = 0;
            foreach(Item item in items)
            {
                total += item.CalculaItem();
            }

            valor = total / emails.Count;
            resto = total % emails.Count;
            
            for(int index = 0; index < emails.Count; index++)
            {
                int valorAPagar = valor;
                if(index == 0) 
                {
                    valorAPagar += resto;
                }
                splitBill.Add(emails[index], valorAPagar);
            }
        }
    }
}
