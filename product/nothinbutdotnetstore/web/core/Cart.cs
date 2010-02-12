using System;
using System.Collections.Generic;
using nothinbutdotnetstore.domain;

namespace nothinbutdotnetstore.web.core
{
    public interface Cart
    {
        IEnumerable<Product> items();
        void Add(Product item);
    }

    public class DefaultCart : Cart
    {
        List<Product> itemsInChart;

        public DefaultCart(IEnumerable<Product> items)
        {
            itemsInChart = new List<Product>(items);
        }

        public IEnumerable<Product> items()
        {
            return itemsInChart;
        }

        public void Add(Product item)
        {
            itemsInChart.Add(item);
        }
    }
}