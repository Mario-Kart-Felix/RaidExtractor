﻿namespace RaidExtractor.Native
{
    public enum ArtifactSetKindId : int
    {
        None = 0,
        Hp = 1,
        AttackPower = 2,
        Defense = 3,
        AttackSpeed = 4,
        CriticalChance = 5,
        CriticalDamage = 6,
        Accuracy = 7,
        Resistance = 8,
        LifeDrain = 9,
        DamageIncreaseOnHpDecrease = 10,
        SleepChance = 11,
        BlockHealChance = 12,
        FreezeRateOnDamageReceived = 13,
        Stamina = 14,
        Heal = 15,
        BlockDebuff = 16,
        Shield = 17,
        GetExtraTurn = 18,
        IgnoreDefense = 19,
        DecreaseMaxHp = 20,
        StunChance = 21,
        DotRate = 22,
        ProvokeChance = 23,
        Counterattack = 24,
        CounterattackOnCrit = 25,
        AoeDamageDecrease = 26,
        CooldownReductionChance = 27,
        CriticalHealMultiplier = 28,
        AttackPowerAndIgnoreDefense = 29,
        HpAndHeal = 30,
        ShieldAndAttackPower = 31,
        ShieldAndCriticalChance = 32,
        ShieldAndHp = 33,
        ShieldAndSpeed = 34,
        UnkillableAndSpdAndCrDmg = 35,
        BlockReflectDebuffAndHpAndDef = 36,
        HpAndDefence = 37,
        AccuracyAndSpeed = 38,
        CritDmgAndTransformWeekIntoCritHit = 39,
        ResistanceAndBlockDebuff = 40,
        AttackAndCritRate = 41,
        FreezeResistAndRate = 42,
        IgnoreCooldown = 1000,
        RemoveDebuff = 1001,
    }
}
