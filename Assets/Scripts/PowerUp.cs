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
            Debug.Log(player1.hasPower);
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            Color c = sr.color;
            c.a = 0f; 
            sr.color = c;
        }
        else if (collision.CompareTag("Player2"))
        {
            player2.hasPower = true;
            Debug.Log(player2.hasPower);
            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            Color c = sr.color;
            c.a = 0f; 
            sr.color = c;
        }
    }
}