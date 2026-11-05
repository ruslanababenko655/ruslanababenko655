using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// One reusable surface for every "that is not available yet" or "that did not save"
/// message, so a refused tap always answers with something visible instead of nothing.
public sealed class _0x4bf36e40 : MonoBehaviour
{
    /// Put the chip last among its siblings. Draw order in UGUI is sibling order and
    /// nothing else, and a refusal message that appears behind the sheet that caused it
    /// is the same as no message at all.
    public void _0x421a395e()
    {
        if (this._0x4543a217 != null)
            this._0x4543a217.SetAsLastSibling();
    }

    public void _0x49779921(string _0x1f9ea763, bool _0xc3341183)
    {
        if (this._0x9fa31b03 == null)
            return;
        Color _0x20fdbb92 = _0xc3341183 ? _0x687afa6e.Danger : _0x687afa6e.Gold;
        this._0x0a01f526.text = _0x1f9ea763;
        this._0x0a01f526.color = _0x687afa6e.TextPrimary;
        this._0x6047eb8f.color = _0x20fdbb92;
        this._0x9fa31b03.gameObject.SetActive(true);
        DOTween.Kill(this._0x4543a217);
        this._0x4543a217.anchoredPosition = new Vector2(0f, this._0xfc386ba4 + 70f);
        this._0x4543a217.DOAnchorPosY(this._0xfc386ba4, 0.25f).SetEase(Ease.OutCubic).SetLink(this.gameObject);
        this._0x81268d8d = true;
        DOVirtual.DelayedCall(2.4f, () => this._0xa99b45ab()).SetId(this).SetLink(this.gameObject);
    }

    private TextMeshProUGUI _0x0a01f526;
    private Image _0x9fa31b03;
    private const float PlateWidth = 880f;
    private bool _0x81268d8d;
    private float _0xfc386ba4;
    private void _0x1194df07()
    {
        if (!this._0x81268d8d && this._0x9fa31b03 != null)
            this._0x9fa31b03.gameObject.SetActive(false);
    }

    public _0x4bf36e40 _0x3375969f(Transform _0xb3828e16, TMP_FontAsset _0xb6345f98, Sprite _0x8b7973b3, float _0x25e4a139)
    {
        this._0x9fa31b03 = _0x131f2561.Plate(_0xb3828e16, _0xef43b4d7._0x5d6e5c8a(new byte[10] { 166, 135, 156, 129, 139, 141, 171, 128, 129, 152 }, 232), _0x8b7973b3, _0x687afa6e.Alpha(_0x687afa6e.BgSurface, 0.96f), 1.3f);
        this._0x4543a217 = this._0x9fa31b03.rectTransform;
        _0x131f2561.Fit(this._0x4543a217, new Vector2(0.5f, 1f), new Vector2(0f, _0x25e4a139), new Vector2(PlateWidth, 110f));
        this._0xfc386ba4 = _0x25e4a139;
        Image _0xba81ad30 = _0x131f2561.Plate(this._0x9fa31b03.transform, _0xef43b4d7._0x5d6e5c8a(new byte[10] { 35, 2, 25, 4, 14, 8, 40, 9, 10, 8 }, 109), _0x8b7973b3, _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.5f), 1.3f);
        _0x131f2561.Stretch(_0xba81ad30.rectTransform);
        _0xba81ad30.rectTransform.offsetMin = new Vector2(-3f, -3f);
        _0xba81ad30.rectTransform.offsetMax = new Vector2(3f, 3f);
        _0xba81ad30.transform.SetAsFirstSibling();
        // The accent bar owns x 36..78 of the chip; the label column starts at 124 and runs
        // 700 wide, so the two never share a horizontal strip (rule C.25).
        this._0x6047eb8f = _0x131f2561.Plate(this._0x9fa31b03.transform, _0xef43b4d7._0x5d6e5c8a(new byte[12] { 50, 19, 8, 21, 31, 25, 61, 31, 31, 25, 18, 8 }, 124), _0x8b7973b3, _0x687afa6e.Gold, 1.2f);
        _0x131f2561.Fit(this._0x6047eb8f.rectTransform, new Vector2(0f, 0.5f), new Vector2(57f, 0f), new Vector2(18f, 66f));
        this._0x0a01f526 = _0x131f2561.Caption(this._0x9fa31b03.transform, _0xef43b4d7._0x5d6e5c8a(new byte[10] { 36, 5, 30, 3, 9, 15, 62, 15, 18, 30 }, 106), _0xb6345f98, "", 36f, _0x687afa6e.TextPrimary, TextAlignmentOptions.Left);
        _0x131f2561.Fit(this._0x0a01f526.rectTransform, new Vector2(0f, 0.5f), new Vector2(474f, 0f), new Vector2(700f, 70f));
        this._0x9fa31b03.gameObject.SetActive(false);
        return this;
    }

    private Image _0x6047eb8f;
    private void OnDestroy()
    {
        DOTween.Kill(this._0x4543a217);
        DOTween.Kill(this);
        DOTween.Kill(this.gameObject);
    }

    private void _0xa99b45ab()
    {
        if (!this._0x81268d8d || this._0x4543a217 == null)
            return;
        this._0x81268d8d = false;
        this._0x4543a217.DOAnchorPosY(this._0xfc386ba4 + 70f, 0.22f).SetEase(Ease.InCubic).SetLink(this.gameObject);
        DOVirtual.DelayedCall(0.24f, () => this._0x1194df07()).SetLink(this.gameObject);
    }

    private RectTransform _0x4543a217;
}

internal static class _0xef43b4d7
{
    internal static string _0x5d6e5c8a(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}