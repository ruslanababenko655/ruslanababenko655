using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x6ddcb65c : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public int LoadSceneId;
    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x42666298.Instance._0xdb96b798(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x42666298.Instance._0xdb96b798(this.LoadSceneId));
    }

    public bool IsLoadCurrentScene;
}