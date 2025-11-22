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



    puplic void GoToGameScene()
    {
        SceneManager.LoadScene("Level1");
    }


    puplic void Quit()
    {
        Application.Quit();
    }



}





