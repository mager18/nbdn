using developwithpassion.bdd.contexts;
using developwithpassion.bdd.harnesses.mbunit;
using developwithpassion.bdd.mocking.rhino;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.domain;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.core;


namespace nothinbutdotnetstore.tests.web
{
    public class AddToCartSpecs
    {
        public abstract class concern : observations_for_a_sut_with_a_contract<ApplicationCommand,
                                            AddToCart>
        {

        }

        [Concern(typeof(AddToCart))]
        public class when_adding_item_to_chart : concern
        {
            context c = () =>
            {
                cart = the_dependency<Cart>();
                product = the_dependency<Product>();
                request = an<Request>();
            };

            because b = () =>
            {
                sut.process(request);
            };


            it should_add_item_to_chart = () =>
            {
                cart.received(x => x.Add(product));
            };

            static Cart cart;
            static Product product;
            static Request request;
        }
    }
}


