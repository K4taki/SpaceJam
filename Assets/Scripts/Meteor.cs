using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    public int damagen= 1;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0) ;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
       
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < screenBounds.x * -2)
        {
            Destroy(gameObject);
            
        }
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Movement character = hitInfo.GetComponent<Movement>();
        if (character != null)
        {
            character.Takedamage(damagen);
        }
        
    }

}
