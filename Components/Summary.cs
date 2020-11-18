using Microsoft.AspNetCore.Mvc;
using Stores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stores.Components
{
    public class Summary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public Summary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }


        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.shoppingCartItems = items;

            var shoppingCartModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartModel);
        }
      }
 }