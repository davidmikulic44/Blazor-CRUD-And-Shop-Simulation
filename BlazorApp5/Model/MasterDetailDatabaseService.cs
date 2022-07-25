using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp5.Model
{
    public class MasterDetailDatabaseService : IMasterDetailDatabaseService
    {
        private MasterDetailDatabaseContext _context;
        public MasterDetailDatabaseService(MasterDetailDatabaseContext context)
        {
            _context = context;

        }

        public void DeleteProduct(int id)
        {
            try
            {
                Product product = _context.Products.Find(id);
                product.IsDeleted = true;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<ItemCart> GetItemCarts()
        {
            try
            {
                return _context.ItemCarts.ToList();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Cart> GetCarts()
        {
            try
            {
                return _context.Carts.ToList();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            try
            {
                return _context.Products.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void RestoreProduct(int id)
        {
            try
            {
                Product product = _context.Products.Find(id);
                product.IsDeleted = false;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void InsertProduct(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void InsertCart(Cart cart)
        {
            try
            {
                _context.Carts.Add(cart);
                _context.SaveChanges();
            }
            catch 
            {
                throw;
            }
        }

        public void InsertItemCart(ItemCart itemCart)
        {
            try
            {
                _context.ItemCarts.Add(itemCart);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }

        }

        public Product SingleProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Item SingleItem(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(int id, string Name, string Description, string Image, double Price)
        {
            try
            {
                Item item = _context.Items.Find(id);
                item.Name = Name;
                item.Description = Description;
                item.Image = Image;
                item.Price = Price;

                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateItemCart(int id, int quantity)
        {
            try
            {
                ItemCart itemCart = _context.ItemCarts.Find(id);
                itemCart.Quantity = quantity;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }


        public void UpdateCart(int id, double Cost) 
        {
            try
            {
                Cart cart = _context.Carts.Find(id);
                cart.TotalCost = Cost;

                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void PurchaseCart(Cart cart, string CurrentUserEmail)
        {
            try
            {
                int id = cart.Id;
                cart = _context.Carts.Find(id);
                cart.IsPaid = true;
                cart.DatePaid = DateTime.Today;
                cart.UserId = CurrentUserEmail;
                _context.SaveChanges();
            }
            catch 
            {
                throw;
            }
        }

        public void UpdateProduct(int id, string Name, string Description)
        {
            try
            {
                Product product = _context.Products.Find(id);
                product.ProductName = Name;
                product.ProductDescription = Description;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Item> GetItems()
        {
            try
            {
                return _context.Items.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void RestoreItem(int id)
        {
            try
            {
                Item item = _context.Items.Find(id);
                item.IsDeleted = false;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteItemCart(int id)
        {
            try 
            {
                ItemCart itemCart = _context.ItemCarts.Find(id);
                _context.ItemCarts.Remove(itemCart);
                _context.SaveChanges();
            }
            catch { throw; }
        }

        public void DeleteItem(int id)
        {
            try
            {
                Item item = _context.Items.Find(id);
                item.IsDeleted = true;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public void InsertItem(Item item)
        {
            try
            {
                _context.Items.Add(item);
                _context.SaveChanges();

            }
            catch
            {
                throw;
            }
        }

    }
}