using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Settings. Everything here changes something the player can SEE on the menu behind the
/// sheet - the wake thickens, the sway stops, the shard counter drops to zero - because a
/// switch whose only effect is its own label reads as broken (rule C.7). There is no sound
/// row: this game ships without audio, so a volume control would toggle silence (rule C.20).
public sealed class _0xa66dddcb : MonoBehaviour
{
    public void _0x0038fc72()
    {
        if (this._0x7385e7c8 == null)
            return;
        this._0x7385e7c8.SetActive(true);
        this._0x878251a2(false);
        this._0x8e49a3ce();
    }

    private void _0x42df35fa(bool _0xe664c4e6)
    {
        _0x1b98df55.SetCalmMotion(_0xe664c4e6);
        this._0x9bc45c3a();
    }

    private const float RowWidth = 1060f;
    /// One settings line: a caption on the left, controls on the right. The two bands never
    /// share a horizontal strip, so left-aligned text cannot slide under a chip (rule C.25).
    private RectTransform _0x6d376e30(Transform _0xddd54a20, TMP_FontAsset _0x0dee1bbb, Sprite _0x95dfd06c, string _0x402d21ee, int _0x6c3b7c8c)
    {
        RectTransform _0x79e4f164 = _0x131f2561.Fit(_0x131f2561.Branch(_0xcf1f8c08._0x215e2965(new byte[11] { 3, 53, 36, 36, 57, 62, 55, 35, 2, 63, 39 }, 80), _0xddd54a20), new Vector2(0.5f, 1f), new Vector2(0f, -452f - _0x6c3b7c8c * RowPitch), new Vector2(RowWidth, RowHeight));
        Image _0xe28a8db8 = _0x131f2561.Plate(_0x79e4f164, _0xcf1f8c08._0x215e2965(new byte[8] { 141, 176, 168, 143, 179, 190, 171, 186 }, 223), _0x95dfd06c, _0x687afa6e.Alpha(_0x687afa6e.BgSurface, 0.92f), 1.4f);
        _0x131f2561.Stretch(_0xe28a8db8.rectTransform);
        TextMeshProUGUI _0x1cbe1d78 = _0x131f2561.Caption(_0x79e4f164, _0xcf1f8c08._0x215e2965(new byte[8] { 203, 246, 238, 213, 248, 251, 252, 245 }, 153), _0x0dee1bbb, _0x402d21ee, 38f, _0x687afa6e.TextPrimary, TextAlignmentOptions.Left);
        _0x131f2561.Fit(_0x1cbe1d78.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(LabelCentre, 0f), new Vector2(LabelWidth, 56f));
        return _0x79e4f164;
    }

    private readonly TextMeshProUGUI[] _0xe0c8d697 = new TextMeshProUGUI[3];
    private const float RowPitch = 184f;
    public bool _0xe46d57e6
    {
        get
        {
            return this._0x7385e7c8 != null && this._0x7385e7c8.activeSelf;
        }
    }

    private const float LabelWidth = 420f;
    private GameObject _0xd2138cf2;
    private void _0xf174362e()
    {
        _0x1b98df55.Wipe();
        this._0x878251a2(false);
        if (this._0x9d6077dc != null)
            this._0x9d6077dc._0x49779921(_0x1b98df55.LastWriteFailed ? _0xcf1f8c08._0x215e2965(new byte[18] { 185, 187, 166, 174, 187, 172, 186, 186, 201, 167, 166, 189, 201, 186, 168, 191, 172, 173 }, 233) : _0xcf1f8c08._0x215e2965(new byte[15] { 134, 132, 153, 145, 132, 147, 133, 133, 246, 147, 132, 151, 133, 147, 146 }, 214), _0x1b98df55.LastWriteFailed);
        this._0x9bc45c3a();
    }

    private void _0xb7cb9a5c(bool _0x0102c8bc)
    {
        _0x1b98df55.SetHaptics(_0x0102c8bc);
        if (_0x0102c8bc)
            Handheld.Vibrate();
        this._0x9bc45c3a();
    }

