using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0xf4a8cd77 : MonoBehaviour
{
    private const float MinOutlineWidth = 0.01f;
    private static void Fix(TMP_Text _0x9c294f62)
    {
        if (_0x9c294f62 == null || !_0x9c294f62.isActiveAndEnabled)
            return;
        Material _0xaaa9c1f5 = _0x9c294f62.fontSharedMaterial;
        if (_0xaaa9c1f5 == null || !_0xaaa9c1f5.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0xaaa9c1f5.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0xaaa9c1f5.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0x52a2dbb6 = _0x9c294f62.color;
        if (_0x52a2dbb6.a <= 0f)
            return;
        Color _0xc1b0a207 = _0xaaa9c1f5.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0x52a2dbb6, _0xc1b0a207) >= MinRatio)
            return;
        Color _0x40270f2b = Luminance(_0xc1b0a207) < 0.5f ? Color.white : Color.black;
        Color _0xf1353b98;
        if (Ratio(_0x40270f2b, _0xc1b0a207) < TargetRatio)
        {
            _0xf1353b98 = _0x40270f2b;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xdb152468 = 0f;
            float _0xb66ce012 = 1f;
            for (int _0x3ed691df = 0; _0x3ed691df < 20; _0x3ed691df++)
            {
                float _0x99e620eb = (_0xdb152468 + _0xb66ce012) * 0.5f;
                if (Ratio(Color.Lerp(_0x52a2dbb6, _0x40270f2b, _0x99e620eb), _0xc1b0a207) >= TargetRatio)
                    _0xb66ce012 = _0x99e620eb;
                else
                    _0xdb152468 = _0x99e620eb;
            }

            _0xf1353b98 = Color.Lerp(_0x52a2dbb6, _0x40270f2b, _0xb66ce012);
        }

        _0xf1353b98.a = _0x52a2dbb6.a;
        _0x9c294f62.color = _0xf1353b98;
    }

    private static float Linear(float _0x43642f89)
    {
        _0x43642f89 = Mathf.Clamp01(_0x43642f89);
        return _0x43642f89 <= 0.03928f ? _0x43642f89 / 12.92f : Mathf.Pow((_0x43642f89 + 0.055f) / 1.055f, 2.4f);
    }

    private void LateUpdate()
    {
        if (this._0x8b67bc19.Count == 0)
            return;
        this._0x097499d7.Clear();
        this._0x097499d7.AddRange(this._0x8b67bc19);
        this._0x8b67bc19.Clear();
        for (int _0x046cd3ea = 0; _0x046cd3ea < this._0x097499d7.Count; _0x046cd3ea++)
            Fix(this._0x097499d7[_0x046cd3ea]);
    }

    private readonly HashSet<TMP_Text> _0x8b67bc19 = new HashSet<TMP_Text>();
    private static _0xf4a8cd77 _0xbc487bf7;
    private void OnEnable()
    {
        if (this._0x74afb3cc == null)
            this._0x74afb3cc = _0x39425d47 => this._0x0c41a744(_0x39425d47);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x74afb3cc);
    }

    private void OnDisable()
    {
        if (this._0x74afb3cc != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x74afb3cc);
    }

    private const float TargetRatio = 7f;
    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0x0c41a744(Object _0x0811a8dc)
    {
        TMP_Text _0x1ca354ac = _0x0811a8dc as TMP_Text;
        if (_0x1ca354ac != null)
            this._0x8b67bc19.Add(_0x1ca354ac);
    }

    private static float Ratio(Color _0xaabf6e86, Color _0x6b621a05)
    {
        float _0x354ad218 = Luminance(_0xaabf6e86);
        float _0x7db05464 = Luminance(_0x6b621a05);
        return (Mathf.Max(_0x354ad218, _0x7db05464) + 0.05f) / (Mathf.Min(_0x354ad218, _0x7db05464) + 0.05f);
    }

    private const float MinRatio = 4.5f;
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x74afb3cc;
    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x2eb9a5f9)
    {
        return 0.2126f * Linear(_0x2eb9a5f9.r) + 0.7152f * Linear(_0x2eb9a5f9.g) + 0.0722f * Linear(_0x2eb9a5f9.b);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0xbc487bf7 != null)
            return;
        GameObject _0xf4518490 = new GameObject(_0xd70fdd12._0x7ee96680(new byte[16] { 211, 234, 247, 196, 232, 233, 243, 245, 230, 244, 243, 192, 242, 230, 245, 227 }, 135));
        _0xf4518490.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xf4518490);
        _0xbc487bf7 = _0xf4518490.AddComponent<_0xf4a8cd77>();
    }

    private readonly List<TMP_Text> _0x097499d7 = new List<TMP_Text>();
}

internal static class _0xd70fdd12
{
    internal static string _0x7ee96680(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}