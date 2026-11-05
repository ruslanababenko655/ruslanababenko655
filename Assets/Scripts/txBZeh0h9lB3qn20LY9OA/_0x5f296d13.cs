using UnityEngine;

/// The one source of elapsed time for everything that moves in a run. The template drives
/// play with BasicController.SetPhysicsRun, so a pop opened by ANY route - our pause button,
/// a result, the template's own handler - stops the circuit through this clock and nothing
/// else needs to know about it.
public static class _0x5f296d13
{
    public static void Release()
    {
        _0x42666298 _0x4f4a79d4 = _0x42666298.Instance;
        if (_0x4f4a79d4 != null)
            _0x4f4a79d4._0x07871970(true);
    }

    public static bool _0x18ede486
    {
        get
        {
            _0x42666298 _0x934de52f = _0x42666298.Instance;
            return _0x934de52f != null && _0x934de52f._0x980e6851;
        }
    }

    /// Clamped so a frame hitch can never teleport a row past the dragon line.
    public const float MaxStep = 0.05f;
    public static float _0x5d49422c
    {
        get
        {
            return _0x18ede486 ? Mathf.Min(Time.deltaTime, MaxStep) : 0f;
        }
    }

    public static void Hold()
    {
        _0x42666298 _0xe87245dc = _0x42666298.Instance;
        if (_0xe87245dc != null)
            _0xe87245dc._0x07871970(false);
    }
}