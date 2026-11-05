using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// One row of the circuit on screen: up to three gates, a crystal and a mote, all as UI
/// images under a single rect that slides down. Contact is an arithmetic crossing test run
/// by the director - no bodies, no overlap test, so nothing can tunnel at any speed.
public sealed class _0x6cc1e207 : MonoBehaviour
{
    /// Move the crystal out of the lane the dragon is already flying in, at the moment the
    /// row appears. Flying INTO one later is still entirely possible.
    public void _0x95d2ce35(int _0x4f801693, float[] _0x21cce9ea)
    {
        if (this._0x0380a1c4 == null || this._0x0380a1c4.Barrier != _0x4f801693 || this._0x5fafc2bb == null)
            return;
        this._0x0380a1c4._0x4cc14f92(_0x4f801693);
        if (this._0x0380a1c4.Barrier < 0)
        {
            this._0x5fafc2bb.gameObject.SetActive(false);
            return;
        }

        Vector2 _0xa0235834 = this._0x5fafc2bb.rectTransform.anchoredPosition;
        this._0x5fafc2bb.rectTransform.anchoredPosition = new Vector2(_0x21cce9ea[this._0x0380a1c4.Barrier], _0xa0235834.y);
    }

    private Image _0xf66ee882;
    public _0xf97a39f6 _0x0380a1c4 { get; private set; }

    private Image _0x5fafc2bb;
    /// The gate the dragon just flew through, lit up.
    public void _0xbba8e241(int _0x258a7b3f, bool _0x193503fa)
    {
        if (_0x258a7b3f < 0 || _0x258a7b3f > 2)
            return;
        Image _0x2e254aa6 = this._0xf679f655[_0x258a7b3f];
        Image _0x5dd05bf9 = this._0x6e52d741[_0x258a7b3f];
        if (_0x2e254aa6 != null)
        {
            Vector2 _0x7532bcc8 = _0x2e254aa6.rectTransform.sizeDelta;
            _0x2e254aa6.rectTransform.DOSizeDelta(_0x7532bcc8 * (_0x193503fa ? 1.14f : 0.92f), 0.22f).SetEase(Ease.OutQuad).SetLink(this.gameObject);
        }

        if (_0x5dd05bf9 != null)
            _0x5dd05bf9.DOFade(_0x193503fa ? 0.9f : 0f, 0.3f).SetLink(this.gameObject);
    }

    private Image[] _0x6e52d741 = new Image[3];
    public float _0x406d6a15
    {
        get
        {
            return this._0xca2c60b5 != null ? this._0xca2c60b5.anchoredPosition.y : 0f;
        }

        set
        {
            if (this._0xca2c60b5 != null)
                this._0xca2c60b5.anchoredPosition = new Vector2(0f, value);
        }
    }

    private RectTransform _0xca2c60b5;
    private Image[] _0xf679f655 = new Image[3];
    public void _0x7cb6d8e2()
    {
        if (this._0xf66ee882 == null)
            return;
        this._0xf66ee882.DOFade(0f, 0.25f).SetLink(this.gameObject);
        this._0xf66ee882.rectTransform.DOAnchorPosY(this._0xf66ee882.rectTransform.anchoredPosition.y + 90f, 0.3f).SetLink(this.gameObject);
    }

    public _0x6cc1e207 _0x8ded5f00(_0xf97a39f6 _0x37307a9d, int _0x135709b5, RectTransform _0xa5d52a77, float[] _0xd567172b, float _0x2250e186, Sprite _0xe8a36219, Sprite _0xc1daa473, Sprite _0x95bcec63, Sprite _0xb4f7e412)
    {
        this._0x0380a1c4 = _0x37307a9d;
        this._0xb2f499a0 = _0x135709b5;
        this._0xca2c60b5 = _0xa5d52a77;
        this._0xefce919a = false;
        for (int _0x6224ada6 = 0; _0x6224ada6 < 3; _0x6224ada6++)
        {
            int _0xe74a31b7 = _0x37307a9d.Gate[_0x6224ada6];
            if (_0xe74a31b7 < 0)
                continue;
            Image _0x4b02f62b = _0x131f2561.Picture(_0xa5d52a77, _0xe3e110b4._0xb17913fa(new byte[4] { 146, 187, 182, 181 }, 218), _0xc1daa473, _0x687afa6e.Alpha(_0x687afa6e.GateFills[_0xe74a31b7], 0.42f));
            _0x131f2561.Fit(_0x4b02f62b.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(_0xd567172b[_0x6224ada6], 0f), new Vector2(_0x2250e186 * 1.22f, _0x2250e186 * 1.22f));
            Image _0xb12cc352 = _0x131f2561.Picture(_0xa5d52a77, _0xe3e110b4._0xb17913fa(new byte[4] { 35, 16, 1, 10 }, 98), _0xe8a36219, _0x687afa6e.GateFills[_0xe74a31b7]);
            _0x131f2561.Fit(_0xb12cc352.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(_0xd567172b[_0x6224ada6], 0f), new Vector2(_0x2250e186, _0x2250e186));
            this._0x6e52d741[_0x6224ada6] = _0x4b02f62b;
            this._0xf679f655[_0x6224ada6] = _0xb12cc352;
        }

        if (_0x37307a9d.Barrier >= 0)
        {
            this._0x5fafc2bb = _0x131f2561.Picture(_0xa5d52a77, _0xe3e110b4._0xb17913fa(new byte[7] { 45, 28, 23, 29, 26, 15, 2 }, 110), _0x95bcec63, Color.white);
            _0x131f2561.Fit(this._0x5fafc2bb.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(_0xd567172b[_0x37307a9d.Barrier], 0f), new Vector2(_0x2250e186 * 0.82f, _0x2250e186 * 0.82f));
        }

        if (_0x37307a9d.Mote >= 0)
        {
            this._0xf66ee882 = _0x131f2561.Picture(_0xa5d52a77, _0xe3e110b4._0xb17913fa(new byte[4] { 222, 252, 231, 246 }, 147), _0xb4f7e412, _0x687afa6e.EmberLight);
            _0x131f2561.Fit(this._0xf66ee882.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(_0xd567172b[_0x37307a9d.Mote], _0x2250e186 * 0.62f), new Vector2(_0x2250e186 * 0.30f, _0x2250e186 * 0.30f));
            this._0xf66ee882.rectTransform.DOScale(1.18f, 0.7f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(this.gameObject);
        }

        return this;
    }

    public void _0x6a09a861()
    {
        if (this._0x5fafc2bb == null)
            return;
        this._0x5fafc2bb.DOFade(0f, 0.25f).SetLink(this.gameObject);
        this._0x5fafc2bb.rectTransform.DOScale(1.4f, 0.25f).SetLink(this.gameObject);
    }

    public int _0xb2f499a0 { get; private set; }
    public bool _0xefce919a { get; set; }
}

internal static class _0xe3e110b4
{
    internal static string _0xb17913fa(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}