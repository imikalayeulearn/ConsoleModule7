using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PickPointDelivery: DeliveryMain
    {
        public string[] Locations;

        public PickPointDelivery()
        {
            Description = "Доставка в пункт выдачи";
        }

        public override void SetupDelivery()
        {
            base.InitialSetup();
        }
        public override void PrintDelivery()
        {
            InitialPrint();
        }
    }
}
