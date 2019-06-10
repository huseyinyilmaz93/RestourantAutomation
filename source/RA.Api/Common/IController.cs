using Microsoft.AspNetCore.Mvc;
using RA.Kernel.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RA.Api.Common
{
    public interface IController<TEntity>
        where TEntity : BaseEntity
    {
        Task<ActionResult<TEntity>> Get(int id);

        Task<ActionResult<IList<TEntity>>> GetList();

        Task<ActionResult<TEntity>> Save(TEntity input);

        Task<ActionResult> Remove(int id);
    }
}
