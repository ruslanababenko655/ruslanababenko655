using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The run itself. Builds the whole game screen inside the template's own game panel, drives
/// the circuit, and hands the result to the template pops. Rows are moved by arithmetic and
/// tweens only - this game drives no bodies at all (design note "physics: none", rule C.57),
/// and contact is a CROSSING test, so nothing can slip past at any speed.
public sealed class _0xbe307921 : MonoBehaviour
{
    private float _0x07d1f2d8;
    private float _0x9ff98b22;
    public const float SurgeSeconds = 18f;
    public const int SurgeBeatRow = 12;
    [SerializeField]
    private Sprite _cloudFar;
    private float _0x343adb96;
    private float _0x4e6ab154;
    private RectTransform _0xd6c58e67;
    [SerializeField]
    private Sprite _gateRing;
    private void _0xa9a92026(_0x6cc1e207 _0x4acf4377)
    {
        _0xf97a39f6 _0xae321465 = _0x4acf4377._0x0380a1c4;
        int _0x1b0ffe2e = this._0x6af4794e._0x80ab0dba;
        this._0xa5371e12++;
        this._0xc5bb44e8._0x55b3c7e9(this._0xa5371e12, this._0xa384b829.Length);
        if (_0xae321465.Barrier == _0x1b0ffe2e)
        {
            _0x4acf4377._0x6a09a861();
            if (!this._0x6af4794e._0x66ef1047)
            {
                this._0x39712227 -= CrystalCost;
                this._0xc5fe3020 = 0;
                this._0x6af4794e._0x745ae6e6();
                this._0xc5bb44e8._0xd9251fa4(0);
                this._0xc5bb44e8._0x2adb5c4e();
                this._0x5d2c7956.DOShakeAnchorPos(0.35f, 26f, 14).SetLink(this.gameObject);
            }
        }
        else
        {
            int _0x7b6472e3 = _0xae321465.Gate[_0x1b0ffe2e];
            if (_0x7b6472e3 >= 0 && _0x7b6472e3 == this._0x661319f9)
            {
                this._0x39712227 = Mathf.Min(Capacity, this._0x39712227 + MatchGain);
                this._0xc5fe3020++;
                if (this._0xc5fe3020 > this._0xd347a6d5)
                    this._0xd347a6d5 = this._0xc5fe3020;
                float _0x6a73c365 = Mathf.Min(1f + Mathf.FloorToInt(this._0xc5fe3020 / 5f) * 0.5f, 4f);
                this._0xe6bda301 += Mathf.RoundToInt(10f * _0x6a73c365 * (this._0x281c8014 > 0f ? 2f : 1f));
                this._0x661319f9 = (this._0x661319f9 + 1) % this._0x4a23eaba;
                this._0xc5bb44e8._0x7658979d(this._0x661319f9);
                this._0xc5bb44e8._0xd9251fa4(this._0xc5fe3020);
                this._0xc5bb44e8._0x02821345();
                _0x4acf4377._0xbba8e241(_0x1b0ffe2e, true);
            }
            else
            {
                _0x4acf4377._0xbba8e241(_0x1b0ffe2e, false);
                if (!this._0xee383329)
                {
                    this._0x39712227 -= MismatchCost;
                    this._0xc5fe3020 = 0;
                    this._0xc5bb44e8._0xd9251fa4(0);
                    this._0xc5bb44e8._0x2adb5c4e();
                }
            }
        }

        if (_0xae321465.Mote == _0x1b0ffe2e)
        {
            this._0x39712227 = Mathf.Min(Capacity, this._0x39712227 + MoteGain);
            this._0xe6bda301 += 5;
            _0x4acf4377._0x7cb6d8e2();
        }
    }

