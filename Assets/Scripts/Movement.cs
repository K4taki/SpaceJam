using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    private float Upspeed = 3.5f ;
    public int Health =3;
    public Animator anime;
    public Simple flashEffect;
    public Screenshake shake;
    
   

    






    public Healthbar healthbar;
    

    void Start()
    {
        healthbar.SetMaxHealth(Health);
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Screenshake>();
        flashEffect = GameObject.FindObjectOfType<Simple>();
       
       
       


    }

    public void Takedamage(int damage)
    {
       
        Health -= damage;
        flashEffect.Flash();
        anime.SetTrigger("Hit");
        shake.CamShake();
        

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

        SceneManager.LoadScene(2);





    }
   

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector2(0, Upspeed));
           
            

        }
        
    }
    

}
