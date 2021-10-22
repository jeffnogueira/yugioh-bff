using System.Runtime.Serialization;

namespace yugioh_bff.Enums
{
    public enum CardAttribute
    {
        [EnumMember(Value = "dark")]
        Dark,
        [EnumMember(Value = "divine")]
        Divine,
        [EnumMember(Value = "earth")]
        Earth,
        [EnumMember(Value = "fire")]
        Fire,
        [EnumMember(Value = "light")]
        Light,
        [EnumMember(Value = "water")]
        Water,
        [EnumMember(Value = "wind")]
        Wind,
    }
}
