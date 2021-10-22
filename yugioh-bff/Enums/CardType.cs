﻿using System.Runtime.Serialization;

namespace yugioh_bff.Enums
{
    public enum CardType
    {
        [EnumMember(Value = "Effect Monster")]
        EffectMonster,
        [EnumMember(Value = "Flip Effect Monster")]
        FlipEffectMonster,
        [EnumMember(Value = "Flip Tuner Effect Monster")]
        FlipTunerEffectMonster,
        [EnumMember(Value = "Gemini Monster")]
        GeminiMonster,
        [EnumMember(Value = "Normal Monster")]
        NormalMonster,
        [EnumMember(Value = "Normal Tuner Monster")]
        NormalTunerMonster,
        [EnumMember(Value = "Pendulum Effect Monster")]
        PendulumEffectMonster,
        [EnumMember(Value = "Pendulum Flip Effect Monster")]
        PendulumFlipEffectMonster,
        [EnumMember(Value = "Pendulum Normal Monster")]
        PendulumNormalMonster,
        [EnumMember(Value = "Pendulum Tuner Effect Monster")]
        PendulumTunerEffectMonster,
        [EnumMember(Value = "Ritual Effect Monster")]
        RitualEffectMonster,
        [EnumMember(Value = "Ritual Monster")]
        RitualMonster,
        [EnumMember(Value = "Skill Card")]
        SkillCard,
        [EnumMember(Value = "Spell Card")]
        SpellCard,
        [EnumMember(Value = "Spirit Monster")]
        SpiritMonster,
        [EnumMember(Value = "Toon Monster")]
        ToonMonster,
        [EnumMember(Value = "Trap Card")]
        TrapCard,
        [EnumMember(Value = "Tuner Monster")]
        TunerMonster,
        [EnumMember(Value = "Union Effect Monster")]
        UnionEffectMonster,
        [EnumMember(Value = "Fusion Monster")]
        FusionMonster,
        [EnumMember(Value = "Link Monster")]
        LinkMonster,
        [EnumMember(Value = "Pendulum Effect Fusion Monster")]
        PendulumEffectFusionMonster,
        [EnumMember(Value = "Synchro Monster")]
        SynchroMonster,
        [EnumMember(Value = "Synchro Pendulum Effect Monster")]
        SynchroPendulumEffectMonster,
        [EnumMember(Value = "Synchro Tuner Monster")]
        SynchroTunerMonster,
        [EnumMember(Value = "XYZ Monster")]
        XYZMonster,
        [EnumMember(Value = "XYZ Pendulum Effect Monster")]
        XYZPendulumEffectMonster,
    }
}
