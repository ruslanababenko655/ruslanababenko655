using UnityEngine;
using UnityEngine.UI;

public class _0xa1238fa0 : MonoBehaviour
{
    public Button Button;
    public bool IsPhysicsRunOnClick;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x42666298.Instance._0x07871970(this.IsPhysicsRunOnClick));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}