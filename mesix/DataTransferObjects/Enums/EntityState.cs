using DataTransferObjects.Attribute;
using System.Runtime.Serialization;

namespace DataTransferObjects.Enums
{
    [DataContractAttribute(Namespace = "DataTransferObjects.Attribute", Name = "EntityState")]
    public enum EntityState
    {
        [EnumMember]
        [StringValueAttributes("Added")]
        [DescriptionStringValueAttributes("Added")]
        Added = 1,

        [EnumMember]
        [StringValueAttributes("Deleted")]
        [DescriptionStringValueAttributes("Deleted")]
        Deleted = 2,

        [EnumMember]
        [StringValueAttributes("Modified")]
        [DescriptionStringValueAttributes("Modified")]
        Modified = 3,

        [EnumMember]
        [StringValueAttributes("Unchanged")]
        [DescriptionStringValueAttributes("Unchanged")]
        Unchanged = 0
    }
}
