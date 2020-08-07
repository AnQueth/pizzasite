using System;

namespace PizzaShared
{
    public class Order
    {
        public OrderItems[] Items { get; set; }
        public string DeliveryTo { get; set; }

        public string DeliveryAddress { get; set; }

        public string DeliveryPhone { get; set; }

        public string DeliveryEmail { get; set; }

        public string CreditCard { get; set; }

        public DateTimeOffset CreditCardExpires { get; set; }

        public int CreditCardCCV { get; set; }

    }
}