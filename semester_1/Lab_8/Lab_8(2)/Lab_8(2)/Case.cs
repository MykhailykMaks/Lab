using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_2_
{
    class Case
    {
        public string? color;
        public string? manufacturer;
        public int weight;
        public int size;
        public Items[] items;
        public int capacity;

        public Case(string? color, string? manufacturer, int weight, int size, Items[] items, int capacity)
        {
            this.color = color;
            this.manufacturer = manufacturer;
            this.weight = weight;
            this.size = size;
            this.items = items;
            this.capacity = capacity;
        }
        public Case()
        {
            color = "";
            manufacturer = "";
            weight = 0;
            size = 0;
            items = new Items[0];
            capacity = 0;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public Items[] Items
        {
            get { return items; }
            set { items = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public delegate void AddItem(ref Items[] items, Items item);
        public event AddItem ItemAdd;
        public event AddItem ItemDelete; 
        public void AddItems(Items item)
        {
            if (size + item.size < capacity)
            {
                size += item.size;
                ItemAdd.Invoke(ref items, item);    
                Console.WriteLine($"Item added to the case.");
            }
            else
            {
                Console.WriteLine($"Not enough space in the case to add this item.");
            }
        }
        public void DeleteItems(Items item)
        {
            if (ItemDelete != null)
            {
                size -= item.size;
                ItemDelete.Invoke(ref items, item);
                Console.WriteLine($"Item deleted from the case.");
            }
        }
        public override string ToString()
        {
            return ($"Color of your case: {color}, Brand of creator your case: {manufacturer}, Weight of your case: {weight}, Size of your case: {size}, Capacity of your case: {capacity}");
        }
    }
}
