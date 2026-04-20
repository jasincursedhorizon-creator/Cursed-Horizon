using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToBossfight : MonoBehaviour
{
    [SerializeField] private string sceneName = "Bossfight";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        SceneManager.LoadScene(sceneName);
    }
}