    [SerializeField]
    private Sprite _iconBack;
    public const float MismatchCost = 4f;
    private _0xf97a39f6[] _0xa384b829 = new _0xf97a39f6[0];
    private int _0x977b9418;
    [SerializeField]
    private Sprite _crystalArt;
    [SerializeField]
    private Sprite _cloudNear;
    private void Update()
    {
        if (!this._0x1786c7a1)
        {
            this._0x60e628de();
            return;
        }

        float step = _0x5f296d13._0x5d49422c;
        if (this._0x26f47b93 || step <= 0f || this._0xa384b829.Length == 0)
            return;
        this._0x39712227 -= (this._0xee383329 ? GlideBurnPerSecond : BurnPerSecond) * step;
        if (this._0x281c8014 > 0f)
        {
            this._0x281c8014 -= step;
            if (this._0x281c8014 <= 0f)
            {
                this._0x6af4794e._0x9ce2d200(false);
                this._0xc5bb44e8._0xb70bdfb1(this._0xf1b2d225, false);
            }
        }

        this._0x1d5977a7();
        this._0x14f66562(step);
        this._0x1c0cfbe3(step);
        this._0x66ab74b3._0x44f4f638(this._0x6af4794e._0xed1c8f6b);
        this._0xc5bb44e8._0x1f4cb5cb(this._0x39712227, Capacity);
        this._0xc5bb44e8._0xc55f2535(this._0x6af4794e._0x55fb9f37);
        if (this._0x39712227 <= 0f)
            this._0x1b71cf7b();
        else if (this._0xa5371e12 >= this._0xa384b829.Length)
            this._0x30bebd86();
    }

    private bool _0xf8442b86;
    private void _0x30bebd86()
    {
        if (this._0x26f47b93)
            return;
        this._0x26f47b93 = true;
        int _0x534d4f28 = _0x1b98df55.ShardsFor(this._0xe6bda301);
        _0x1b98df55.Bank(this._0x977b9418, this._0xe6bda301, this._0xd347a6d5, true);
        _0x5f296d13.Hold();
        _0xc89a04dc.Instance._0x1ea70e15(_0x038ba1ae._0x473c0d2d.WIN);
        _0xf90413c3 _0x53bf67d4 = _0xc89a04dc.Instance._0x8199c2c8(_0x038ba1ae._0x473c0d2d.WIN);
        bool _0x9ac0401e = this._0x977b9418 + 1 < _0x1ceaad4b.Count;
        this._0x7fd3f3b7._0xb45a6535(_0x53bf67d4, this._0xe6bda301, this._0xd347a6d5, _0x534d4f28, _0x9ac0401e, () => this._0xf023a733(), () => this._0xaa507e38());
    }

    public const float BurnPerSecond = 1.2f;
    private void _0x83805e76(int _0xb0dab2bf)
    {
        _0x5f296d13.Hold();
        _0xc89a04dc.Instance._0x1ea70e15(_0x038ba1ae._0x473c0d2d.LOSE);
        _0xf90413c3 _0xb1722b6f = _0xc89a04dc.Instance._0x8199c2c8(_0x038ba1ae._0x473c0d2d.LOSE);
        this._0x7fd3f3b7._0xf3d3fe2d(_0xb1722b6f, this._0xa5371e12, this._0xa384b829.Length, this._0xd347a6d5, _0xb0dab2bf, () => this._0xf404b791(), () => this._0xaa507e38());
    }

