﻿
namespace OpenConquer.Domain.Enums
{
    [Flags]
    public enum Effect1 : ulong
    {
        None = 0UL,
        BlueName = 1UL << 0,
        Poisoned = 1UL << 1,
        FullInvis = 1UL << 2,//(Full invisibility)
        Fade = 1UL << 3,
        StartXp = 1UL << 4,
        Ghost = 1UL << 5,
        TeamLeader = 1UL << 6,
        StarOfAccuracy = 1UL << 7,
        Shield = 1UL << 8,
        Stig = 1UL << 9,
        Dead = 1UL << 10,
        Invisible = 1UL << 11,// (DOES NOT REMOVE :S)
        Unknown12 = 1UL << 12,
        Unknown13 = 1UL << 13,
        RedName = 1UL << 14,
        BlackName = 1UL << 15,
        Unknown16 = 1UL << 16,
        Unknown17 = 1UL << 17,
        Superman = 1UL << 18,
        ReflecttypeThing = 1UL << 19,
        DifReflectThing = 1UL << 20,
        Unknown21 = 1UL << 21,
        PartiallyInvisible = 1UL << 22,
        Cyclone = 1UL << 23,
        Unknown24 = 1UL << 24,
        Unknown25 = 1UL << 25,
        Unknown26 = 1UL << 26,
        Fly = 1UL << 27,
        Unknown28 = 1UL << 28,
        Unknown29 = 1UL << 29,
        LuckyTime = 1UL << 30,
        Pray = 1UL << 31,
        Cursed = 1UL << 32,
        HeavenBless = 1UL << 33,
        TopGuild = 1UL << 34,
        TopDep = 1UL << 35,
        MonthPk = 1UL << 36,
        WeekPk = 1UL << 37,
        TopWarrior = 1UL << 38,
        TopTro = 1UL << 39,
        TopArcher = 1UL << 40,
        TopWater = 1UL << 41,
        TopFire = 1UL << 42,
        TopNinja = 1UL << 43,
        Unknown44 = 1UL << 44,
        Unknown45 = 1UL << 45,
        Vortex = 1UL << 46,
        FatalStrike = 1UL << 47,
        OrangeHaloGlow = 1UL << 48,
        Unknown49 = 1UL << 49,
        LowVigorUnableToJump = 1UL << 50,
        Riding = 1UL << 50,
        TopSpouse = 1UL << 51,
        SparkleHalo = 1UL << 52,
        NoPotion = 1UL << 53,
        Dazed = 1UL << 54,//no movement
        BlueRestoreAura = 1UL << 55,
        MoveSpeedRecovered = 1UL << 56,
        SuperShieldHalo = 1UL << 57,
        HUGEDazed = 1UL << 58,//no movement
        IceBlock = 1UL << 59, //no movement
        Confused = 1UL << 60,//reverses movement
        Unknown61 = 1UL << 61,
        Unknown62 = 1UL << 62,
        Unknown63 = 1UL << 63
    }

    [Flags]
    public enum Effect2 : ulong
    {
        None = 0UL,
        WeeklyTop8Pk = 1UL << 0,
        WeeklyTop2PkGold = 1UL << 1,
        WeeklyTop2PkBlue = 1UL << 2,
        MonthlyTop8Pk = 1UL << 3,
        MontlyTop2Pk = 1UL << 4,
        MontlyTop3Pk = 1UL << 5,
        Top8Fire = 1UL << 6,
        Top2Fire = 1UL << 7,
        Top3Fire = 1UL << 8,
        Top8Water = 1UL << 9,
        Top2Water = 1UL << 10,
        Top3Water = 1UL << 11,
        Top8Ninja = 1UL << 12,
        Top2Ninja = 1UL << 13,
        Top3Ninja = 1UL << 14,
        Top8Warrior = 1UL << 15,
        Top2Warrior = 1UL << 16,
        Top3Warrior = 1UL << 17,
        Top8Trojan = 1UL << 18,
        Top2Trojan = 1UL << 19,
        Top3Trojan = 1UL << 20,
        Top8Archer = 1UL << 21,
        Top2Archer = 1UL << 22,
        Top3Archer = 1UL << 23,
        Top3SpouseBlue = 1UL << 24,
        Top2SpouseBlue = 1UL << 25,
        Top3SpouseYellow = 1UL << 26,
        Contestant = 1UL << 27,
        ChainBoltActive = 1UL << 28,
        AzureShield = 1UL << 29,
        AzureShieldFade = 1UL << 30,
        CaryingFlag = 1UL << 31,//blank next one?
        Unknown32 = 1UL << 32,
        Unknown33 = 1UL << 33,
        TyrantAura = 1UL << 34,
        Unknown35 = 1UL << 35,
        FendAura = 1UL << 36,
        Unknown37 = 1UL << 37,
        MetalAura = 1UL << 38,
        Unknown39 = 1UL << 39,
        WoodAura = 1UL << 40,
        Unknown41 = 1UL << 41,
        WaterAura = 1UL << 42,
        Unknown43 = 1UL << 43,
        FireAura = 1UL << 44,
        Unknown45 = 1UL << 45,
        EarthAura = 1UL << 46,
        Shackled = 1UL << 47,
        Oblivion = 1UL << 48,
        Unknown49 = 1UL << 49,
        TopMonk = 1UL << 50,
        Top8Monk = 1UL << 51,
        Top2Monk = 1UL << 52,
        Top3Monk = 1UL << 53,
        Unknown54 = 1UL << 54,
        Unknown55 = 1UL << 55,
        Unknown56 = 1UL << 56,
        Unknown57 = 1UL << 57,
        Unknown58 = 1UL << 58,
        Unknown59 = 1UL << 59,
        Unknown60 = 1UL << 60,
        Unknown61 = 1UL << 61,
        Unknown62 = 1UL << 62,
        Unknown63 = 1UL << 63
    }
}
