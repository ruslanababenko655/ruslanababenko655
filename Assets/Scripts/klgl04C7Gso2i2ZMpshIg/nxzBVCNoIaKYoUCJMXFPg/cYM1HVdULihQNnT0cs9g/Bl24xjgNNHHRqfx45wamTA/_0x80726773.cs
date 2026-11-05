using UnityEngine;
using UnityEngine.UI;

public class _0x80726773 : MonoBehaviour
{
    private int _0x99ff2b39;
    private void Awake()
    {
        if (this._0xe813a161 == null)
            if (!this.TryGetComponent(out this._0xe813a161))
                this._0xe813a161 = this.GetComponentInChildren<Button>();
    }

    private bool _0x279bceab;
    private Button _0xe813a161;
    private void Start()
    {
        if (this._0x279bceab)
            this._0xe813a161.onClick.AddListener(() => _0x828b28ef.Instance._0x3c71538b());
        else
            this._0xe813a161.onClick.AddListener(() => _0x828b28ef.Instance._0x97f22d25(this._0x99ff2b39));
    }
}