using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace TestInterface.Interface
{
    public interface IEntity
    {
        int Id { get; set; }
        string CreateBy { get; set; }
        DateTime CreateOn { get; set; }
        string ModifiedBy { get; set; }
        DateTime ModifiedOn { get; set; }
    }
}
