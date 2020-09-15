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
                Name = "Bush's Baked Beans",
                Price = 1,
                Quantity = 1,
                Sale = SaleType.NoSale
            };
            
            _checkout.Products.Add(beans);

            //Act
            var total = _checkout.CalculateNetTotal(); 

            //Assert
            total.Should().Be(1);
        }

        [Test]
        public void ThreeCanOfBeans_CostsThreeDollars()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Bush's Baked Beans",
                Price = 1,
                Quantity = 3,
                Sale = SaleType.NoSale
            };

            _checkout.Products.Add(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(3);
        }

        [Test]
        public void OneCanOfBeansAndABottleOfWater_Costs2Dollars()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Bush's Baked Beans",
                Price = 1,
                Quantity = 1,
                Sale = SaleType.NoSale
            };

            var bottleOfWater = new Product
            {
                Name = "Bush's Baked Beans",
                Price = 2,
                Quantity = 1,
                Sale = SaleType.NoSale
            };

            _checkout.Products.Add(beans);
            _checkout.Products.Add(bottleOfWater);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(3);
        }

        [Test]
        public void ThreeCanOfBeans_BuyTwoGetOneFree_CostsTwoDollars()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Bush's Baked Beans",
                Price = 1,
                Quantity = 3,
                Sale = SaleType.Btgo
            };

            _checkout.Products.Add(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(2);
        }

        [Test]
        public void FourCanOfBeans_BuyTwoGetOneFree_CostsThreeDollars()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Bush's Baked Beans",
                Price = 1,
                Quantity = 4,
                Sale = SaleType.Btgo
            };

            _checkout.Products.Add(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(3);
        }

        [Test]
        public void TwoCanOfBeans_BuyTwoGetOneFree_CostsTwoDollars()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Bush's Baked Beans",
                Price = 1,
                Quantity = 2,
                Sale = SaleType.Btgo
            };

            _checkout.Products.Add(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(2);
        }

        [Test]
        public void TwoCanOfBeans_BuyOneGetOneFree_CostsOneDollars()
        {
            //Arrange
            var beans = new Product
            {
                Name = "Bush's Baked Beans",
                Price = 1,
                Quantity = 2,
                Sale = SaleType.Bogo
            };

            _checkout.Products.Add(beans);

            //Act
            var total = _checkout.CalculateNetTotal();

            //Assert
            total.Should().Be(1);
        }
    }
}
