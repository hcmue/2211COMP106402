using DemoBuoi04.Models;

namespace DemoBuoi04.Repositories
{
    public interface ICategoryRepository
    {
        List<CategoryModel> GetAll();
        CategoryModel GetById(int id);
        CategoryModel GetByName(string name);
        int Add(CategoryModel model);
        bool Update(CategoryModel model);
        bool Remove(int id);
    }
}
