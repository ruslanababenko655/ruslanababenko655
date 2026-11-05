using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// Dresses the three template pops. The template body - its static Score: / Reward: rows,
/// its action buttons and the close square whose Image carries no sprite - is switched off
/// and an own card is built in its place, so none of the template's wording or its white
/// blank can reach the screen (rules C.3, C.17, B.1). The BASE_PANEL chrome underneath is
/// kept: that is the themed surface the card sits on.
public sealed class _0x5a18fc88 : MonoBehaviour
{
    public void _0xb45a6535(_0xf90413c3 _0xf07c61b8, int _0x429f0c9b, int _0x111fcb77, int _0x24fc24e0, bool _0xa7763cf9, System.Action _0x7884ddf8, System.Action _0x443ded3e)
    {
        RectTransform _0x393cc9fa = this._0x20cc4335(_0xf07c61b8);
        if (_0x393cc9fa == null)
            return;
        this._0x3dab113b(_0x393cc9fa, _0xe5fe9691._0xc56275b2(new byte[15] { 251, 241, 234, 251, 237, 241, 236, 152, 251, 244, 253, 249, 234, 253, 252 }, 184), _0x687afa6e.Gold);
        this._0xdb9b518c(_0x393cc9fa, _0x687afa6e.Gold);
        this._0xa81d2243(_0x393cc9fa, string.Format(_0xe5fe9691._0xc56275b2(new byte[20] { 80, 88, 87, 80, 71, 53, 81, 80, 89, 92, 67, 80, 71, 80, 81, 53, 53, 110, 37, 104 }, 21), _0x429f0c9b));
        this._0x9af4fd3c(_0x393cc9fa, string.Format(_0xe5fe9691._0xc56275b2(new byte[33] { 156, 155, 141, 138, 254, 157, 145, 147, 156, 145, 254, 166, 165, 238, 163, 254, 254, 254, 243, 254, 254, 254, 141, 150, 159, 140, 154, 141, 254, 245, 165, 239, 163 }, 222), _0x111fcb77, _0x24fc24e0));
        this._0x159b3791(_0x393cc9fa, _0xa7763cf9 ? _0xe5fe9691._0xc56275b2(new byte[12] { 106, 97, 124, 112, 4, 103, 109, 118, 103, 113, 109, 112 }, 36) : _0xe5fe9691._0xc56275b2(new byte[9] { 209, 219, 206, 183, 214, 208, 214, 222, 217 }, 151), _0xe5fe9691._0xc56275b2(new byte[7] { 122, 98, 112, 9, 100, 104, 121 }, 41), _0x7884ddf8, _0x443ded3e);
        this._0x18db0d68(_0x393cc9fa, _0x443ded3e);
        this._0x0435b4cd(_0x393cc9fa);
    }

    private void _0x18db0d68(RectTransform _0xe3ebab5c, System.Action _0xee35ce1f)
    {
        Button _0xcb99b16a = _0x131f2561.Glyph(_0xe3ebab5c, _0xe5fe9691._0xc56275b2(new byte[8] { 142, 177, 174, 157, 178, 177, 173, 187 }, 222), this._0xa989e6b5, this._0x67b18f9e, new Vector2(1f, 1f), new Vector2(-54f, -54f), 96f, _0x687afa6e.TextSecondary);
        _0xcb99b16a.onClick.AddListener(() => this._0x938e60df(_0xee35ce1f));
    }

