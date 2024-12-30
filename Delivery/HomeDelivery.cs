using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class HomeDelivery: DeliveryMain
    {
        public int CourierType;
        public int PickupOption;
        enum CourierTypes
        {
            Bicycle = 0,
            Car = 1
        }

        public HomeDelivery()
        {
            Description = "Доставка на дом!";
        }

        public override void SetupDelivery()
        {
            base.InitialSetup();
            Console.WriteLine("Выберите, как вам доставить товар?");
            Console.WriteLine("На велосепеде - 1");
            Console.WriteLine("На машине - 2");
            int Choice = int.Parse(Console.ReadLine());

            if (Choice == 0)
            {
                CourierType = (int) CourierTypes.Bicycle;
            }
            else
            {
                CourierType = (int)CourierTypes.Car;
            }
        }
        public override void PrintDelivery()
        {
            base.InitialPrint();
            String DeliveryType = (CourierType == (int)CourierTypes.Bicycle) ? "Велосепед" : "Машина";
            Console.WriteLine("Способ доставки на дом - {0}", DeliveryType);
        }
    }
}
