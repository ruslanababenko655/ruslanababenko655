using UnityEngine;
using UnityEngine.UI;

/// Keeps a nine-sliced plate from eating itself. Unity holds the four border edges of a
/// sliced sprite at a fixed pixel size and stretches only the middle, so on a plate
/// shorter than two borders the middle is gone and the whole layer draws as a crooked
/// sliver. The slab this game uses carries a 127 px border - wider than most of its own
/// chips - so the multiplier cannot be a literal: it is derived from the rect the plate is
/// really drawn at, and recomputed whenever that rect changes (autorotation is on, so it
/// does change).
public sealed class _0x0a1d8773 : MonoBehaviour
{
    private float _0xfbb51a86 = 1f;
    private Image _0x383ea1c4;
    /// The share of the shorter side the stretched middle must keep for itself.
    public const float MiddleShare = 0.35f;
    /// The floor is the look the caller asked for - lower is rounder. The plate only ever
    /// gets sharper than that, and only when it is too small to carry the border.
    public _0x0a1d8773 _0x9053c3a3(Image _0x06a89818, float _0x68102789)
    {
        this._0x383ea1c4 = _0x06a89818;
        this._0xfbb51a86 = Mathf.Max(0.2f, _0x68102789);
        this._0x3b30146d();
        return this;
    }

    private void LateUpdate()
    {
        this._0x3b30146d();
    }

    private void _0x3b30146d()
    {
        if (this._0x383ea1c4 == null)
            return;
        Vector2 _0x92b4c09f = this._0x383ea1c4.rectTransform.rect.size;
        if (_0x92b4c09f.x < 1f || _0x92b4c09f.y < 1f)
            return;
        if (Mathf.Abs(_0x92b4c09f.x - this._0x6b1e6499.x) < 0.5f && Mathf.Abs(_0x92b4c09f.y - this._0x6b1e6499.y) < 0.5f)
            return;
        this._0x6b1e6499 = _0x92b4c09f;
        Sprite _0x02795e61 = this._0x383ea1c4.sprite;
        if (_0x02795e61 == null)
        {
            this._0x383ea1c4.pixelsPerUnitMultiplier = this._0xfbb51a86;
            return;
        }

        Vector4 _0x232901bb = _0x02795e61.border;
        float _0x16aa94b6 = Mathf.Max(Mathf.Max(_0x232901bb.x, _0x232901bb.y), Mathf.Max(_0x232901bb.z, _0x232901bb.w));
        if (_0x16aa94b6 <= 0f)
        {
            this._0x383ea1c4.pixelsPerUnitMultiplier = this._0xfbb51a86;
            return;
        }

        // Image draws a sliced border at border / (spritePixelsPerUnit / referencePixels
        // PerUnit) / multiplier canvas units, so this is the exact inverse of that.
        float _0xa680665f = this._0x383ea1c4.canvas != null ? this._0x383ea1c4.canvas.referencePixelsPerUnit : 100f;
        float _0x8b99a9e0 = _0x02795e61.pixelsPerUnit <= 0f ? 100f : _0x02795e61.pixelsPerUnit;
        float _0xfb78c681 = Mathf.Min(_0x92b4c09f.x, _0x92b4c09f.y);
        float _0x19e00906 = 2f * _0x16aa94b6 * _0xa680665f / (_0x8b99a9e0 * (1f - MiddleShare) * _0xfb78c681);
        this._0x383ea1c4.pixelsPerUnitMultiplier = Mathf.Clamp(Mathf.Max(this._0xfbb51a86, _0x19e00906), 0.2f, CeilingMultiplier);
    }

    private Vector2 _0x6b1e6499 = new Vector2(-1f, -1f);
    /// Nothing is ever made sharper than this; below it the corners read as square.
    public const float CeilingMultiplier = 14f;
}