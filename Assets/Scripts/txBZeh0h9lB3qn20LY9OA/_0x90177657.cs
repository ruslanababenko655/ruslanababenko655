using UnityEngine;
using UnityEngine.UI;

/// The backdrop that makes height readable: two cloud bands drifting at different speeds
/// and a temple spire that passes once, partway through the circuit, so the whole skyline
/// changes shape while the player is flying.
public sealed class _0x90177657 : MonoBehaviour
{
    private Image _0xa638e670;
    private bool _0x22bc79b4;
    public _0x90177657 _0x7b2c5bcf(Transform _0xde7a519a, Sprite _0xb87871a4, Sprite _0x11e72fc0, Sprite _0xbb309e2a, float width, float height, float _0xb75e8f69)
    {
        this._0x9fc2efca = width;
        this._0x7f525dd8 = height;
        this._0x4ecc83f7(_0xb75e8f69);
        for (int _0xa08383b7 = 0; _0xa08383b7 < BandCount; _0xa08383b7++)
        {
            Image _0x06069ae1 = _0x131f2561.Picture(_0xde7a519a, _0x4df4fc08._0xadf8d819(new byte[8] { 238, 193, 194, 216, 201, 235, 204, 223 }, 173), _0xb87871a4, _0x687afa6e.Alpha(_0x687afa6e.Teal, 0.30f));
            float _0xb50c3e1d = width * 1.25f;
            _0x131f2561.Fit(_0x06069ae1.rectTransform, new Vector2(0.5f, 0.5f), new Vector2((_0xa08383b7 % 2 == 0 ? -0.18f : 0.20f) * width, height * (0.10f + 0.42f * _0xa08383b7)), new Vector2(_0xb50c3e1d, _0xb50c3e1d));
            this._0x716e20ee[_0xa08383b7] = _0x06069ae1.rectTransform;
        }

        for (int _0xbedc2dcc = 0; _0xbedc2dcc < BandCount; _0xbedc2dcc++)
        {
            Image _0xd38bb647 = _0x131f2561.Picture(_0xde7a519a, _0x4df4fc08._0xadf8d819(new byte[9] { 119, 88, 91, 65, 80, 122, 81, 85, 70 }, 52), _0x11e72fc0, _0x687afa6e.Alpha(_0x687afa6e.TealLight, 0.22f));
            float _0xf82c0d0a = width * 1.05f;
            _0x131f2561.Fit(_0xd38bb647.rectTransform, new Vector2(0.5f, 0.5f), new Vector2((_0xbedc2dcc % 2 == 0 ? 0.26f : -0.24f) * width, height * (-0.22f + 0.40f * _0xbedc2dcc)), new Vector2(_0xf82c0d0a, _0xf82c0d0a));
            this._0x6d85173e[_0xbedc2dcc] = _0xd38bb647.rectTransform;
        }

        this._0xa638e670 = _0x131f2561.Picture(_0xde7a519a, _0x4df4fc08._0xadf8d819(new byte[5] { 150, 181, 172, 183, 160 }, 197), _0xbb309e2a, _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.65f));
        _0x131f2561.Fit(this._0xa638e670.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(width * 0.30f, height * 0.95f), new Vector2(width * 0.78f, width * 0.78f));
        this._0x971a292d = this._0xa638e670.rectTransform;
        this._0xa638e670.gameObject.SetActive(false);
        return this;
    }

    private float _0x7f525dd8;
    private float _0x92e66faa;
    /// Set how far the sky is allowed to move. The calmer setting halves every band at
    /// once and is visible on the spot, which is the whole point of that switch.
    public void _0x4ecc83f7(float _0x9314d8db)
    {
        this._0x33a8963a = Mathf.Clamp(_0x9314d8db, 0.2f, 1f);
        this._0x7d7a6767 = this._0x7f525dd8 * 0.018f * this._0x33a8963a;
        this._0x92e66faa = this._0x7f525dd8 * 0.042f * this._0x33a8963a;
        this._0x017bba25 = this._0x7f525dd8 * 0.085f * this._0x33a8963a;
    }

    private void Update()
    {
        float _0xb2755d87 = _0x5f296d13._0x5d49422c;
        if (_0xb2755d87 <= 0f)
            return;
        this._0xebb1d930(this._0x716e20ee, this._0x7d7a6767 * _0xb2755d87);
        this._0xebb1d930(this._0x6d85173e, this._0x92e66faa * _0xb2755d87);
        if (!this._0x22bc79b4 || this._0x971a292d == null)
            return;
        Vector2 _0x6d2fc9e4 = this._0x971a292d.anchoredPosition;
        _0x6d2fc9e4.y -= this._0x017bba25 * _0xb2755d87;
        this._0x971a292d.anchoredPosition = _0x6d2fc9e4;
        if (_0x6d2fc9e4.y < -this._0x7f525dd8 * 1.1f)
        {
            this._0x22bc79b4 = false;
            this._0xa638e670.gameObject.SetActive(false);
        }
    }

    private float _0x9fc2efca;
    private float _0x7d7a6767;
    private void _0xebb1d930(RectTransform[] _0x301b5b82, float delta)
    {
        float _0x54790995 = this._0x7f525dd8 * 1.25f;
        for (int _0xb7baa8ac = 0; _0xb7baa8ac < _0x301b5b82.Length; _0xb7baa8ac++)
        {
            if (_0x301b5b82[_0xb7baa8ac] == null)
                continue;
            Vector2 _0x90cd66b5 = _0x301b5b82[_0xb7baa8ac].anchoredPosition;
            _0x90cd66b5.y -= delta;
            if (_0x90cd66b5.y < -_0x54790995)
                _0x90cd66b5.y += _0x54790995 * 2f;
            _0x301b5b82[_0xb7baa8ac].anchoredPosition = _0x90cd66b5;
        }
    }

    private RectTransform[] _0x716e20ee = new RectTransform[BandCount];
    /// Send the landmark past. Called once, on a fixed gate, so consecutive capture frames
    /// differ by more than a moving row.
    public void _0x4d2fbc0f()
    {
        if (this._0x971a292d == null || this._0x22bc79b4)
            return;
        this._0x22bc79b4 = true;
        this._0xa638e670.gameObject.SetActive(true);
        this._0x971a292d.anchoredPosition = new Vector2(this._0x9fc2efca * 0.30f, this._0x7f525dd8 * 0.95f);
    }

    private float _0x33a8963a = 1f;
    private float _0x017bba25;
    private RectTransform _0x971a292d;
    public bool _0xce5f1c65
    {
        get
        {
            return this._0x22bc79b4;
        }
    }

    private RectTransform[] _0x6d85173e = new RectTransform[BandCount];
    private const int BandCount = 3;
}

internal static class _0x4df4fc08
{
    internal static string _0xadf8d819(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}