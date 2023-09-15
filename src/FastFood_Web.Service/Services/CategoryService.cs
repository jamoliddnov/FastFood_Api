using FastFood_Web.DataAccess.Interfaces.Common;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Interfaces;
using FastFood_Web.Service.Interfaces.Common;
using FastFood_Web.Service.Services.Common.Utils;



namespace FastFood_Web.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthManager _authManager;
        private readonly IPaginatonService _paginatonService;

        public CategoryService(IUnitOfWork unitOfWork, IAuthManager authManager, IPaginatonService paginatonService)
        {
            _unitOfWork = unitOfWork;
            _authManager = authManager;
            _paginatonService = paginatonService;
        }

        public async Task<bool> CreateAsync(Category categoryFastFood)
        {
            try
            {
                var category = categoryFastFood;

                _unitOfWork.Categorys.Add(category);

                var result = await _unitOfWork.SaveChangeAsync();

                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(string id)
        {
            try
            {
                _unitOfWork.Categorys.Delete(id);

                var result = await _unitOfWork.SaveChangeAsync();

                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<Category>> GetAllAsync(PagenationParams @params)
        {
            try
            {
                var query = _unitOfWork.Categorys.GetAll();

                return await _paginatonService.ToPageAsync(query, @params.PageNumber, @params.PageSize);
            }
            catch
            {
                return null;
            }
        }

        public async Task<Category> GetByIdAsync(string id)
        {
            try
            {
                var category = await _unitOfWork.Categorys.FindByIdAsync(id);

                return category;
            }
            catch
            {
                return null;
            }
        }

        public async Task<bool> UpdateAsync(string id, Category categoryFastFood)
        {
            try
            {
                var category = categoryFastFood;

                _unitOfWork.Categorys.Update(category, id);

                var result = await _unitOfWork.SaveChangeAsync();

                return result > 0;

            }
            catch
            {
                return false;
            }
        }
    }
}