    private int _0x78848e4b;
    [SerializeField]
    private Sprite _iconClose;
    private float _0x39712227 = Capacity;
    /// Put the next row on the circuit, and fire the scripted beats that make consecutive
    /// capture frames genuinely different rather than the same frame moved along.
    private void _0x14f66562(float step)
    {
        if (this._0x78848e4b >= this._0xa384b829.Length)
            return;
        this._0x1031681c -= step;
        if (this._0x1031681c > 0f)
            return;
        this._0x1031681c += this._0x343adb96;
        _0xf97a39f6 _0xf1269997 = this._0xa384b829[this._0x78848e4b]._0xf083ef89();
        RectTransform _0x7e811c3b = _0x131f2561.Branch(_0x26bee30c._0xcca3ad55(new byte[3] { 150, 171, 179 }, 196), this._0xd6c58e67);
        _0x7e811c3b.sizeDelta = new Vector2(this._0x1d810faf * 3.4f, this._0x1d810faf * 1.5f);
        _0x7e811c3b.anchoredPosition = new Vector2(0f, this._0x9ff98b22);
        _0x6cc1e207 _0x07ec4805 = _0x7e811c3b.gameObject.AddComponent<_0x6cc1e207>()._0x8ded5f00(_0xf1269997, this._0x78848e4b, _0x7e811c3b, this._0x7989fa07, this._0x1d810faf, this._gateRing, this._gateGlow, this._crystalArt, this._moteArt);
        _0x07ec4805._0x95d2ce35(this._0x6af4794e._0x80ab0dba, this._0x7989fa07);
        this._0xee2ba156.Add(_0x07ec4805);
        this._0x78848e4b++;
        if (!this._0xf8442b86 && this._0x78848e4b >= CrystalBeatRow)
        {
            this._0xf8442b86 = true;
            this._0xc5bb44e8._0xf6e0b895(_0x26bee30c._0xcca3ad55(new byte[23] { 100, 127, 98, 101, 112, 115, 125, 116, 17, 114, 99, 104, 98, 101, 112, 125, 98, 17, 112, 121, 116, 112, 117 }, 49), _0x687afa6e.Danger, 9f);
        }

        if (!this._0xa6fbfb76 && this._0x78848e4b >= SurgeBeatRow)
        {
            this._0xa6fbfb76 = true;
            this._0x281c8014 = SurgeSeconds;
            this._0x6af4794e._0x9ce2d200(true);
            this._0xc5bb44e8._0xb70bdfb1(this._0xf1b2d225, true);
            this._0xc5bb44e8._0xf6e0b895(_0x26bee30c._0xcca3ad55(new byte[14] { 164, 172, 163, 164, 179, 193, 178, 180, 179, 166, 164, 193, 153, 211 }, 225), _0x687afa6e.Gold, 12f);
        }

        if (!this._0xf1a7a179 && this._0x78848e4b >= SpireBeatRow)
        {
            this._0xf1a7a179 = true;
            this._0x2d8facb9._0x4d2fbc0f();
        }
    }

    private float _0x1d810faf;
    private _0xae61d7dd _0x66ab74b3;
    [SerializeField]
    private Sprite _slab;
    private int _0xa5371e12;
    [SerializeField]
    private Sprite _dragonArt;
    public const float FlightSeconds = 3f;
    [SerializeField]
    private Sprite _gateGlow;
    private void _0x94b5df60()
    {
        if (this._0x26f47b93)
            return;
        _0x5f296d13.Hold();
        _0xc89a04dc.Instance._0x1ea70e15(_0x038ba1ae._0x473c0d2d.PAUSE);
        _0xf90413c3 _0xcd10ac10 = _0xc89a04dc.Instance._0x8199c2c8(_0x038ba1ae._0x473c0d2d.PAUSE);
        this._0x7fd3f3b7._0x69766198(_0xcd10ac10, () => this._0x29227c92(), () => this._0xaa507e38());
    }

    private void _0xaa507e38()
    {
        _0x5f296d13.Release();
        _0x42666298.Instance._0xdb96b798(_0x038ba1ae._0xe9cafa10.SCENE_0);
    }

