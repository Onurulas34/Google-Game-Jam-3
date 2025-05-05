using UnityEngine;
using System.Collections;

public class Player2Gravity : MonoBehaviour
{
    private Rigidbody2D rb2;
    public float movespeed = 5f;
    public TrapSpawner trapSpawner;
    public bool hasPower = false;
    public Transform player1;
    private bool isFlipy = false;
    public Animator powerUpUIAnimator2;
    public AudioSource skillsSound2;

    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (hasPower == true)
    {
        powerUpUIAnimator2.SetBool("isActivee", true);
    }
        if (hasPower && Input.GetKeyDown(KeyCode.RightShift))
    {
        float spawnX = Camera.main.transform.position.x + 10f;
        Vector2 spawnPos = new Vector2(spawnX, player1.position.y);
        trapSpawner.SpawnTrap(spawnPos);
        hasPower = false;
        powerUpUIAnimator2.SetBool("isActivee", false);
        skillsSound2.Play();
    }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb2.gravityScale = -1f;
            FlipPlayer();
            isFlipy= true;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb2.gravityScale = 1f;
            FlipPlayer();
            isFlipy = false;
        }
        rb2.linearVelocityX = movespeed;
    }

    void FlipPlayer()
    {
        
        Collider2D collider = GetComponent<Collider2D>();
        collider.enabled = false; 
    
        Vector3 scale = transform.localScale;
        scale.y *= -1;
        transform.localScale = scale;

        if (!isFlipy)
        {
        transform.position += new Vector3(0, 1f, 0);
        }
        else
        transform.position += new Vector3(0, -1f, 0);

        collider.enabled = true; 

    }
}
