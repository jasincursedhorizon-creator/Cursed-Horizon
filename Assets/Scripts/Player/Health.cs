using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }
}