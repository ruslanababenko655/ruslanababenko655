using UnityEngine;
using UnityEngine.UI;

/// Themes the loading bar on the splash. The template ships it at the default
/// near-transparent alpha, i.e. invisible, and inset so hard that most of its body has
/// nothing to draw - a bar that is present in the hierarchy and absent on screen.
///
/// The slider is reached through the reference the template already holds
/// (SplashPanel.AnimationSlider) and through Slider.fillRect, never by object name:
/// names do not survive obfuscation and these two do.
public sealed class _0x3934365a
{
    public void _0x52a72421()
    {
        _0xc88f8b5d _0x4ad77129 = _0xc88f8b5d.Instance;
        if (_0x4ad77129 == null)
            return;
        Slider _0xea8a3218 = _0x4ad77129.AnimationSlider;
        if (_0xea8a3218 == null || _0xea8a3218.fillRect == null)
            return;
        RectTransform _0x531cad9d = _0xea8a3218.fillRect.parent as RectTransform;
        if (_0x531cad9d != null)
        {
            // The prefab stretches this rect to the slider and then insets itself by 80
            // units, so at anything but the template's own height the track collapses to
            // nothing whatever colour it carries (ANDROID-3578). Re-stretch it with a
            // padding of our own and the authored inset no longer decides.
            _0x531cad9d.anchorMin = new Vector2(0f, 0f);
            _0x531cad9d.anchorMax = new Vector2(1f, 1f);
            _0x531cad9d.offsetMin = new Vector2(TrackPadX, TrackPadY);
            _0x531cad9d.offsetMax = new Vector2(-TrackPadX, -TrackPadY);
            Image _0x7e09ed59 = _0x531cad9d.GetComponent<Image>();
            if (_0x7e09ed59 != null)
                _0x7e09ed59.color = _0x687afa6e.BarTrack;
        }

        Image _0x879cc4dc = _0xea8a3218.fillRect.GetComponent<Image>();
        if (_0x879cc4dc != null)
            _0x879cc4dc.color = _0x687afa6e.BarFill;
        Image _0x0412740e = _0xea8a3218.GetComponent<Image>();
        if (_0x0412740e != null)
            _0x0412740e.color = _0x687afa6e.BarTrack;
    }

    /// Horizontal and vertical padding left between the slider body and its track.
    public const float TrackPadX = 12f;
    public const float TrackPadY = 16f;
}