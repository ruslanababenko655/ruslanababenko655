using UnityEngine;

/// Proves a generated circuit is flyable BEFORE it is shown (rule C.11, point 2). Two
/// simulations, both over the shipped numbers:
///   - a greedy pilot that always takes a matching gate when one is reachable. Its ember
///     must never fall to zero and must end above a quarter.
///   - a pilot that never touches the screen. Glide keeps a mismatch free, so the only
///     question is whether the circuit outlasts the glide burn - the review capture needs
///     live gameplay at second 30, not a result card (rule C.5).
/// A draw that fails either is regenerated; after the retry budget the hand-written
/// circuit takes over, as a floor and never as the game.
public static class _0x4e8af039
{
    public const float MatchGain = 8f;
    public const int MaxAttempts = 20;
    public const float MinEndingEmber = 25f;
    public static bool GreedySurvives(_0xf97a39f6[] _0x44f02f22, int _0xb5352330)
    {
        int _0xd71fb56a = _0x1ceaad4b.Clamp(_0xb5352330);
        float _0x3f8deb1e = _0x1ceaad4b.RowInterval[_0xd71fb56a];
        int _0xb24c465a = Mathf.Clamp(_0x1ceaad4b.Colours[_0xd71fb56a], 2, 3);
        float _0x756d7844 = Capacity;
        int _0x8e41faf9 = 1;
        int _0x7f7c0dd9 = 0;
        for (int _0xef399151 = 0; _0xef399151 < _0x44f02f22.Length; _0xef399151++)
        {
            _0xf97a39f6 _0xc12081c5 = _0x44f02f22[_0xef399151]._0xf083ef89();
            _0xc12081c5._0x4cc14f92(_0x8e41faf9);
            _0x756d7844 -= BurnPerSecond * _0x3f8deb1e;
            int _0x5d0a0a7b = _0xc12081c5._0x8049ebdb(_0x7f7c0dd9);
            if (_0x5d0a0a7b >= 0)
            {
                _0x8e41faf9 = _0x5d0a0a7b;
                _0x756d7844 = Mathf.Min(Capacity, _0x756d7844 + MatchGain);
                _0x7f7c0dd9 = (_0x7f7c0dd9 + 1) % _0xb24c465a;
            }
            else
            {
                int _0xc4df9233 = -1;
                for (int _0x06b2d451 = 0; _0x06b2d451 < 3; _0x06b2d451++)
                    if (_0xc12081c5.Gate[_0x06b2d451] >= 0 && _0xc12081c5.Barrier != _0x06b2d451)
                    {
                        _0xc4df9233 = _0x06b2d451;
                        break;
                    }

                if (_0xc4df9233 < 0)
                    return false;
                _0x8e41faf9 = _0xc4df9233;
                _0x756d7844 -= MismatchCost;
            }

            if (_0xc12081c5.Mote == _0x8e41faf9)
                _0x756d7844 = Mathf.Min(Capacity, _0x756d7844 + MoteGain);
            if (_0xc12081c5.Barrier == _0x8e41faf9)
                _0x756d7844 -= CrystalCost;
            if (_0x756d7844 <= 0f)
                return false;
        }

        return _0x756d7844 >= MinEndingEmber;
    }

    /// Pick a circuit for this attempt: generate, verify, retry, else fall back.
    public static _0xf97a39f6[] Resolve(int _0x6d163b2f, int _0x0b13b280)
    {
        int _0x00b64f36 = _0x1ceaad4b.Clamp(_0x6d163b2f);
        for (int _0x0c2e67a6 = 0; _0x0c2e67a6 < MaxAttempts; _0x0c2e67a6++)
        {
            int _0xa09f6acd = _0x3ad1a5c4.SeedFor(_0x00b64f36, _0x0b13b280 * MaxAttempts + _0x0c2e67a6);
            System.Random _0xffe7a03c = new System.Random(_0xa09f6acd);
            _0xf97a39f6[] _0xd238d7f1 = _0x3ad1a5c4.Build(_0x00b64f36, _0xffe7a03c);
            if (GreedySurvives(_0xd238d7f1, _0x00b64f36) && PassiveSurvives(_0xd238d7f1, _0x00b64f36))
            {
                {
#if B_LOGS
                    {
                        Debug.Log(string.Format(_0x17f28eee._0x908b445b(new byte[49] { 193, 249, 243, 232, 249, 239, 243, 238, 199, 186, 243, 244, 254, 255, 226, 167, 225, 170, 231, 186, 251, 238, 238, 255, 247, 234, 238, 167, 225, 171, 231, 186, 233, 255, 255, 254, 167, 225, 168, 231, 186, 232, 245, 237, 233, 167, 225, 169, 231 }, 154), _0x00b64f36, _0x0b13b280, _0xa09f6acd, _0xd238d7f1.Length));
                    }
#endif
                }

                return _0xd238d7f1;
            }
        }

        {
#if B_LOGS
            {
                Debug.Log(string.Format(_0x17f28eee._0x908b445b(new byte[68] { 14, 54, 60, 39, 54, 32, 60, 33, 8, 117, 60, 59, 49, 48, 45, 104, 46, 101, 40, 117, 52, 33, 33, 48, 56, 37, 33, 104, 46, 100, 40, 117, 51, 48, 57, 57, 117, 55, 52, 54, 62, 117, 33, 58, 117, 33, 61, 48, 117, 61, 52, 59, 49, 120, 34, 39, 60, 33, 33, 48, 59, 117, 57, 52, 44, 58, 32, 33 }, 85), _0x00b64f36, _0x0b13b280));
            }
#endif
        }

        return _0xdf57a9d1.Circuit(_0x00b64f36);
    }

    public const float Capacity = 100f;
    public const float GlideBurnPerSecond = 0.72f;
    /// The pilot who never touches the screen. Glide makes a mismatch free and the spawn
    /// guard keeps crystals out of the lane it sits in, so this is purely "does the ember
    /// outlast the circuit".
    public static bool PassiveSurvives(_0xf97a39f6[] _0x2cf829b0, int _0xcb1c7d2e)
    {
        int _0x227dcf23 = _0x1ceaad4b.Clamp(_0xcb1c7d2e);
        float _0x789b040b = _0x1ceaad4b.RowInterval[_0x227dcf23];
        float _0x381d583e = Capacity;
        int _0x37c7b15b = 1;
        for (int _0xd79570dc = 0; _0xd79570dc < _0x2cf829b0.Length; _0xd79570dc++)
        {
            _0xf97a39f6 _0x35b399a2 = _0x2cf829b0[_0xd79570dc]._0xf083ef89();
            _0x35b399a2._0x4cc14f92(_0x37c7b15b);
            _0x381d583e -= GlideBurnPerSecond * _0x789b040b;
            if (_0x35b399a2.Mote == _0x37c7b15b)
                _0x381d583e = Mathf.Min(Capacity, _0x381d583e + MoteGain);
            if (_0x381d583e <= 0f)
                return false;
        }

        return true;
    }

    public const float CrystalCost = 18f;
    public const float BurnPerSecond = 1.2f;
    public const float MismatchCost = 4f;
    public const float MoteGain = 4f;
}

internal static class _0x17f28eee
{
    internal static string _0x908b445b(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}