    private TMP_FontAsset _0x17952dca;
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
    }

    private void _0x0435b4cd(RectTransform _0x199fd776)
    {
        _0x199fd776.localScale = new Vector3(0.88f, 0.88f, 1f);
        _0x199fd776.DOScale(1f, 0.3f).SetEase(Ease.OutBack).SetLink(_0x199fd776.gameObject);
    }

    private void _0x3dab113b(RectTransform _0xcaba8a26, string _0xbf660130, Color _0xb264aadb)
    {
        TextMeshProUGUI _0xbf9e4cf7 = _0x131f2561.Caption(_0xcaba8a26, _0xe5fe9691._0xc56275b2(new byte[7] { 168, 151, 136, 176, 157, 153, 156 }, 248), this._0x17952dca, _0xbf660130, 70f, _0xb264aadb, TextAlignmentOptions.Center);
        _0x131f2561.Fit(_0xbf9e4cf7.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -70f), new Vector2(820f, 96f));
    }

    public void _0xf3d3fe2d(_0xf90413c3 _0xc21eec3d, int _0xf018a8c6, int _0xd3e32c68, int _0x28d49631, int _0xbdc56fa0, System.Action _0xff762090, System.Action _0x12d59869)
    {
        RectTransform _0x534d89f2 = this._0x20cc4335(_0xc21eec3d);
        if (_0x534d89f2 == null)
            return;
        this._0x3dab113b(_0x534d89f2, _0xe5fe9691._0xc56275b2(new byte[18] { 155, 135, 138, 239, 138, 130, 141, 138, 157, 239, 152, 138, 129, 155, 239, 128, 154, 155 }, 207), _0x687afa6e.EmberLight);
        this._0xdb9b518c(_0x534d89f2, _0x687afa6e.EmberLight);
        this._0xa81d2243(_0x534d89f2, string.Format(_0xe5fe9691._0xc56275b2(new byte[14] { 45, 43, 62, 47, 74, 17, 90, 23, 74, 69, 74, 17, 91, 23 }, 106), _0xf018a8c6, _0xd3e32c68));
        this._0x9af4fd3c(_0x534d89f2, string.Format(_0xe5fe9691._0xc56275b2(new byte[33] { 204, 203, 221, 218, 174, 205, 193, 195, 204, 193, 174, 246, 245, 190, 243, 174, 174, 174, 163, 174, 174, 174, 221, 198, 207, 220, 202, 221, 174, 165, 245, 191, 243 }, 142), _0x28d49631, _0xbdc56fa0));
        this._0x159b3791(_0x534d89f2, _0xe5fe9691._0xc56275b2(new byte[9] { 211, 217, 204, 181, 212, 210, 212, 220, 219 }, 149), _0xe5fe9691._0xc56275b2(new byte[7] { 135, 159, 141, 244, 153, 149, 132 }, 212), _0xff762090, _0x12d59869);
        this._0x18db0d68(_0x534d89f2, _0x12d59869);
        this._0x0435b4cd(_0x534d89f2);
    }

    public void _0xcf2b99fc(TMP_FontAsset _0x1639d95a, Sprite _0xbcf06d49, Sprite _0xb43cc0fb, Sprite _0x1973ed35)
    {
        this._0x17952dca = _0x1639d95a;
        this._0x67b18f9e = _0xbcf06d49;
        this._0xa989e6b5 = _0xb43cc0fb;
        this._0x9aaffdb6 = _0x1973ed35;
    }

    private Sprite _0x9aaffdb6;
    private Sprite _0xa989e6b5;
    private void _0xdb9b518c(RectTransform _0x3b9f363b, Color _0x44a958bb)
    {
        Image _0x5983afb8 = _0x131f2561.Picture(_0x3b9f363b, _0xe5fe9691._0xc56275b2(new byte[8] { 193, 254, 225, 210, 227, 244, 226, 229 }, 145), this._0x9aaffdb6, _0x44a958bb);
        _0x131f2561.Fit(_0x5983afb8.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -280f), new Vector2(260f, 260f));
    }

    private void _0x9af4fd3c(RectTransform _0xa1db8ba7, string _0x147c6b63)
    {
        TextMeshProUGUI _0x6be4e8af = _0x131f2561.Caption(_0xa1db8ba7, _0xe5fe9691._0xc56275b2(new byte[7] { 200, 247, 232, 204, 249, 241, 244 }, 152), this._0x17952dca, _0x147c6b63, 36f, _0x687afa6e.TextSecondary, TextAlignmentOptions.Center);
        _0x131f2561.Fit(_0x6be4e8af.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -556f), new Vector2(820f, 58f));
    }

    private void _0x159b3791(RectTransform _0xd0a5ba18, string _0x71e81927, string _0xe58da98b, System.Action _0x194eb8d4, System.Action _0x5f80bb15)
    {
        Button _0x4f654b72 = _0x131f2561.Action(_0xd0a5ba18, _0xe5fe9691._0xc56275b2(new byte[10] { 113, 78, 81, 113, 83, 72, 76, 64, 83, 88 }, 33), this._0x17952dca, this._0x67b18f9e, _0x71e81927, new Vector2(0.5f, 0f), new Vector2(0f, 230f), new Vector2(620f, 128f), _0x687afa6e.Gold, 48f);
        _0x4f654b72.onClick.AddListener(() => this._0x938e60df(_0x194eb8d4));
        Button _0xec77850d = _0x131f2561.Action(_0xd0a5ba18, _0xe5fe9691._0xc56275b2(new byte[12] { 103, 88, 71, 100, 82, 84, 88, 89, 83, 86, 69, 78 }, 55), this._0x17952dca, this._0x67b18f9e, _0xe58da98b, new Vector2(0.5f, 0f), new Vector2(0f, 82f), new Vector2(620f, 112f), _0x687afa6e.TealLight, 42f);
        _0xec77850d.onClick.AddListener(() => this._0x938e60df(_0x5f80bb15));
    }

    public void _0x69766198(_0xf90413c3 _0x37defafb, System.Action _0x98c0172e, System.Action _0x2c9e4610)
    {
        RectTransform _0xad923c4a = this._0x20cc4335(_0x37defafb);
        if (_0xad923c4a == null)
            return;
        this._0x3dab113b(_0xad923c4a, _0xe5fe9691._0xc56275b2(new byte[12] { 71, 77, 86, 71, 81, 77, 80, 36, 76, 65, 72, 64 }, 4), _0x687afa6e.TealLight);
        this._0xdb9b518c(_0xad923c4a, _0x687afa6e.TealLight);
        this._0xa81d2243(_0xad923c4a, _0xe5fe9691._0xc56275b2(new byte[24] { 173, 169, 183, 174, 187, 222, 178, 222, 209, 222, 172, 222, 222, 189, 182, 191, 176, 185, 187, 222, 178, 191, 176, 187 }, 254));
        this._0x9af4fd3c(_0xad923c4a, _0xe5fe9691._0xc56275b2(new byte[20] { 152, 156, 130, 155, 142, 235, 158, 155, 235, 235, 142, 134, 137, 142, 153, 235, 143, 138, 152, 131 }, 203));
        this._0x159b3791(_0xad923c4a, _0xe5fe9691._0xc56275b2(new byte[6] { 147, 132, 146, 148, 140, 132 }, 193), _0xe5fe9691._0xc56275b2(new byte[7] { 210, 202, 216, 161, 204, 192, 209 }, 129), _0x98c0172e, _0x2c9e4610);
        this._0x18db0d68(_0xad923c4a, _0x98c0172e);
        this._0x0435b4cd(_0xad923c4a);
    }

    private void _0xa81d2243(RectTransform _0x43a9b81d, string _0x682ac0cf)
    {
        TextMeshProUGUI _0xa7f52dbd = _0x131f2561.Caption(_0x43a9b81d, _0xe5fe9691._0xc56275b2(new byte[7] { 50, 13, 18, 32, 13, 6, 27 }, 98), this._0x17952dca, _0x682ac0cf, 50f, _0x687afa6e.TextPrimary, TextAlignmentOptions.Center);
        _0x131f2561.Fit(_0xa7f52dbd.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -470f), new Vector2(820f, 72f));
    }

    /// Clear the template body and start a fresh card. Rebuilt every time rather than
    /// cached: captions and handlers are captured when the card is built, so a reused card
    /// would still offer the previous result's action.
    private RectTransform _0x20cc4335(_0xf90413c3 _0xe3da68b9)
    {
        if (_0xe3da68b9 == null || _0xe3da68b9.Content == null)
            return null;
        Transform _0x13d315d6 = _0xe3da68b9.Content.transform;
        if (this._0x02c0b93c != null)
        {
            this._0x02c0b93c.SetParent(null, false);
            Destroy(this._0x02c0b93c.gameObject);
            this._0x02c0b93c = null;
        }

        // Child 0 is the BASE_PANEL chrome and carries the themed surface - everything after
        // it is the template's own body and goes dark.
        for (int _0xf8ebb716 = 1; _0xf8ebb716 < _0x13d315d6.childCount; _0xf8ebb716++)
            _0x13d315d6.GetChild(_0xf8ebb716).gameObject.SetActive(false);
        RectTransform _0xec8b5029 = _0x131f2561.Stretch(_0x131f2561.Branch(_0xe5fe9691._0xc56275b2(new byte[10] { 235, 220, 202, 204, 213, 205, 250, 216, 203, 221 }, 185), _0x13d315d6));
        _0xec8b5029.offsetMin = new Vector2(70f, 120f);
        _0xec8b5029.offsetMax = new Vector2(-70f, -120f);
        this._0x02c0b93c = _0xec8b5029;
        return _0xec8b5029;
    }

    private Sprite _0x67b18f9e;
    private void _0x938e60df(System.Action _0x271b851b)
    {
        if (_0x271b851b != null)
            _0x271b851b();
    }

    private RectTransform _0x02c0b93c;
}

internal static class _0xe5fe9691
{
    internal static string _0xc56275b2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}