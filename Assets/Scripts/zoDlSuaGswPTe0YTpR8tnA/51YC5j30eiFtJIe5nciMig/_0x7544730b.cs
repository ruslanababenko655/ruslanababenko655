using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x7544730b : MonoBehaviour
{
    private void _0xfb93c41f()
    {
        if (this._0x1ddde20d.canvasRenderer.GetColor() != this._0xf0f75f6e.canvasRenderer.GetColor())
            this._0xf0f75f6e.canvasRenderer.SetColor(this._0x1ddde20d.canvasRenderer.GetColor());
    }

    private Image _0x1ddde20d;
    private TMP_Text _0xf0f75f6e;
    private void Update()
    {
        this._0xfb93c41f();
    }
}