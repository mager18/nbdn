using System;
using nothinbutdotnetstore.domain;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class AddToCart : ApplicationCommand
    {
        Cart cart;
        Product product;

        public AddToCart(Cart cart, Product product)
        {
            this.cart = cart;
            this.product = product;
        }

        public void process(Request request)
        {
            cart.Add(product);
        }
    }
}
