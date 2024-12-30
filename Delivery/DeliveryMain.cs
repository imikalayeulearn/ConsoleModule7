using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class DeliveryMain
    {
        public string Address;
        public int DeliveryDays;
        public double DeliveryPrice;
        public string Description;

        public abstract void SetupDelivery();
        public abstract void PrintDelivery();

        protected void InitialSetup()
        {
            Console.Write("Введите адрес доставки: ");
            Address = Console.ReadLine();

            Console.Write("Введите стоимость доставки в формате xx.xx: ");
            DeliveryPrice = Double.Parse(Console.ReadLine());

            Console.Write("Введите сроки доставки в дней: ");
            DeliveryDays = int.Parse(Console.ReadLine());
        }
        protected void InitialPrint()
        {
            Console.WriteLine("Адресс доставки:{0} ", Address);
            Console.WriteLine("Сроки доставки: {0}", DeliveryDays);
            Console.WriteLine("Стоимость доставки: {0} рублей", DeliveryPrice);
        }
    }
}
