using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed = 25;
    [SerializeField] private Rigidbody rb;

    public float PlayerNumber;

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, z);

        rb.AddForce(movement * speed);
    }
}