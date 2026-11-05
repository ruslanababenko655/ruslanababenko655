using UnityEngine;
using UnityEngine.UI;

public class _0xe515db7f : MonoBehaviour
{
    public bool IsShowLastPop;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsHideAllPops;
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xc89a04dc.Instance._0xf9a29395();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xc89a04dc.Instance._0x64fa7905());
        else
            this.Button.onClick.AddListener(() => _0xc89a04dc.Instance._0x1ea70e15(this.PopToShowIndex));
    }

    public int PopToShowIndex;
    public Button Button;
}