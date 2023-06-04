using DataTransferObjects.Attribute;
using System.Runtime.Serialization;

namespace DataTransferObjects
{
    [DataContractAttribute(Namespace = "DataTransferObjects.Attribute", Name = "SysRoles")]
    public enum SystemRole
    {
        [EnumMember]
        [StringValueAttributes("Admin")]
        [DescriptionStringValueAttributes("Admin")]
        ADMIN = 1,

        [EnumMember]
        [StringValueAttributes("Student")]
        [DescriptionStringValueAttributes("Student")]
        Student = 2,

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
