using UnityEngine;

/// Colours of the sky circuit. ONE font material serves the whole app and its outline is
/// dark, so every colour used for GLYPHS here is light (rule C.14). Ember and Teal are
/// fill-only tones: their light twins EmberLight / TealLight are the ones text may use.
public static class _0x687afa6e
{
    public static readonly string[] TrailNames =
    {
        _0xd8105343._0x489fb627(new byte[10] { 182, 190, 177, 182, 161, 211, 164, 178, 184, 182 }, 243),
        _0xd8105343._0x489fb627(new byte[13] { 230, 238, 237, 229, 129, 231, 232, 237, 224, 236, 228, 239, 245 }, 161),
        _0xd8105343._0x489fb627(new byte[12] { 1, 16, 20, 25, 117, 22, 0, 7, 7, 16, 27, 1 }, 85),
        _0xd8105343._0x489fb627(new byte[8] { 145, 148, 130, 155, 245, 148, 134, 157 }, 213),
        _0xd8105343._0x489fb627(new byte[10] { 82, 85, 91, 84, 72, 91, 80, 93, 79, 79 }, 28),
        _0xd8105343._0x489fb627(new byte[15] { 5, 3, 10, 3, 21, 18, 15, 7, 10, 102, 17, 14, 15, 18, 3 }, 70)
    };
    public static readonly Color BgSurfaceHi = new Color(0.1059f, 0.1647f, 0.2588f, 1f);
    public static readonly Color Teal = new Color(0.0863f, 0.5412f, 0.6784f, 1f);
    public static Color Alpha(Color _0xbed24ef0, float _0xf1ea7580)
    {
        return new Color(_0xbed24ef0.r, _0xbed24ef0.g, _0xbed24ef0.b, _0xf1ea7580);
    }

    public static readonly Color TextPrimary = new Color(0.9686f, 0.9804f, 0.9882f, 1f);
    /// The six trail tints, index = trail id in the save file.
    public static readonly Color[] TrailTints =
    {
        new Color(0.8941f, 0.3412f, 0.1804f, 1f),
        new Color(0.9529f, 0.7137f, 0.1216f, 1f),
        new Color(0.0863f, 0.5412f, 0.6784f, 1f),
        new Color(1f, 0.4784f, 0.3020f, 1f),
        new Color(0.3098f, 0.7647f, 0.8784f, 1f),
        new Color(0.9686f, 0.9804f, 0.9882f, 1f)
    };
    public static readonly Color Danger = new Color(0.7843f, 0.2118f, 0.2902f, 1f);
    public static readonly string[] GateNames =
    {
        _0xd8105343._0x489fb627(new byte[5] { 181, 189, 178, 181, 162 }, 240),
        _0xd8105343._0x489fb627(new byte[4] { 141, 133, 134, 142 }, 202),
        _0xd8105343._0x489fb627(new byte[4] { 231, 246, 242, 255 }, 179)
    };
    public static readonly Color BgSurface = new Color(0.0863f, 0.1294f, 0.2275f, 1f);
    public static readonly Color Ember = new Color(0.8941f, 0.3412f, 0.1804f, 1f);
    /// Cumulative shards each trail costs. The first two are free so the collection screen
    /// is never a wall of locks.
    public static readonly int[] TrailCost =
    {
        0,
        0,
        400,
        800,
        1400,
        2200
    };
    public static readonly Color OutlineInk = new Color(0.0392f, 0.0627f, 0.1255f, 1f);
    public static readonly Color Gold = new Color(0.9529f, 0.7137f, 0.1216f, 1f);
    /// The readable twin of each gate colour, for glyphs and thin strokes.
    public static readonly Color[] GateGlyphs =
    {
        new Color(1f, 0.4784f, 0.3020f, 1f),
        new Color(0.9529f, 0.7137f, 0.1216f, 1f),
        new Color(0.3098f, 0.7647f, 0.8784f, 1f)
    };
    public static readonly Color BgDeep = new Color(0.0627f, 0.0941f, 0.1490f, 1f);
    public static readonly Color BarFill = new Color(0.9529f, 0.7137f, 0.1216f, 1f);
    /// The splash loading bar. Declared as whole literals rather than Alpha(BgSurface, ...)
    /// because the bar is read back from this file by the pipeline's visibility check, and
    /// an expression it cannot evaluate is reported as an unthemed bar.
    public static readonly Color BarTrack = new Color(0.0863f, 0.1294f, 0.2275f, 0.88f);
    public static readonly Color TextSecondary = new Color(0.6588f, 0.7137f, 0.7843f, 1f);
    /// The three ember colours a gate can carry. Index is the stable id used by the save
    /// file and by the generator, so never reorder this.
    public static readonly Color[] GateFills =
    {
        new Color(0.8941f, 0.3412f, 0.1804f, 1f),
        new Color(0.9529f, 0.7137f, 0.1216f, 1f),
        new Color(0.0863f, 0.5412f, 0.6784f, 1f)
    };
    public static readonly Color EmberLight = new Color(1f, 0.4784f, 0.3020f, 1f);
    public static readonly Color TealLight = new Color(0.3098f, 0.7647f, 0.8784f, 1f);
    public static Color Mix(Color _0x22c91efe, Color _0xa12ee9c9, float _0xe691120e)
    {
        float _0xc3f7cfab = Mathf.Clamp01(_0xe691120e);
        return new Color(_0x22c91efe.r + (_0xa12ee9c9.r - _0x22c91efe.r) * _0xc3f7cfab, _0x22c91efe.g + (_0xa12ee9c9.g - _0x22c91efe.g) * _0xc3f7cfab, _0x22c91efe.b + (_0xa12ee9c9.b - _0x22c91efe.b) * _0xc3f7cfab, _0x22c91efe.a + (_0xa12ee9c9.a - _0x22c91efe.a) * _0xc3f7cfab);
    }
}

internal static class _0xd8105343
{
    internal static string _0x489fb627(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}