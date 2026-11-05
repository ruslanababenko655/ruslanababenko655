using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xc5d25948 : MonoBehaviour
{
    private void Update()
    {
        if (_0x899f58f4[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x67e14c84)
            OrientationChanged();
        if (Screen.safeArea != _0x4539cf13)
            SafeAreaChanged();
        if (Screen.width != _0x3efb69d7.x || Screen.height != _0x3efb69d7.y)
            ResolutionChanged();
    }

    private static ScreenOrientation _0x67e14c84 = ScreenOrientation.LandscapeLeft;
    private RectTransform _0x39375890;
    private static void ResolutionChanged()
    {
        _0x3efb69d7.x = Screen.width;
        _0x3efb69d7.y = Screen.height;
        _0x3b639204.Invoke();
    }

    private static void OrientationChanged()
    {
        _0x67e14c84 = Screen.orientation;
        _0x3efb69d7.x = Screen.width;
        _0x3efb69d7.y = Screen.height;
        _0x3b639204.Invoke();
    }

    private static Vector2 _0x3efb69d7 = Vector2.zero;
    private static Rect _0x4539cf13 = Rect.zero;
    private void Awake()
    {
        if (!_0x899f58f4.Contains(this))
            _0x899f58f4.Add(this);
        this._0xbaf9a18c = this.GetComponent<Canvas>();
        this._0x39375890 = this.GetComponent<RectTransform>();
        this._0xcca5cd8d = this.transform.Find(_0xaa27ca5d._0x008c1475(new byte[8] { 88, 106, 109, 110, 74, 121, 110, 106 }, 11)) as RectTransform;
        if (!_0xeccdb60a)
        {
            _0x67e14c84 = Screen.orientation;
            _0x3efb69d7.x = Screen.width;
            _0x3efb69d7.y = Screen.height;
            _0x4539cf13 = Screen.safeArea;
            _0xeccdb60a = true;
        }

        this._0x9c1cd919();
    }

    private static UnityEvent _0x3b639204 = new();
    private RectTransform _0xcca5cd8d;
    private void OnDestroy()
    {
        if (_0x899f58f4 != null && _0x899f58f4.Contains(this))
            _0x899f58f4.Remove(this);
    }

    private void _0x9c1cd919()
    {
        if (this._0xcca5cd8d == null)
            return;
        Rect _0xe2a187ae = Screen.safeArea;
        Vector2 _0x7bd9f667 = _0xe2a187ae.position;
        Vector2 _0x7e231eba = _0xe2a187ae.position + _0xe2a187ae.size;
        _0x7bd9f667.x /= this._0xbaf9a18c.pixelRect.width;
        _0x7bd9f667.y /= this._0xbaf9a18c.pixelRect.height;
        _0x7e231eba.x /= this._0xbaf9a18c.pixelRect.width;
        _0x7e231eba.y /= this._0xbaf9a18c.pixelRect.height;
        this._0xcca5cd8d.anchorMin = _0x7bd9f667;
        this._0xcca5cd8d.anchorMax = _0x7e231eba;
    }

    private static void SafeAreaChanged()
    {
        _0x4539cf13 = Screen.safeArea;
        for (int _0x1598f6df = 0; _0x1598f6df < _0x899f58f4.Count; _0x1598f6df++)
            _0x899f58f4[_0x1598f6df]._0x9c1cd919();
    }

    private static bool _0xeccdb60a;
    private Canvas _0xbaf9a18c;
    private static readonly List<_0xc5d25948> _0x899f58f4 = new();
}

internal static class _0xaa27ca5d
{
    internal static string _0x008c1475(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}