using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0x038ba1ae;

public class _0x42666298 : MonoBehaviour
{
    public void _0xdb96b798(int _0x1d6337ed)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xd3aa52c9(_0x1d6337ed));
    }

    public Transform Environment;
    public bool _0x980e6851 { get; private set; }
    public static _0xf44becec _0x16293c1a => _0xf44becec.ALL_SCENES_SETTING_SINGLETONS[Instance._0x140e150c];

    public void _0xc10c7778()
    {
        _0x16293c1a._0xa2901a99 = true;
    }

    public void _0x07871970(bool _0xc05b8de2)
    {
        this._0x980e6851 = _0xc05b8de2;
        this._0xe8200903(!this._0x980e6851);
        Physics2D.simulationMode = this._0x980e6851 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x40182622(this.EnvironmentWithTweensToToggle);
    }

    [HideInInspector]
    public List<_0x368dcd47> MoneyCountContainers = new();
    private void _0xa6614161()
    {
        IsAfterLevelComplete = true;
        Instance._0xdb96b798(_0xe9cafa10.SCENE_0);
    }

    private void _0xe8200903(bool _0xf0d6458f)
    {
        Rigidbody2D[] _0x3edc38fd = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x67ebcc55 in _0x3edc38fd)
            if (_0xf0d6458f)
                _0x67ebcc55.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x67ebcc55.constraints = RigidbodyConstraints2D.None;
    }

    public static _0x42666298 Instance;
    public int _0x140e150c => SceneManager.GetActiveScene().buildIndex;

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public Button DeleteProgressDataButton;
    private static void MakeGrid(List<RectTransform> _0xe2664982, AspectRatioFitter _0xe99965fc, float _0xa4a0876b, int _0xe89a7e4f, int _0x45db5972)
    {
        _0xe99965fc.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0xe99965fc.aspectRatio = _0xa4a0876b;
        foreach (RectTransform _0x0f9fb162 in _0xe2664982)
        {
            int _0x24c545bf = _0x0f9fb162.transform.GetSiblingIndex();
            _0x0f9fb162.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x24c545bf % _0xe89a7e4f) * (1f / _0xe89a7e4f), (_0x45db5972 - (Mathf.FloorToInt((float)_0x24c545bf / _0xe89a7e4f) % _0x45db5972 + 1f)) * (1f / _0x45db5972));
            _0x0f9fb162.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x24c545bf % _0xe89a7e4f + 1f) * (1f / _0xe89a7e4f), (_0x45db5972 - Mathf.FloorToInt((float)_0x24c545bf / _0xe89a7e4f) % _0x45db5972) * (1f / _0x45db5972));
            _0x0f9fb162.offsetMin = Vector2.zero;
            _0x0f9fb162.offsetMax = Vector2.zero;
        }
    }

    private void _0x40182622(Transform _0x24fb1671)
    {
        Transform[] _0x755fef44 = _0x24fb1671.GetComponentsInChildren<Transform>();
        foreach (Transform _0x403f67a7 in _0x755fef44)
            if (_0x403f67a7 != null && DOTween.IsTweening(_0x403f67a7))
            {
                if (this._0x980e6851)
                    DOTween.Play(_0x403f67a7);
                else
                    DOTween.Pause(_0x403f67a7);
            }
    }

    public Transform EnvironmentWithTweensToToggle;
    private IEnumerator _0xd3aa52c9(int _0x46c157bb)
    {
        _0x828b28ef.Instance._0x97f22d25(_0xdbcb6201.SPLASH);
        AsyncOperation _0xc31e95fa = SceneManager.LoadSceneAsync(_0x46c157bb);
        while (!_0xc31e95fa.isDone)
            yield return null;
    }

    private static _0xf44becec _0xa3c303de => _0xf44becec.ALL_SCENES_SETTING_SINGLETONS[0];

    public static bool IsAfterLevelFailed = false;
    public void _0x4183d0b8()
    {
        this._0xdb96b798(SceneManager.GetActiveScene().buildIndex);
    }

    public Button ShowResetTutorialButton;
    public Canvas MainCanvas;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x42666298>();
        this.RootGameObject = GameObject.FindWithTag(_0xca9ef33b._0x3e52cb03(new byte[4] { 188, 129, 129, 154 }, 238));
        if (this._0x140e150c == _0xe9cafa10.SCENE_0)
            this._0x07871970(true);
        else
            this._0x07871970(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x368dcd47>(true).ToList();
    }

    private void Start()
    {
        if (this._0x140e150c != _0xe9cafa10.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0xdb96b798(_0xe9cafa10.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x16293c1a._0xa2901a99 = false;
            _0xc89a04dc.Instance._0x64fa7905();
            _0x828b28ef.Instance._0x97f22d25(_0xdbcb6201.TUTORIAL0);
        });
    }

    private IEnumerator _0x43cc7fbc(string _0xb08282e8)
    {
        _0x828b28ef.Instance._0x97f22d25(_0xdbcb6201.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x7d480cc7 = SceneManager.LoadSceneAsync(_0xb08282e8);
        while (!_0x7d480cc7.isDone)
            yield return null;
    }

    public static bool IsAfterLevelComplete;
    private static void ExitGame()
    {
        Application.Quit();
    }

    public void _0x1d8efb03()
    {
        foreach (_0x368dcd47 _0xe87cf5ca in this.MoneyCountContainers)
            _0xe87cf5ca._0x0d4a53c8();
    }

    private static _0xf44becec GAME_INDEX_SETTINGS(int _0x2e435d0c)
    {
        return _0xf44becec.ALL_SCENES_SETTING_SINGLETONS[_0x2e435d0c];
    }
}

internal static class _0xca9ef33b
{
    internal static string _0x3e52cb03(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}