using DataTransferObjects.Attribute;
using System.Runtime.Serialization;

namespace DataTransferObjects.Enums
{
    [DataContractAttribute(Namespace = "DataTransferObjects.Attribute", Name = "BloodGroup")]
    public enum BloodGroup
    {
        [EnumMember]
        [StringValueAttributes("A+")]
        [DescriptionStringValueAttributes("A+")]
        Apos = 1,

        [EnumMember]
        [StringValueAttributes("A-")]
        [DescriptionStringValueAttributes("A-")]
        Aneg = 2,

        [EnumMember]
        [StringValueAttributes("B+")]
        [DescriptionStringValueAttributes("B+")]
        Bpos = 3,

        [EnumMember]
        [StringValueAttributes("B-")]
        [DescriptionStringValueAttributes("B-")]
        Bneg = 4,

        [EnumMember]
        [StringValueAttributes("O+")]
        [DescriptionStringValueAttributes("O+")]
        Opos = 5,

        [EnumMember]
        [StringValueAttributes("O-")]
        [DescriptionStringValueAttributes("O-")]
        Oneg = 6,

        [EnumMember]
        [StringValueAttributes("AB+")]
        [DescriptionStringValueAttributes("AB+")]
        ABpos = 7,

        [EnumMember]
        [StringValueAttributes("AB-")]
        [DescriptionStringValueAttributes("AB-")]
        ABneg = 8
    }
}
