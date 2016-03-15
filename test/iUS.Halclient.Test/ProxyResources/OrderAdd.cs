using System.Collections.Generic;

namespace iUS.Halclient.Test.ProxyResources
{
    internal class OrderAdd
    {
        public IEnumerable<OrderItemAdd> OrderItems { get; set; }
    }
}