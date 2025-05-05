using UnityEngine;

public class Player1Gravity : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5f;
    public TrapSpawner trapSpawner;
    public bool hasPower = false;
    public Transform player2;
    public Animator powerUpUIAnimator;
    public AudioSource skillsSound;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (hasPower==true)
    {
        powerUpUIAnimator.SetBool("isActive", true);
    }

        if (hasPower && Input.GetKeyDown(KeyCode.E))
    {
        float spawnX = Camera.main.transform.position.x + 10f; // ekranın sağı
        Vector2 spawnPos = new Vector2(spawnX, player2.position.y); // hedef: rakip
        trapSpawner.SpawnTrap(spawnPos);
        hasPower = false;
        powerUpUIAnimator.SetBool("isActive", false); 
        skillsSound.Play();
    }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.gravityScale = -1f;
            FlipPlayer();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            rb.gravityScale = 1f;
            FlipPlayer();
        }
        rb.linearVelocityX = moveSpeed;
    }

    void FlipPlayer()
    {
        Vector3 scale = transform.localScale;
        scale.y *= -1;
        transform.localScale = scale;
    }
}
