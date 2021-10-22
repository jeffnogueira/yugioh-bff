namespace yugioh_bff.Entities
{
    public class CardTypeClass
    {
        private CardTypeClass(string value) { ValueCardType = value; }

        private string ValueCardType { get; set; }

        private static CardTypeClass EffectMonster { get { return new CardTypeClass("Effect Monster"); } }
        private static CardTypeClass FlipEffectMonster { get { return new CardTypeClass("Flip Effect Monster"); } }
        private static CardTypeClass FlipTunerEffectMonster { get { return new CardTypeClass("Flip Tuner Effect Monster"); } }
        private static CardTypeClass GeminiMonster { get { return new CardTypeClass("Gemini Monster"); } }
        private static CardTypeClass NormalMonster { get { return new CardTypeClass("Normal Monster"); } }
        private static CardTypeClass NormalTunerMonster { get { return new CardTypeClass("Normal Tuner Monster"); } }
        private static CardTypeClass PendulumEffectMonster { get { return new CardTypeClass("Pendulum Effect Monster"); } }
        private static CardTypeClass PendulumFlipEffectMonster { get { return new CardTypeClass("Pendulum Flip Effect Monster"); } }
        private static CardTypeClass PendulumNormalMonster { get { return new CardTypeClass("Pendulum Normal Monster"); } }
        private static CardTypeClass PendulumTunerEffectMonster { get { return new CardTypeClass("Pendulum Tuner Effect Monster"); } }
        private static CardTypeClass RitualEffectMonster { get { return new CardTypeClass("Ritual Effect Monster"); } }
        private static CardTypeClass RitualMonster { get { return new CardTypeClass("Ritual Monster"); } }
        private static CardTypeClass SkillCard { get { return new CardTypeClass("Skill Card"); } }
        private static CardTypeClass SpellCard { get { return new CardTypeClass("Spell Card"); } }
        private static CardTypeClass SpiritMonster { get { return new CardTypeClass("Spirit Monster"); } }
        private static CardTypeClass ToonMonster { get { return new CardTypeClass("Toon Monster"); } }
        private static CardTypeClass TrapCard { get { return new CardTypeClass("Trap Card"); } }
        private static CardTypeClass TunerMonster { get { return new CardTypeClass("Tuner Monster"); } }
        private static CardTypeClass UnionEffectMonster { get { return new CardTypeClass("Union Effect Monster"); } }
        private static CardTypeClass FusionMonster { get { return new CardTypeClass("Fusion Monster"); } }
        private static CardTypeClass LinkMonster { get { return new CardTypeClass("Link Monster"); } }
        private static CardTypeClass PendulumEffectFusionMonster { get { return new CardTypeClass("Pendulum Effect Fusion Monster"); } }
        private static CardTypeClass SynchroMonster { get { return new CardTypeClass("Synchro Monster"); } }
        private static CardTypeClass SynchroPendulumEffectMonster { get { return new CardTypeClass("Synchro Pendulum Effect Monster"); } }
        private static CardTypeClass SynchroTunerMonster { get { return new CardTypeClass("Synchro Tuner Monster"); } }
        private static CardTypeClass XYZMonster { get { return new CardTypeClass("XYZ Monster"); } }
        private static CardTypeClass XYZPendulumEffectMonster { get { return new CardTypeClass("XYZ Pendulum Effect Monster"); } }

    }
}
