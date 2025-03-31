using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Service_layer
{
    public interface ICategoryServieces
    {
        public List<CategoryModel> GetAll();

        public CategoryModel GetbyId(int Id);

        public void Create(CategoryModel category);

        public void Update(CategoryModel category);

        public void Delete(int Id);
    }
}
