using UnityEngine;

/// The six circuits, as data. Quantities live here; WHERE anything sits comes from the
/// generator (rule C.11). Every row interval is multiplied by the row count below to give
/// the baseline run length, and all six are far longer than the review capture window
/// (rule C.5): the shortest, circuit six, still runs 76 s against 138 s of glide ember.
public static class _0x1ceaad4b
{
    /// Circuits one and two are open from the start, the rest need the one before cleared.
    public static readonly int[] UnlockAfter =
    {
        -1,
        -1,
        1,
        2,
        3,
        4
    };
    public static readonly string[] Names =
    {
        _0xfe5dfc36._0xc458978b(new byte[12] { 25, 17, 30, 25, 14, 124, 29, 15, 31, 25, 18, 8 }, 92),
        _0xfe5dfc36._0xc458978b(new byte[11] { 53, 61, 62, 54, 82, 33, 34, 59, 32, 55, 33 }, 114),
        _0xfe5dfc36._0xc458978b(new byte[10] { 75, 90, 94, 83, 63, 91, 77, 86, 89, 75 }, 31),
        _0xfe5dfc36._0xc458978b(new byte[11] { 9, 14, 21, 8, 23, 122, 12, 27, 15, 22, 14 }, 90),
        _0xfe5dfc36._0xc458978b(new byte[9] { 203, 217, 194, 207, 196, 170, 203, 216, 201 }, 138),
        _0xfe5dfc36._0xc458978b(new byte[17] { 2, 4, 13, 4, 18, 21, 8, 0, 13, 97, 2, 8, 19, 2, 20, 8, 21 }, 65)
    };
    /// How many of the three ember colours this circuit mixes.
    public static readonly int[] Colours =
    {
        2,
        2,
        3,
        3,
        3,
        3
    };
    public static bool Open(int _0x526ee1d4, int _0x971b83b1)
    {
        int _0x915091b9 = Clamp(_0x526ee1d4);
        int _0x02e5702f = UnlockAfter[_0x915091b9];
        if (_0x02e5702f < 0)
            return true;
        return (_0x971b83b1 & (1 << (_0x02e5702f - 1))) != 0;
    }

    public const int Count = 6;
    public static float Baseline(int _0xa1afd7c0)
    {
        int _0x39faa690 = Clamp(_0xa1afd7c0);
        return RowInterval[_0x39faa690] * Rows[_0x39faa690];
    }

    /// Seconds between two rows. Also the time the player has to pick a lane.
    public static readonly float[] RowInterval =
    {
        2.19f,
        2.01f,
        1.86f,
        1.73f,
        1.62f,
        1.52f
    };
    public static int Clamp(int _0xd97789af)
    {
        return Mathf.Clamp(_0xd97789af, 0, Count - 1);
    }

    public static string Objective(int _0xc192dbb1)
    {
        int _0xc2967eff = Clamp(_0xc192dbb1);
        return string.Format(_0xfe5dfc36._0xc458978b(new byte[44] { 136, 130, 153, 136, 158, 130, 159, 235, 176, 251, 182, 235, 230, 235, 176, 250, 182, 235, 140, 138, 159, 142, 152, 235, 230, 235, 128, 142, 142, 155, 235, 159, 131, 142, 235, 142, 134, 137, 142, 153, 235, 135, 130, 159 }, 203), _0xc2967eff + 1, Rows[_0xc2967eff]);
    }

    /// Chance a row carries an unstable crystal.
    public static readonly float[] CrystalChance =
    {
        0.10f,
        0.16f,
        0.21f,
        0.26f,
        0.30f,
        0.34f
    };
    /// Rows in the circuit before it is cleared.
    public static readonly int[] Rows =
    {
        40,
        42,
        44,
        46,
        48,
        50
    };
}

internal static class _0xfe5dfc36
{
    internal static string _0xc458978b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}