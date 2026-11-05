using UnityEngine;
using UnityEngine.UI;

/// The burning wake behind the dragon: a chain of wisps that lag the head by a fixed number
/// of samples each, tapering in size and alpha. Pure position history, no body and no
/// tween - it has to keep up with a lane change exactly, which a spring would not.
public sealed class _0xae61d7dd : MonoBehaviour
{
    private RectTransform[] _0xe314b7d2 = new RectTransform[0];
    /// Feed one sample of the head position. Called from the director's own update so the
    /// trail and the dragon never drift a frame apart.
    public void _0x44f4f638(Vector2 _0x26d77920)
    {
        this._0x54845f68[this._0x76acaa6d] = _0x26d77920;
        this._0x76acaa6d = (this._0x76acaa6d + 1) % this._0x54845f68.Length;
        if (this._0x94b1e6da < this._0x54845f68.Length)
            this._0x94b1e6da++;
        for (int _0x18431870 = 0; _0x18431870 < this._0xe314b7d2.Length; _0x18431870++)
        {
            if (this._0xe314b7d2[_0x18431870] == null || !this._0xe314b7d2[_0x18431870].gameObject.activeSelf)
                continue;
            int _0xd2503416 = (_0x18431870 + 1) * SamplesPerNode;
            if (_0xd2503416 >= this._0x94b1e6da)
            {
                this._0xe314b7d2[_0x18431870].anchoredPosition = _0x26d77920;
                continue;
            }

            int _0xda658cf1 = this._0x76acaa6d - 1 - _0xd2503416;
            while (_0xda658cf1 < 0)
                _0xda658cf1 += this._0x54845f68.Length;
            this._0xe314b7d2[_0x18431870].anchoredPosition = this._0x54845f68[_0xda658cf1];
        }
    }

    public _0xae61d7dd _0xdfe98624(Transform _0xebb75752, Sprite _0x3e12b2ab, int _0xdc2ee805, float _0x0f58d29b, Color _0x61c4398c)
    {
        int _0x2e7bf6c6 = Mathf.Clamp(_0xdc2ee805, 4, MaxNodes);
        this._0xe314b7d2 = new RectTransform[_0x2e7bf6c6];
        this._0xb6eb45eb = new Image[_0x2e7bf6c6];
        this._0xe910235a = _0x0f58d29b;
        for (int _0xdc46dd0d = 0; _0xdc46dd0d < _0x2e7bf6c6; _0xdc46dd0d++)
        {
            float _0x4f1fc6eb = 1f - (float)_0xdc46dd0d / _0x2e7bf6c6;
            Image _0xe054f02f = _0x131f2561.Picture(_0xebb75752, _0x5312f680._0x60591c3d(new byte[4] { 3, 61, 39, 36 }, 84), _0x3e12b2ab, _0x687afa6e.Alpha(_0x61c4398c, 0.18f + 0.62f * _0x4f1fc6eb));
            float _0xef59bf03 = _0x0f58d29b * (0.30f + 0.70f * _0x4f1fc6eb);
            _0x131f2561.Fit(_0xe054f02f.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0xef59bf03, _0xef59bf03));
            _0xe054f02f.transform.SetAsFirstSibling();
            this._0xe314b7d2[_0xdc46dd0d] = _0xe054f02f.rectTransform;
            this._0xb6eb45eb[_0xdc46dd0d] = _0xe054f02f;
        }

        this._0xc84c7c62(_0x61c4398c);
        return this;
    }

    /// Stretch the wisps along the scroll axis for the length of a dash.
    public void _0xfa55e562(bool _0xecb4cfc6)
    {
        for (int _0x7806bcf8 = 0; _0x7806bcf8 < this._0xe314b7d2.Length; _0x7806bcf8++)
        {
            if (this._0xe314b7d2[_0x7806bcf8] == null)
                continue;
            float _0xd137c71f = 1f - (float)_0x7806bcf8 / this._0xe314b7d2.Length;
            float _0x3ee0cbc3 = this._0xe910235a * (0.30f + 0.70f * _0xd137c71f);
            this._0xe314b7d2[_0x7806bcf8].sizeDelta = new Vector2(_0x3ee0cbc3, _0x3ee0cbc3 * (_0xecb4cfc6 ? 1.6f : 1f));
        }
    }

    private Image[] _0xb6eb45eb = new Image[0];
    public void _0x87eecbeb(int _0x4e410e74)
    {
        int _0xd99d1224 = Mathf.Clamp(_0x4e410e74, 4, this._0xe314b7d2.Length);
        for (int _0x15233793 = 0; _0x15233793 < this._0xe314b7d2.Length; _0x15233793++)
            if (this._0xe314b7d2[_0x15233793] != null)
                this._0xe314b7d2[_0x15233793].gameObject.SetActive(_0x15233793 < _0xd99d1224);
    }

    private readonly Vector2[] _0x54845f68 = new Vector2[MaxNodes * SamplesPerNode + 2];
    private int _0x76acaa6d;
    private float _0xe910235a;
    private int _0x94b1e6da;
    public const int SamplesPerNode = 3;
    public void _0xc84c7c62(Color _0xa8ad22a6)
    {
        for (int _0xa678b218 = 0; _0xa678b218 < this._0xb6eb45eb.Length; _0xa678b218++)
        {
            if (this._0xb6eb45eb[_0xa678b218] == null)
                continue;
            float _0x4d3920ef = 1f - (float)_0xa678b218 / this._0xb6eb45eb.Length;
            this._0xb6eb45eb[_0xa678b218].color = _0x687afa6e.Alpha(_0xa8ad22a6, 0.18f + 0.62f * _0x4d3920ef);
        }
    }

    public const int MaxNodes = 14;
}

internal static class _0x5312f680
{
    internal static string _0x60591c3d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}