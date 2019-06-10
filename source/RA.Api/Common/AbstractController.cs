using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RA.BusinessService.Common;
using RA.Kernel.Common;

namespace RA.Api.Common
{
    public class AbstractController<TEntity> : ControllerBase,  IController<TEntity>
        where TEntity : BaseEntity
    {
        private IBaseBusinessService<TEntity> _baseBusinessService { get; set; }

        public AbstractController(IBaseBusinessService<TEntity> baseBusinessService)
        {
            _baseBusinessService = baseBusinessService;
        }


        [HttpGet]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            return await Task.FromResult(_baseBusinessService.Get(id));
        }

        [HttpGet]
        public async Task<ActionResult<IList<TEntity>>> GetList()
        {
            return await Task.FromResult(_baseBusinessService.GetList().ToList());
        }

        [HttpPost]
        public async Task<ActionResult<TEntity>> Save(TEntity input)
        {
            return await Task.FromResult(_baseBusinessService.Save(input));
        }

        [HttpDelete]
        public async Task<ActionResult> Remove(int id)
        {
            _baseBusinessService.Remove(id);
            return await Task.FromResult(Ok());
        }

    }
}
