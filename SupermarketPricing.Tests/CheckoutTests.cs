using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace SupermarketPricing.Tests
{
    public class CheckoutTests
    {
        private Checkout _checkout;

        [SetUp]
        public void BeforeEach()
        {
            _checkout = new Checkout();
        }

        [Test]
        public void OneCanOfBeans_CostsOneDollar()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Beans",
                Price = 1,
                Quantity = 1
            };

            _checkout.AddProduct(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(1);
        }

        [Test]
        public void TwoCansOfBeans_CostsTwoDollars()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Beans",
                Price = 1,
                Quantity = 1
            };

            _checkout.AddProduct(beans);
            _checkout.AddProduct(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(2);
        }

        [Test]
        public void ThreeCansOfBeans_CostsTwoDollars()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Beans",
                Price = 1,
                Quantity = 1
            };

            _checkout.AddProduct(beans);
            _checkout.AddProduct(beans);
            _checkout.AddProduct(beans);
             //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(2);
        }

         
    }
}
