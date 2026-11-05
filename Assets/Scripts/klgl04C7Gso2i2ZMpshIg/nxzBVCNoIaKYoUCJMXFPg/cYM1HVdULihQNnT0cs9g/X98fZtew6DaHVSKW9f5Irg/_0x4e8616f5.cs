using UnityEngine;
using UnityEngine.UI;

public class _0x4e8616f5 : MonoBehaviour
{
    public int EndTutorialPanelIndex = 1;
    public Button TutorialEndButton;
    public int NextTutorialPanelIndex;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x828b28ef.Instance._0x97f22d25(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x42666298.Instance._0xc10c7778());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x828b28ef.Instance._0x97f22d25(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x828b28ef.Instance._0x97f22d25(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x42666298.Instance._0xc10c7778());
        }
    }

    public Button NextTutorialButton;
    public bool IsTutorialEndPanel;
}