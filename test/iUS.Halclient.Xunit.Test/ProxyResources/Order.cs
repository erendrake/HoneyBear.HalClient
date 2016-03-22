using System;

namespace iUS.Halclient.Test.ProxyResources
{
    internal class Order
    {
        public Guid OrderRef { get; set; }
        public string OrderNumber { get; set; }
        public string Status { get; set; }
        public decimal Total { get; set; }
    }
}