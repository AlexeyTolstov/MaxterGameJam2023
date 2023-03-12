using UnityEngine;
class SettingsControler : MonoBehaviour
{
    public GameObject settingsMenu;

    public void SettingsOff()
    {
        settingsMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void SettingsOn()
    {
        settingsMenu.SetActive(true);
        Time.timeScale = 0f;
    }
}
