using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject stMenuPanel, authorPanel;

    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void OpenPanelAuthor()
    {
        stMenuPanel.SetActive(false);
        authorPanel.SetActive(true);
    }

    public void ClosePanelAuthor()
    {
        stMenuPanel.SetActive(true);
        authorPanel.SetActive(false);
    }
}
