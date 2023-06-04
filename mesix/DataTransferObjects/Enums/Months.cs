using DataTransferObjects.Attribute;
using System.Runtime.Serialization;

namespace DataTransferObjects.Enums
{
    [DataContractAttribute(Namespace = "DataTransferObjects.Attribute", Name = "SysMonths")]
    public enum Months
    {
        [EnumMember]
        [StringValueAttributes("January")]
        [DescriptionStringValueAttributes("January")]
        JANUARY = 1,

        [EnumMember]
        [StringValueAttributes("FEB")]
        [DescriptionStringValueAttributes("FEB")]
        FEB = 2,

        [EnumMember]
        [StringValueAttributes("Teacher")]
        [DescriptionStringValueAttributes("Teacher")]
        Teacher = 3,

        [EnumMember]
        [StringValueAttributes("OtherStaff")]
        [DescriptionStringValueAttributes("OtherStaff")]
        OtherStaff = 4,
    }
}
