using System.Collections.Generic;
using System.Web.Http;

namespace AddionalController.Controller
{
    public class ValuesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<int> Get()
        {
            return new int[] {1, 2, 3};
        }
    }
}
