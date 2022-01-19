using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float movespeed = 7f;
    Rigidbody2D rb;
    Movement target;
    public int damagi =1;
     Vector2 moveDirection;  
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Movement>();
        
        moveDirection =(target.transform.position - transform.position).normalized * movespeed;
        rb.velocity = new Vector3(moveDirection.x,moveDirection.y);
        Destroy(gameObject, 5f);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Movement character = hitInfo.GetComponent<Movement>();
        if (character != null)
        {
            character.Takedamage(damagi);
        }
    }
}
