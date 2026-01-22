using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float speed;

    [SerializeField]
    private Renderer backgroundRenderer;
    void Update()
    {
        float offset = Time.time * speed;
        backgroundRenderer.material.mainTextureOffset = new Vector2(offset, 0);

    }
}
