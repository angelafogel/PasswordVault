using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVaultTests
{
    public class Product
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string MasterPassword { get; set; }
        public string UserEmail { get; set; }
        public string PasswordHint { get; set; }
    }

    public interface IProductRepository
    {
        IList<Product> FindAll();
        Product FindByUserId(int userid);
        Product FindByUserName(string username);
        Product FindByUserEmail(string email);
        bool Save(Product target);
    }
}
