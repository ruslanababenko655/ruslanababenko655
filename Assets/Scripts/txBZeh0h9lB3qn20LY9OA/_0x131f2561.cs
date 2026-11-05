using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The only place that creates UGUI objects in this game. Keeping the factory in one
/// file means every caption gets the same readability treatment (rule C.10: wrapping off,
/// autosize on with a 24 floor, an own material whose outline contrasts the face) and
/// every rect is built the same way, so the layout is predictable on any aspect.
public static class _0x131f2561
{
    /// A framed action button: accent plate, inset dark body, light caption. Light letters
    /// on a dark body is the only combination the shared dark outline reads against.
    public static Button Action(Transform _0x116634d3, string _0x9c5dd087, TMP_FontAsset _0xabf31ce6, Sprite _0x03e9bfa6, string _0xf1f4bb7e, Vector2 _0x71fa61e8, Vector2 _0x03a44ecd, Vector2 _0xe9f90f24, Color _0xb886ad68, float _0xdc597ea9)
    {
        RectTransform _0x0f21d0cc = Fit(Branch(_0x9c5dd087, _0x116634d3), _0x71fa61e8, _0x03a44ecd, _0xe9f90f24);
        Image _0xfb0b5762 = Plate(_0x0f21d0cc, _0xf5463c50._0xcf53252f(new byte[4] { 29, 60, 63, 61 }, 88), _0x03e9bfa6, _0xb886ad68, 1.35f);
        Stretch(_0xfb0b5762.rectTransform);
        Image _0x8487307c = Plate(_0x0f21d0cc, _0xf5463c50._0xcf53252f(new byte[4] { 87, 122, 113, 108 }, 21), _0x03e9bfa6, _0x687afa6e.Alpha(_0x687afa6e.BgSurface, 0.98f), 1.45f);
        Stretch(_0x8487307c.rectTransform);
        _0x8487307c.rectTransform.offsetMin = new Vector2(6f, 6f);
        _0x8487307c.rectTransform.offsetMax = new Vector2(-6f, -6f);
        TextMeshProUGUI _0x7bf12c1a = Caption(_0x0f21d0cc, _0xf5463c50._0xcf53252f(new byte[5] { 138, 167, 164, 163, 170 }, 198), _0xabf31ce6, _0xf1f4bb7e, _0xdc597ea9, _0xb886ad68, TextAlignmentOptions.Center);
        Stretch(_0x7bf12c1a.rectTransform);
        _0x7bf12c1a.rectTransform.offsetMin = new Vector2(18f, 10f);
        _0x7bf12c1a.rectTransform.offsetMax = new Vector2(-18f, -10f);
        return Press(_0x0f21d0cc);
    }

    /// Place a box by a POINT anchor (anchorMin == anchorMax) plus a pixel offset and size.
    public static RectTransform Fit(RectTransform _0xa26c7511, Vector2 _0xc431c6cb, Vector2 _0x2746c521, Vector2 _0xbd447c81)
    {
        _0xa26c7511.anchorMin = _0xc431c6cb;
        _0xa26c7511.anchorMax = _0xc431c6cb;
        _0xa26c7511.pivot = new Vector2(0.5f, 0.5f);
        _0xa26c7511.anchoredPosition = _0x2746c521;
        _0xa26c7511.sizeDelta = _0xbd447c81;
        return _0xa26c7511;
    }

    /// A flat colour block with no sprite at all - safe because a sprite-less Image draws
    /// the colour it is given, and this one always carries one.
    public static Image Wash(Transform _0xbe6600a1, string _0x7bd25e6f, Color _0xf17e920b)
    {
        RectTransform _0x51f45c5f = Branch(_0x7bd25e6f, _0xbe6600a1);
        Image _0x369fc838 = _0x51f45c5f.gameObject.AddComponent<Image>();
        _0x369fc838.color = _0xf17e920b;
        _0x369fc838.raycastTarget = false;
        return _0x369fc838;
    }

