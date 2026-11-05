using UnityEngine;

/// The hand-written circuit. It exists only so a stubborn seed can never leave the player
/// without a flyable route (rule C.11, point 2) - the game itself is always the generated
/// one. The pattern walks the three colours in a rolling order so every window of three
/// rows carries each of them, and the crystal lanes step sideways instead of stacking.
public static class _0xdf57a9d1
{
    private static int Fold(int _0xd08a85f3, int _0x517e6f47)
    {
        if (_0xd08a85f3 < 0)
            return -1;
        return _0xd08a85f3 % _0x517e6f47;
    }

    private static readonly int[, ] _0xad988d59 =
    {
        //  left, mid, right, crystal, mote
        {
            0,
            1,
            2,
            -1,
            1
        },
        {
            1,
            2,
            0,
            -1,
            -1
        },
        {
            2,
            0,
            1,
            -1,
            2
        },
        {
            0,
            2,
            1,
            -1,
            -1
        },
        {
            1,
            0,
            2,
            -1,
            0
        },
        {
            2,
            1,
            -1,
            2,
            -1
        },
        {
            0,
            1,
            2,
            -1,
            1
        },
        {
            -1,
            2,
            0,
            0,
            2
        },
        {
            1,
            0,
            2,
            -1,
            -1
        },
        {
            2,
            1,
            0,
            -1,
            1
        },
        {
            0,
            2,
            -1,
            2,
            -1
        },
        {
            1,
            2,
            0,
            -1,
            0
        },
        {
            2,
            0,
            1,
            -1,
            2
        },
        {
            -1,
            1,
            2,
            0,
            -1
        },
        {
            0,
            1,
            2,
            -1,
            1
        },
        {
            1,
            2,
            0,
            -1,
            -1
        },
        {
            2,
            0,
            1,
            -1,
            0
        },
        {
            0,
            2,
            1,
            -1,
            -1
        },
        {
            1,
            -1,
            2,
            1,
            2
        },
        {
            2,
            1,
            0,
            -1,
            -1
        }
    };
    public static _0xf97a39f6[] Circuit(int _0x50729775)
    {
        int _0x51e0452e = _0x1ceaad4b.Clamp(_0x50729775);
        int _0xb9b3aeca = _0x1ceaad4b.Rows[_0x51e0452e];
        int _0xa54e0be7 = Mathf.Clamp(_0x1ceaad4b.Colours[_0x51e0452e], 2, 3);
        _0xf97a39f6[] _0x246781d3 = new _0xf97a39f6[_0xb9b3aeca];
        int _0x6607fc93 = _0xad988d59.GetLength(0);
        for (int _0x616b8411 = 0; _0x616b8411 < _0xb9b3aeca; _0x616b8411++)
        {
            int _0xd62de4f4 = _0x616b8411 % _0x6607fc93;
            _0x246781d3[_0x616b8411] = new _0xf97a39f6()._0xc8350f76(Fold(_0xad988d59[_0xd62de4f4, 0], _0xa54e0be7), Fold(_0xad988d59[_0xd62de4f4, 1], _0xa54e0be7), Fold(_0xad988d59[_0xd62de4f4, 2], _0xa54e0be7), _0x616b8411 < 5 ? -1 : _0xad988d59[_0xd62de4f4, 3], _0xad988d59[_0xd62de4f4, 4]);
        }

        return _0x246781d3;
    }
}