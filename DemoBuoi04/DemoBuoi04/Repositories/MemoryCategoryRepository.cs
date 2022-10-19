using DemoBuoi04.Models;

namespace DemoBuoi04.Repositories
{
    public class MemoryCategoryRepository : ICategoryRepository
    {
        static List<CategoryModel> categories = new List<CategoryModel> {
            new CategoryModel{Id = 1, Name = "Laptop"},
            new CategoryModel{Id = 2, Name = "Tablet"},
            new CategoryModel{Id = 3, Name = "Phone"}
        };

        public List<CategoryModel> GetAll()
        {
            return categories;
        }

        public int Add(CategoryModel model)
        {
            throw new NotImplementedException();
        }

        

        public CategoryModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryModel GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CategoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
