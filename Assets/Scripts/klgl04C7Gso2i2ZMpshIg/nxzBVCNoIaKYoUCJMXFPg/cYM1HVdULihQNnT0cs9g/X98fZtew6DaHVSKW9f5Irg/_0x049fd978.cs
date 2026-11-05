using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x049fd978 : MonoBehaviour
{
    public Ease Ease = Ease.OutSine;
    private void _0xaad50169()
    {
        if (this.OuterBackground != null)
        {
            Image _0x39004816 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x39004816, true);
            _0x39004816.DOFade(0f, this.ScaleDuration);
        }
    }

    public GameObject Content;
    public TMP_Text HeaderText;
    public TMP_Text MainText;
    public void _0x292086f0()
    {
        this._0x3971ff2f();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0x828b28ef.Instance._0xe05c4e38(_0x828b28ef.Instance.CurrentPanelIndex);
    }

    private void _0x69e5c1aa()
    {
        if (this.OuterBackground != null)
        {
            Image _0x87f9174a = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x87f9174a, true);
            _0x87f9174a.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    private void _0x172f446c()
    {
        if (this.OuterBackground != null)
        {
            Image _0x4491283c = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x4491283c, true);
            _0x4491283c.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x172f446c();
    }

    public void Show()
    {
        this._0x69e5c1aa();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0x828b28ef.Instance._0xe05c4e38(_0x828b28ef.Instance.CurrentPanelIndex);
            });
        }
    }

    private bool _0xfc55e036 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    public float ScaleDuration = 0.4f;
    private void _0x3971ff2f()
    {
        if (this.OuterBackground != null)
        {
            Image _0xc660e5e4 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xc660e5e4, true);
            _0xc660e5e4.DOFade(1f, 0f);
        }
    }

    public void _0x4c9c06d4()
    {
        this._0xaad50169();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public GameObject OuterBackground;
    public bool IsScaledDownOnAwake = true;
}