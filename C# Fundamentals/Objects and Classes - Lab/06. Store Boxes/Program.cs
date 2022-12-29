using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a class Item, which contains these properties: Name and Price.
            //Define a class Box, which contains these properties: Serial Number, Item, Item Quantity and Price for a Box.
            //Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
            //The Price of one box has to be calculated: itemQuantity* itemPrice.
            //Print all the boxes ordered descending by price for a box, in the following format: 
            //{ boxSerialNumber}
            //-- {boxItemName} – ${boxItemPrice}: {boxItemQuantity}
            //-- ${ boxPrice}
            //The price should be formatted to the 2nd digit after the decimal separator.
            string input;
            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] boxInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = boxInfo[0];
                string itemName = boxInfo[1];
                int itemQty = int.Parse(boxInfo[2]);
                decimal itemPrice = decimal.Parse(boxInfo[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQty);
                boxes.Add(box);
            }
            foreach (var box in boxes.OrderByDescending(x => x.PricePerBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PricePerBox:f2}");
            }
        }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;

        }
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal PricePerBox
        {
            get
            {
                return Quantity * Item.Price;
            }
        }
    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

