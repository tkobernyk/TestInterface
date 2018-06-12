using System;
using Newtonsoft.Json;
using System.Runtime.Serialization;

using TestInterface.Interface;

namespace TestInterface.Model
{
    [KnownType(typeof(User))]
    [DataContract(Name = "User", Namespace = "https://www.testinterface.com/namespace")]
    public class User : IUser
    {
        [DataMember(Name = "Id", Order = 1)]
        public int Id { get; set; }
        [JsonIgnore]
        public string CreateBy { get; set; }
        [JsonIgnore]
        public DateTime CreateOn { get; set; }
        [JsonIgnore]
        public string ModifiedBy { get; set; }
        [JsonIgnore]
        public DateTime ModifiedOn { get; set; }
        [DataMember(Name = "FirstName", Order = 2)]
        public string FirstName { get; set; }
        [DataMember(Name = "LastName" , Order = 3)]
        public string LastName { get; set; }
        [DataMember(Name = "Email", Order = 4)]
        public string Email { get; set; }
    }
}