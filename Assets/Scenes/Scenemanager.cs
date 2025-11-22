using UnityEngine;
using UnityEngine.SceneManagement; // Für Szenenwechsel
using UnityEngine.UI; // Für Button

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Button myButton; // Im Inspector zuweisen
    public string sceneName; // Name der Zielszene

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (myButton != null)
        {
            myButton.onClick.AddListener(LoadTargetScene);
        }
    }

    void LoadTargetScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    // Update is called once per frame
    void Update()
    {

    }
}