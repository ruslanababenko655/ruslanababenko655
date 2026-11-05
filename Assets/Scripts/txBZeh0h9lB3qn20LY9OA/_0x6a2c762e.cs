using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The card that tells a first-time pilot what the two gestures do. It is a scene object in
/// the game itself, not a template tutorial panel, so it shows on EVERY launch and lands in
/// the first capture frame (rule C.6). The permanent one-line hint below it stays for the
/// whole run; this card only carries the longer explanation.
public sealed class _0x6a2c762e : MonoBehaviour
{
    public _0x6a2c762e _0xcc2b2a1e(Transform _0xdaf6a69d, TMP_FontAsset _0x24048d16, Sprite _0x6245448d, Sprite _0x7a899a7a)
    {
        Image _0xa3d15afa = _0x131f2561.Plate(_0xdaf6a69d, _0x7539055d._0xffe17834(new byte[11] { 58, 22, 23, 13, 11, 22, 21, 58, 24, 11, 29 }, 121), _0x6245448d, _0x687afa6e.Alpha(_0x687afa6e.BgSurface, 0.94f), 1.35f);
        _0x131f2561.Fit(_0xa3d15afa.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -730f), new Vector2(960f, 230f));
        this._0x987967bb = _0xa3d15afa.gameObject.AddComponent<CanvasGroup>();
        Image _0xad4e07f7 = _0x131f2561.Plate(_0xa3d15afa.transform, _0x7539055d._0xffe17834(new byte[8] { 55, 21, 6, 16, 49, 16, 19, 17 }, 116), _0x6245448d, _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.55f), 1.35f);
        _0x131f2561.Stretch(_0xad4e07f7.rectTransform);
        _0xad4e07f7.rectTransform.offsetMin = new Vector2(-4f, -4f);
        _0xad4e07f7.rectTransform.offsetMax = new Vector2(4f, 4f);
        _0xad4e07f7.transform.SetAsFirstSibling();
        TextMeshProUGUI _0x55d90524 = _0x131f2561.Caption(_0xa3d15afa.transform, _0x7539055d._0xffe17834(new byte[8] { 28, 62, 45, 59, 23, 58, 62, 59 }, 95), _0x24048d16, _0x7539055d._0xffe17834(new byte[28] { 0, 12, 25, 14, 5, 109, 25, 5, 8, 109, 10, 12, 25, 8, 109, 25, 2, 109, 20, 2, 24, 31, 109, 8, 0, 15, 8, 31 }, 77), 44f, _0x687afa6e.Gold, TextAlignmentOptions.Center);
        _0x131f2561.Fit(_0x55d90524.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -46f), new Vector2(880f, 56f));
        TextMeshProUGUI _0xca8a7ad2 = _0x131f2561.Caption(_0xa3d15afa.transform, _0x7539055d._0xffe17834(new byte[8] { 230, 196, 215, 193, 231, 202, 193, 220 }, 165), _0x24048d16, _0x7539055d._0xffe17834(new byte[45] { 203, 207, 209, 200, 221, 184, 212, 184, 183, 184, 202, 184, 184, 219, 208, 217, 214, 223, 221, 184, 212, 217, 214, 221, 146, 203, 207, 209, 200, 221, 184, 205, 200, 184, 184, 221, 213, 218, 221, 202, 184, 220, 217, 203, 208 }, 152), 36f, _0x687afa6e.TextPrimary, TextAlignmentOptions.Center);
        _0x131f2561.Fit(_0xca8a7ad2.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -124f), new Vector2(880f, 96f));
        for (int _0x7f3da9a6 = 0; _0x7f3da9a6 < 3; _0x7f3da9a6++)
        {
            Image _0xe450a489 = _0x131f2561.Picture(_0xa3d15afa.transform, _0x7539055d._0xffe17834(new byte[7] { 69, 103, 116, 98, 66, 105, 114 }, 6), _0x7a899a7a, _0x687afa6e.GateFills[_0x7f3da9a6]);
            _0x131f2561.Fit(_0xe450a489.rectTransform, new Vector2(0.5f, 0f), new Vector2(-62f + 62f * _0x7f3da9a6, 34f), new Vector2(44f, 44f));
            this._0xf787d040[_0x7f3da9a6] = _0xe450a489;
        }

        this._0xb4e5cb3c = HoldSeconds;
        return this;
    }

    private void Update()
    {
        if (this._0x83f0ac27)
            return;
        float step = _0x5f296d13._0x5d49422c;
        if (step <= 0f)
            return;
        this._0xb4e5cb3c -= step;
        if (this._0xb4e5cb3c <= 0f)
            this._0xb4f5cdca();
    }

    private float _0xb4e5cb3c;
    private void OnDestroy()
    {
        DOTween.Kill(this._0x987967bb);
        DOTween.Kill(this.gameObject);
    }

    private void _0xac0ada65()
    {
        if (this._0x987967bb != null)
            this._0x987967bb.gameObject.SetActive(false);
    }

    private Image[] _0xf787d040 = new Image[3];
    public const float HoldSeconds = 9f;
    /// Fade the card out, either on its timer or on the pilot's first real steering input.
    public void _0xb4f5cdca()
    {
        if (this._0x83f0ac27 || this._0x987967bb == null)
            return;
        this._0x83f0ac27 = true;
        this._0x987967bb.DOFade(0f, 0.5f).SetLink(this.gameObject);
        DOVirtual.DelayedCall(0.55f, () => this._0xac0ada65()).SetLink(this.gameObject);
    }

    private CanvasGroup _0x987967bb;
    private bool _0x83f0ac27;
}

internal static class _0x7539055d
{
    internal static string _0xffe17834(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}