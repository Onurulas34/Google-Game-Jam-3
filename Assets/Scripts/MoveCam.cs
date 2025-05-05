using System.Globalization;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public float moveSpeedCam = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    void FixedUpdate()
    {
        rb.linearVelocityX = moveSpeedCam; 
    }
}
