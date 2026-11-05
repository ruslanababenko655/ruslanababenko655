using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The menu. It dresses the template's splash, then builds the sky map inside the
/// template's own default panel: the shard purse, the circuit the pilot is about to fly,
/// the dragon with its live wake, and the two sheets that sit over all of it. The one
/// template element it keeps is the pre-wired PLAY slot - the scene pins that slot to a
/// real button rect and its driver still owns the scene change, so nothing here has to
/// know a scene index.
public sealed class _0x8d091f3a : MonoBehaviour
{
    /// A setting changed: the wake thickens or thins, the sky slows down, the sway stops.
    private void _0x41c84416()
    {
        if (this._0xb124855b != null)
            this._0xb124855b._0x87eecbeb(6 + _0x1b98df55._0x8aff4184 * 4);
        if (this._0xd220361a != null)
            this._0xd220361a._0x4ecc83f7(_0x1b98df55._0xb9c0d93b ? 0.5f : 1f);
        this._0x4d98f6b7(!_0x1b98df55._0xb9c0d93b);
        this._0xa8e87fd8();
    }

    [SerializeField]
    private Sprite _gateGlow;
    private void Start()
    {
        this._0x920e0f38();
    }

    [SerializeField]
    private Sprite _dragonArt;
    [SerializeField]
    private Sprite _gateRing;
    private TextMeshProUGUI _0x246e1bd4;
    [SerializeField]
    private Sprite _emblemArt;
    private _0x368dcd47 _0xdafb1a37;
    private _0xa66dddcb _0x4ef0f4dc;
    private _0x4bf36e40 _0x755ce5d2;
    private TextMeshProUGUI _0xe9ef0493;
    private void _0x1864696d()
    {
        if (this._0x4ef0f4dc != null)
            this._0x4ef0f4dc._0x0038fc72();
    }

    /// A trail was picked: the wake behind the dragon changes colour on the spot, which
    /// is a change a still frame can show. A label swap would not be.
    private void _0x61fbe165()
    {
        if (this._0xb124855b != null)
            this._0xb124855b._0xc84c7c62(_0x687afa6e.TrailTints[_0x1b98df55._0x21bcf3a2]);
        this._0xa8e87fd8();
    }

    private const float HeroY = 1880f;
    [SerializeField]
    private Sprite _slab;
    private _0x90177657 _0xd220361a;
    private Image _0xd56bf3e3;
    /// The first screen: an abstract mark over a darkened sky, and the template's own
    /// loading bar repainted so it is actually visible.
    private void _0x93f0b1dd(_0x828b28ef _0xbcca0fce)
    {
        new _0x3934365a()._0x52a72421();
        if (_0xbcca0fce.Panels.Count <= _0x038ba1ae._0xdbcb6201.SPLASH)
            return;
        _0x049fd978 _0xa20a59b3 = _0xbcca0fce.Panels[_0x038ba1ae._0xdbcb6201.SPLASH];
        if (_0xa20a59b3 == null || _0xa20a59b3.Content == null)
            return;
        RectTransform _0xca9a129b = _0xa20a59b3.Content.GetComponent<RectTransform>();
        if (_0xca9a129b == null)
            return;
        _0xca9a129b.gameObject.AddComponent<_0xbbb8cf10>()._0xb9a3a258(_0xca9a129b, this._font, this._emblemArt, this._wispArt, 250f);
    }

    private void _0x54f60c96(int _0x478a9e6b)
    {
        this._0xa8e87fd8();
    }

    private void _0x4d98f6b7(bool _0x098c3974)
    {
        if (this._0xd6a57d43 == null)
            return;
        DOTween.Kill(this._0xd6a57d43);
        this._0xd6a57d43.anchoredPosition = new Vector2(0f, HeroY);
        this._0xd6a57d43.localRotation = Quaternion.identity;
        if (!_0x098c3974)
            return;
        this._0xd6a57d43.DOAnchorPosY(HeroY + HeroSway, 2.2f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._0xd6a57d43.gameObject);
        this._0xd6a57d43.DOLocalRotate(new Vector3(0f, 0f, 3f), 2.6f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this._0xd6a57d43.gameObject);
    }

