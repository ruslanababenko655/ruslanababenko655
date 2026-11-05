using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The first screen. Branding here is an abstract mark and nothing else - no title, no
/// slogan, no lettering baked into art. The loading bar underneath is themed in its own
/// prefab, so nothing in this file touches it.
public sealed class _0xbbb8cf10 : MonoBehaviour
{
    public _0xbbb8cf10 _0xb9a3a258(Transform _0xf9b62d6b, TMP_FontAsset _0xff6f600c, Sprite _0x7e8bc762, Sprite _0x03bc45b7, float _0x82e83346)
    {
        // A wash dark enough that the first screen never reads as the menu.
        Image _0xfa363b34 = _0x131f2561.Wash(_0xf9b62d6b, _0x85622db1._0x4d44dae2(new byte[10] { 64, 99, 127, 114, 96, 123, 69, 118, 122, 127 }, 19), _0x687afa6e.Alpha(_0x687afa6e.OutlineInk, 0.55f));
        _0x131f2561.Stretch(_0xfa363b34.rectTransform);
        _0xfa363b34.transform.SetAsFirstSibling();
        RectTransform _0x28674462 = _0x131f2561.Branch(_0x85622db1._0x4d44dae2(new byte[5] { 174, 147, 131, 136, 149 }, 225), _0xf9b62d6b);
        _0x131f2561.Fit(_0x28674462, new Vector2(0.5f, 1f), new Vector2(0f, -980f), new Vector2(_0x82e83346 * 2.2f, _0x82e83346 * 2.2f));
        for (int _0xe209e314 = 0; _0xe209e314 < OrbitNodes; _0xe209e314++)
        {
            float _0xd81ec22e = Mathf.PI * 2f * _0xe209e314 / OrbitNodes;
            Color _0x2c6be98d = _0x687afa6e.Mix(_0x687afa6e.Ember, _0x687afa6e.Gold, (float)_0xe209e314 / OrbitNodes);
            Image _0xa0368eed = _0x131f2561.Picture(_0x28674462, _0x85622db1._0x4d44dae2(new byte[9] { 200, 245, 229, 238, 243, 201, 232, 227, 226 }, 135), _0x03bc45b7, _0x687afa6e.Alpha(_0x2c6be98d, 0.85f));
            _0x131f2561.Fit(_0xa0368eed.rectTransform, new Vector2(0.5f, 0.5f), new Vector2(Mathf.Cos(_0xd81ec22e) * _0x82e83346, Mathf.Sin(_0xd81ec22e) * _0x82e83346), new Vector2(46f, 46f));
            _0xa0368eed.DOFade(0.25f, 1.1f).SetDelay(0.12f * _0xe209e314).SetLoops(-1, LoopType.Yoyo).SetLink(_0xa0368eed.gameObject);
            this._0x6cd098bd[_0xe209e314] = _0xa0368eed.rectTransform;
        }

        Image _0x655ae525 = _0x131f2561.Picture(_0xf9b62d6b, _0x85622db1._0x4d44dae2(new byte[9] { 6, 54, 37, 42, 32, 9, 37, 54, 47 }, 68), _0x7e8bc762, Color.white);
        _0x131f2561.Fit(_0x655ae525.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -980f), new Vector2(_0x82e83346 * 1.7f, _0x82e83346 * 1.7f));
        this._0xf436e0fb = _0x655ae525.rectTransform;
        this._0xf436e0fb.localScale = new Vector3(0.82f, 0.82f, 1f);
        this._0xf436e0fb.DOScale(1f, 0.42f).SetEase(Ease.OutBack).SetLink(_0x655ae525.gameObject);
        this._0xf436e0fb.DOScale(1.04f, 1.6f).SetDelay(0.5f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine).SetLink(_0x655ae525.gameObject);
        TextMeshProUGUI _0x39253f2a = _0x131f2561.Caption(_0xf9b62d6b, _0x85622db1._0x4d44dae2(new byte[13] { 144, 179, 175, 162, 176, 171, 128, 162, 179, 183, 170, 172, 173 }, 195), _0xff6f600c, _0x85622db1._0x4d44dae2(new byte[18] { 114, 112, 119, 125, 117, 112, 119, 126, 25, 109, 113, 124, 25, 124, 116, 123, 124, 107 }, 57), 38f, _0x687afa6e.TextSecondary, TextAlignmentOptions.Center);
        _0x131f2561.Fit(_0x39253f2a.rectTransform, new Vector2(0.5f, 0f), new Vector2(0f, 340f), new Vector2(900f, 58f));
        return this;
    }

    private RectTransform _0xf436e0fb;
    private void OnDestroy()
    {
        DOTween.Kill(this._0xf436e0fb);
        DOTween.Kill(this.gameObject);
    }

    private void Update()
    {
        if (this._0xf436e0fb == null)
            return;
        this._0x52b478de += Time.deltaTime * 14f;
        this._0xf436e0fb.parent.localRotation = Quaternion.identity;
        for (int _0xf3d174dd = 0; _0xf3d174dd < this._0x6cd098bd.Length; _0xf3d174dd++)
        {
            if (this._0x6cd098bd[_0xf3d174dd] == null)
                continue;
            float _0x3b97945a = Mathf.Deg2Rad * (this._0x52b478de + 360f * _0xf3d174dd / OrbitNodes);
            float _0x4e117297 = this._0x6cd098bd[_0xf3d174dd].parent.GetComponent<RectTransform>().sizeDelta.x * 0.5f / 1.1f;
            this._0x6cd098bd[_0xf3d174dd].anchoredPosition = new Vector2(Mathf.Cos(_0x3b97945a) * _0x4e117297, Mathf.Sin(_0x3b97945a) * _0x4e117297);
        }
    }

    private const int OrbitNodes = 8;
    private float _0x52b478de;
    private readonly RectTransform[] _0x6cd098bd = new RectTransform[OrbitNodes];
}

internal static class _0x85622db1
{
    internal static string _0x4d44dae2(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}