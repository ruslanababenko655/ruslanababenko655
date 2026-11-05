using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0x038ba1ae
{
    public static class _0xb2212895
    {
        public static int _0x41daa88c
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x229c89cf._0x04776c0d(new byte[5] { 92, 112, 118, 113, 108 }, 31)))
                    PlayerPrefs.SetInt(_0x229c89cf._0x04776c0d(new byte[5] { 93, 113, 119, 112, 109 }, 30), 0);
                return PlayerPrefs.GetInt(_0x229c89cf._0x04776c0d(new byte[5] { 169, 133, 131, 132, 153 }, 234));
            }

            set
            {
                PlayerPrefs.SetInt(_0x229c89cf._0x04776c0d(new byte[5] { 58, 22, 16, 23, 10 }, 121), value);
                _0x42666298.Instance._0x1d8efb03();
            }
        }
    }

    public static class _0xdbcb6201
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }

    public static class _0xe9cafa10
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public class _0xf44becec
    {
        private static readonly _0xf44becec _0xd0df2166 = new();
        public static readonly _0xf44becec[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xd0df2166,
            _0xd0df2166,
            _0xd0df2166,
        };
        private int _0x39394cf9 => 0;
        private int _0x639b12d8 => 10;
        private string _0x41710f9b => _0x229c89cf._0x04776c0d(new byte[4] { 203, 227, 232, 243 }, 134);
        private string _0xae5f96cf => _0x229c89cf._0x04776c0d(new byte[8] { 221, 212, 199, 212, 221, 234, 161, 236 }, 145);

        private int _0x5eb22229
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x229c89cf._0x04776c0d(new byte[25] { 251, 205, 202, 202, 221, 214, 204, 255, 212, 215, 218, 217, 212, 251, 208, 217, 200, 204, 221, 202, 241, 214, 220, 221, 192 }, 184)))
                    PlayerPrefs.SetInt(_0x229c89cf._0x04776c0d(new byte[25] { 198, 240, 247, 247, 224, 235, 241, 194, 233, 234, 231, 228, 233, 198, 237, 228, 245, 241, 224, 247, 204, 235, 225, 224, 253 }, 133), 0);
                return PlayerPrefs.GetInt(_0x229c89cf._0x04776c0d(new byte[25] { 189, 139, 140, 140, 155, 144, 138, 185, 146, 145, 156, 159, 146, 189, 150, 159, 142, 138, 155, 140, 183, 144, 154, 155, 134 }, 254));
            }

            set => PlayerPrefs.SetInt(_0x229c89cf._0x04776c0d(new byte[25] { 154, 172, 171, 171, 188, 183, 173, 158, 181, 182, 187, 184, 181, 154, 177, 184, 169, 173, 188, 171, 144, 183, 189, 188, 161 }, 217), value);
        }

        public int _0xbc2af3eb
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x41710f9b}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x41710f9b}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x41710f9b}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x41710f9b}CurrentLevelIndex", value);
        }

        public int _0xe002b16d
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x41710f9b}BestScore"))
                    this._0xe002b16d = 0;
                return PlayerPrefs.GetInt($"{this._0x41710f9b}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x41710f9b}BestScore", value);
        }

        public bool _0xa2901a99
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x41710f9b}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x41710f9b}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x41710f9b}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x41710f9b}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x473c0d2d
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }
}

internal static class _0x229c89cf
{
    internal static string _0x04776c0d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}