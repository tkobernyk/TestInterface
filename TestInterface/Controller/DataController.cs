using System.Collections.Generic;
using System.Web.Http;
using TestInterface.Model;
using TestInterface.Interface;

namespace TestInterface.Controller
{
    public class DataController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<IUser> Get()
        {
            return new User[]
            {
               new User {Id = 1, FirstName = "Taras", LastName = "Kobernyk", Email = "taras.kobernyk@gmail.com" },
               new User {Id = 2, FirstName = "Taras1", LastName = "Kobernyk1", Email = "taras.kobernyk1@gmail.com" }
            };
        }

        // GET api/<controller>/5
        public IUser Get(int id)
        {
            return new User { Id = 1, FirstName = "Taras", LastName = "Kobernyk", Email = "taras.kobernyk@gmail.com" };
        }
    }
}