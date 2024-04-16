using Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoryDTO>> GetAllAsync();
        Task<CategoryDTO?> GetByIdAsync(int id);
        Task CreateAsync(CreateCategoryDTO createCategoryDTO);
        Task DeleteCategoryByIDAsync(int id);
        Task EditAsync(EditCategoryDTO editCategoryDTO);
    }
}
