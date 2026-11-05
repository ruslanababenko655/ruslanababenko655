using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x6436975a : MonoBehaviour
{
    [HideInInspector]
    public bool IsGameEnd;
    public List<Button> HomeButtons = new();
    private void _0xc575b884()
    {
        if (this.ScoreCurrent >= this._0x9d3ca21b)
            this._0xcfd929c0();
        else
            this._0xa51504e7();
    }

    private IEnumerator _0x48da0a23()
    {
        this._0x49a1c6be();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x42666298.Instance._0x140e150c == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x42666298.Instance._0x980e6851)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x49a1c6be();
            }
        }

        if (!this.IsGameEnd)
            this._0xa51504e7();
    }

    public List<TMP_Text> LevelNumberText = new();
    public int CustomTimeInitial = 30;
    private int _0xe335ca31 => this.CustomTimeInitial + _0x42666298._0x16293c1a._0xbc2af3eb * 10;

    public List<Button> PauseButtons = new();
    private void Awake()
    {
        _0x9cbb7461 = this.gameObject.GetComponent<_0x6436975a>();
    }

    public void _0xdd99c2cb()
    {
        _0x42666298.Instance._0x07871970(true);
        _0x42666298.Instance._0xdb96b798(_0x038ba1ae._0xe9cafa10.SCENE_0);
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0xe335ca31;
        this.CurrentGameIndex = _0x42666298.Instance._0x140e150c;
        foreach (Button _0xd4da0d1a in this.HomeButtons)
            _0xd4da0d1a.onClick.AddListener(() =>
            {
                this._0xdd99c2cb();
            });
        foreach (Button _0x72a271a6 in this.PauseButtons)
            _0x72a271a6.onClick.AddListener(() =>
            {
                _0x42666298.Instance._0x07871970(false);
                _0xc89a04dc.Instance._0x1ea70e15(_0x038ba1ae._0x473c0d2d.PAUSE);
            });
        this._0xeb7c521f();
        this.LevelNumberText.ForEach(_0xb02eb948 => _0xb02eb948.text = $"LVL {_0x42666298._0x16293c1a._0xbc2af3eb + 1}");
        if (_0x86552015.Instance.IsTimerEnabled)
        {
            this._0x49a1c6be();
            this.StartCoroutine(this._0x48da0a23());
        }
    }

    public void _0x4643d28f(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xeb7c521f();
            this._0xa088033f();
        }
    }

    private void _0x1904f8dc()
    {
        this.IsGameEnd = true;
        _0x42666298.IsAfterLevelComplete = true;
    }

    public void _0xa51504e7()
    {
        if (_0x86552015.Instance.IsOnlyWinGameEndEnabled)
            this._0xcfd929c0();
        if (!this.IsGameEnd)
        {
            this._0x1904f8dc();
            _0x42666298.IsAfterLevelComplete = false;
            _0x42666298.IsAfterLevelFailed = true;
            _0xf90413c3 _0x1bcd438b = _0xc89a04dc.Instance._0x8199c2c8(_0x038ba1ae._0x473c0d2d.LOSE).GetComponent<_0xf90413c3>();
            if (_0x86552015.Instance.IsCheckScoreEnabled)
                _0x1bcd438b.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x9d3ca21b}";
            else
                _0x1bcd438b.ContentMainText.text = $"{this.ScoreCurrent}";
            _0x1bcd438b.ContentAdditionalText.text = $"{0}";
            _0x038ba1ae._0xb2212895._0x41daa88c += 0;
            _0xc89a04dc.Instance._0x1ea70e15(_0x038ba1ae._0x473c0d2d.LOSE);
        }
    }

    private void _0xeb7c521f()
    {
        if (_0x86552015.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xb02eb948 => _0xb02eb948.text = $"{this.ScoreCurrent}/{this._0x9d3ca21b}");
        else
            this.ScoreText.ForEach(_0xb02eb948 => _0xb02eb948.text = $"{this.ScoreCurrent}");
    }

    [HideInInspector]
    public int TimeLeft;
    public List<TMP_Text> SubtitleText = new();
    public int CustomTargetScore = 10;
    [HideInInspector]
    public int CurrentGameIndex;
    [HideInInspector]
    public int ScoreCurrent;
    private void _0x49a1c6be()
    {
        this.TimerText.ForEach(_0xb02eb948 => _0xb02eb948.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xb288b3ff._0xa5c8961c(new byte[6] { 98, 98, 83, 53, 124, 124 }, 15)));
    }

    public List<TMP_Text> TimerText = new();
    private void _0xa088033f()
    {
        if (this.ScoreCurrent > _0x42666298._0x16293c1a._0xe002b16d)
            _0x42666298._0x16293c1a._0xe002b16d = this.ScoreCurrent;
        if (_0x86552015.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x9d3ca21b)
                this._0xcfd929c0();
    }

    public List<TMP_Text> ScoreText = new();
    private int _0x9d3ca21b => this.CustomTargetScore + _0x42666298._0x16293c1a._0xbc2af3eb * 10;
    private int _0x62f78f27 => this.ScoreCurrent;

    private static _0x6436975a _0x9cbb7461;
    public void _0xcfd929c0()
    {
        if (!this.IsGameEnd)
        {
            this._0x1904f8dc();
            _0x42666298.IsAfterLevelComplete = true;
            _0x42666298.IsAfterLevelFailed = false;
            _0xf90413c3 _0xedaa990b = _0xc89a04dc.Instance._0x8199c2c8(_0x038ba1ae._0x473c0d2d.WIN).GetComponent<_0xf90413c3>();
            if (_0x86552015.Instance.IsCheckScoreEnabled)
                _0xedaa990b.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x9d3ca21b}";
            else
                _0xedaa990b.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x86552015.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0x038ba1ae._0xb2212895._0x41daa88c)
                    _0x038ba1ae._0xb2212895._0x41daa88c = this.ScoreCurrent;
                _0xedaa990b.ContentAdditionalText.text = $"{_0x038ba1ae._0xb2212895._0x41daa88c}";
            }
            else
            {
                _0xedaa990b.ContentAdditionalText.text = $"{this._0x62f78f27}";
                _0x038ba1ae._0xb2212895._0x41daa88c += this._0x62f78f27;
            }

            if (_0x86552015.Instance.IsLevelIncrementOnWin)
                ++_0x42666298._0x16293c1a._0xbc2af3eb;
            _0xc89a04dc.Instance._0x1ea70e15(_0x038ba1ae._0x473c0d2d.WIN);
        }
    }
}

internal static class _0xb288b3ff
{
    internal static string _0xa5c8961c(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}