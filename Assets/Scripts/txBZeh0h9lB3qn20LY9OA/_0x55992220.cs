using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// The sky map: one large card showing the circuit the pilot is about to fly, and a row of
/// numbered chips to choose between the six. A chip tap rewrites the card, re-tints the
/// chip row and punches the card, so the choice is visible in a still frame and not only
/// in a label (rule C.7). A locked chip shakes and raises the notice instead.
public sealed class _0x55992220 : MonoBehaviour
{
    private TextMeshProUGUI _0xf3b9b1c5;
    private const float ChipPitch = 178f;
    private readonly RectTransform[] _0x29189561 = new RectTransform[ChipCount];
    private const float ChipWidth = 170f;
    private readonly TextMeshProUGUI[] _0x4152d4a0 = new TextMeshProUGUI[ChipCount];
    private readonly Image[] _0x2c05304f = new Image[3];
    private TextMeshProUGUI _0x7075afb1;
    private const float CardWidth = 800f;
    private const float CardHeight = 540f;
    public const int ChipCount = 6;
    private TextMeshProUGUI _0xecfb22ed;
    private const float ChipHeight = 140f;
    private TextMeshProUGUI _0xdd475c06;
    private readonly Image[] _0x2a47e8e6 = new Image[ChipCount];
    public int _0x1a1f72f6
    {
        get
        {
            return this._0x7f288d29;
        }
    }

    private RectTransform _0x5345fb47;
    private _0x4bf36e40 _0xc70d5743;
    /// Pick a circuit. A locked one answers with a shake and a notice rather than silence.
    private void _0x613b069b(int _0x2f25d2ff)
    {
        int _0xead75989 = _0x1ceaad4b.Clamp(_0x2f25d2ff);
        if (!_0x1b98df55.CircuitOpen(_0xead75989))
        {
            if (this._0x29189561[_0xead75989] != null)
                this._0x29189561[_0xead75989].DOShakeAnchorPos(0.3f, 18f, 16).SetLink(this.gameObject);
            if (this._0xc70d5743 != null)
                this._0xc70d5743._0x49779921(string.Format(_0x7ee59e5d._0xe3cdfa38(new byte[23] { 14, 1, 8, 12, 31, 109, 14, 4, 31, 14, 24, 4, 25, 109, 54, 125, 48, 109, 11, 4, 31, 30, 25 }, 77), _0x1ceaad4b.UnlockAfter[_0xead75989]), false);
            return;
        }

        this._0x7f288d29 = _0xead75989;
        _0x1b98df55.ChooseCircuit(_0xead75989);
        this._0xe228d44b();
        if (this._0x5345fb47 != null)
        {
            this._0x5345fb47.DOScale(1.05f, 0.12f).SetEase(Ease.OutQuad).SetLink(this.gameObject);
            this._0x5345fb47.DOScale(1f, 0.22f).SetDelay(0.12f).SetEase(Ease.OutBack).SetLink(this.gameObject);
        }

        if (this._0x7a3ff6a2 != null)
        {
            this._0x7a3ff6a2.color = _0x687afa6e.Gold;
            this._0x7a3ff6a2.DOColor(_0x687afa6e.Alpha(_0x687afa6e.Gold, 0.75f), 0.35f).SetLink(this.gameObject);
        }

        if (this._0xc71c53ff != null)
            this._0xc71c53ff(_0xead75989);
    }