    /// An icon-only square button, used for back / pause / close.
    public static Button Glyph(Transform _0x803a6af5, string _0x661874c0, Sprite _0xfcbcde09, Sprite _0x104eb43c, Vector2 _0x3fcdd567, Vector2 _0xfea698dc, float _0x88cfbf55, Color _0xa43ffc4b)
    {
        RectTransform _0xcdf218c3 = Fit(Branch(_0x661874c0, _0x803a6af5), _0x3fcdd567, _0xfea698dc, new Vector2(_0x88cfbf55, _0x88cfbf55));
        Image _0xfe6bc392 = Plate(_0xcdf218c3, _0xf5463c50._0xcf53252f(new byte[4] { 19, 50, 49, 51 }, 86), _0x104eb43c, _0x687afa6e.Alpha(_0x687afa6e.BgSurface, 0.92f), 1.3f);
        Stretch(_0xfe6bc392.rectTransform);
        Image _0xb2dc2ebd = Plate(_0xcdf218c3, _0xf5463c50._0xcf53252f(new byte[4] { 92, 103, 96, 105 }, 14), _0x104eb43c, _0x687afa6e.Alpha(_0xa43ffc4b, 0.55f), 1.3f);
        Stretch(_0xb2dc2ebd.rectTransform);
        _0xb2dc2ebd.rectTransform.offsetMin = new Vector2(-3f, -3f);
        _0xb2dc2ebd.rectTransform.offsetMax = new Vector2(3f, 3f);
        _0xb2dc2ebd.transform.SetAsFirstSibling();
        Image _0x31d4c01c = Picture(_0xcdf218c3, _0xf5463c50._0xcf53252f(new byte[4] { 0, 42, 38, 39 }, 73), _0xfcbcde09, _0xa43ffc4b);
        Fit(_0x31d4c01c.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x88cfbf55 * 0.52f, _0x88cfbf55 * 0.52f));
        return Press(_0xcdf218c3);
    }

    /// A transparent hit layer. Alpha is kept above zero and cullTransparentMesh off so the
    /// mesh survives and the raycaster still sees it.
    public static Image HitLayer(Transform _0x710c8de3, string _0xc98b94c4)
    {
        RectTransform _0xbf921fea = Stretch(Branch(_0xc98b94c4, _0x710c8de3));
        Image _0x582e6211 = _0xbf921fea.gameObject.AddComponent<Image>();
        _0x582e6211.color = new Color(1f, 1f, 1f, 0.004f);
        _0x582e6211.raycastTarget = true;
        CanvasRenderer _0xdcb1f1f7 = _0xbf921fea.gameObject.GetComponent<CanvasRenderer>();
        if (_0xdcb1f1f7 != null)
            _0xdcb1f1f7.cullTransparentMesh = false;
        return _0x582e6211;
    }

    public const float MinFont = 24f;
    /// Fill the parent completely. Used for hosts and washes, never for content boxes.
    public static RectTransform Stretch(RectTransform _0x22ed8f07)
    {
        _0x22ed8f07.anchorMin = Vector2.zero;
        _0x22ed8f07.anchorMax = Vector2.one;
        _0x22ed8f07.offsetMin = Vector2.zero;
        _0x22ed8f07.offsetMax = Vector2.zero;
        return _0x22ed8f07;
    }

    /// A caption. Wrapping is OFF and every line break is an explicit \n in the string;
    /// autosize is ON and its floor is the readability threshold, so a long line shrinks
    /// to 24 and never below (rules C.10 and C.12).
    public static TextMeshProUGUI Caption(Transform _0x69121fd6, string _0x22e1a9d3, TMP_FontAsset _0x75a8bf64, string _0x0888d0c1, float _0x8819a830, Color _0xe2cc9ed3, TextAlignmentOptions _0x2f117470)
    {
        RectTransform _0xe7b20f2b = Branch(_0x22e1a9d3, _0x69121fd6);
        TextMeshProUGUI _0xf63b2d29 = _0xe7b20f2b.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0x75a8bf64 != null)
            _0xf63b2d29.font = _0x75a8bf64;
        _0xf63b2d29.text = _0x0888d0c1;
        _0xf63b2d29.color = _0xe2cc9ed3;
        _0xf63b2d29.alignment = _0x2f117470;
        _0xf63b2d29.textWrappingMode = TextWrappingModes.NoWrap;
        _0xf63b2d29.overflowMode = TextOverflowModes.Overflow;
        _0xf63b2d29.enableAutoSizing = true;
        _0xf63b2d29.fontSizeMin = MinFont;
        _0xf63b2d29.fontSizeMax = Mathf.Max(MinFont, _0x8819a830);
        _0xf63b2d29.fontSize = Mathf.Max(MinFont, _0x8819a830);
        _0xf63b2d29.raycastTarget = false;
        Readable(_0xf63b2d29, _0xe2cc9ed3);
        return _0xf63b2d29;
    }

    /// A content picture: the sprite keeps its own proportions, always.
    public static Image Picture(Transform _0xa361f4ff, string _0xda0eaf7a, Sprite _0x730f9254, Color _0xe69b3949)
    {
        RectTransform _0xf60d3679 = Branch(_0xda0eaf7a, _0xa361f4ff);
        Image _0xad7388ee = _0xf60d3679.gameObject.AddComponent<Image>();
        _0xad7388ee.sprite = _0x730f9254;
        _0xad7388ee.type = Image.Type.Simple;
        _0xad7388ee.preserveAspect = true;
        _0xad7388ee.color = _0xe69b3949;
        _0xad7388ee.raycastTarget = false;
        return _0xad7388ee;
    }

    /// A tintable 9-slice plate. The sprite is the template's own rounded slab, so there is
    /// no generated art here that could arrive missing and draw as a white rectangle (B.1).
    /// The corner radius is not written here: PlateRound derives it from the rect the plate
    /// ends up with, because a literal that looks right on a card destroys a 52 px bar.
    public static Image Plate(Transform _0x45867fef, string _0xc9bef755, Sprite _0x0c6b445f, Color _0x9fa2a74a, float _0x6c7070dc)
    {
        RectTransform _0x4f4c3fbe = Branch(_0xc9bef755, _0x45867fef);
        Image _0x29e4f76a = _0x4f4c3fbe.gameObject.AddComponent<Image>();
        _0x29e4f76a.sprite = _0x0c6b445f;
        _0x29e4f76a.type = Image.Type.Sliced;
        _0x29e4f76a.color = _0x9fa2a74a;
        _0x29e4f76a.raycastTarget = false;
        _0x4f4c3fbe.gameObject.AddComponent<_0x0a1d8773>()._0x9053c3a3(_0x29e4f76a, _0x6c7070dc);
        return _0x29e4f76a;
    }

    /// Turn a host into a tap target. Returns the Button so the caller can add its own
    /// lambda listener - a method group would survive obfuscation only by luck (rule C.1).
    public static Button Press(RectTransform _0x6eb7c780)
    {
        Image _0x7cbfe161 = HitLayer(_0x6eb7c780, _0xf5463c50._0xcf53252f(new byte[3] { 147, 178, 175 }, 219));
        Button _0xdf0a6973 = _0x6eb7c780.gameObject.AddComponent<Button>();
        _0xdf0a6973.transition = Selectable.Transition.None;
        _0xdf0a6973.targetGraphic = _0x7cbfe161;
        return _0xdf0a6973;
    }

    /// A plain rect node. Anchors collapse to a point by default: a point anchor plus an
    /// explicit size is the only placement that survives a change of screen aspect without
    /// the box reshaping itself.
    public static RectTransform Branch(string _0x5a850290, Transform _0xf1ccca07)
    {
        GameObject _0x6b39d32a = new GameObject(_0x5a850290, typeof(RectTransform));
        RectTransform _0xa30d78f8 = _0x6b39d32a.GetComponent<RectTransform>();
        _0xa30d78f8.SetParent(_0xf1ccca07, false);
        _0xa30d78f8.localScale = Vector3.one;
        _0xa30d78f8.anchorMin = new Vector2(0.5f, 0.5f);
        _0xa30d78f8.anchorMax = new Vector2(0.5f, 0.5f);
        _0xa30d78f8.pivot = new Vector2(0.5f, 0.5f);
        _0xa30d78f8.anchoredPosition = Vector2.zero;
        _0xa30d78f8.sizeDelta = new Vector2(100f, 100f);
        return _0xa30d78f8;
    }

    /// Give a runtime caption its own outline. 5c3 only rewrites colours serialised in
    /// scenes and prefabs, so text built in code is on us (rule C.10 / C.14).
    public static void Readable(TextMeshProUGUI _0xb452e35c, Color _0x4f08954d)
    {
        Material _0xba6e6a97 = _0xb452e35c.fontMaterial;
        if (_0xba6e6a97 == null)
            return;
        float _0xaa7c4eae = 0.299f * _0x4f08954d.r + 0.587f * _0x4f08954d.g + 0.114f * _0x4f08954d.b;
        _0xba6e6a97.SetColor(ShaderUtilities.ID_OutlineColor, _0xaa7c4eae < 0.5f ? _0x687afa6e.TextPrimary : _0x687afa6e.OutlineInk);
        _0xba6e6a97.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.18f);
        _0xba6e6a97.SetFloat(ShaderUtilities.ID_FaceDilate, 0.14f);
    }
}

internal static class _0xf5463c50
{
    internal static string _0xcf53252f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}