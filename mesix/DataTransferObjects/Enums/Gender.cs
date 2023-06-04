using DataTransferObjects.Attribute;
using System.Runtime.Serialization;

namespace DataTransferObjects.Enums
{
    [DataContractAttribute(Namespace = "DataTransferObjects.Attribute", Name = "Genders")]
    public enum Gender
    {
        [EnumMember]
        [StringValueAttributes("Male")]
        [DescriptionStringValueAttributes("Male")]
        Male = 1,

        [EnumMember]
        [StringValueAttributes("Female")]
        [DescriptionStringValueAttributes("Female")]
        Female = 2,

        [EnumMember]
        [StringValueAttributes("Others")]
        [DescriptionStringValueAttributes("Others")]
        Others = 3
    }
}
