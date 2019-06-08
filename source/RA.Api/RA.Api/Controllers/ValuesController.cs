using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RA.Api.Common;
using RA.Api.Interfaces;
using RA.BusinessService.Interfaces;
using RA.IoC.Container;
using RA.Kernel.DtoObjects;

namespace RA.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : AbstractController<OrderDto>, IOrderController
    {
        public ValuesController(IOrderBusinessService orderBusinessService) : base(orderBusinessService)
        {

            IOrderBusinessService orderBusinessSasdce = IoCHelper.Resolve<IOrderBusinessService>();
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
