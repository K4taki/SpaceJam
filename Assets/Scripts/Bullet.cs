using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private Vector2 screenBounds;
    public GameObject bulletPrefab;
    public int damage ;
    
    
    void Start()
    {

        rb.velocity = transform.right * speed;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

  

    void Update()
    {
        if(transform.position.x > screenBounds.x * 2)
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
            
        }

      
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        EnemyMovement enemy =hitInfo.GetComponent<EnemyMovement>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
           
        }
        Destroy(gameObject.GetComponent("Enemy"));
    }
}

    