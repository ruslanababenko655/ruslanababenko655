using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xc88f8b5d : MonoBehaviour
{
    public GameObject Error;
    public float SecondPassSliderValue = 0.5f;
    public float DefaultAnimationTime = 0.4f;
    private void _0x38e4f6fd()
    {
        this.AnimationSlider.value = 0.05f;
        _0x070ab9ef = !_0x070ab9ef;
        this._0x9fb4ac51 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x7c076f8c => this.AnimationSlider.value = _0x7c076f8c, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x36758372._0x6176ecbe?._0x0fa44290();
        });
    }

    private Sequence _0x9fb4ac51;
    public void _0x85543be5()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x9fb4ac51?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0x070ab9ef = false;
    }

    public float FirstAnimationTime = 10.0f;
    public void _0xf97ec66e()
    {
        this._0x9fb4ac51?.Kill();
        this.AnimationSlider.value = _0x070ab9ef ? this.SecondPassSliderValue : 0.05f;
    }

    public void _0xbd956398()
    {
        this._0x9fb4ac51?.Play();
    }

    public Slider AnimationSlider;
    public GameObject Background;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xc88f8b5d>();
    }

    public void _0xf0da892f()
    {
        this._0x9fb4ac51?.Pause();
    }

    public void _0x57d281d9()
    {
        this._0xf97ec66e();
        bool _0xcd599ad4 = _0x070ab9ef;
        this._0x9fb4ac51 = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x7c076f8c => this.AnimationSlider.value = _0x7c076f8c, _0xcd599ad4 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0x070ab9ef = !_0x070ab9ef;
    }

    public GameObject Content;
    public static _0xc88f8b5d Instance;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x038ba1ae._0xe9cafa10.SCENE_0 && !_0x070ab9ef)
        {
            this._0x38e4f6fd();
        }
        else
        {
            this._0x57d281d9();
        }
    }

    private static bool _0x070ab9ef = false;
}