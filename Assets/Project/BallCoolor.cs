using UnityEngine;

public class BallCoolor : MonoBehaviour
{
    private Renderer cubeRenderer;

    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
    }

    public void SetColor(Color newColor)
    {
        cubeRenderer.material.color = newColor;
    }
}