using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.System.Roles
{
    public interface IRoleService
    {
        Task<List<RoleVm>> GetAll();
    }
}