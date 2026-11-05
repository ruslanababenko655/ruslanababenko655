using UnityEngine;

/// Everything the player keeps between runs. PlayerPrefs only - this game opens no socket,
/// has no account and talks to no service. Shards live in the template's own coin counter
/// so there is exactly one currency on screen.
public static class _0x1b98df55
{
    public static int _0x7c0b9cbe
    {
        get
        {
            return PlayerPrefs.GetInt(KeyAttempt, 0);
        }
    }

    private static readonly string KeyAttempt = _0xff8d621a._0x2e955770(new byte[11] { 119, 96, 112, 76, 114, 103, 103, 118, 126, 99, 103 }, 19);
    public static int _0xa315e49a
    {
        get
        {
            return PlayerPrefs.GetInt(KeyTrails, 3);
        }
    }

    public static int ShardsFor(int _0x38b151bb)
    {
        return Mathf.Max(0, _0x38b151bb / 20);
    }

    public static bool _0xb7531c9e
    {
        get
        {
            return PlayerPrefs.GetInt(KeyHaptics, 1) == 1;
        }
    }

    public static int _0x21bcf3a2
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(KeyTrail, 0), 0, _0x687afa6e.TrailTints.Length - 1);
        }
    }

    private static void Save()
    {
        try
        {
            PlayerPrefs.Save();
        }
        catch (System.Exception)
        {
            LastWriteFailed = true;
        }
    }

    private static readonly string KeyTrails = _0xff8d621a._0x2e955770(new byte[14] { 79, 88, 72, 116, 95, 89, 74, 66, 71, 116, 70, 74, 88, 64 }, 43);
    public static int _0xfaa47fb8
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBestScore, 0);
        }
    }

    public static int _0x54309030
    {
        get
        {
            return _0x038ba1ae._0xb2212895._0x41daa88c;
        }
    }

    public static bool TrailOpen(int _0x7cbd2bb1)
    {
        int _0x24476c3e = Mathf.Clamp(_0x7cbd2bb1, 0, _0x687afa6e.TrailTints.Length - 1);
        return (_0xa315e49a & (1 << _0x24476c3e)) != 0 || _0x687afa6e.TrailCost[_0x24476c3e] <= 0;
    }

    /// Set when a write throws, so the menu can raise the notice chip instead of failing
    /// silently.
    public static bool LastWriteFailed;
    public static void ChooseTrail(int _0x4e28afba)
    {
        Write(KeyTrail, Mathf.Clamp(_0x4e28afba, 0, _0x687afa6e.TrailTints.Length - 1));
    }

    /// Spend shards on a trail. Returns how many are still missing, 0 when it unlocked.
    public static int BuyTrail(int _0x3404b32f)
    {
        int _0x04871d3c = Mathf.Clamp(_0x3404b32f, 0, _0x687afa6e.TrailTints.Length - 1);
        if (TrailOpen(_0x04871d3c))
            return 0;
        int _0xed1dde42 = _0x687afa6e.TrailCost[_0x04871d3c];
        int _0x93739566 = _0x54309030;
        if (_0x93739566 < _0xed1dde42)
            return _0xed1dde42 - _0x93739566;
        _0x038ba1ae._0xb2212895._0x41daa88c = _0x93739566 - _0xed1dde42;
        Write(KeyTrails, _0xa315e49a | (1 << _0x04871d3c));
        ChooseTrail(_0x04871d3c);
        return 0;
    }

    private static void Write(string _0x664e55ae, int _0xd5865e63)
    {
        try
        {
            PlayerPrefs.SetInt(_0x664e55ae, _0xd5865e63);
            LastWriteFailed = false;
        }
        catch (System.Exception)
        {
            LastWriteFailed = true;
        }
    }

    private static readonly string KeyCleared = _0xff8d621a._0x2e955770(new byte[16] { 11, 28, 12, 48, 12, 3, 10, 14, 29, 10, 11, 48, 2, 14, 28, 4 }, 111);
    public static void SetHaptics(bool _0x8585f29d)
    {
        Write(KeyHaptics, _0x8585f29d ? 1 : 0);
    }

    public static int _0x4754588a
    {
        get
        {
            return PlayerPrefs.GetInt(KeyCleared, 0);
        }
    }

    public static bool CircuitOpen(int _0x80973f98)
    {
        return _0x1ceaad4b.Open(_0x80973f98, _0x4754588a);
    }

    public static void Wipe()
    {
        try
        {
            PlayerPrefs.DeleteKey(KeyBestCombo);
            PlayerPrefs.DeleteKey(KeyBestScore);
            PlayerPrefs.DeleteKey(KeyCleared);
            PlayerPrefs.DeleteKey(KeyTrails);
            PlayerPrefs.DeleteKey(KeyTrail);
            PlayerPrefs.DeleteKey(KeyCircuit);
            PlayerPrefs.DeleteKey(KeyAttempt);
            _0x038ba1ae._0xb2212895._0x41daa88c = 0;
            PlayerPrefs.Save();
            LastWriteFailed = false;
        }
        catch (System.Exception)
        {
            LastWriteFailed = true;
        }
    }

    public static void SetCalmMotion(bool _0xcc4d3c1e)
    {
        Write(KeyCalm, _0xcc4d3c1e ? 1 : 0);
    }

    private static readonly string KeyBestScore = _0xff8d621a._0x2e955770(new byte[14] { 55, 32, 48, 12, 49, 54, 32, 39, 12, 32, 48, 60, 33, 54 }, 83);
    private static readonly string KeyCircuit = _0xff8d621a._0x2e955770(new byte[11] { 26, 13, 29, 33, 29, 23, 12, 29, 11, 23, 10 }, 126);
    private static readonly string KeyCalm = _0xff8d621a._0x2e955770(new byte[8] { 2, 21, 5, 57, 5, 7, 10, 11 }, 102);
    public static void SetGlow(int _0x15a8f7c1)
    {
        Write(KeyGlow, Mathf.Clamp(_0x15a8f7c1, 0, 2));
    }

    private static readonly string KeyGlow = _0xff8d621a._0x2e955770(new byte[8] { 202, 221, 205, 241, 201, 194, 193, 217 }, 174);
    public static bool _0xb9c0d93b
    {
        get
        {
            return PlayerPrefs.GetInt(KeyCalm, 0) == 1;
        }
    }

    /// Bank the result of a run and bump the attempt counter, which seeds the next circuit.
    public static void Bank(int _0xd4c4bfc7, int _0xc4159da8, int _0x21ad4c80, bool _0xa8416905)
    {
        int _0x7c36b9a8 = _0x1ceaad4b.Clamp(_0xd4c4bfc7);
        Write(KeyAttempt, _0x7c0b9cbe + 1);
        if (_0x21ad4c80 > _0xb6b09ccc)
            Write(KeyBestCombo, _0x21ad4c80);
        if (_0xc4159da8 > _0xfaa47fb8)
            Write(KeyBestScore, _0xc4159da8);
        if (_0xa8416905)
            Write(KeyCleared, _0x4754588a | (1 << _0x7c36b9a8));
        int _0xb4c45835 = Mathf.Max(0, _0xc4159da8 / 20);
        if (_0xb4c45835 > 0)
            _0x038ba1ae._0xb2212895._0x41daa88c = _0x54309030 + _0xb4c45835;
        Save();
    }

    private static readonly string KeyTrail = _0xff8d621a._0x2e955770(new byte[9] { 243, 228, 244, 200, 227, 229, 246, 254, 251 }, 151);
    public static int _0x8aff4184
    {
        get
        {
            return Mathf.Clamp(PlayerPrefs.GetInt(KeyGlow, 1), 0, 2);
        }
    }

    public static int _0xb6b09ccc
    {
        get
        {
            return PlayerPrefs.GetInt(KeyBestCombo, 0);
        }
    }

    private static readonly string KeyBestCombo = _0xff8d621a._0x2e955770(new byte[14] { 43, 60, 44, 16, 45, 42, 60, 59, 16, 44, 32, 34, 45, 32 }, 79);
    private static readonly string KeyHaptics = _0xff8d621a._0x2e955770(new byte[11] { 186, 173, 189, 129, 182, 191, 174, 170, 183, 189, 173 }, 222);
    public static int _0xd4859787
    {
        get
        {
            return _0x1ceaad4b.Clamp(PlayerPrefs.GetInt(KeyCircuit, 0));
        }
    }

    public static void ChooseCircuit(int _0x0cba539f)
    {
        Write(KeyCircuit, _0x1ceaad4b.Clamp(_0x0cba539f));
    }
}

internal static class _0xff8d621a
{
    internal static string _0x2e955770(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}