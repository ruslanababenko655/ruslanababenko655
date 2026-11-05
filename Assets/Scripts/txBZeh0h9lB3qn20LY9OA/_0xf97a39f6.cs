using UnityEngine;

/// One row of the circuit: what sits in each of the three lanes when that row reaches the
/// dragon. No constructor anywhere (rule C.59) - rows are built with Init and returned.
public sealed class _0xf97a39f6
{
    public override string ToString()
    {
        return string.Format(_0x6b84e5cc._0x300ae19f(new byte[34] { 78, 110, 37, 104, 57, 110, 36, 104, 57, 110, 39, 104, 72, 53, 118, 103, 108, 102, 97, 116, 121, 40, 110, 38, 104, 53, 120, 122, 97, 112, 40, 110, 33, 104 }, 21), this.Gate[0], this.Gate[1], this.Gate[2], this.Barrier, this.Mote);
    }

    public _0xf97a39f6 _0xf083ef89()
    {
        return new _0xf97a39f6()._0xc8350f76(this.Gate[0], this.Gate[1], this.Gate[2], this.Barrier, this.Mote);
    }

    public _0xf97a39f6 _0xc8350f76(int _0x4567b340, int _0xc9598eeb, int _0xb4c9fc51, int _0x1693eebb, int _0x72c6ad55)
    {
        this.Gate = new int[3];
        this.Gate[0] = _0x4567b340;
        this.Gate[1] = _0xc9598eeb;
        this.Gate[2] = _0xb4c9fc51;
        this.Barrier = _0x1693eebb;
        this.Mote = _0x72c6ad55;
        return this;
    }

    /// Push the crystal out of a lane the dragon is already flying in. The circuit stays
    /// real - the player can still fly INTO one later - it only refuses to drop a shard
    /// straight onto a dragon that has had no chance to move.
    public void _0x4cc14f92(int _0xd07e058f)
    {
        if (this.Barrier != _0xd07e058f)
            return;
        for (int _0xc4063e66 = 1; _0xc4063e66 <= 2; _0xc4063e66++)
        {
            int _0xf74391a4 = (_0xd07e058f + _0xc4063e66) % 3;
            if (this.Gate[_0xf74391a4] < 0)
            {
                this.Barrier = _0xf74391a4;
                return;
            }
        }

        this.Barrier = -1;
    }

    /// Lane holding an ember mote, -1 when the row carries none.
    public int Mote = -1;
    /// The lane holding that colour, or -1. Barriers never count as a way through.
    public int _0x8049ebdb(int _0x8a863f99)
    {
        for (int _0xc46580be = 0; _0xc46580be < 3; _0xc46580be++)
            if (this.Gate[_0xc46580be] == _0x8a863f99 && this.Barrier != _0xc46580be)
                return _0xc46580be;
        return -1;
    }

    /// Gate colour per lane, -1 when that lane carries no gate.
    public int[] Gate =
    {
        -1,
        -1,
        -1
    };
    /// Lane holding an unstable crystal, -1 when the row carries none.
    public int Barrier = -1;
    /// Does any lane of this row carry the colour the dragon currently needs?
    public bool _0x4145c702(int _0xafff4be8)
    {
        for (int _0x83cfb0b7 = 0; _0x83cfb0b7 < 3; _0x83cfb0b7++)
            if (this.Gate[_0x83cfb0b7] == _0xafff4be8 && this.Barrier != _0x83cfb0b7)
                return true;
        return false;
    }

    public int _0xca53e27d()
    {
        int _0xf665e0d8 = 0;
        for (int _0xad13e1f2 = 0; _0xad13e1f2 < 3; _0xad13e1f2++)
            if (this.Gate[_0xad13e1f2] >= 0)
                _0xf665e0d8++;
        return _0xf665e0d8;
    }
}

internal static class _0x6b84e5cc
{
    internal static string _0x300ae19f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}