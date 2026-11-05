using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0x9b593b5d : MonoBehaviour
{
    private float _0xe5399a2e = 0.6f;
    private List<string> _0x413adf7e = new();
    private float _0x3343f20c = 1.5f;
    private float _0x3cfe05d4 = 4;
    private AspectRatioFitter _0x96767054;
    private float _0x96886624;
    private void Update()
    {
        int _0x3fd73268 = 1;
        if (this._0x413adf7e.Count > 0)
        {
            string _0xaba8e411 = this._0x52feb057.text;
            foreach (string _0xa0d87289 in this._0x413adf7e)
                while (_0xaba8e411.Contains(_0xa0d87289))
                    _0xaba8e411 = _0xaba8e411.Replace(_0xa0d87289, "");
            _0x3fd73268 = _0xaba8e411.Length;
        }
        else
        {
            _0x3fd73268 = this._0x52feb057.text.Length;
        }

        float _0xce792772 = Mathf.Clamp(this._0x96886624 + this._0xe5399a2e * _0x3fd73268, this._0x3343f20c, this._0x3cfe05d4);
        if (!Mathf.Approximately(this._0x96767054.aspectRatio, _0xce792772))
            this._0x96767054.aspectRatio = _0xce792772;
    }

    private TMP_Text _0x52feb057;
}