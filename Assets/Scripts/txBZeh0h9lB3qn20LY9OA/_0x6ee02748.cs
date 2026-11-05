using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The trail collection: six wakes the dragon can burn behind it, two free and four bought
/// with the shards a run pays out. Picking one re-tints the live trail behind this overlay,
/// so the change is visible in a still frame and not only in a label (rule C.7).
public sealed class _0x6ee02748 : MonoBehaviour
{
    private const float CardHeight = 400f;
    private GameObject _0xbf3f8ed3;
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    private _0x4bf36e40 _0xd6f4660c;
    public bool _0xb0cf4f54
    {
        get
        {
            return this._0xbf3f8ed3 != null && this._0xbf3f8ed3.activeSelf;
        }
    }

    private TextMeshProUGUI _0xe36e7ff0;
    private readonly TextMeshProUGUI[] _0x7e5156df = new TextMeshProUGUI[6];
    private readonly Image[] _0x02effa1a = new Image[6];
    private const float ColumnPitch = 520f;
    private const float RowPitch = 440f;
    private const float CardWidth = 480f;
    private void _0xdeb5c6de()
    {
        int _0xb345ae00 = _0x1b98df55._0x21bcf3a2;
        int _0x12748490 = 0;
        this._0xd86cc674.text = string.Format(_0x34809771._0xfe9bbaad(new byte[18] { 5, 13, 2, 5, 18, 96, 19, 8, 1, 18, 4, 19, 96, 96, 96, 59, 112, 61 }, 64), _0x1b98df55._0x54309030);
        for (int _0xfe4bb8db = 0; _0xfe4bb8db < this._0xba626098.Length; _0xfe4bb8db++)
        {
            if (this._0xba626098[_0xfe4bb8db] == null)
                continue;
            _0x12748490++;
            bool _0xace3dbf0 = _0x1b98df55.TrailOpen(_0xfe4bb8db);
            bool _0x75b1a09b = _0xace3dbf0 && _0xfe4bb8db == _0xb345ae00;
            this._0x02effa1a[_0xfe4bb8db].color = _0x75b1a09b ? _0x687afa6e.Gold : _0x687afa6e.Alpha(_0x687afa6e.Gold, _0xace3dbf0 ? 0.45f : 0.16f);
            this._0x0678d37c[_0xfe4bb8db].color = _0x687afa6e.Alpha(_0x75b1a09b ? _0x687afa6e.BgSurfaceHi : _0x687afa6e.BgSurface, _0xace3dbf0 ? 0.96f : 0.68f);
            Color _0x3a67a7a4 = _0x75b1a09b ? _0x687afa6e.Gold : (_0xace3dbf0 ? _0x687afa6e.TextPrimary : _0x687afa6e.TextSecondary);
            this._0x2e85e63e[_0xfe4bb8db].color = _0x3a67a7a4;
            _0x131f2561.Readable(this._0x2e85e63e[_0xfe4bb8db], _0x3a67a7a4);
            this._0x7e5156df[_0xfe4bb8db].text = _0x75b1a09b ? _0x34809771._0xfe9bbaad(new byte[8] { 123, 109, 100, 109, 107, 124, 109, 108 }, 40) : (_0xace3dbf0 ? _0x34809771._0xfe9bbaad(new byte[5] { 172, 187, 191, 186, 167 }, 254) : string.Format(_0x34809771._0xfe9bbaad(new byte[10] { 189, 246, 187, 230, 149, 142, 135, 148, 130, 149 }, 198), _0x687afa6e.TrailCost[_0xfe4bb8db]));
            this._0x7e5156df[_0xfe4bb8db].color = _0x75b1a09b ? _0x687afa6e.Gold : _0x687afa6e.TextSecondary;
            _0x131f2561.Readable(this._0x7e5156df[_0xfe4bb8db], this._0x7e5156df[_0xfe4bb8db].color);
            Image[] _0xd4f8cecc = this._0xcba18f53[_0xfe4bb8db];
            if (_0xd4f8cecc == null)
                continue;
            for (int _0xf247a6bf = 0; _0xf247a6bf < _0xd4f8cecc.Length; _0xf247a6bf++)
            {
                if (_0xd4f8cecc[_0xf247a6bf] == null)
                    continue;
                float _0xe07c3109 = 1f - _0xf247a6bf / (float)_0xd4f8cecc.Length;
                _0xd4f8cecc[_0xf247a6bf].color = _0x687afa6e.Alpha(_0x687afa6e.TrailTints[_0xfe4bb8db], _0xace3dbf0 ? _0xe07c3109 : _0xe07c3109 * 0.3f);
            }
        }

        if (this._0xe36e7ff0 != null)
            this._0xe36e7ff0.gameObject.SetActive(_0x12748490 == 0);
    }

