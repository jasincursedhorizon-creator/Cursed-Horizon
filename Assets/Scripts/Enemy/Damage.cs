using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damage = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.currentHealth -= damage;

                // optional: Tod prüfen
                if (playerHealth.currentHealth <= 0)
                {
                    playerHealth.currentHealth = 0;
                    Debug.Log("Spieler ist tot");
                }
            }
        }
    }
}