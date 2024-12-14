using E_Commerce_Application.DataAccessLayer;
using E_Commerce_Application.Models;
using E_Commerce_Application.ViewModels;

namespace E_Commerce_Application.ServiceLayer
{
    public interface IProductService
    {
        public IEnumerable<Product> GetAll(string name, int page, int pageSize);
        public Product GetById(int id);
        public ResponseDto Add(ProductCreateDto productdto);
        public ProductUpdateDto UpdateById(ProductUpdateDto productupdatedto);
        public void DeleteById(int id);
    }
}
