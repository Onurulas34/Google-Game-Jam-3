using UnityEngine;

public class TrapSpawner : MonoBehaviour
{
    public GameObject trapPrefab;
    public float trapSpeed = 5f;

    public void SpawnTrap(Vector2 spawnPos)
    {
        GameObject trap = Instantiate(trapPrefab, spawnPos, Quaternion.identity);
        Rigidbody2D rb = trap.GetComponent<Rigidbody2D>();
        rb.linearVelocityX = -trapSpeed; // sola gitsin
        Debug.Log("Trap Oluşturuldu");
    }

    
}
