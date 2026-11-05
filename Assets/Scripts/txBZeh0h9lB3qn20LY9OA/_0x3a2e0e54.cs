using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

/// Turns finger movement into the two intents this game has: change lane, and dash.
/// Reads EnhancedTouch directly - the template's InputController keeps both its singleton
/// and its helpers private, so it cannot be called from here, and widening it would mean
/// editing a template file. Gating on IsGameRunning reproduces exactly what those private
/// helpers did, so a raised pop really does stop input.
public sealed class _0x3a2e0e54 : MonoBehaviour
{
    private void Update()
    {
        this._0x9c498244 = 0;
        this._0x058f6d7c = false;
        if (!_0x5f296d13._0x18ede486)
        {
            this._0x3b697fd3 = -1;
            return;
        }

        float _0x831d950b = Screen.width * SideThreshold;
        float _0x010b6458 = Screen.height * LiftThreshold;
        bool _0xe1b07ae6 = false;
        foreach (Touch _0x3176ba70 in Touch.activeTouches)
        {
            if (_0x3176ba70.touchId != this._0x3b697fd3)
            {
                if (this._0x3b697fd3 >= 0)
                    continue;
                this._0x3b697fd3 = _0x3176ba70.touchId;
                this._0x921f6850 = false;
                this._0x4264a10c = _0x3176ba70.screenPosition;
            }

            _0xe1b07ae6 = !_0x3176ba70.ended;
            if (this._0x921f6850)
                break;
            Vector2 _0x0d90e0b8 = _0x3176ba70.screenPosition - this._0x4264a10c;
            if (_0x0d90e0b8.y > _0x010b6458 && Mathf.Abs(_0x0d90e0b8.y) > Mathf.Abs(_0x0d90e0b8.x))
            {
                this._0x058f6d7c = true;
                this._0xd3042b2c = true;
                this._0x921f6850 = true;
            }
            else if (Mathf.Abs(_0x0d90e0b8.x) > _0x831d950b)
            {
                this._0x9c498244 = _0x0d90e0b8.x > 0f ? 1 : -1;
                this._0xd3042b2c = true;
                this._0x921f6850 = true;
            }

            break;
        }

        if (!_0xe1b07ae6)
            this._0x3b697fd3 = -1;
    }

    private Vector2 _0x4264a10c;
    private bool _0x921f6850;
    /// -1 left, +1 right, 0 none. Read once per frame and cleared by the reader itself.
    public int _0x9c498244 { get; private set; }
    /// True on the frame an upward flick is recognised.
    public bool _0x058f6d7c { get; private set; }

    private void OnEnable()
    {
        EnhancedTouchSupport.Enable();
    }

    /// True once the player has given any real steering input this run.
    public bool _0xd3042b2c { get; private set; }

    public const float LiftThreshold = 0.07f;
    /// Fraction of the screen's shorter edge a finger must travel before it counts.
    public const float SideThreshold = 0.06f;
    public void _0x6fa0c8b9()
    {
        this._0x3b697fd3 = -1;
        this._0x921f6850 = false;
        this._0xd3042b2c = false;
        this._0x9c498244 = 0;
        this._0x058f6d7c = false;
    }

    private int _0x3b697fd3 = -1;
}