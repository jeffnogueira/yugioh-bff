using System.Runtime.Serialization;

namespace yugioh_bff.Domain.Enums
{
    public enum CardType
    {
        [EnumMember(Value = "Effect Monster")]
        EffectMonsterd,
        [EnumMember(Value = "Flip Effect Monster")]
        FlipEffectMonsterd,
        [EnumMember(Value = "Flip Tuner Effect Monster")]
        FlipTunerEffectMonsterd,
        [EnumMember(Value = "Gemini Monster")]
        GeminiMonsterd,
        [EnumMember(Value = "Normal Monster")]
        NormalMonsterd,
        [EnumMember(Value = "Normal Tuner Monster")]
        NormalTunerMonsterd,
        [EnumMember(Value = "Pendulum Effect Monster")]
        PendulumEffectMonsterd,
        [EnumMember(Value = "Pendulum Flip Effect Monster")]
        PendulumFlipEffectMonsterd,
        [EnumMember(Value = "Pendulum Normal Monster")]
        PendulumNormalMonsterd,
        [EnumMember(Value = "Pendulum Tuner Effect Monster")]
        PendulumTunerEffectMonsterd,
        [EnumMember(Value = "Ritual Effect Monster")]
        RitualEffectMonsterd,
        [EnumMember(Value = "Ritual Monster")]
        RitualMonsterd,
        [EnumMember(Value = "Skill Card")]
        SkillCardd,
        [EnumMember(Value = "Spell Card")]
        SpellCardd,
        [EnumMember(Value = "Spirit Monster")]
        SpiritMonsterd,
        [EnumMember(Value = "Toon Monster")]
        ToonMonsterd,
        [EnumMember(Value = "Trap Card")]
        TrapCardd,
        [EnumMember(Value = "Tuner Monster")]
        TunerMonsterd,
        [EnumMember(Value = "Union Effect Monster")]
        UnionEffectMonsterd,
        [EnumMember(Value = "Fusion Monster")]
        FusionMonsterd,
        [EnumMember(Value = "Link Monster")]
        LinkMonsterd,
        [EnumMember(Value = "Pendulum Effect Fusion Monster")]
        PendulumEffectFusionMonsterd,
        [EnumMember(Value = "Synchro Monster")]
        SynchroMonsterd,
        [EnumMember(Value = "Synchro Pendulum Effect Monster")]
        SynchroPendulumEffectMonsterd,
        [EnumMember(Value = "Synchro Tuner Monster")]
        SynchroTunerMonsterd,
        [EnumMember(Value = "XYZ Monster")]
        XYZMonsterd,
        [EnumMember(Value = "XYZ Pendulum Effect Monster")]
        XYZPendulumEffectMonsterd,
    }
}
