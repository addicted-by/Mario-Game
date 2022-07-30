using UnityEngine;
using System.Collections;

public class CoinMovement : MonoBehaviour
{
   // public float CoinSpeed = 2f;
   //public int count = 0;
    void FixedUpdate()
    {
       //GetComponent<Rigidbody2D>().velocity = new Vector2(CoinSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Game manager
            // Add score!
           // count++;
            Destroy(this.gameObject);
        }
    }
}