    private void _0x1d5977a7()
    {
        if (this._0xd7b25e0c == null)
            return;
        bool _0x94974451 = false;
        if (this._0xd7b25e0c._0x9c498244 != 0)
            _0x94974451 = this._0x6af4794e._0x1d271568(this._0xd7b25e0c._0x9c498244);
        if (this._0xd7b25e0c._0x058f6d7c)
        {
            if (this._0x39712227 > DashCost && this._0x6af4794e._0xab71ef70())
            {
                this._0x39712227 -= DashCost;
                this._0x66ab74b3._0xfa55e562(true);
                DOVirtual.DelayedCall(_0x42669c31.DashSeconds, () => this._0x66ab74b3._0xfa55e562(false)).SetLink(this.gameObject);
                _0x94974451 = true;
            }
            else
            {
                this._0x167dd976._0x49779921(this._0x6af4794e._0x01173df2 ? _0x26bee30c._0xcca3ad55(new byte[24] { 28, 29, 6, 114, 23, 28, 29, 7, 21, 26, 114, 23, 31, 16, 23, 0, 114, 6, 29, 114, 22, 19, 1, 26 }, 82) : _0x26bee30c._0xcca3ad55(new byte[21] { 134, 142, 129, 134, 145, 227, 135, 130, 144, 139, 227, 145, 134, 128, 139, 130, 145, 132, 138, 141, 132 }, 195), false);
            }
        }

        if (_0x94974451 && this._0xee383329)
        {
            this._0xee383329 = false;
            this._0x72c46fce._0xb4f5cdca();
        }
    }

    private void Start()
    {
        this._0x60e628de();
    }

    private float[] _0x7989fa07 =
    {
        0f,
        0f,
        0f
    };
    private int _0x661319f9;
    private void _0x29227c92()
    {
        _0xc89a04dc.Instance._0x64fa7905();
        DOVirtual.DelayedCall(0.35f, () => _0x5f296d13.Release()).SetLink(this.gameObject);
    }

    private bool _0xf1a7a179;
    private void OnDestroy()
    {
        DOTween.Kill(this.gameObject);
        DOTween.Kill(this._0x5d2c7956);
    }

    [SerializeField]
    private Sprite _wispArt;
    [SerializeField]
    private Sprite _iconPause;
    private readonly List<_0x6cc1e207> _0xee2ba156 = new List<_0x6cc1e207>();
    private _0x42669c31 _0x6af4794e;
    private bool _0xee383329 = true;
    private void _0xf023a733()
    {
        _0x1b98df55.ChooseCircuit(Mathf.Min(this._0x977b9418 + 1, _0x1ceaad4b.Count - 1));
        _0x5f296d13.Release();
        _0x42666298.Instance._0xdb96b798(_0x038ba1ae._0xe9cafa10.SCENE_1);
    }

    [SerializeField]
    private Sprite _emblemArt;
    public const float MoteGain = 4f;
    private RectTransform _0x5d2c7956;
    private float _0x1031681c;
    private _0x5a18fc88 _0x7fd3f3b7;
    private int _0xc5fe3020;
    private void _0xf404b791()
    {
        _0x5f296d13.Release();
        _0x42666298.Instance._0xdb96b798(_0x038ba1ae._0xe9cafa10.SCENE_1);
    }

