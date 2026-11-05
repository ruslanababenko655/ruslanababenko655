using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

/// The dragon itself: which lane it flies in, how it banks into a change, and the dash
/// window. Nothing here is driven by a body - the position is written straight onto the
/// rect and every move is a tween, so one mover owns the transform (rule C.57).
public sealed class _0x42669c31 : MonoBehaviour
{
    public Vector2 _0xed1c8f6b
    {
        get
        {
            return this._0x58c0d892 != null ? this._0x58c0d892.anchoredPosition : Vector2.zero;
        }
    }

    private Image _0xe2722307;
    public float _0x55fb9f37
    {
        get
        {
            return Mathf.Clamp01(1f - this._0x1fad9879 / DashCooldown);
        }
    }

    private Image _0xf92e3a4a;
    /// The burnout spiral, played before the result card arrives.
    public void _0x142cd334()
    {
        if (this._0x58c0d892 == null)
            return;
        this._0x58c0d892.DOLocalRotate(new Vector3(0f, 0f, 360f), 0.8f, RotateMode.FastBeyond360).SetLink(this.gameObject);
        this._0x58c0d892.DOScale(0f, 0.8f).SetEase(Ease.InBack).SetLink(this.gameObject);
    }

    private float _0xac13ea4c;
    public bool _0x01173df2
    {
        get
        {
            return this._0x1fad9879 <= 0f;
        }
    }

    private float _0x37ab4fea;
    public float _0xbf1da92b
    {
        get
        {
            return this._0x37ab4fea;
        }
    }

    private float _0x1fad9879;
    public const float DashCooldown = 2f;
    public int _0x80ab0dba { get; private set; }

    private float _0xe5b0ddba;
    /// The surge rim light, independent of the dash rim.
    public void _0x9ce2d200(bool _0x44093b8d)
    {
        if (this._0xe2722307 == null)
            return;
        float _0x76c2e5ae = _0x44093b8d ? 0.6f : 0f;
        DOTween.To(() => this._0xe2722307.color.a, _0x7c076f8c => this._0xe2722307.color = _0x687afa6e.Alpha(_0x687afa6e.Gold, _0x7c076f8c), _0x76c2e5ae, 0.4f).SetLink(this.gameObject);
    }

    public const float BankDuration = 0.18f;
    /// Spend the dash: a short immunity and a visible gold rim.
    public bool _0xab71ef70()
    {
        if (!this._0x01173df2 || this._0x58c0d892 == null)
            return false;
        this._0xac13ea4c = DashSeconds;
        this._0x1fad9879 = DashCooldown;
        this._0x58c0d892.DOScale(1.15f, 0.12f).SetEase(Ease.OutQuad).SetLink(this.gameObject);
        this._0x58c0d892.DOScale(1f, 0.22f).SetDelay(0.12f).SetEase(Ease.OutBack).SetLink(this.gameObject);
        if (this._0xe2722307 != null)
            this._0xe2722307.color = _0x687afa6e.Alpha(_0x687afa6e.Gold, 0.85f);
        return true;
    }

    public bool _0x66ef1047
    {
        get
        {
            return this._0xac13ea4c > 0f;
        }
    }

    public const float DashSeconds = 0.6f;
    private float[] _0xf98b408e =
    {
        0f,
        0f,
        0f
    };
    public _0x42669c31 _0xc8d66969(RectTransform _0x5ec04f38, Image _0x25f8d754, Image _0xd23ea7f9, float[] _0xa73e9fea, float _0xf0fa70ad, float _0x88dd65ed)
    {
        this._0x58c0d892 = _0x5ec04f38;
        this._0xf92e3a4a = _0x25f8d754;
        this._0xe2722307 = _0xd23ea7f9;
        this._0xf98b408e = _0xa73e9fea;
        this._0xe5b0ddba = _0xf0fa70ad;
        this._0x37ab4fea = _0x88dd65ed;
        this._0x80ab0dba = 1;
        this._0x58c0d892.anchoredPosition = new Vector2(this._0xf98b408e[this._0x80ab0dba], this._0xe5b0ddba);
        if (this._0xe2722307 != null)
            this._0xe2722307.color = _0x687afa6e.Alpha(_0x687afa6e.Gold, 0f);
        return this;
    }

    /// A crystal bite: the dragon flashes and is briefly staggered.
    public void _0x745ae6e6()
    {
        if (this._0xf92e3a4a == null)
            return;
        this._0xf92e3a4a.DOColor(_0x687afa6e.Danger, 0.12f).SetLink(this.gameObject);
        this._0xf92e3a4a.DOColor(Color.white, 0.22f).SetDelay(0.14f).SetLink(this.gameObject);
    }

    private RectTransform _0x58c0d892;
    /// Move one lane across. Returns false when the dragon is already at the edge, so the
    /// caller can leave the combo and the glide state alone.
    public bool _0x1d271568(int _0x1ffc3bed)
    {
        int _0x3dbf6a47 = Mathf.Clamp(this._0x80ab0dba + (_0x1ffc3bed > 0 ? 1 : -1), 0, 2);
        if (_0x3dbf6a47 == this._0x80ab0dba || this._0x58c0d892 == null)
            return false;
        this._0x80ab0dba = _0x3dbf6a47;
        float _0x12c49e12 = _0x1ffc3bed > 0 ? -14f : 14f;
        this._0x58c0d892.DOAnchorPosX(this._0xf98b408e[this._0x80ab0dba], BankDuration).SetEase(Ease.OutCubic).SetLink(this.gameObject);
        this._0x58c0d892.DOLocalRotate(new Vector3(0f, 0f, _0x12c49e12), BankDuration * 0.6f).SetEase(Ease.OutQuad).SetLink(this.gameObject);
        this._0x58c0d892.DOLocalRotate(Vector3.zero, BankDuration * 0.7f).SetDelay(BankDuration * 0.6f).SetEase(Ease.OutQuad).SetLink(this.gameObject);
        return true;
    }

    private void Update()
    {
        float step = _0x5f296d13._0x5d49422c;
        if (step <= 0f)
            return;
        if (this._0xac13ea4c > 0f)
        {
            this._0xac13ea4c -= step;
            if (this._0xac13ea4c <= 0f && this._0xe2722307 != null)
                DOTween.To(() => this._0xe2722307.color.a, _0x7c076f8c => this._0xe2722307.color = _0x687afa6e.Alpha(_0x687afa6e.Gold, _0x7c076f8c), 0f, 0.25f).SetLink(this.gameObject);
        }

        if (this._0x1fad9879 > 0f)
            this._0x1fad9879 -= step;
    }
}