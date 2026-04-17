using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public void GoToGameScene()
    {
        SceneManager.LoadScene("Level1");
    }

    public void GoToSettingsScene()
    {
        SceneManager.LoadScene("Einstellungen");
    }

    public void Quit()
    {
        Application.Quit();
    }
}




