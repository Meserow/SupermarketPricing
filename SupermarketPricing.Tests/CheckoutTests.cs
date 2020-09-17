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
                Quantity = 1,
                sale = null
            };
            
            _checkout.Products.Add(beans);

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
                Quantity = 2,
                sale = null
            };

            _checkout.Products.Add(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(2);
        }

        [Test]
        public void TwoCansOfBeans_NullProduct()
        {
            //Arrange
            _checkout.Products.Add(null);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(0);
        }

        [Test]
        public void ThreeCansOfBeans_BuyTwoGetOneFree_CostsTwoDollars()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Beans",
                Price = 1,
                Quantity = 3,
                sale = new BuyXGetY()
                {
                    ForFree = 1,
                    QualifyingAmount = 2
                }
            };

            _checkout.Products.Add(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(2);
        }

        [Test]
        public void TwoCansOfBeans_BuyTwoGetOneFree_CostsTwoDollars()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Beans",
                Price = 1,
                Quantity = 2,
                sale = new BuyXGetY()
                {
                    ForFree = 1,
                    QualifyingAmount = 2
                }
            };

            _checkout.Products.Add(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(2);
        }

        [Test]
        public void FiveCansOfBeans_BuyTwoGetOneFree_CostsTwoDollars()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Beans",
                Price = 1,
                Quantity = 5,
                sale = new BuyXGetY()
                {
                    ForFree = 1,
                    QualifyingAmount = 2
                }
            };

            _checkout.Products.Add(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(4);
        }

        [Test]
        public void sixCansOfBeans_BuyTwoGetOneFree_CostsTwoDollars()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Beans",
                Price = 1,
                Quantity = 6,
                sale = new BuyXGetY()
                {
                    ForFree = 1,
                    QualifyingAmount = 2
                }
            };

            _checkout.Products.Add(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(4);
        }

        [Test]
        public void ThreeCansOfBeans_BuyOneGetOneFree_CostsTwoDollars()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Beans",
                Price = 1,
                Quantity = 2,
                sale = new BuyXGetY()
                {
                    ForFree = 1,
                    QualifyingAmount = 1
                }
            };

            _checkout.Products.Add(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(1);
        }

        [Test]
        public void ThreeCansOfBeans_GetFor1Dollar()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Beans",
                Price = 1,
                Quantity = 3,
                sale = new BuyForX()
                {
                    Price = 1,
                    SaleQuantity = 3
                }
            };

            _checkout.Products.Add(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(1);
        }
    }
}
