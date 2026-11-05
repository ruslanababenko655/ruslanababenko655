using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0x038ba1ae;

public class _0xc89a04dc : MonoBehaviour
{
    public void _0x1ea70e15(int _0x8723c203)
    {
        this.CurrentPopIndex = _0x8723c203;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0xeb41ee03(true);
        this._0x60c03945();
        this.Pops[_0x8723c203].Show();
        foreach (GameObject _0xd68d251b in this.GameObjectsToHide)
            _0xd68d251b.SetActive(false);
    }

    public int CurrentPopIndex;
    public GameObject BlurBackground;
    public List<int> LastPopIndexes = new();
    public _0xf90413c3 _0x8199c2c8(int _0xb560f3a2)
    {
        return this.Pops[_0xb560f3a2];
    }

    public List<_0xf90413c3> Pops;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public float ScaleDuration = 0.4f;
    private void _0xeb41ee03(bool _0xb205e7ee = false)
    {
        for (int _0xbea0e1ec = 0; _0xbea0e1ec < this.Pops.Count; ++_0xbea0e1ec)
            if (this.Pops[_0xbea0e1ec] != null && !(_0xbea0e1ec == this.CurrentPopIndex && _0xb205e7ee))
                this.Pops[_0xbea0e1ec]._0xd7bed3ad();
    }

    public void _0xf9a29395()
    {
        this.LastPopIndexes.RemoveAll(_0x55f381ca => _0x55f381ca == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x64fa7905();
        else
            this._0x1ea70e15(this.LastPopIndexes.Last());
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0xf90413c3 _0x58955793 in this.Pops)
            if (_0x58955793 != null)
                _0x58955793.gameObject.SetActive(true);
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xc89a04dc>();
    }

    public void _0x64fa7905()
    {
        this.LastPopIndexes.Clear();
        this._0xeb41ee03();
        foreach (GameObject _0x92eb5aac in this.GameObjectsToHide)
            if (_0x92eb5aac != null)
                _0x92eb5aac.SetActive(true);
        this._0x5910e95f();
    }

    private void _0x60c03945()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public List<GameObject> GameObjectsToHide;
    public static _0xc89a04dc Instance;
    private void _0x5910e95f()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }
}