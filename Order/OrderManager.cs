using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class OrderManager
    {
        public static void RunOrder()
        {
            Console.WriteLine("Добро пожаловать в службу доставки!!!\n");

            DeliveryMain Delivery = null;

            Console.WriteLine("Выберете способ доставки: ");
            Console.WriteLine("Доставка на дом - 1");
            Console.WriteLine("Доставка в пункт выдачи - 2");
            Console.WriteLine("Самовывоз - 3");

            int Choice = int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Delivery = new HomeDelivery();
                    break;
                case 2:
                    Delivery = new PickPointDelivery();
                    break;
                case 3:
                    Delivery = new ShopDelivery();
                    break;
            }
            Console.WriteLine("\nВы выбрали тип доставки: {0}", Delivery.Description);

            Delivery.SetupDelivery();

            Order<DeliveryMain> order = new Order<DeliveryMain>(Delivery);
            order.Description = "Заказ с типом доставки "+Delivery.Description;
            order.Number = 10;
            order.PrintOrder();
        }
    }
}
