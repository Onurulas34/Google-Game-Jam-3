using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Player1Gravity player1;
    public Player2Gravity player2;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            player1.hasPower = true;
            Destroy(gameObject);
            
        }
        else if (collision.CompareTag("Player2"))
        {
            player2.hasPower = true;
            Destroy(gameObject);
            
        }
    }
}
