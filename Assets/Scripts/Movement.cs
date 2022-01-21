using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Upspeed;
    public int Health =3;
    public Animator anime;
    public Simple flashEffect;

   



    public Healthbar healthbar;
    

    void Start()
    {
        healthbar.SetMaxHealth(Health);
        
        flashEffect = GameObject.FindObjectOfType<Simple>();

    }

    public void Takedamage(int damage)
    {
       
        Health -= damage;
        flashEffect.Flash();
        anime.SetTrigger("Hit");

        if (Health <= 0)
        {
            Die();
            anime.SetTrigger("Hit");
            
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
