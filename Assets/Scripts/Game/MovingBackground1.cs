using UnityEngine;

public class BackgroundMoveWithPlayer : MonoBehaviour
{
    public Transform player;        // Dein Spieler
    public float parallaxFactor = 0.5f; // 0 = Hintergrund bleibt, 1 = folgt Spieler genau
    private Vector3 lastPlayerPos;

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Bitte den Spieler-Transform zuweisen!");
            enabled = false;
            return;
        }

        lastPlayerPos = player.position;
    }

    void LateUpdate()
    {
        // Unterschied seit letztem Frame
        Vector3 delta = player.position - lastPlayerPos;

        // Quad bewegen, nur x-Richtung (für Side-Scroller)
        transform.position += new Vector3(delta.x * parallaxFactor, 0f, 0f);

        lastPlayerPos = player.position;
    }
}
