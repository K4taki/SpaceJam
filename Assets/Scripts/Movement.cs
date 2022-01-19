using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Upspeed;
    public int Health = 3;
    public Healthbar healthbar;
    

    void Start()
    {
        healthbar.SetMaxHealth(Health);
        
    }

    public void Takedamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Die();
        }
        healthbar.SetHealth(Health);

    }
    void Die()
    {

        this.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);



    }
    

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector2(0, Upspeed));
            

        }
        
    }
}
