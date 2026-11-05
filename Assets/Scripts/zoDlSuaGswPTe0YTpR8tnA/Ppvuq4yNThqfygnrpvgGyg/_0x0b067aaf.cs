using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0x0b067aaf : MonoBehaviour
{
    private static Vector2 _0x5e6af616 = Vector2.zero;
    private CanvasScaler _0xc83947c4;
    private RectTransform _0xc32667d6;
    private Vector2 _0x4110029a;
    private void Update()
    {
        if (_0xcbc6729e.Count == 0 || _0xcbc6729e[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x7d4fc081)
            OrientationChanged();
        if (Screen.safeArea != _0xfe1601b6)
            SafeAreaChanged();
        if (Screen.width != _0x5e6af616.x || Screen.height != _0x5e6af616.y)
            ResolutionChanged();
    }

    private void Start()
    {
    }

    private static UnityEvent _0xbb0b1d2d = new();
    private void OnDestroy()
    {
        if (_0xcbc6729e != null && _0xcbc6729e.Contains(this))
            _0xcbc6729e.Remove(this);
    }

    private static readonly List<_0x0b067aaf> _0xcbc6729e = new();
    private void Awake()
    {
        if (!_0xcbc6729e.Contains(this))
            _0xcbc6729e.Add(this);
        this._0x28f87b70 = this.GetComponent<Canvas>();
        this._0xc83947c4 = this.GetComponent<CanvasScaler>();
        if (this._0xc83947c4 != null)
            this._0x4110029a = this._0xc83947c4.referenceResolution;
        this._0xc32667d6 = this.GetComponent<RectTransform>();
        this._0xed5daad1 = this.transform.Find(_0x0e2d4a21._0x6d35623c(new byte[8] { 162, 144, 151, 148, 176, 131, 148, 144 }, 241)) as RectTransform;
        if (!_0x0304783b)
        {
            _0x7d4fc081 = Screen.orientation;
            _0x5e6af616.x = Screen.width;
            _0x5e6af616.y = Screen.height;
            _0xfe1601b6 = Screen.safeArea;
            _0x0304783b = true;
        }

        this._0x5a54542c();
    }

    private Canvas _0x28f87b70;
    private static ScreenOrientation _0x7d4fc081 = ScreenOrientation.LandscapeLeft;
    private static void OrientationChanged()
    {
        _0x7d4fc081 = Screen.orientation;
        _0x5e6af616.x = Screen.width;
        _0x5e6af616.y = Screen.height;
        _0xfe1601b6 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xbb0b1d2d.Invoke();
    }

    private void _0x5a54542c()
    {
        if (this._0xed5daad1 == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x683d0996 = Screen.safeArea;
        Vector2 _0xcc8020f7 = _0x683d0996.position;
        Vector2 _0xc6151c82 = _0x683d0996.position + _0x683d0996.size;
        _0xcc8020f7.x /= screenWidth;
        _0xcc8020f7.y /= screenHeight;
        _0xc6151c82.x /= screenWidth;
        _0xc6151c82.y /= screenHeight;
        this._0xed5daad1.anchorMin = _0xcc8020f7;
        this._0xed5daad1.anchorMax = _0xc6151c82;
        this._0xed5daad1.offsetMin = Vector2.zero;
        this._0xed5daad1.offsetMax = Vector2.zero;
        if (this._0xc83947c4 == null)
            return;
        Vector2 _0x3108a822 = _0xc6151c82 - _0xcc8020f7;
        float _0xc576ad60 = 2f - _0x3108a822.x;
        float _0x429dab09 = 2f - _0x3108a822.y;
        this._0xc83947c4.referenceResolution = this._0x4110029a * new Vector2(_0xc576ad60, _0x429dab09);
    }

    private static bool _0x0304783b;
    private static void ResolutionChanged()
    {
        _0x5e6af616.x = Screen.width;
        _0x5e6af616.y = Screen.height;
        _0xfe1601b6 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0xbb0b1d2d.Invoke();
    }

    private static Rect _0xfe1601b6 = Rect.zero;
    private static void SafeAreaChanged()
    {
        _0xfe1601b6 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0x3caa4e24 = 0; _0x3caa4e24 < _0xcbc6729e.Count; _0x3caa4e24++)
            _0xcbc6729e[_0x3caa4e24]._0x5a54542c();
    }

    private RectTransform _0xed5daad1;
}

internal static class _0x0e2d4a21
{
    internal static string _0x6d35623c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}