    private readonly Image[] _0xcf5e7ca0 = new Image[ChipCount];
    public _0x55992220 _0x3bf3a454(Transform _0x98eede0f, TMP_FontAsset _0x50edb050, Sprite _0x516fba19, Sprite _0x02434727, Sprite _0x68a91251, _0x4bf36e40 _0xf4dbfefe, Action<int> _0xf9828039)
    {
        this._0xc70d5743 = _0xf4dbfefe;
        this._0xc71c53ff = _0xf9828039;
        this._0x7f288d29 = _0x1b98df55._0xd4859787;
        Image _0x0d763647 = _0x131f2561.Plate(_0x98eede0f, _0x7ee59e5d._0xe3cdfa38(new byte[11] { 235, 193, 218, 203, 221, 193, 220, 235, 201, 218, 204 }, 168), _0x02434727, _0x687afa6e.Alpha(_0x687afa6e.BgSurface, 0.94f), 1.5f);
        this._0x5345fb47 = _0x0d763647.rectTransform;
        _0x131f2561.Fit(this._0x5345fb47, new Vector2(0.5f, 0f), new Vector2(0f, 1290f), new Vector2(CardWidth, CardHeight));
        this._0x7a3ff6a2 = _0x131f2561.Plate(_0x0d763647.transform, _0x7ee59e5d._0xe3cdfa38(new byte[15] { 193, 235, 240, 225, 247, 235, 246, 193, 227, 240, 230, 199, 230, 229, 231 }, 130), _0x02434727, _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.75f), 1.5f);
        _0x131f2561.Stretch(this._0x7a3ff6a2.rectTransform);
        this._0x7a3ff6a2.rectTransform.offsetMin = new Vector2(-5f, -5f);
        this._0x7a3ff6a2.rectTransform.offsetMax = new Vector2(5f, 5f);
        this._0x7a3ff6a2.transform.SetAsFirstSibling();
        this._0xdd475c06 = _0x131f2561.Caption(_0x0d763647.transform, _0x7ee59e5d._0xe3cdfa38(new byte[12] { 200, 226, 249, 232, 254, 226, 255, 194, 229, 239, 238, 243 }, 139), _0x50edb050, "", 62f, _0x687afa6e.Gold, TextAlignmentOptions.Center);
        _0x131f2561.Fit(this._0xdd475c06.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -66f), new Vector2(700f, 82f));
        this._0xecfb22ed = _0x131f2561.Caption(_0x0d763647.transform, _0x7ee59e5d._0xe3cdfa38(new byte[11] { 41, 3, 24, 9, 31, 3, 30, 36, 11, 7, 15 }, 106), _0x50edb050, "", 46f, _0x687afa6e.TextPrimary, TextAlignmentOptions.Center);
        _0x131f2561.Fit(this._0xecfb22ed.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -160f), new Vector2(700f, 66f));
        this._0x7075afb1 = _0x131f2561.Caption(_0x0d763647.transform, _0x7ee59e5d._0xe3cdfa38(new byte[12] { 52, 30, 5, 20, 2, 30, 3, 48, 22, 3, 18, 4 }, 119), _0x50edb050, "", 32f, _0x687afa6e.TextSecondary, TextAlignmentOptions.Center);
        _0x131f2561.Fit(this._0x7075afb1.rectTransform, new Vector2(0.5f, 1f), new Vector2(0f, -238f), new Vector2(700f, 50f));
        for (int _0x7f1ef68e = 0; _0x7f1ef68e < 3; _0x7f1ef68e++)
        {
            Image _0x6da0504c = _0x131f2561.Picture(_0x0d763647.transform, _0x7ee59e5d._0xe3cdfa38(new byte[10] { 37, 15, 20, 5, 19, 15, 18, 34, 9, 18 }, 102), _0x68a91251, _0x687afa6e.GateFills[_0x7f1ef68e]);
            _0x131f2561.Fit(_0x6da0504c.rectTransform, new Vector2(0.5f, 1f), new Vector2(-72f + 72f * _0x7f1ef68e, -326f), new Vector2(62f, 62f));
            this._0x2c05304f[_0x7f1ef68e] = _0x6da0504c;
        }

        this._0xf3b9b1c5 = _0x131f2561.Caption(_0x0d763647.transform, _0x7ee59e5d._0xe3cdfa38(new byte[12] { 182, 156, 135, 150, 128, 156, 129, 166, 129, 148, 129, 144 }, 245), _0x50edb050, "", 32f, _0x687afa6e.TealLight, TextAlignmentOptions.Center);
        _0x131f2561.Fit(this._0xf3b9b1c5.rectTransform, new Vector2(0.5f, 0f), new Vector2(0f, 58f), new Vector2(700f, 54f));
        for (int _0xe1d59980 = 0; _0xe1d59980 < ChipCount; _0xe1d59980++)
        {
            int _0xfa2e5982 = _0xe1d59980;
            float _0xa1e96c73 = (_0xe1d59980 - (ChipCount - 1) * 0.5f) * ChipPitch;
            RectTransform _0xa564fcda = _0x131f2561.Fit(_0x131f2561.Branch(_0x7ee59e5d._0xe3cdfa38(new byte[11] { 160, 138, 145, 128, 150, 138, 151, 160, 139, 138, 147 }, 227), _0x98eede0f), new Vector2(0.5f, 0f), new Vector2(_0xa1e96c73, 880f), new Vector2(ChipWidth, ChipHeight));
            Image _0x442c2887 = _0x131f2561.Plate(_0xa564fcda, _0x7ee59e5d._0xe3cdfa38(new byte[8] { 25, 50, 51, 42, 31, 62, 61, 63 }, 90), _0x516fba19, _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.6f), 1.3f);
            _0x131f2561.Stretch(_0x442c2887.rectTransform);
            Image _0x0a7fe516 = _0x131f2561.Plate(_0xa564fcda, _0x7ee59e5d._0xe3cdfa38(new byte[8] { 114, 89, 88, 65, 115, 94, 85, 72 }, 49), _0x516fba19, _0x687afa6e.Alpha(_0x687afa6e.BgSurface, 0.96f), 1.35f);
            _0x131f2561.Stretch(_0x0a7fe516.rectTransform);
            _0x0a7fe516.rectTransform.offsetMin = new Vector2(5f, 5f);
            _0x0a7fe516.rectTransform.offsetMax = new Vector2(-5f, -5f);
            TextMeshProUGUI _0xf10dc40a = _0x131f2561.Caption(_0xa564fcda, _0x7ee59e5d._0xe3cdfa38(new byte[9] { 121, 82, 83, 74, 118, 91, 88, 95, 86 }, 58), _0x50edb050, (_0xe1d59980 + 1).ToString(), 52f, _0x687afa6e.TextPrimary, TextAlignmentOptions.Center);
            _0x131f2561.Stretch(_0xf10dc40a.rectTransform);
            Button _0x344dedbc = _0x131f2561.Press(_0xa564fcda);
            _0x344dedbc.onClick.AddListener(() => this._0x613b069b(_0xfa2e5982));
            this._0x29189561[_0xe1d59980] = _0xa564fcda;
            this._0x2a47e8e6[_0xe1d59980] = _0x442c2887;
            this._0xcf5e7ca0[_0xe1d59980] = _0x0a7fe516;
            this._0x4152d4a0[_0xe1d59980] = _0xf10dc40a;
        }

        this._0xe228d44b();
        return this;
    }

    /// Repaint card and chips from the current selection and the save file.
    private void _0xe228d44b()
    {
        int _0x9526c003 = this._0x7f288d29;
        bool _0x2d56c56b = _0x1b98df55.CircuitOpen(_0x9526c003);
        this._0xdd475c06.text = string.Format(_0x7ee59e5d._0xe3cdfa38(new byte[11] { 211, 217, 194, 211, 197, 217, 196, 176, 235, 160, 237 }, 144), _0x9526c003 + 1);
        this._0xecfb22ed.text = _0x1ceaad4b.Names[_0x9526c003];
        this._0x7075afb1.text = string.Format(_0x7ee59e5d._0xe3cdfa38(new byte[9] { 75, 0, 77, 16, 119, 113, 100, 117, 99 }, 48), _0x1ceaad4b.Rows[_0x9526c003]);
        this._0xf3b9b1c5.text = _0x2d56c56b ? _0x7ee59e5d._0xe3cdfa38(new byte[12] { 164, 179, 183, 178, 175, 214, 162, 185, 214, 176, 186, 175 }, 246) : string.Format(_0x7ee59e5d._0xe3cdfa38(new byte[23] { 30, 17, 24, 28, 15, 125, 30, 20, 15, 30, 8, 20, 9, 125, 38, 109, 32, 125, 27, 20, 15, 14, 9 }, 93), _0x1ceaad4b.UnlockAfter[_0x9526c003]);
        this._0xf3b9b1c5.color = _0x2d56c56b ? _0x687afa6e.TealLight : _0x687afa6e.TextSecondary;
        _0x131f2561.Readable(this._0xf3b9b1c5, this._0xf3b9b1c5.color);
        int _0xffaeae16 = _0x1ceaad4b.Colours[_0x9526c003];
        for (int _0x3388eb78 = 0; _0x3388eb78 < this._0x2c05304f.Length; _0x3388eb78++)
        {
            if (this._0x2c05304f[_0x3388eb78] == null)
                continue;
            bool _0x405393e6 = _0x3388eb78 < _0xffaeae16;
            this._0x2c05304f[_0x3388eb78].color = _0x405393e6 ? _0x687afa6e.GateFills[_0x3388eb78] : _0x687afa6e.Alpha(_0x687afa6e.TextSecondary, 0.25f);
        }

        for (int _0x34f1db61 = 0; _0x34f1db61 < ChipCount; _0x34f1db61++)
        {
            bool _0x503831b6 = _0x34f1db61 == _0x9526c003;
            bool _0xd5c221f0 = _0x1b98df55.CircuitOpen(_0x34f1db61);
            if (this._0x2a47e8e6[_0x34f1db61] != null)
                this._0x2a47e8e6[_0x34f1db61].color = _0x503831b6 ? _0x687afa6e.Gold : _0x687afa6e.Alpha(_0x687afa6e.Gold, _0xd5c221f0 ? 0.45f : 0.15f);
            if (this._0xcf5e7ca0[_0x34f1db61] != null)
                this._0xcf5e7ca0[_0x34f1db61].color = _0x503831b6 ? _0x687afa6e.Alpha(_0x687afa6e.BgSurfaceHi, 0.98f) : _0x687afa6e.Alpha(_0x687afa6e.BgSurface, _0xd5c221f0 ? 0.96f : 0.6f);
            if (this._0x4152d4a0[_0x34f1db61] == null)
                continue;
            Color _0x06b59ec5 = _0x503831b6 ? _0x687afa6e.Gold : (_0xd5c221f0 ? _0x687afa6e.TextPrimary : _0x687afa6e.TextSecondary);
            this._0x4152d4a0[_0x34f1db61].color = _0x06b59ec5;
            _0x131f2561.Readable(this._0x4152d4a0[_0x34f1db61], _0x06b59ec5);
        }
    }

    private int _0x7f288d29;
    private Action<int> _0xc71c53ff;
    private Image _0x7a3ff6a2;
    private void OnDestroy()
    {
        DOTween.Kill(this._0x5345fb47);
        DOTween.Kill(this._0x7a3ff6a2);
        DOTween.Kill(this.gameObject);
    }
}

internal static class _0x7ee59e5d
{
    internal static string _0xe3cdfa38(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}