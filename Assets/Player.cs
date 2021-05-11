using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb2d;

    public float speed = 10f;
    public float mapWidth = 3f;
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPos = rb2d.position + Vector2.right * x;
        newPos.x = Mathf.Clamp(newPos.x, -mapWidth, mapWidth);
   

        rb2d.MovePosition(newPos);
    }


    private void OnCollisionEnter2D()
    {
        FindObjectOfType<GameManager>().EndGame();
    }
}
