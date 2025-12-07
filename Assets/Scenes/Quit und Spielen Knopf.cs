using UnityEngine;
using UnityEngine.SceneManagement; // Für Szenenwechsel
using UnityEngine.UI; // Für Button

public class NewMonoBehaviourScript : MonoBehaviour
{
    void Start()
    {

    }


    void Update()
    {

    }



    public void GoToGameScene()
    {
        SceneManager.LoadScene("Level1");
    }


    public void Quit()
    {
        Application.Quit();
    }



}