    /// Build the run. Everything here is sized off the panel's own rectangle, and that
    /// rectangle does not exist yet on the frame Start runs: the canvas has not resolved
    /// its scale and the safe-area handler has not sized its host, so every stretched
    /// child measures zero. So the build waits for a real rect and Update retries until
    /// it has one - the alternative is a circuit laid out at size zero, which no gate
    /// would catch.
    private void _0x60e628de()
    {
        if (this._0x1786c7a1)
            return;
        _0x828b28ef _0xf9fd05dc = _0x828b28ef.Instance;
        if (_0xf9fd05dc == null || _0xf9fd05dc.Panels == null || _0xf9fd05dc.Panels.Count <= _0x038ba1ae._0xdbcb6201.DEFAULT)
            return;
        _0x049fd978 _0xd8a1ab22 = _0xf9fd05dc.Panels[_0x038ba1ae._0xdbcb6201.DEFAULT];
        if (_0xd8a1ab22 == null || _0xd8a1ab22.Content == null)
            return;
        RectTransform _0xd77f858d = _0xd8a1ab22.Content.GetComponent<RectTransform>();
        if (_0xd77f858d == null)
            return;
        float width = _0xd77f858d.rect.width;
        float height = _0xd77f858d.rect.height;
        if (width < 1f || height < 1f)
            return;
        this._0x1786c7a1 = true;
        // Rule H, second option: the template's own HUD slots are not reused and nothing of
        // ours is hung on them - we simply take the panel body and build our own.
        for (int _0x90b89b15 = _0xd77f858d.childCount - 1; _0x90b89b15 >= 0; _0x90b89b15--)
            _0xd77f858d.GetChild(_0x90b89b15).gameObject.SetActive(false);
        new _0xe22ab1be()._0xc3f450e4(this._font);
        this._0x977b9418 = _0x1b98df55._0xd4859787;
        this._0x4a23eaba = Mathf.Clamp(_0x1ceaad4b.Colours[this._0x977b9418], 2, 3);
        this._0x343adb96 = _0x1ceaad4b.RowInterval[this._0x977b9418];
        this._0xa384b829 = _0x4e8af039.Resolve(this._0x977b9418, _0x1b98df55._0x7c0b9cbe);
        for (int _0x7424b9d4 = 0; _0x7424b9d4 < 3; _0x7424b9d4++)
            this._0x7989fa07[_0x7424b9d4] = (_0x7424b9d4 - 1) * width * 0.30f;
        this._0x1d810faf = width * 0.26f;
        this._0x4e6ab154 = -height * 0.5f + height * 0.22f;
        this._0x9ff98b22 = height * 0.5f + height * 0.12f;
        this._0x07d1f2d8 = -height * 0.5f - height * 0.16f;
        this._0xca1beb4d = (this._0x9ff98b22 - this._0x4e6ab154) / FlightSeconds;
        float _0xbab59c85 = _0x1b98df55._0xb9c0d93b ? 0.5f : 1f;
        RectTransform _0xa29b5240 = _0x131f2561.Stretch(_0x131f2561.Branch(_0x26bee30c._0xcca3ad55(new byte[7] { 214, 241, 234, 198, 229, 231, 239 }, 132), _0xd77f858d));
        _0xa29b5240.SetAsFirstSibling();
        Image _0x200139fb = _0x131f2561.Wash(_0xa29b5240, _0x26bee30c._0xcca3ad55(new byte[7] { 208, 232, 250, 212, 226, 240, 235 }, 131), _0x687afa6e.Alpha(_0x687afa6e.BgDeep, 0.35f));
        _0x131f2561.Stretch(_0x200139fb.rectTransform);
        this._0x2d8facb9 = _0xa29b5240.gameObject.AddComponent<_0x90177657>()._0x7b2c5bcf(_0xa29b5240, this._cloudFar, this._cloudNear, this._spireArt, width, height, _0xbab59c85);
        this._0xf1b2d225 = _0x131f2561.Wash(_0xa29b5240, _0x26bee30c._0xcca3ad55(new byte[9] { 13, 43, 44, 57, 59, 9, 63, 45, 54 }, 94), _0x687afa6e.Alpha(_0x687afa6e.Gold, 0f));
        _0x131f2561.Stretch(this._0xf1b2d225.rectTransform);
        this._0x5d2c7956 = _0x131f2561.Stretch(_0x131f2561.Branch(_0x26bee30c._0xcca3ad55(new byte[8] { 131, 164, 191, 151, 184, 180, 189, 181 }, 209), _0xd77f858d));
        this._0xd6c58e67 = _0x131f2561.Stretch(_0x131f2561.Branch(_0x26bee30c._0xcca3ad55(new byte[4] { 26, 39, 63, 59 }, 72), this._0x5d2c7956));
        RectTransform _0xe9d3be02 = _0x131f2561.Stretch(_0x131f2561.Branch(_0x26bee30c._0xcca3ad55(new byte[4] { 153, 175, 165, 171 }, 206), this._0x5d2c7956));
        RectTransform _0x35866307 = _0x131f2561.Branch(_0x26bee30c._0xcca3ad55(new byte[6] { 211, 229, 246, 240, 248, 249 }, 151), this._0x5d2c7956);
        float _0x2080bf9d = width * 0.22f;
        _0x131f2561.Fit(_0x35866307, new Vector2(0.5f, 0.5f), new Vector2(0f, this._0x4e6ab154), new Vector2(_0x2080bf9d, _0x2080bf9d));
        Image _0xabc526ab = _0x131f2561.Picture(_0x35866307, _0x26bee30c._0xcca3ad55(new byte[3] { 89, 98, 102 }, 11), this._gateGlow, _0x687afa6e.Alpha(_0x687afa6e.Gold, 0f));
        _0x131f2561.Fit(_0xabc526ab.rectTransform, new Vector2(0.5f, 0.5f), Vector2.zero, new Vector2(_0x2080bf9d * 1.3f, _0x2080bf9d * 1.3f));
        Image _0x59197d46 = _0x131f2561.Picture(_0x35866307, _0x26bee30c._0xcca3ad55(new byte[4] { 215, 239, 237, 234 }, 132), this._dragonArt, Color.white);
        _0x131f2561.Stretch(_0x59197d46.rectTransform);
        int _0xc02a4738 = 6 + _0x1b98df55._0x8aff4184 * 4;
        this._0x66ab74b3 = _0xe9d3be02.gameObject.AddComponent<_0xae61d7dd>()._0xdfe98624(_0xe9d3be02, this._wispArt, _0xc02a4738, _0x2080bf9d * 0.34f, _0x687afa6e.TrailTints[_0x1b98df55._0x21bcf3a2]);
        this._0x6af4794e = _0x35866307.gameObject.AddComponent<_0x42669c31>()._0xc8d66969(_0x35866307, _0x59197d46, _0xabc526ab, this._0x7989fa07, this._0x4e6ab154, _0x2080bf9d);
        RectTransform _0x939eb8a7 = _0x131f2561.Stretch(_0x131f2561.Branch(_0x26bee30c._0xcca3ad55(new byte[6] { 230, 193, 218, 252, 193, 208 }, 180), _0xd77f858d));
        this._0xc5bb44e8 = _0x939eb8a7.gameObject.AddComponent<_0x73c586f9>()._0xf05e5987(_0x939eb8a7, this._font, this._slab, this._gateRing, this._gateGlow);
        this._0x72c46fce = _0x939eb8a7.gameObject.AddComponent<_0x6a2c762e>()._0xcc2b2a1e(_0x939eb8a7, this._font, this._slab, this._gateRing);
        this._0x167dd976 = _0x939eb8a7.gameObject.AddComponent<_0x4bf36e40>()._0x3375969f(_0x939eb8a7, this._font, this._slab, -120f);
        Button _0x9a39a597 = _0x131f2561.Glyph(_0x939eb8a7, _0x26bee30c._0xcca3ad55(new byte[10] { 78, 109, 111, 103, 78, 121, 120, 120, 99, 98 }, 12), this._iconBack, this._slab, new Vector2(0f, 1f), new Vector2(112f, -200f), 108f, _0x687afa6e.Gold);
        _0x9a39a597.onClick.AddListener(() => this._0xaa507e38());
        Button _0x47b7b09d = _0x131f2561.Glyph(_0x939eb8a7, _0x26bee30c._0xcca3ad55(new byte[11] { 201, 248, 236, 234, 252, 219, 236, 237, 237, 246, 247 }, 153), this._iconPause, this._slab, new Vector2(1f, 1f), new Vector2(-112f, -200f), 108f, _0x687afa6e.Gold);
        _0x47b7b09d.onClick.AddListener(() => this._0x94b5df60());
        this._0xd7b25e0c = _0x939eb8a7.gameObject.AddComponent<_0x3a2e0e54>();
        this._0x7fd3f3b7 = _0x939eb8a7.gameObject.AddComponent<_0x5a18fc88>();
        this._0x7fd3f3b7._0xcf2b99fc(this._font, this._slab, this._iconClose, this._emblemArt);
        this._0xc5bb44e8._0x1f4cb5cb(this._0x39712227, Capacity);
        this._0xc5bb44e8._0x7658979d(this._0x661319f9);
        this._0xc5bb44e8._0xd9251fa4(0);
        this._0xc5bb44e8._0x55b3c7e9(0, this._0xa384b829.Length);
        this._0xc5bb44e8._0xc55f2535(1f);
        this._0x1031681c = 0.4f;
    }

