﻿namespace OrdersService.Messages
{
    public class NewOrderMessage
    {
        public Order Order { get; set; }
        public string UserId { get; set; }
    }
}
