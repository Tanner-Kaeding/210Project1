using UnityEngine;

public class numberWall : MonoBehaviour
{
    public float wallNum;
    public Color wallColor = Color.red;

    private Collider wallCollider;
    private Renderer wallRenderer;

    void Start()
    {
        wallCollider = GetComponent<Collider>();
        wallRenderer = GetComponent<Renderer>();

        wallRenderer.material.color = wallColor;
    }

    private void OnCollisionEnter(Collision collision)
    {
        PlayerMove player = collision.gameObject.GetComponent<PlayerMove>();

        if (player != null)
        {
            if (player.PlayerNumber == wallNum)
            {
                wallCollider.isTrigger = true;
            }
        }
    }
}