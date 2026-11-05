using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Everything the pilot reads while flying. Built as our own objects inside the game
/// panel - none of it is hung on a template slot, so nothing here depends on a placeholder
/// the pipeline switches off (rule C.2).
public sealed class _0x73c586f9 : MonoBehaviour
{
    public _0x73c586f9 _0xf05e5987(Transform _0xe5fbb189, TMP_FontAsset _0xb0d13169, Sprite _0xfa133701, Sprite _0x37ed9a04, Sprite _0x067b4c20)
    {
        // Ember bar. Its band is x -445..295 and the readout starts at 320, so the two never
        // share a horizontal strip (rule C.25).
        Image _0x5c3217f7 = _0x131f2561.Plate(_0xe5fbb189, _0x618d7751._0xedeb8548(new byte[10] { 231, 207, 192, 199, 208, 246, 208, 195, 193, 201 }, 162), _0xfa133701, _0x687afa6e.Alpha(_0x687afa6e.BgSurface, 0.92f), 1.2f);
        _0x131f2561.Fit(_0x5c3217f7.rectTransform, new Vector2(0.5f, 1f), new Vector2(-75f, -330f), new Vector2(BarWidth, BarHeight));
        this._0x772e1d4b = _0x5c3217f7;
        Image _0x36842fdf = _0x131f2561.Plate(_0x5c3217f7.transform, _0x618d7751._0xedeb8548(new byte[9] { 97, 73, 70, 65, 86, 97, 64, 67, 65 }, 36), _0xfa133701, _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.45f), 1.2f);
        _0x131f2561.Stretch(_0x36842fdf.rectTransform);
        _0x36842fdf.rectTransform.offsetMin = new Vector2(-3f, -3f);
        _0x36842fdf.rectTransform.offsetMax = new Vector2(3f, 3f);
        _0x36842fdf.transform.SetAsFirstSibling();
        Image _0xf72ed3ab = _0x131f2561.Plate(_0x5c3217f7.transform, _0x618d7751._0xedeb8548(new byte[9] { 243, 219, 212, 211, 196, 240, 223, 218, 218 }, 182), _0xfa133701, _0x687afa6e.Ember, 1.2f);
        RectTransform _0x93b644dc = _0xf72ed3ab.rectTransform;
        _0x93b644dc.anchorMin = new Vector2(0f, 0.5f);
        _0x93b644dc.anchorMax = new Vector2(0f, 0.5f);
        _0x93b644dc.pivot = new Vector2(0f, 0.5f);
        _0x93b644dc.anchoredPosition = new Vector2(BarInset, 0f);
        _0x93b644dc.sizeDelta = new Vector2(BarWidth - BarInset * 2f, BarHeight - 12f);
        this._0x02cedbb3 = _0xf72ed3ab;
        this._0x00667fe3 = _0x131f2561.Caption(_0xe5fbb189, _0x618d7751._0xedeb8548(new byte[10] { 243, 219, 212, 211, 196, 224, 215, 218, 195, 211 }, 182), _0xb0d13169, _0x618d7751._0xedeb8548(new byte[3] { 176, 177, 177 }, 129), 52f, _0x687afa6e.EmberLight, TextAlignmentOptions.Left);
        _0x131f2561.Fit(this._0x00667fe3.rectTransform, new Vector2(0.5f, 1f), new Vector2(400f, -330f), new Vector2(160f, 72f));
        // Required colour: the single most important readout, so it sits alone above the bar.
        this._0x43d71c61 = _0x131f2561.Picture(_0xe5fbb189, _0x618d7751._0xedeb8548(new byte[7] { 138, 179, 170, 146, 187, 182, 181 }, 218), _0x067b4c20, _0x687afa6e.Alpha(_0x687afa6e.Ember, 0.5f));
        _0x131f2561.Fit(this._0x43d71c61.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -205f), new Vector2(126f, 126f));
        this._0xf32aaed2 = _0x131f2561.Picture(_0xe5fbb189, _0x618d7751._0xedeb8548(new byte[3] { 248, 193, 216 }, 168), _0x37ed9a04, _0x687afa6e.Ember);
        _0x131f2561.Fit(this._0xf32aaed2.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -205f), new Vector2(92f, 92f));
        this._0xa25f23ba = _0x131f2561.Picture(_0xe5fbb189, _0x618d7751._0xedeb8548(new byte[8] { 204, 233, 251, 224, 218, 225, 230, 239 }, 136), _0x37ed9a04, _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.85f));
        _0x131f2561.Fit(this._0xa25f23ba.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -205f), new Vector2(126f, 126f));
        // Combo badge.
        this._0x8471f80e = _0x131f2561.Plate(_0xe5fbb189, _0x618d7751._0xedeb8548(new byte[10] { 179, 159, 157, 146, 159, 160, 156, 145, 132, 149 }, 240), _0xfa133701, _0x687afa6e.Alpha(_0x687afa6e.BgSurface, 0.90f), 1.4f);
        this._0xa27314f2 = this._0x8471f80e.rectTransform;
        _0x131f2561.Fit(this._0xa27314f2, new Vector2(0.5f, 1f), new Vector2(0f, -440f), new Vector2(290f, 100f));
        this._0x5db7dfe8 = _0x131f2561.Caption(this._0x8471f80e.transform, _0x618d7751._0xedeb8548(new byte[10] { 2, 46, 44, 35, 46, 23, 32, 45, 52, 36 }, 65), _0xb0d13169, _0x618d7751._0xedeb8548(new byte[2] { 54, 126 }, 78), 60f, _0x687afa6e.Gold, TextAlignmentOptions.Center);
        _0x131f2561.Stretch(this._0x5db7dfe8.rectTransform);
        this._0x107f8eba = _0x131f2561.Caption(_0xe5fbb189, _0x618d7751._0xedeb8548(new byte[9] { 78, 104, 125, 108, 74, 102, 124, 103, 125 }, 9), _0xb0d13169, _0x618d7751._0xedeb8548(new byte[12] { 17, 23, 2, 19, 118, 102, 102, 118, 121, 118, 102, 102 }, 86), 40f, _0x687afa6e.TextSecondary, TextAlignmentOptions.Center);
        _0x131f2561.Fit(this._0x107f8eba.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -548f), new Vector2(460f, 56f));
        // Beat banner. Shares its slot with the control card, which has always faded before
        // the first beat fires.
        this._0x830828a5 = _0x131f2561.Plate(_0xe5fbb189, _0x618d7751._0xedeb8548(new byte[6] { 210, 241, 254, 254, 245, 226 }, 144), _0xfa133701, _0x687afa6e.Alpha(_0x687afa6e.BgSurface, 0.94f), 1.35f);
        this._0x4fdf1625 = this._0x830828a5.rectTransform;
        _0x131f2561.Fit(this._0x4fdf1625, new Vector2(0.5f, 1f), new Vector2(0f, -730f), new Vector2(900f, 120f));
        this._0x26c50fe6 = _0x131f2561.Plate(this._0x830828a5.transform, _0x618d7751._0xedeb8548(new byte[12] { 199, 228, 235, 235, 224, 247, 196, 230, 230, 224, 235, 241 }, 133), _0xfa133701, _0x687afa6e.Gold, 1.2f);
        _0x131f2561.Fit(this._0x26c50fe6.rectTransform, new Vector2(0f, 0.5f), new Vector2(46f, 0f), new Vector2(14f, 70f));
        this._0xef98f1ad = _0x131f2561.Caption(this._0x830828a5.transform, _0x618d7751._0xedeb8548(new byte[10] { 164, 135, 136, 136, 131, 148, 178, 131, 158, 146 }, 230), _0xb0d13169, "", 44f, _0x687afa6e.Gold, TextAlignmentOptions.Left);
        // Gutter is x 39..53; the label starts at 100 and is 700 wide (rule C.25).
        _0x131f2561.Fit(this._0xef98f1ad.rectTransform, new Vector2(0f, 0.5f), new Vector2(450f, 0f), new Vector2(700f, 76f));
        this._0x22b17096 = this._0x4fdf1625.anchoredPosition.y;
        this._0x830828a5.gameObject.SetActive(false);
        TextMeshProUGUI _0x2b71e8a5 = _0x131f2561.Caption(_0xe5fbb189, _0x618d7751._0xedeb8548(new byte[11] { 57, 21, 20, 14, 8, 21, 22, 50, 19, 20, 14 }, 122), _0xb0d13169, _0x618d7751._0xedeb8548(new byte[51] { 221, 217, 199, 222, 203, 174, 194, 174, 161, 174, 220, 174, 174, 205, 198, 207, 192, 201, 203, 174, 194, 207, 192, 203, 174, 174, 174, 163, 174, 174, 174, 221, 217, 199, 222, 203, 174, 219, 222, 174, 174, 203, 195, 204, 203, 220, 174, 202, 207, 221, 198 }, 142), 34f, _0x687afa6e.TextSecondary, TextAlignmentOptions.Center);
        _0x131f2561.Fit(_0x2b71e8a5.rectTransform, new Vector2(0.5f, 0f), new Vector2(0f, 180f), new Vector2(1120f, 56f));
        return this;
    }

    private TextMeshProUGUI _0x107f8eba;
    public void _0x55b3c7e9(int _0xffa619c7, int _0x3405a124)
    {
        if (this._0x107f8eba == null)
            return;
        this._0x107f8eba.text = string.Format(_0x618d7751._0xedeb8548(new byte[20] { 175, 169, 188, 173, 200, 147, 216, 210, 216, 216, 149, 200, 199, 200, 147, 217, 210, 216, 216, 149 }, 232), _0xffa619c7, _0x3405a124);
    }

    /// Raise a beat banner. Held long enough that a capture frame taken anywhere in the
    /// window shows it (rule C.5 timing, section 6.7 of the design).
    public void _0xf6e0b895(string _0xc1202c32, Color _0xd9ec37d3, float _0x802a68ee)
    {
        if (this._0x830828a5 == null)
            return;
        this._0xef98f1ad.text = _0xc1202c32;
        this._0xef98f1ad.color = _0xd9ec37d3;
        _0x131f2561.Readable(this._0xef98f1ad, _0xd9ec37d3);
        this._0x26c50fe6.color = _0xd9ec37d3;
        this._0x830828a5.gameObject.SetActive(true);
        this._0x4fdf1625.anchoredPosition = new Vector2(0f, this._0x22b17096 - 60f);
        this._0x4fdf1625.DOAnchorPosY(this._0x22b17096, 0.25f).SetEase(Ease.OutCubic).SetLink(this.gameObject);
        DOVirtual.DelayedCall(_0x802a68ee, () => this._0xe1e04780()).SetLink(this.gameObject);
    }

    private Image _0x830828a5;
    public void _0x02821345()
    {
        if (this._0xa27314f2 == null)
            return;
        this._0xa27314f2.DOScale(1.18f, 0.1f).SetEase(Ease.OutQuad).SetLink(this.gameObject);
        this._0xa27314f2.DOScale(1f, 0.2f).SetDelay(0.1f).SetEase(Ease.OutBack).SetLink(this.gameObject);
    }

    private Image _0x02cedbb3;
    public void _0xd9251fa4(int _0x765eb355)
    {
        if (this._0x5db7dfe8 == null)
            return;
        this._0x5db7dfe8.text = _0x618d7751._0xedeb8548(new byte[1] { 56 }, 64) + _0x765eb355;
        this._0x5db7dfe8.color = _0x765eb355 > 0 ? _0x687afa6e.Gold : _0x687afa6e.TextSecondary;
    }

    private void _0xe1e04780()
    {
        if (this._0x830828a5 == null || this._0x4fdf1625 == null)
            return;
        this._0x4fdf1625.DOAnchorPosY(this._0x22b17096 - 60f, 0.22f).SetEase(Ease.InCubic).SetLink(this.gameObject);
        DOVirtual.DelayedCall(0.24f, () => this._0xff3906f0()).SetLink(this.gameObject);
    }

    private Image _0x43d71c61;
    private TextMeshProUGUI _0x5db7dfe8;
    public void _0xb70bdfb1(Image _0x2324088d, bool _0xdfca8c71)
    {
        if (_0x2324088d == null)
            return;
        _0x2324088d.DOFade(_0xdfca8c71 ? 0.18f : 0f, 0.4f).SetLink(this.gameObject);
    }

    private const float BarHeight = 52f;
    private Image _0x8471f80e;
    private void _0xff3906f0()
    {
        if (this._0x830828a5 != null)
            this._0x830828a5.gameObject.SetActive(false);
    }

    public void _0x1f4cb5cb(float _0x21674dbc, float _0xb12763c8)
    {
        float _0x15c116b0 = Mathf.Clamp01(_0xb12763c8 <= 0f ? 0f : _0x21674dbc / _0xb12763c8);
        if (this._0x02cedbb3 != null)
        {
            this._0x02cedbb3.rectTransform.sizeDelta = new Vector2(Mathf.Max(8f, (BarWidth - BarInset * 2f) * _0x15c116b0), BarHeight - 12f);
            this._0x02cedbb3.color = _0x15c116b0 < 0.6f ? _0x687afa6e.Mix(_0x687afa6e.Danger, _0x687afa6e.Ember, _0x15c116b0 / 0.6f) : _0x687afa6e.Ember;
        }

        if (this._0x00667fe3 != null)
            this._0x00667fe3.text = Mathf.CeilToInt(Mathf.Max(0f, _0x21674dbc)).ToString();
    }

    private Image _0xa25f23ba;
    private float _0x22b17096;
    private TextMeshProUGUI _0xef98f1ad;
    private Image _0xf32aaed2;
    public void _0x7658979d(int _0x19de811e)
    {
        int _0x95f60c98 = Mathf.Clamp(_0x19de811e, 0, _0x687afa6e.GateFills.Length - 1);
        if (this._0xf32aaed2 != null)
            this._0xf32aaed2.color = _0x687afa6e.GateFills[_0x95f60c98];
        if (this._0x43d71c61 != null)
            this._0x43d71c61.color = _0x687afa6e.Alpha(_0x687afa6e.GateFills[_0x95f60c98], 0.5f);
    }

    public void _0x2adb5c4e()
    {
        if (this._0xa27314f2 == null)
            return;
        this._0xa27314f2.DOShakeAnchorPos(0.25f, 14f, 14).SetLink(this.gameObject);
    }

    private RectTransform _0xa27314f2;
    private RectTransform _0x4fdf1625;
    private const float BarWidth = 740f;
    private Image _0x772e1d4b;
    private Image _0x26c50fe6;
    private const float BarInset = 6f;
    private TextMeshProUGUI _0x00667fe3;
    private void OnDestroy()
    {
        DOTween.Kill(this._0xa27314f2);
        DOTween.Kill(this._0x4fdf1625);
        DOTween.Kill(this.gameObject);
    }

    public void _0xc55f2535(float _0xffa83ecd)
    {
        if (this._0xa25f23ba == null)
            return;
        float _0x1d06d8a9 = Mathf.Clamp01(_0xffa83ecd);
        this._0xa25f23ba.color = _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.15f + 0.70f * _0x1d06d8a9);
    }
}

internal static class _0x618d7751
{
    internal static string _0xedeb8548(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}