    private int _0xe6bda301;
    [SerializeField]
    private TMP_FontAsset _font;
    private int _0x4a23eaba;
    private bool _0x1786c7a1;
    public const int SpireBeatRow = 15;
    private int _0xd347a6d5;
    private Image _0xf1b2d225;
    private void _0x1b71cf7b()
    {
        if (this._0x26f47b93)
            return;
        this._0x26f47b93 = true;
        this._0x39712227 = 0f;
        this._0xc5bb44e8._0x1f4cb5cb(0f, Capacity);
        this._0x6af4794e._0x142cd334();
        int _0x6492c57a = _0x1b98df55.ShardsFor(this._0xe6bda301);
        _0x1b98df55.Bank(this._0x977b9418, this._0xe6bda301, this._0xd347a6d5, false);
        DOVirtual.DelayedCall(0.85f, () => this._0x83805e76(_0x6492c57a)).SetLink(this.gameObject);
    }

    public const float CrystalCost = 18f;
    [SerializeField]
    private Sprite _moteArt;
    private _0x73c586f9 _0xc5bb44e8;
    /// Slide every live row down and resolve the one that crosses the dragon line this frame.
    private void _0x1c0cfbe3(float step)
    {
        float _0x42927db1 = this._0xca1beb4d * step;
        for (int _0xb026b7f1 = this._0xee2ba156.Count - 1; _0xb026b7f1 >= 0; _0xb026b7f1--)
        {
            _0x6cc1e207 _0xa6d73715 = this._0xee2ba156[_0xb026b7f1];
            if (_0xa6d73715 == null)
            {
                this._0xee2ba156.RemoveAt(_0xb026b7f1);
                continue;
            }

            float _0x9d714f90 = _0xa6d73715._0x406d6a15;
            float _0xf61c878e = _0x9d714f90 - _0x42927db1;
            _0xa6d73715._0x406d6a15 = _0xf61c878e;
            if (!_0xa6d73715._0xefce919a && _0x9d714f90 > this._0x4e6ab154 && _0xf61c878e <= this._0x4e6ab154)
            {
                _0xa6d73715._0xefce919a = true;
                this._0xa9a92026(_0xa6d73715);
            }

            if (_0xf61c878e < this._0x07d1f2d8)
            {
                this._0xee2ba156.RemoveAt(_0xb026b7f1);
                Destroy(_0xa6d73715.gameObject);
            }
        }
    }

    public const float DashCost = 10f;
    private bool _0xa6fbfb76;
    private _0x90177657 _0x2d8facb9;
    public const float GlideBurnPerSecond = 0.72f;
    private _0x3a2e0e54 _0xd7b25e0c;
    public const float Capacity = 100f;
    // The three scripted beats. Their row numbers are chosen against the row interval of
    // the circuits so that the frames the review captures - roughly seconds 12, 20 and 28
    // of a run - each land on a different one: crystals called, then nothing but the
    // circuit, then the surge with the spire drifting past behind it.
    public const int CrystalBeatRow = 5;
    public const float MatchGain = 8f;
    [SerializeField]
    private Sprite _spireArt;
    private float _0xca1beb4d;
    private float _0x281c8014;
    private bool _0x26f47b93;
    private _0x6a2c762e _0x72c46fce;
    private _0x4bf36e40 _0x167dd976;
}

internal static class _0x26bee30c
{
    internal static string _0xcca3ad55(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}