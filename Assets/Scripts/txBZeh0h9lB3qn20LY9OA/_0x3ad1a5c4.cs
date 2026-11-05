using UnityEngine;

/// Builds a circuit from a seed. Nothing here is written out by hand: the gate colours,
/// the crystal lanes, the motes and the exact row count all come from System.Random, so no
/// two attempts look alike (rule C.11). UnityEngine.Random is deliberately not used - it
/// carries global state that other systems would disturb.
public static class _0x3ad1a5c4
{
    public static int SeedFor(int _0xef314922, int _0x116f280e)
    {
        return (_0xef314922 * 7919) ^ (_0x116f280e * 104729);
    }

    public static _0xf97a39f6[] Build(int _0x1664d263, System.Random _0xdb18f30e)
    {
        int _0xdae384f0 = _0x1ceaad4b.Clamp(_0x1664d263);
        int _0x95d03e75 = Mathf.Clamp(_0x1ceaad4b.Colours[_0xdae384f0], 2, 3);
        int _0x4bae9204 = _0x1ceaad4b.Rows[_0xdae384f0];
        int _0x39e224e8 = Mathf.Max(12, _0x4bae9204 + _0xdb18f30e.Next(-3, 4));
        float _0xa3a156f6 = _0x1ceaad4b.CrystalChance[_0xdae384f0];
        _0xf97a39f6[] _0x1f53dfab = new _0xf97a39f6[_0x39e224e8];
        int _0xe6de2cd6 = -1;
        int _0x4398068f = 0;
        for (int _0x10fac097 = 0; _0x10fac097 < _0x39e224e8; _0x10fac097++)
        {
            bool _0x5e6367fe = _0x10fac097 >= 5 && _0xdb18f30e.NextDouble() < _0xa3a156f6;
            int _0x9bf6f9f7 = _0x5e6367fe ? _0xdb18f30e.Next(0, 3) : -1;
            int[] _0xdd7c7004 =
            {
                -1,
                -1,
                -1
            };
            for (int _0x1fb8aa87 = 0; _0x1fb8aa87 < 3; _0x1fb8aa87++)
            {
                if (_0x1fb8aa87 == _0x9bf6f9f7)
                    continue;
                _0xdd7c7004[_0x1fb8aa87] = _0xdb18f30e.Next(0, _0x95d03e75);
            }

            int _0x612d0596 = _0x9bf6f9f7;
            if (_0x612d0596 >= 0 && _0x612d0596 == _0xe6de2cd6 && _0x4398068f >= 2)
            {
                // Three rows of crystal in one lane reads as a wall, not a circuit.
                _0x612d0596 = -1;
                _0xdd7c7004[_0x9bf6f9f7] = _0xdb18f30e.Next(0, _0x95d03e75);
            }

            if (_0x612d0596 >= 0 && _0x612d0596 == _0xe6de2cd6)
                _0x4398068f++;
            else
                _0x4398068f = _0x612d0596 >= 0 ? 1 : 0;
            _0xe6de2cd6 = _0x612d0596;
            int _0xe59d1c92 = -1;
            if (_0xdb18f30e.NextDouble() < 0.26)
            {
                int _0xa15827ad = _0xdb18f30e.Next(0, 3);
                if (_0xa15827ad != _0x612d0596)
                    _0xe59d1c92 = _0xa15827ad;
            }

            _0x1f53dfab[_0x10fac097] = new _0xf97a39f6()._0xc8350f76(_0xdd7c7004[0], _0xdd7c7004[1], _0xdd7c7004[2], _0x612d0596, _0xe59d1c92);
        }

        Repair(_0x1f53dfab, _0x95d03e75, _0xdb18f30e);
        return _0x1f53dfab;
    }

    /// Force the window rule: inside every ColourWindow rows each palette colour must sit in
    /// a lane the dragon can actually reach. Done as a repair pass rather than by rejection
    /// so the generator never dead-ends on a stubborn draw.
    private static void Repair(_0xf97a39f6[] _0x7cc051e9, int _0xe1a80a13, System.Random _0xda8b1bcf)
    {
        for (int _0x0272dad8 = 0; _0x0272dad8 < _0xe1a80a13; _0x0272dad8++)
        {
            int _0x0e0d32a5 = 0;
            for (int _0x29bacbb9 = 0; _0x29bacbb9 < _0x7cc051e9.Length; _0x29bacbb9++)
            {
                if (_0x7cc051e9[_0x29bacbb9]._0x4145c702(_0x0272dad8))
                {
                    _0x0e0d32a5 = 0;
                    continue;
                }

                _0x0e0d32a5++;
                if (_0x0e0d32a5 < ColourWindow)
                    continue;
                _0xf97a39f6 _0x9c329966 = _0x7cc051e9[_0x29bacbb9];
                int _0x96ae444c = -1;
                for (int _0xcb1c4e95 = 0; _0xcb1c4e95 < 3; _0xcb1c4e95++)
                    if (_0x9c329966.Barrier != _0xcb1c4e95 && _0x9c329966.Gate[_0xcb1c4e95] >= 0)
                    {
                        _0x96ae444c = _0xcb1c4e95;
                        break;
                    }

                if (_0x96ae444c < 0)
                {
                    _0x96ae444c = (_0x9c329966.Barrier + 1) % 3;
                    _0x9c329966.Barrier = -1;
                }

                _0x9c329966.Gate[_0x96ae444c] = _0x0272dad8;
                _0x0e0d32a5 = 0;
            }
        }

        for (int _0x9e219ccf = 0; _0x9e219ccf < _0x7cc051e9.Length; _0x9e219ccf++)
        {
            _0xf97a39f6 _0x072b1691 = _0x7cc051e9[_0x9e219ccf];
            if (_0x072b1691._0xca53e27d() >= 2)
                continue;
            // Never leave the dragon with a single way through: that is not a choice.
            for (int _0x14f627b7 = 0; _0x14f627b7 < 3; _0x14f627b7++)
                if (_0x072b1691.Gate[_0x14f627b7] < 0 && _0x072b1691.Barrier != _0x14f627b7)
                {
                    _0x072b1691.Gate[_0x14f627b7] = _0xda8b1bcf.Next(0, _0xe1a80a13);
                    break;
                }
        }
    }

    /// Rows a colour is allowed to go missing for. Inside any window of this many rows every
    /// colour of the circuit's palette appears as a reachable gate, which is what bounds a
    /// run of mismatches to two.
    public const int ColourWindow = 3;
}