    private TextMeshProUGUI _0xd86cc674;
    private const int Columns = 2;
    private readonly TextMeshProUGUI[] _0x2e85e63e = new TextMeshProUGUI[6];
    private readonly Image[] _0x0678d37c = new Image[6];
    private readonly Image[][] _0xcba18f53 = new Image[6][];
    public void _0x6daa767a()
    {
        if (this._0xbf3f8ed3 != null)
            this._0xbf3f8ed3.SetActive(false);
    }

    public _0x6ee02748 _0x7a89520c(Transform _0x4716b9ff, TMP_FontAsset _0x46b9b635, Sprite _0x66a79801, Sprite _0x649c913b, Sprite _0x6b5f4016, _0x4bf36e40 _0x8766656b, Action _0x0ce922e6)
    {
        this._0xd6f4660c = _0x8766656b;
        this._0x1f38edf8 = _0x0ce922e6;
        RectTransform _0x19909c0c = _0x131f2561.Stretch(_0x131f2561.Branch(_0x34809771._0xfe9bbaad(new byte[10] { 103, 65, 82, 90, 95, 96, 91, 86, 86, 71 }, 51), _0x4716b9ff));
        this._0xbf3f8ed3 = _0x19909c0c.gameObject;
        Image _0xcacabda0 = _0x131f2561.Wash(_0x19909c0c, _0x34809771._0xfe9bbaad(new byte[9] { 165, 131, 144, 152, 157, 166, 144, 130, 153 }, 241), _0x687afa6e.Alpha(_0x687afa6e.OutlineInk, 0.88f));
        _0x131f2561.Stretch(_0xcacabda0.rectTransform);
        _0xcacabda0.raycastTarget = true;
        TextMeshProUGUI _0xde9bc35b = _0x131f2561.Caption(_0x19909c0c, _0x34809771._0xfe9bbaad(new byte[9] { 91, 125, 110, 102, 99, 71, 106, 110, 107 }, 15), _0x46b9b635, _0x34809771._0xfe9bbaad(new byte[16] { 34, 36, 55, 63, 58, 86, 53, 57, 58, 58, 51, 53, 34, 63, 57, 56 }, 118), 56f, _0x687afa6e.Gold, TextAlignmentOptions.Center);
        _0x131f2561.Fit(_0xde9bc35b.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -236f), new Vector2(940f, 76f));
        this._0xd86cc674 = _0x131f2561.Caption(_0x19909c0c, _0x34809771._0xfe9bbaad(new byte[10] { 177, 151, 132, 140, 137, 181, 144, 151, 150, 128 }, 229), _0x46b9b635, "", 38f, _0x687afa6e.TextSecondary, TextAlignmentOptions.Center);
        _0x131f2561.Fit(this._0xd86cc674.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -320f), new Vector2(940f, 58f));
        this._0xe36e7ff0 = _0x131f2561.Caption(_0x19909c0c, _0x34809771._0xfe9bbaad(new byte[10] { 38, 0, 19, 27, 30, 55, 31, 2, 6, 11 }, 114), _0x46b9b635, _0x34809771._0xfe9bbaad(new byte[21] { 174, 175, 192, 180, 178, 161, 169, 172, 179, 192, 163, 168, 161, 178, 180, 165, 164, 192, 185, 165, 180 }, 224), 40f, _0x687afa6e.TextSecondary, TextAlignmentOptions.Center);
        _0x131f2561.Fit(this._0xe36e7ff0.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(940f, 64f));
        this._0xe36e7ff0.gameObject.SetActive(false);
        int _0x8856d42e = _0x687afa6e.TrailNames.Length;
        for (int _0x79840b75 = 0; _0x79840b75 < _0x8856d42e && _0x79840b75 < this._0xba626098.Length; _0x79840b75++)
        {
            int _0x134625ac = _0x79840b75;
            float _0xb74d3b37 = (_0x79840b75 % Columns - (Columns - 1) * 0.5f) * ColumnPitch;
            float _0xd72b1481 = -470f - (_0x79840b75 / Columns) * RowPitch;
            RectTransform _0x19cb0f9e = _0x131f2561.Fit(_0x131f2561.Branch(_0x34809771._0xfe9bbaad(new byte[9] { 231, 193, 210, 218, 223, 240, 210, 193, 215 }, 179), _0x19909c0c), new Vector2(0.5f, 1f), new Vector2(_0xb74d3b37, _0xd72b1481), new Vector2(CardWidth, CardHeight));
            Image _0x0d42993c = _0x131f2561.Plate(_0x19cb0f9e, _0x34809771._0xfe9bbaad(new byte[9] { 217, 255, 236, 228, 225, 200, 233, 234, 232 }, 141), _0x66a79801, _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.45f), 1.4f);
            _0x131f2561.Stretch(_0x0d42993c.rectTransform);
            Image _0x8341ad46 = _0x131f2561.Plate(_0x19cb0f9e, _0x34809771._0xfe9bbaad(new byte[9] { 52, 18, 1, 9, 12, 34, 15, 4, 25 }, 96), _0x66a79801, _0x687afa6e.Alpha(_0x687afa6e.BgSurface, 0.96f), 1.45f);
            _0x131f2561.Stretch(_0x8341ad46.rectTransform);
            _0x8341ad46.rectTransform.offsetMin = new Vector2(6f, 6f);
            _0x8341ad46.rectTransform.offsetMax = new Vector2(-6f, -6f);
            Image[] _0xfa0225e7 = new Image[PreviewNodes];
            for (int _0x5cd23855 = 0; _0x5cd23855 < PreviewNodes; _0x5cd23855++)
            {
                float _0x708d1a8f = 1f - _0x5cd23855 / (float)PreviewNodes;
                Image _0xdfe7901c = _0x131f2561.Picture(_0x19cb0f9e, _0x34809771._0xfe9bbaad(new byte[9] { 69, 99, 112, 120, 125, 95, 126, 117, 116 }, 17), _0x649c913b, _0x687afa6e.Alpha(_0x687afa6e.TrailTints[_0x79840b75], _0x708d1a8f));
                float _0xf05f9044 = 26f + 44f * _0x708d1a8f;
                _0x131f2561.Fit(_0xdfe7901c.rectTransform, new Vector2(0.5f, 1f), new Vector2(-150f + 60f * _0x5cd23855, -120f), new Vector2(_0xf05f9044, _0xf05f9044));
                _0xfa0225e7[_0x5cd23855] = _0xdfe7901c;
            }

            this._0xcba18f53[_0x79840b75] = _0xfa0225e7;
            TextMeshProUGUI _0xa7764a39 = _0x131f2561.Caption(_0x19cb0f9e, _0x34809771._0xfe9bbaad(new byte[9] { 206, 232, 251, 243, 246, 212, 251, 247, 255 }, 154), _0x46b9b635, _0x687afa6e.TrailNames[_0x79840b75], 38f, _0x687afa6e.TextPrimary, TextAlignmentOptions.Center);
            _0x131f2561.Fit(_0xa7764a39.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -232f), new Vector2(420f, 56f));
            TextMeshProUGUI _0x7934ffdd = _0x131f2561.Caption(_0x19cb0f9e, _0x34809771._0xfe9bbaad(new byte[10] { 231, 193, 210, 218, 223, 224, 199, 210, 199, 214 }, 179), _0x46b9b635, "", 30f, _0x687afa6e.TextSecondary, TextAlignmentOptions.Center);
            _0x131f2561.Fit(_0x7934ffdd.rectTransform, new Vector2(0.5f, 0f), new Vector2(0f, 62f), new Vector2(420f, 48f));
            Button _0xcade207d = _0x131f2561.Press(_0x19cb0f9e);
            _0xcade207d.onClick.AddListener(() => this._0xb1e9c1c4(_0x134625ac));
            this._0xba626098[_0x79840b75] = _0x19cb0f9e;
            this._0x02effa1a[_0x79840b75] = _0x0d42993c;
            this._0x0678d37c[_0x79840b75] = _0x8341ad46;
            this._0x2e85e63e[_0x79840b75] = _0xa7764a39;
            this._0x7e5156df[_0x79840b75] = _0x7934ffdd;
        }

        Button _0x5ceccf51 = _0x131f2561.Glyph(_0x19909c0c, _0x34809771._0xfe9bbaad(new byte[10] { 33, 7, 20, 28, 25, 54, 25, 26, 6, 16 }, 117), _0x6b5f4016, _0x66a79801, new Vector2(1f, 1f), new Vector2(-118f, -236f), 112f, _0x687afa6e.TextPrimary);
        _0x5ceccf51.onClick.AddListener(() => this._0x6daa767a());
        this._0xbf3f8ed3.SetActive(false);
        return this;
    }

    /// Select an unlocked trail, or spend shards on a locked one. A refusal always answers
    /// with the notice chip, never with nothing.
    private void _0xb1e9c1c4(int _0x92b27061)
    {
        int _0xec8ca4ba = Mathf.Clamp(_0x92b27061, 0, _0x687afa6e.TrailTints.Length - 1);
        if (!_0x1b98df55.TrailOpen(_0xec8ca4ba))
        {
            int _0xfa0df718 = _0x1b98df55.BuyTrail(_0xec8ca4ba);
            if (_0xfa0df718 > 0)
            {
                if (this._0xba626098[_0xec8ca4ba] != null)
                    this._0xba626098[_0xec8ca4ba].DOShakeAnchorPos(0.3f, 18f, 16).SetLink(this.gameObject);
                if (this._0xd6f4660c != null)
                    this._0xd6f4660c._0x49779921(string.Format(_0x34809771._0xfe9bbaad(new byte[25] { 64, 11, 70, 27, 118, 116, 105, 126, 27, 104, 115, 122, 105, 127, 104, 27, 111, 116, 27, 110, 117, 119, 116, 120, 112 }, 59), _0xfa0df718), false);
                return;
            }
        }
        else
        {
            _0x1b98df55.ChooseTrail(_0xec8ca4ba);
        }

        if (_0x1b98df55.LastWriteFailed && this._0xd6f4660c != null)
            this._0xd6f4660c._0x49779921(_0x34809771._0xfe9bbaad(new byte[18] { 104, 106, 119, 127, 106, 125, 107, 107, 24, 118, 119, 108, 24, 107, 121, 110, 125, 124 }, 56), true);
        this._0xdeb5c6de();
        if (this._0xba626098[_0xec8ca4ba] != null)
        {
            this._0xba626098[_0xec8ca4ba].DOScale(1.06f, 0.12f).SetEase(Ease.OutQuad).SetLink(this.gameObject);
            this._0xba626098[_0xec8ca4ba].DOScale(1f, 0.22f).SetDelay(0.12f).SetEase(Ease.OutBack).SetLink(this.gameObject);
        }

        if (this._0x1f38edf8 != null)
            this._0x1f38edf8();
    }

    private const int PreviewNodes = 6;
    private Action _0x1f38edf8;
    public void _0x5ed3eb5e()
    {
        if (this._0xbf3f8ed3 == null)
            return;
        this._0xbf3f8ed3.SetActive(true);
        this._0xdeb5c6de();
    }

    private readonly RectTransform[] _0xba626098 = new RectTransform[6];
}

internal static class _0x34809771
{
    internal static string _0xfe9bbaad(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}