    [SerializeField]
    private RectTransform _playSlot;
    [SerializeField]
    private Sprite _spireArt;
    private bool _0x31ef085e;
    private _0xae61d7dd _0xb124855b;
    [SerializeField]
    private Sprite _wispArt;
    private const float HeroSway = 26f;
    [SerializeField]
    private Sprite _iconClose;
    [SerializeField]
    private Sprite _cloudNear;
    /// One top readout: a caption over a big coloured number. Two of them sit side by
    /// side, each in its own plate, so neither label can slide under the other's value.
    private TextMeshProUGUI _0x0895ed3e(Transform _0x380e025f, string _0x0776da2a, string _0x25db2d73, float _0xca310095, Color _0x9e1727e3)
    {
        RectTransform _0xd4345e70 = _0x131f2561.Fit(_0x131f2561.Branch(_0x39906976._0xea5be7f0(new byte[7] { 79, 120, 124, 121, 114, 104, 105 }, 29), _0x380e025f), new Vector2(0.5f, 1f), new Vector2(_0xca310095, -210f), new Vector2(540f, 160f));
        Image _0x08e2925f = _0x131f2561.Plate(_0xd4345e70, _0x39906976._0xea5be7f0(new byte[11] { 99, 84, 80, 85, 94, 68, 69, 116, 85, 86, 84 }, 49), this._slab, _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.5f), 1.3f);
        _0x131f2561.Stretch(_0x08e2925f.rectTransform);
        Image _0xa7bf8d8a = _0x131f2561.Plate(_0xd4345e70, _0x39906976._0xea5be7f0(new byte[11] { 37, 18, 22, 19, 24, 2, 3, 53, 24, 19, 14 }, 119), this._slab, _0x687afa6e.Alpha(_0x687afa6e.BgSurface, 0.94f), 1.35f);
        _0x131f2561.Stretch(_0xa7bf8d8a.rectTransform);
        _0xa7bf8d8a.rectTransform.offsetMin = new Vector2(5f, 5f);
        _0xa7bf8d8a.rectTransform.offsetMax = new Vector2(-5f, -5f);
        TextMeshProUGUI _0x7b6a2514 = _0x131f2561.Caption(_0xd4345e70, _0x39906976._0xea5be7f0(new byte[11] { 67, 116, 112, 117, 126, 100, 101, 89, 116, 112, 117 }, 17), this._font, _0x0776da2a, 28f, _0x687afa6e.TextSecondary, TextAlignmentOptions.Center);
        _0x131f2561.Fit(_0x7b6a2514.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -36f), new Vector2(470f, 42f));
        TextMeshProUGUI _0x15684e78 = _0x131f2561.Caption(_0xd4345e70, _0x39906976._0xea5be7f0(new byte[12] { 164, 147, 151, 146, 153, 131, 130, 160, 151, 154, 131, 147 }, 246), this._font, _0x25db2d73, 58f, _0x9e1727e3, TextAlignmentOptions.Center);
        _0x131f2561.Fit(_0x15684e78.rectTransform, new Vector2(0.5f, 0f), new Vector2(0f, 48f), new Vector2(470f, 78f));
        return _0x15684e78;
    }

    /// Build the menu. Every rect here is sized off the panel's own rectangle, and on the
    /// frame Start runs that rectangle is still zero: the canvas has not resolved its
    /// scale and the safe-area host has not been sized. So the build waits for a real
    /// rect and Update keeps asking until there is one.
    private void _0x920e0f38()
    {
        if (this._0x31ef085e)
            return;
        _0x828b28ef _0x693ec0b8 = _0x828b28ef.Instance;
        if (_0x693ec0b8 == null || _0x693ec0b8.Panels == null || _0x693ec0b8.Panels.Count <= _0x038ba1ae._0xdbcb6201.DEFAULT)
            return;
        _0x049fd978 _0xc3594a46 = _0x693ec0b8.Panels[_0x038ba1ae._0xdbcb6201.DEFAULT];
        if (_0xc3594a46 == null || _0xc3594a46.Content == null)
            return;
        RectTransform _0x5b9e89b5 = _0xc3594a46.Content.GetComponent<RectTransform>();
        if (_0x5b9e89b5 == null)
            return;
        float width = _0x5b9e89b5.rect.width;
        float height = _0x5b9e89b5.rect.height;
        if (width < 1f || height < 1f)
            return;
        this._0x31ef085e = true;
        this._0x93f0b1dd(_0x693ec0b8);
        float _0xe2774408 = _0x1b98df55._0xb9c0d93b ? 0.5f : 1f;
        RectTransform _0x732f0097 = _0x131f2561.Stretch(_0x131f2561.Branch(_0x39906976._0xea5be7f0(new byte[7] { 66, 122, 104, 83, 112, 114, 122 }, 17), _0x5b9e89b5));
        _0x732f0097.SetAsFirstSibling();
        Image _0x8759a60b = _0x131f2561.Wash(_0x732f0097, _0x39906976._0xea5be7f0(new byte[7] { 106, 82, 64, 110, 88, 74, 81 }, 57), _0x687afa6e.Alpha(_0x687afa6e.BgDeep, 0.30f));
        _0x131f2561.Stretch(_0x8759a60b.rectTransform);
        this._0xd220361a = _0x732f0097.gameObject.AddComponent<_0x90177657>()._0x7b2c5bcf(_0x732f0097, this._cloudFar, this._cloudNear, this._spireArt, width, height, _0xe2774408);
        this._0x755ce5d2 = _0x5b9e89b5.gameObject.AddComponent<_0x4bf36e40>()._0x3375969f(_0x5b9e89b5, this._font, this._slab, -340f);
        this._0xe9ef0493 = this._0x0895ed3e(_0x5b9e89b5, _0x39906976._0xea5be7f0(new byte[12] { 52, 60, 51, 52, 35, 81, 34, 57, 48, 35, 53, 34 }, 113), _0x1b98df55._0x54309030.ToString(), -290f, _0x687afa6e.Gold);
        this._0xdafb1a37 = this._0xe9ef0493.gameObject.AddComponent<_0x368dcd47>();
        this._0xdafb1a37.MoneyCountText = this._0xe9ef0493;
        _0x42666298 _0x59a7227a = _0x42666298.Instance;
        if (_0x59a7227a != null && _0x59a7227a.MoneyCountContainers != null && !_0x59a7227a.MoneyCountContainers.Contains(this._0xdafb1a37))
            _0x59a7227a.MoneyCountContainers.Add(this._0xdafb1a37);
        this._0x77500a55 = this._0x0895ed3e(_0x5b9e89b5, _0x39906976._0xea5be7f0(new byte[10] { 80, 87, 65, 70, 50, 81, 93, 95, 80, 93 }, 18), _0x39906976._0xea5be7f0(new byte[1] { 19 }, 107) + _0x1b98df55._0xb6b09ccc, 290f, _0x687afa6e.TealLight);
        RectTransform _0xc1a0ceb7 = _0x131f2561.Fit(_0x131f2561.Branch(_0x39906976._0xea5be7f0(new byte[4] { 180, 130, 136, 134 }, 227), _0x5b9e89b5), new Vector2(0.5f, 0f), Vector2.zero, Vector2.zero);
        this._0xb124855b = _0xc1a0ceb7.gameObject.AddComponent<_0xae61d7dd>()._0xdfe98624(_0xc1a0ceb7, this._wispArt, 6 + _0x1b98df55._0x8aff4184 * 4, 150f, _0x687afa6e.TrailTints[_0x1b98df55._0x21bcf3a2]);
        RectTransform _0x621823d2 = _0x131f2561.Fit(_0x131f2561.Branch(_0x39906976._0xea5be7f0(new byte[8] { 91, 115, 120, 99, 94, 115, 100, 121 }, 22), _0x5b9e89b5), new Vector2(0.5f, 0f), new Vector2(0f, HeroY), new Vector2(440f, 440f));
        Image _0x65ec9810 = _0x131f2561.Picture(_0x621823d2, _0x39906976._0xea5be7f0(new byte[8] { 63, 18, 5, 24, 63, 22, 27, 24 }, 119), this._gateGlow, _0x687afa6e.Alpha(_0x687afa6e.Ember, 0.28f));
        _0x131f2561.Fit(_0x65ec9810.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(620f, 620f));
        Image _0xb5c4320f = _0x131f2561.Picture(_0x621823d2, _0x39906976._0xea5be7f0(new byte[8] { 100, 73, 94, 67, 127, 71, 69, 66 }, 44), this._dragonArt, Color.white);
        _0x131f2561.Stretch(_0xb5c4320f.rectTransform);
        this._0xd6a57d43 = _0x621823d2;
        this._0x4d98f6b7(!_0x1b98df55._0xb9c0d93b);
        this._0xf6739ee2 = _0x5b9e89b5.gameObject.AddComponent<_0x55992220>()._0x3bf3a454(_0x5b9e89b5, this._font, this._slab, this._slab, this._gateRing, this._0x755ce5d2, _0x61c9f254 => this._0x54f60c96(_0x61c9f254));
        this._0x246e1bd4 = _0x131f2561.Caption(_0x5b9e89b5, _0x39906976._0xea5be7f0(new byte[9] { 245, 216, 208, 223, 217, 206, 211, 204, 223 }, 186), this._font, _0x1ceaad4b.Objective(_0x1b98df55._0xd4859787), 34f, _0x687afa6e.TextSecondary, TextAlignmentOptions.Center);
        _0x131f2561.Fit(this._0x246e1bd4.rectTransform, new Vector2(0.5f, 0f), new Vector2(0f, 720f), new Vector2(1120f, 56f));
        Button _0x58c2f23c = _0x131f2561.Action(_0x5b9e89b5, _0x39906976._0xea5be7f0(new byte[12] { 137, 175, 188, 180, 177, 174, 159, 168, 169, 169, 178, 179 }, 221), this._font, this._slab, _0x39906976._0xea5be7f0(new byte[6] { 175, 169, 186, 178, 183, 168 }, 251), new Vector2(0.5f, 0f), new Vector2(-200f, 360f), new Vector2(380f, 124f), _0x687afa6e.TealLight, 40f);
        _0x58c2f23c.onClick.AddListener(() => this._0xf0a40255());
        Button _0x42a7f5bd = _0x131f2561.Action(_0x5b9e89b5, _0x39906976._0xea5be7f0(new byte[13] { 243, 204, 200, 213, 211, 210, 207, 254, 201, 200, 200, 211, 210 }, 188), this._font, this._slab, _0x39906976._0xea5be7f0(new byte[8] { 91, 77, 92, 92, 65, 70, 79, 91 }, 8), new Vector2(0.5f, 0f), new Vector2(200f, 360f), new Vector2(380f, 124f), _0x687afa6e.Gold, 40f);
        _0x42a7f5bd.onClick.AddListener(() => this._0x1864696d());
        this._0xeeb1e161(_0x5b9e89b5);
        this._0x03dbc454 = _0x5b9e89b5.gameObject.AddComponent<_0x6ee02748>()._0x7a89520c(_0x5b9e89b5, this._font, this._slab, this._wispArt, this._iconClose, this._0x755ce5d2, () => this._0x61fbe165());
        this._0x4ef0f4dc = _0x5b9e89b5.gameObject.AddComponent<_0xa66dddcb>()._0xbb881c87(_0x5b9e89b5, this._font, this._slab, this._iconClose, this._0x755ce5d2, () => this._0x41c84416());
        this._0x755ce5d2._0x421a395e();
    }

    private void OnDestroy()
    {
        DOTween.Kill(this._0xd6a57d43);
        DOTween.Kill(this._0xd56bf3e3);
        DOTween.Kill(this.gameObject);
    }

    private void _0xa8e87fd8()
    {
        if (this._0xdafb1a37 != null)
            this._0xdafb1a37._0x0d4a53c8();
        else if (this._0xe9ef0493 != null)
            this._0xe9ef0493.text = _0x1b98df55._0x54309030.ToString();
        if (this._0x77500a55 != null)
            this._0x77500a55.text = _0x39906976._0xea5be7f0(new byte[1] { 19 }, 107) + _0x1b98df55._0xb6b09ccc;
        if (this._0x246e1bd4 != null)
            this._0x246e1bd4.text = _0x1ceaad4b.Objective(_0x1b98df55._0xd4859787);
    }

    private _0x6ee02748 _0x03dbc454;
    private void Update()
    {
        if (!this._0x31ef085e)
        {
            this._0x920e0f38();
            return;
        }

        if (this._0xb124855b != null && this._0xd6a57d43 != null)
            this._0xb124855b._0x44f4f638(this._0xd6a57d43.anchoredPosition);
    }

    [SerializeField]
    private TMP_FontAsset _font;
    private void _0xf0a40255()
    {
        if (this._0x03dbc454 != null)
            this._0x03dbc454._0x5ed3eb5e();
    }

    private _0x55992220 _0xf6739ee2;
    private TextMeshProUGUI _0x77500a55;
    private RectTransform _0xd6a57d43;
    /// The PLAY face. The template slot renders nothing a player would recognise as a
    /// button - the variant switches every decorative layer off - so the face is built
    /// next to it, after it, at exactly its rect, with nothing of ours taking raycasts.
    /// A single near-invisible hit layer goes inside the slot so the tap always reaches
    /// the driver that owns the scene change.
    private void _0xeeb1e161(RectTransform _0x2c656849)
    {
        if (this._playSlot == null)
            return;
        RectTransform _0x53741675 = _0x131f2561.Branch(_0x39906976._0xea5be7f0(new byte[8] { 130, 190, 179, 171, 148, 179, 177, 183 }, 210), _0x2c656849);
        _0x53741675.anchorMin = this._playSlot.anchorMin;
        _0x53741675.anchorMax = this._playSlot.anchorMax;
        _0x53741675.pivot = this._playSlot.pivot;
        _0x53741675.anchoredPosition = this._playSlot.anchoredPosition;
        _0x53741675.sizeDelta = this._playSlot.sizeDelta;
        _0x53741675.SetAsLastSibling();
        Image _0x12ad5647 = _0x131f2561.Plate(_0x53741675, _0x39906976._0xea5be7f0(new byte[8] { 81, 109, 96, 120, 70, 109, 110, 118 }, 1), this._slab, _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.5f), 1.3f);
        _0x131f2561.Stretch(_0x12ad5647.rectTransform);
        _0x12ad5647.rectTransform.offsetMin = new Vector2(-9f, -9f);
        _0x12ad5647.rectTransform.offsetMax = new Vector2(9f, 9f);
        this._0xd56bf3e3 = _0x12ad5647;
        Image _0x9cb5e17f = _0x131f2561.Plate(_0x53741675, _0x39906976._0xea5be7f0(new byte[8] { 81, 109, 96, 120, 67, 110, 101, 120 }, 1), this._slab, _0x687afa6e.Ember, 1.35f);
        _0x131f2561.Stretch(_0x9cb5e17f.rectTransform);
        Image _0xdf208573 = _0x131f2561.Plate(_0x53741675, _0x39906976._0xea5be7f0(new byte[9] { 8, 52, 57, 33, 11, 48, 61, 61, 54 }, 88), this._slab, _0x687afa6e.Alpha(_0x687afa6e.EmberLight, 0.45f), 1.4f);
        _0x131f2561.Stretch(_0xdf208573.rectTransform);
        _0xdf208573.rectTransform.offsetMin = new Vector2(12f, 84f);
        _0xdf208573.rectTransform.offsetMax = new Vector2(-12f, -12f);
        TextMeshProUGUI _0xb7ca0e11 = _0x131f2561.Caption(_0x53741675, _0x39906976._0xea5be7f0(new byte[9] { 157, 161, 172, 180, 129, 172, 175, 168, 161 }, 205), this._font, _0x39906976._0xea5be7f0(new byte[4] { 218, 198, 203, 211 }, 138), 76f, _0x687afa6e.TextPrimary, TextAlignmentOptions.Center);
        _0x131f2561.Stretch(_0xb7ca0e11.rectTransform);
        _0xb7ca0e11.rectTransform.offsetMin = new Vector2(26f, 18f);
        _0xb7ca0e11.rectTransform.offsetMax = new Vector2(-26f, -18f);
        _0xb7ca0e11.characterSpacing = 8f;
        _0x12ad5647.DOFade(1f, 1.4f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(_0x12ad5647.gameObject);
        _0x131f2561.HitLayer(this._playSlot, _0x39906976._0xea5be7f0(new byte[7] { 196, 248, 245, 237, 220, 253, 224 }, 148));
    }

    [SerializeField]
    private Sprite _cloudFar;
}

internal static class _0x39906976
{
    internal static string _0xea5be7f0(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}