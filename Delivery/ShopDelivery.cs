using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ShopDelivery: DeliveryMain
    {
        public ShopDelivery()
        {
            Description = "Самовывоз из магазины";
        }
        public override void SetupDelivery()
        {
            base.InitialSetup();
        }

        public override void PrintDelivery()
        {
            base.InitialPrint();
        }
    }
}
