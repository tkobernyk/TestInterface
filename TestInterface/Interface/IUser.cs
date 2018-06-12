using System.Runtime.Serialization;
using System.Xml.Serialization;
using TestInterface.Model;

namespace TestInterface.Interface
{
    public interface IUser : IEntity
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
    }
}
