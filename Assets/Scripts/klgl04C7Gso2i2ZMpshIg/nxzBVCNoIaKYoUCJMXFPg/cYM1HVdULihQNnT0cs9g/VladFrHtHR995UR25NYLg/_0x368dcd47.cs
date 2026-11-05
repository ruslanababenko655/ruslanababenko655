using TMPro;
using UnityEngine;
using static _0x038ba1ae;

public class _0x368dcd47 : MonoBehaviour
{
    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0xfa503c73;
            if (this.gameObject.TryGetComponent(out _0xfa503c73))
                this.MoneyCountText = _0xfa503c73;
        }

        this._0x0d4a53c8();
    }

    public void _0x0d4a53c8()
    {
        this.MoneyCountText.text = _0xb2212895._0x41daa88c.ToString();
    }
}