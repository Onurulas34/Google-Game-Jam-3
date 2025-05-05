using UnityEngine;

using UnityEngine;

public class ScrollingPlatform : MonoBehaviour
{
    public float scrollSpeed = 2f;
    public float resetPositionX = -10f; // Gözden çýkýnca
    public float startPositionX = 10f;  // Baþtan baþlama yeri

    void Update()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        if (transform.position.x < resetPositionX)
        {
            Vector3 newPos = transform.position;
            newPos.x = startPositionX;
            transform.position = newPos;
        }
    }
}