    private const float RowHeight = 150f;
    private readonly Image[] _0x0ef6cfd4 = new Image[2];
    private readonly Image[] _0x2cec35d6 = new Image[3];
    private void _0x15eed1ab(Image[] _0x0fd573ec, TextMeshProUGUI[] _0xd524d079, int _0x6f951f06)
    {
        for (int _0xf3c72f82 = 0; _0xf3c72f82 < _0x0fd573ec.Length; _0xf3c72f82++)
        {
            bool _0xbbe078ef = _0xf3c72f82 == _0x6f951f06;
            if (_0x0fd573ec[_0xf3c72f82] != null)
                _0x0fd573ec[_0xf3c72f82].color = _0xbbe078ef ? _0x687afa6e.Gold : _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.3f);
            if (_0xd524d079[_0xf3c72f82] == null)
                continue;
            Color _0xa25fb28b = _0xbbe078ef ? _0x687afa6e.Gold : _0x687afa6e.TextSecondary;
            _0xd524d079[_0xf3c72f82].color = _0xa25fb28b;
            _0x131f2561.Readable(_0xd524d079[_0xf3c72f82], _0xa25fb28b);
        }
    }

    private void _0x878251a2(bool _0xb0089cf1)
    {
        if (this._0xd2138cf2 != null)
            this._0xd2138cf2.SetActive(_0xb0089cf1);
    }

    private void _0x9bc45c3a()
    {
        this._0x8e49a3ce();
        if (_0x1b98df55.LastWriteFailed && this._0x9d6077dc != null)
            this._0x9d6077dc._0x49779921(_0xcf1f8c08._0x215e2965(new byte[18] { 55, 53, 40, 32, 53, 34, 52, 52, 71, 41, 40, 51, 71, 52, 38, 49, 34, 35 }, 103), true);
        if (this._0x737946b8 != null)
            this._0x737946b8();
    }

    private void _0xb90d2ae6(Transform _0x7b2fec6c, TMP_FontAsset _0x47aa3ed2, Sprite _0xb435b452, string _0xbd3fb2ce, float _0xfbc7565f, float width, int _0x57e7115e, Image[] _0x09e820bb, TextMeshProUGUI[] _0x5752a06d, Action _0x9e0cabde)
    {
        RectTransform _0x953edd67 = _0x131f2561.Fit(_0x131f2561.Branch(_0xcf1f8c08._0x215e2965(new byte[7] { 5, 56, 32, 20, 63, 62, 39 }, 87), _0x7b2fec6c), new Vector2(0.5f, 0.5f), new Vector2(_0xfbc7565f, 0f), new Vector2(width, 96f));
        Image _0xf8162668 = _0x131f2561.Plate(_0x953edd67, _0xcf1f8c08._0x215e2965(new byte[8] { 216, 243, 242, 235, 222, 255, 252, 254 }, 155), _0xb435b452, _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.45f), 1.3f);
        _0x131f2561.Stretch(_0xf8162668.rectTransform);
        Image _0x6180c67d = _0x131f2561.Plate(_0x953edd67, _0xcf1f8c08._0x215e2965(new byte[8] { 210, 249, 248, 225, 211, 254, 245, 232 }, 145), _0xb435b452, _0x687afa6e.Alpha(_0x687afa6e.BgSurfaceHi, 0.96f), 1.35f);
        _0x131f2561.Stretch(_0x6180c67d.rectTransform);
        _0x6180c67d.rectTransform.offsetMin = new Vector2(5f, 5f);
        _0x6180c67d.rectTransform.offsetMax = new Vector2(-5f, -5f);
        TextMeshProUGUI _0xb88eb2ef = _0x131f2561.Caption(_0x953edd67, _0xcf1f8c08._0x215e2965(new byte[9] { 238, 197, 196, 221, 225, 204, 207, 200, 193 }, 173), _0x47aa3ed2, _0xbd3fb2ce, 34f, _0x687afa6e.TextPrimary, TextAlignmentOptions.Center);
        _0x131f2561.Stretch(_0xb88eb2ef.rectTransform);
        Button _0x59977870 = _0x131f2561.Press(_0x953edd67);
        _0x59977870.onClick.AddListener(() => _0x9e0cabde());
        if (_0x09e820bb != null && _0x57e7115e < _0x09e820bb.Length)
            _0x09e820bb[_0x57e7115e] = _0xf8162668;
        if (_0x5752a06d != null && _0x57e7115e < _0x5752a06d.Length)
            _0x5752a06d[_0x57e7115e] = _0xb88eb2ef;
    }

    private readonly TextMeshProUGUI[] _0xd9bc3c41 = new TextMeshProUGUI[2];
    private _0x4bf36e40 _0x9d6077dc;
    private Action _0x737946b8;
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    private void _0x8dcf0266(int _0x5ba369b8)
    {
        _0x1b98df55.SetGlow(_0x5ba369b8);
        this._0x9bc45c3a();
    }

    public _0xa66dddcb _0xbb881c87(Transform _0x058bdda0, TMP_FontAsset _0x0d5b3d29, Sprite _0x99a236ee, Sprite _0x002daa7b, _0x4bf36e40 _0x0d4ed6e6, Action _0x5f793b26)
    {
        this._0x9d6077dc = _0x0d4ed6e6;
        this._0x737946b8 = _0x5f793b26;
        RectTransform _0x3992b0d3 = _0x131f2561.Stretch(_0x131f2561.Branch(_0xcf1f8c08._0x215e2965(new byte[13] { 79, 121, 104, 104, 117, 114, 123, 111, 79, 116, 121, 121, 104 }, 28), _0x058bdda0));
        this._0x7385e7c8 = _0x3992b0d3.gameObject;
        Image _0x24485600 = _0x131f2561.Wash(_0x3992b0d3, _0xcf1f8c08._0x215e2965(new byte[12] { 245, 195, 210, 210, 207, 200, 193, 213, 241, 199, 213, 206 }, 166), _0x687afa6e.Alpha(_0x687afa6e.OutlineInk, 0.88f));
        _0x131f2561.Stretch(_0x24485600.rectTransform);
        _0x24485600.raycastTarget = true;
        TextMeshProUGUI _0x135d4d4c = _0x131f2561.Caption(_0x3992b0d3, _0xcf1f8c08._0x215e2965(new byte[12] { 150, 160, 177, 177, 172, 171, 162, 182, 141, 160, 164, 161 }, 197), _0x0d5b3d29, _0xcf1f8c08._0x215e2965(new byte[8] { 7, 17, 0, 0, 29, 26, 19, 7 }, 84), 56f, _0x687afa6e.Gold, TextAlignmentOptions.Center);
        _0x131f2561.Fit(_0x135d4d4c.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -236f), new Vector2(940f, 76f));
        RectTransform _0x6d6e9e4f = this._0x6d376e30(_0x3992b0d3, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[7] { 234, 227, 242, 246, 235, 225, 241 }, 162), 0);
        this._0xb90d2ae6(_0x6d6e9e4f, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[2] { 47, 46 }, 96), 110f, 200f, 0, this._0x33d5aab4, this._0xd9bc3c41, () => this._0xb7cb9a5c(true));
        this._0xb90d2ae6(_0x6d6e9e4f, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[3] { 159, 150, 150 }, 208), 350f, 200f, 1, this._0x33d5aab4, this._0xd9bc3c41, () => this._0xb7cb9a5c(false));
        RectTransform _0x864abfa9 = this._0x6d376e30(_0x3992b0d3, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[10] { 61, 59, 40, 32, 37, 73, 46, 37, 38, 62 }, 105), 1);
        this._0xb90d2ae6(_0x864abfa9, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[4] { 144, 140, 133, 151 }, 195), 60f, 160f, 0, this._0x2cec35d6, this._0xe0c8d697, () => this._0x8dcf0266(0));
        this._0xb90d2ae6(_0x864abfa9, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[6] { 16, 0, 27, 21, 26, 6 }, 82), 240f, 160f, 1, this._0x2cec35d6, this._0xe0c8d697, () => this._0x8dcf0266(1));
        this._0xb90d2ae6(_0x864abfa9, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[5] { 232, 230, 235, 240, 239 }, 170), 420f, 160f, 2, this._0x2cec35d6, this._0xe0c8d697, () => this._0x8dcf0266(2));
        RectTransform _0xaa53cfa9 = this._0x6d376e30(_0x3992b0d3, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[11] { 27, 25, 20, 21, 120, 21, 23, 12, 17, 23, 22 }, 88), 2);
        this._0xb90d2ae6(_0xaa53cfa9, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[2] { 129, 128 }, 206), 110f, 200f, 0, this._0x0ef6cfd4, this._0xd3a24fcf, () => this._0x42df35fa(true));
        this._0xb90d2ae6(_0xaa53cfa9, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[3] { 47, 38, 38 }, 96), 350f, 200f, 1, this._0x0ef6cfd4, this._0xd3a24fcf, () => this._0x42df35fa(false));
        RectTransform _0x8129fecd = this._0x6d376e30(_0x3992b0d3, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[8] { 41, 43, 54, 62, 43, 60, 42, 42 }, 121), 3);
        this._0xb90d2ae6(_0x8129fecd, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[5] { 150, 129, 151, 129, 144 }, 196), 230f, 280f, 0, null, null, () => this._0x878251a2(true));
        RectTransform _0xf6574a4d = _0x131f2561.Fit(_0x131f2561.Branch(_0xcf1f8c08._0x215e2965(new byte[12] { 168, 159, 137, 159, 142, 185, 149, 148, 156, 147, 136, 151 }, 250), _0x3992b0d3), new Vector2(0.5f, 1f), new Vector2(0f, -452f - 4f * RowPitch), new Vector2(RowWidth, RowHeight));
        this._0xd2138cf2 = _0xf6574a4d.gameObject;
        Image _0xad98b0dc = _0x131f2561.Plate(_0xf6574a4d, _0xcf1f8c08._0x215e2965(new byte[12] { 48, 28, 29, 21, 26, 1, 30, 35, 31, 18, 7, 22 }, 115), _0x99a236ee, _0x687afa6e.Alpha(_0x687afa6e.Danger, 0.22f), 1.4f);
        _0x131f2561.Stretch(_0xad98b0dc.rectTransform);
        TextMeshProUGUI _0x35d33a91 = _0x131f2561.Caption(_0xf6574a4d, _0xcf1f8c08._0x215e2965(new byte[11] { 198, 234, 235, 227, 236, 247, 232, 209, 224, 253, 241 }, 133), _0x0d5b3d29, _0xcf1f8c08._0x215e2965(new byte[17] { 95, 72, 91, 73, 95, 58, 95, 76, 95, 72, 67, 78, 82, 83, 84, 93, 37 }, 26), 34f, _0x687afa6e.TextPrimary, TextAlignmentOptions.Left);
        _0x131f2561.Fit(_0x35d33a91.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(LabelCentre, 0f), new Vector2(LabelWidth, 56f));
        this._0xb90d2ae6(_0xf6574a4d, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[3] { 216, 196, 210 }, 129), 110f, 200f, 0, null, null, () => this._0xf174362e());
        this._0xb90d2ae6(_0xf6574a4d, _0x0d5b3d29, _0x99a236ee, _0xcf1f8c08._0x215e2965(new byte[2] { 47, 46 }, 97), 350f, 200f, 1, null, null, () => this._0x878251a2(false));
        this._0xd2138cf2.SetActive(false);
        TextMeshProUGUI _0xe7d15495 = _0x131f2561.Caption(_0x3992b0d3, _0xcf1f8c08._0x215e2965(new byte[15] { 148, 162, 179, 179, 174, 169, 160, 180, 145, 162, 181, 180, 174, 168, 169 }, 199), _0x0d5b3d29, string.Format(_0xcf1f8c08._0x215e2965(new byte[11] { 159, 140, 155, 154, 128, 134, 135, 233, 178, 249, 180 }, 201), Application.version), 30f, _0x687afa6e.TextSecondary, TextAlignmentOptions.Center);
        _0x131f2561.Fit(_0xe7d15495.rectTransform, new Vector2(0.5f, 0f), new Vector2(0f, 300f), new Vector2(940f, 48f));
        Button _0x4f5d3cf9 = _0x131f2561.Glyph(_0x3992b0d3, _0xcf1f8c08._0x215e2965(new byte[13] { 196, 242, 227, 227, 254, 249, 240, 228, 212, 251, 248, 228, 242 }, 151), _0x002daa7b, _0x99a236ee, new Vector2(1f, 1f), new Vector2(-118f, -236f), 112f, _0x687afa6e.TextPrimary);
        _0x4f5d3cf9.onClick.AddListener(() => this._0xc003825d());
        this._0x7385e7c8.SetActive(false);
        return this;
    }

    private void _0x8e49a3ce()
    {
        this._0x15eed1ab(this._0x33d5aab4, this._0xd9bc3c41, _0x1b98df55._0xb7531c9e ? 0 : 1);
        this._0x15eed1ab(this._0x2cec35d6, this._0xe0c8d697, _0x1b98df55._0x8aff4184);
        this._0x15eed1ab(this._0x0ef6cfd4, this._0xd3a24fcf, _0x1b98df55._0xb9c0d93b ? 0 : 1);
    }

    private readonly Image[] _0x33d5aab4 = new Image[2];
    public void _0xc003825d()
    {
        if (this._0x7385e7c8 != null)
            this._0x7385e7c8.SetActive(false);
    }

    private readonly TextMeshProUGUI[] _0xd3a24fcf = new TextMeshProUGUI[2];
    private const float LabelCentre = -290f;
    private GameObject _0x7385e7c8;
}

internal static class _0xcf1f8c08
{
    internal static string _0x215e2965(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}