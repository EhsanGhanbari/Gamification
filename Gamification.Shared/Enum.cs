using System;

namespace Gamification.Shared
{
    [Flags]
    public enum UserLevel
    {
        One = 1,
        Two = 2,
        Three = 4
    }

    [Flags]
    public enum BillType
    {
        Water = 1,
        Power = 2,
        Gas = 4,
        Phone = 8,
        Mobile = 9
    }

    [Flags]
    public enum ChargeType
    {
        Irancell = 1,
        Mci = 2,
        Rightel = 4
    }

    [Flags]
    public enum CardType
    {

    }
}
