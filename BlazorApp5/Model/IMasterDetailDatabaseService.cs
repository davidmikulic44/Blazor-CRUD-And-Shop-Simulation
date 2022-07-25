using Microsoft.AspNetCore.Builder;

namespace BlazorApp5.Model
{
    interface IMasterDetailDatabaseService
    {
        IEnumerable<Product> GetProducts();
        void InsertProduct(Product product);
        void UpdateProduct(int id, string Name, string Descripiton);
        Product SingleProduct(int id);
        void DeleteProduct(int id);
        void RestoreProduct(int id);

        IEnumerable<Item> GetItems();
        void DeleteItem(int id);
        void RestoreItem(int id);
        void UpdateItem(int id, string Name, string Description, string Image, double Price);
        void InsertItem(Item item);
        Item SingleItem(int id);

        IEnumerable<ItemCart> GetItemCarts();
        IEnumerable<Cart> GetCarts();
        public void InsertItemCart(ItemCart itemCart);
        public void InsertCart(Cart cart);
        void UpdateCart(int id, double Cost);
        void PurchaseCart(Cart cart, string CurrentUserEmail);
        void DeleteItemCart(int id);
        public void UpdateItemCart(int id, int quantity);
    }
}
