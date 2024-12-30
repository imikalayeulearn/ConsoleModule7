using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Order <TDelivery> where TDelivery : DeliveryMain
    {
        public TDelivery Delivery { get; set; }
        public int Number;
        public string Description;

        public Order(TDelivery delivery)
        {
            Delivery = delivery;
        }

        public void PrintOrder()
        {
            Console.WriteLine("=========== ПЕЧАТЬ ЗАКАЗА ===============");
            Console.WriteLine("Номер заказа: {0}", Number);
            Console.WriteLine("Описание Заказа: {0}", Description);
            Console.WriteLine("-- Данные доставки -- ");
            Delivery.PrintDelivery();
        }
    }
}
