using TMPro;
using UnityEngine;

/// The template ships seven tutorial slots and fills the ones it defines with filler prose.
/// This game explains itself with the in-run control card instead, so the slots are never
/// raised - but a slot that is never raised is still one bad navigation step away from the
/// screen, and the filler would ship with it (rule C.15). Every slot the template declares
/// is therefore rewritten here, in this game's words, at runtime; the panels themselves are
/// left in place because the controller addresses them by index.
public sealed class _0xe22ab1be
{
    public void _0xc3f450e4(TMP_FontAsset _0x38c15cb6)
    {
        _0x828b28ef _0x903397a6 = _0x828b28ef.Instance;
        if (_0x903397a6 == null || _0x903397a6.Panels == null)
            return;
        int[] _0xd0544bb7 =
        {
            _0x038ba1ae._0xdbcb6201.TUTORIAL0,
            _0x038ba1ae._0xdbcb6201.TUTORIAL1,
            _0x038ba1ae._0xdbcb6201.TUTORIAL2,
            _0x038ba1ae._0xdbcb6201.TUTORIAL3,
            _0x038ba1ae._0xdbcb6201.TUTORIAL4,
            _0x038ba1ae._0xdbcb6201.TUTORIAL5,
            _0x038ba1ae._0xdbcb6201.TUTORIAL6
        };
        for (int _0x10511147 = 0; _0x10511147 < _0xd0544bb7.Length; _0x10511147++)
        {
            int _0xcc35f8ea = _0xd0544bb7[_0x10511147];
            if (_0xcc35f8ea < 0 || _0xcc35f8ea >= _0x903397a6.Panels.Count)
                continue;
            _0x049fd978 _0x05b471ed = _0x903397a6.Panels[_0xcc35f8ea];
            if (_0x05b471ed == null)
                continue;
            string _0x23ff4391 = _0x10511147 < _0x6ed84660.Length ? _0x6ed84660[_0x10511147] : string.Empty;
            TMP_Text[] _0x6daf14f2 = _0x05b471ed.GetComponentsInChildren<TMP_Text>(true);
            // Tell the heading from the body by SIZE, not by object name: names are renamed
            // by the obfuscator and sizes are not.
            for (int _0x6616dd00 = 0; _0x6616dd00 < _0x6daf14f2.Length; _0x6616dd00++)
            {
                TMP_Text _0xc4e9a099 = _0x6daf14f2[_0x6616dd00];
                if (_0xc4e9a099 == null)
                    continue;
                float _0xc087bfc3 = Mathf.Max(_0x131f2561.MinFont, _0xc4e9a099.fontSize);
                bool _0xeb8b7835 = _0xc087bfc3 >= 80f;
                _0xc4e9a099.text = _0xeb8b7835 ? (_0x23ff4391.Length > 0 ? _0x2b554ba3._0x9f5f55ea(new byte[10] { 214, 209, 201, 190, 202, 209, 190, 216, 210, 199 }, 158) : string.Empty) : _0x23ff4391;
                _0xc4e9a099.color = _0xeb8b7835 ? _0x687afa6e.Gold : _0x687afa6e.TextPrimary;
                _0xc4e9a099.textWrappingMode = TextWrappingModes.NoWrap;
                _0xc4e9a099.enableAutoSizing = true;
                _0xc4e9a099.fontSizeMin = _0x131f2561.MinFont;
                _0xc4e9a099.fontSizeMax = _0xc087bfc3;
                if (_0x38c15cb6 != null)
                    _0xc4e9a099.font = _0x38c15cb6;
            }
        }
    }

    private static readonly string[] _0x6ed84660 =
    {
        _0x2b554ba3._0x9f5f55ea(new byte[28] { 52, 56, 45, 58, 49, 89, 45, 49, 60, 89, 62, 56, 45, 60, 115, 45, 54, 89, 32, 54, 44, 43, 89, 60, 52, 59, 60, 43 }, 121),
        _0x2b554ba3._0x9f5f55ea(new byte[23] { 113, 117, 107, 114, 103, 2, 110, 2, 13, 2, 112, 40, 97, 106, 99, 108, 101, 103, 2, 110, 99, 108, 103 }, 34),
        _0x2b554ba3._0x9f5f55ea(new byte[19] { 242, 246, 232, 241, 228, 129, 244, 241, 171, 228, 236, 227, 228, 243, 129, 229, 224, 242, 233 }, 161),
        _0x2b554ba3._0x9f5f55ea(new byte[27] { 221, 202, 211, 213, 216, 188, 200, 212, 217, 150, 201, 210, 207, 200, 221, 222, 208, 217, 188, 223, 206, 197, 207, 200, 221, 208, 207 }, 156),
        _0x2b554ba3._0x9f5f55ea(new byte[38] { 46, 33, 40, 44, 63, 77, 40, 59, 40, 63, 52, 77, 42, 44, 57, 40, 103, 57, 34, 77, 43, 36, 35, 36, 62, 37, 77, 57, 37, 40, 77, 46, 36, 63, 46, 56, 36, 57 }, 109),
        "",
        ""
    };
}

internal static class _0x2b554ba3
{
    internal static string _0x9f5f55ea(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}