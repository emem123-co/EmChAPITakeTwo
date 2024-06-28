﻿namespace EmChAPITakeTwo.Models;

public class OrderLine
{


        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }

        public virtual Order? Order { get; set; }
        public virtual Item? Items { get; set; }

}