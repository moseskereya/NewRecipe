using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Stores.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.Models
{
    public class ShoppingCart
    {
        private readonly StoresContext _storesContext;
        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> shoppingCartItems { get; set; }

        private ShoppingCart(StoresContext storesContext)
        {
            _storesContext = storesContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<StoresContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Product product, int amount)
        {
            var shoppingCartItem =
                    _storesContext.ShoppingCartItems.SingleOrDefault(
                        s => s.product.Id == product.Id && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    product = product,
                    Amount = 1
                };
                _storesContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _storesContext.SaveChanges();
        }

        public int RemoveFromCart(Product product)
        {
            var shoppingCartItem =
                    _storesContext.ShoppingCartItems.SingleOrDefault(
                        s => s.product.Id == product.Id && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _storesContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _storesContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return shoppingCartItems ??
                   (shoppingCartItems =
                       _storesContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.product)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _storesContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _storesContext.ShoppingCartItems.RemoveRange(cartItems);

            _storesContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _storesContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.product.Price  *  c.Amount).Sum();
            return total;
        }
    }
}
