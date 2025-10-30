using System;

namespace Task
{
    public class Product
    {
        public int No { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercent { get; set; }

        public double GetDiscountedPrice()
        {
            return Price - (Price * DiscountPercent / 100);
        }

        public override string ToString()
        {
            return "No: " + No + " | Name: " + Name + " | Price: " + Price + " | DiscountPercent: " + DiscountPercent + "%";
        }
    }

    public class Notebook : Product
    {
        public int RAM { get; set; }
        public int Storage { get; set; }

        public override string ToString()
        {
            return base.ToString() + " | RAM: " + RAM + "GB | Storage: " + Storage + "GB";
        }
    }

    public class Phone : Product
    {
        public int SIMCount { get; set; }

        public override string ToString()
        {
            return base.ToString() + " | SIM Count: " + SIMCount;
        }
    }

    public class Store
    {
        public Product[] Products;
        public int NotebookLimit { get; set; }
        public int PhoneLimit { get; set; }
        private int _productCount = 0;

        public Store(int notebookLimit, int phoneLimit)
        {
            NotebookLimit = notebookLimit;
            PhoneLimit = phoneLimit;
            Products = new Product[notebookLimit + phoneLimit];
        }

        public void AddProduct(Product product)
        {
            int notebookCount = 0;
            int phoneCount = 0;

            for (int i = 0; i < _productCount; i++)
            {
                if (Products[i] is Notebook) notebookCount++;
                if (Products[i] is Phone) phoneCount++;
            }

            if (product is Notebook && notebookCount >= NotebookLimit)
            {
                Console.WriteLine("Notebook limiti dolub. Yeni notebook elave edile bilmez!");
                return;
            }

            if (product is Phone && phoneCount >= PhoneLimit)
            {
                Console.WriteLine("Telefon limiti dolub. Yeni telefon elave edile bilmez!");
                return;
            }

            if (_productCount >= Products.Length)
            {
                Console.WriteLine("Umumi mehsul limiti dolub!");
                return;
            }

            Products[_productCount++] = product;
            Console.WriteLine("Mehsul elave olundu: " + product.Name);
        }

        public Product FindByNo(int no)
        {
            for (int i = 0; i < _productCount; i++)
            {
                if (Products[i].No == no)
                    return Products[i];
            }
            return null;
        }

        public double CalcNotebookAvg()
        {
            double total = 0;
            int count = 0;

            for (int i = 0; i < _productCount; i++)
            {
                if (Products[i] is Notebook nb)
                {
                    total += nb.Price;
                    count++;
                }
            }

            if (count == 0) return 0;
            return total / count;
        }

        public double CalcPhoneAvg()
        {
            double total = 0;
            int count = 0;

            for (int i = 0; i < _productCount; i++)
            {
                if (Products[i] is Phone ph)
                {
                    total += ph.Price;
                    count++;
                }
            }

            if (count == 0) return 0;
            return total / count;
        }

        public void ShowAllProducts()
        {
            for (int i = 0; i < _productCount; i++)
            {
                Console.WriteLine(Products[i].ToString());
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Store store = new Store(2, 3);

            Notebook nb1 = new Notebook { No = 1, Name = "Asus", Price = 1500, DiscountPercent = 10, RAM = 16, Storage = 512 };
            Notebook nb2 = new Notebook { No = 1, Name = "HP", Price = 1200, DiscountPercent = 8, RAM = 8, Storage = 64 };
            Notebook nb3 = new Notebook { No = 3, Name = "Acer", Price = 1800, DiscountPercent = 12, RAM = 32, Storage = 1024 };

            Phone ph1 = new Phone { No = 4, Name = "Samsung", Price = 1200, DiscountPercent = 6, SIMCount = 2 };
            Phone ph2 = new Phone { No = 5, Name = "Xiaomi", Price = 600, DiscountPercent = 4, SIMCount = 1 };

            store.AddProduct(nb1);
            store.AddProduct(nb2);
            store.AddProduct(nb3);
            store.AddProduct(ph1);
            store.AddProduct(ph2);
            Console.WriteLine("\nMehsullar siyahisi:");
            store.ShowAllProducts();

            Console.WriteLine("\nNotebook ortalama qiymeti:" + store.CalcNotebookAvg());
            Console.WriteLine("Telefon ortalama qiymeti:" + store.CalcPhoneAvg());

            Product found = store.FindByNo(1);
            if (found != null)
                Console.WriteLine("\nTapilan mehsul: " + found.ToString());
            else
            {
                Console.WriteLine("\nTapilan mehsul: Tapilmadi.");
            }
        }
    }
}