using Dal_Layer;
using Dal_Layer.DBContext;
using Repo_Layer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_Layer.Implimentations
{
    public class CategoryRepo : ICategoryRepo
    {

        ApplicationDbContext _dbContext;
        public CategoryRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var remove = _dbContext.Categories.Find(Id);

            if(remove != null)
            {
                _dbContext.Categories.Remove(remove);
                _dbContext.SaveChanges();
            }
        }

        public List<Category> GetAll()
        {
            return _dbContext.Categories.ToList();
        }

        public Category GetbyId(int Id)
        {
            var GetID = _dbContext.Categories.Find(Id);
            if(GetID != null)
            {
                return GetID;
            }
            return null;
        }

        public void Update(Category category)
        {
            var ExistingData = _dbContext.Categories.Find(category);
            
        }
    }
}
