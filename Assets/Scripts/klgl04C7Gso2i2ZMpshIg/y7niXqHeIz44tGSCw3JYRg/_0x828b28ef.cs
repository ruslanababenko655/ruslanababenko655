using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x038ba1ae;

public class _0x828b28ef : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x828b28ef>();
    }

    public int CurrentPanelIndex;
    public void _0x97f22d25(int _0x36796fa7)
    {
        this._0xa2c6dbc0(_0x36796fa7);
        this._0x820dc27b(_0x36796fa7);
        this.CurrentPanelIndex = _0x36796fa7;
        this.Panels[_0x36796fa7].Show();
    }

    private void _0xa2c6dbc0(int _0x0e09f519)
    {
        this.LastPanelIndexes.Add(_0x0e09f519);
        this.CurrentPanelIndex = _0x0e09f519;
        for (int _0xf3c44e99 = 0; _0xf3c44e99 < this.Panels.Count; _0xf3c44e99++)
            if (_0xf3c44e99 != _0x0e09f519 && this.Panels[_0xf3c44e99] != null)
                this.Panels[_0xf3c44e99]._0x4c9c06d4();
    }

    public float ScaleDuration = 0.4f;
    public bool IsShowSplashOnStart = true;
    private void _0x820dc27b(int _0x56c6fce6)
    {
        if (_0x56c6fce6 == _0xdbcb6201.SPLASH)
            _0xc88f8b5d.Instance._0xf97ec66e();
        if (_0x42666298.Instance._0x140e150c == _0xe9cafa10.SCENE_0)
        {
        }
    }

    private void SwitchSplash()
    {
        if (_0x86552015.Instance.IsTutorialEnabled && !_0x42666298._0x16293c1a._0xa2901a99)
            this._0x97f22d25(_0xdbcb6201.TUTORIAL0);
        else
            this._0x97f22d25(_0xdbcb6201.DEFAULT);
    }

    public static _0x828b28ef Instance;
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0x831728cf(int _0x97ea0011)
    {
        this.LastPanelIndexes.Add(_0x97ea0011);
        this.CurrentPanelIndex = _0x97ea0011;
        for (int _0x1b6cde95 = 0; _0x1b6cde95 < this.Panels.Count; _0x1b6cde95++)
            if (_0x1b6cde95 != _0x97ea0011 && this.Panels[_0x1b6cde95] != null)
                this.Panels[_0x1b6cde95]._0x4c9c06d4();
    }

    public void _0xe05c4e38(int _0xba77b22a)
    {
        if (_0xba77b22a == _0xdbcb6201.SPLASH && _0x42666298.Instance._0x140e150c != _0xe9cafa10.SCENE_0)
            _0xc88f8b5d.Instance._0x57d281d9();
        if (_0x42666298.Instance._0x140e150c != _0xe9cafa10.SCENE_0)
        {
            if (_0xba77b22a == _0xdbcb6201.SPLASH || _0xba77b22a == _0xdbcb6201.TUTORIAL0)
                _0x42666298.Instance._0x07871970(false);
            else if (_0xba77b22a == _0xdbcb6201.DEFAULT)
                _0x42666298.Instance._0x07871970(true);
        }
    }

    private _0x049fd978 _0x5394274f(int _0x6a0312bb)
    {
        return this.Panels[_0x6a0312bb];
    }

    private void Start()
    {
        this._0xf0d63f07();
    }

    public List<_0x049fd978> Panels;
    public float StaticBlurMaterialInitialValue;
    public void _0x3c71538b()
    {
        this.LastPanelIndexes.RemoveAll(_0x55f381ca => _0x55f381ca == this.CurrentPanelIndex);
        int _0x3d973791 = this.LastPanelIndexes.Last();
        this._0x820dc27b(_0x3d973791);
        this._0x831728cf(_0x3d973791);
        this.CurrentPanelIndex = _0x3d973791;
        this.Panels[_0x3d973791].Show();
    }

    private void _0xf0d63f07()
    {
        this._0x564ca1b5(_0xdbcb6201.SPLASH);
        if (_0x42666298.Instance._0x140e150c == _0xe9cafa10.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0xc88f8b5d.Instance.DefaultAnimationTime);
        }
    }

    private void _0x564ca1b5(int _0x3765bda6)
    {
        this._0xa2c6dbc0(_0x3765bda6);
        this._0x820dc27b(_0x3765bda6);
        this.CurrentPanelIndex = _0x3765bda6;
        this.Panels[_0x3765bda6]._0x292086f0();
    }
}