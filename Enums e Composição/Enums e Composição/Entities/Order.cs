using Enums_e_Composição.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enums_e_Composição.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }


        public override string ToString()
        {
            return Id
                + " "
                + Momment
                + " "
                + Status;
        }
    }
}
