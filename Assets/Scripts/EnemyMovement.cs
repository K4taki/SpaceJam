using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    
    public float speed;
    public int Leben;
    public Healthbar healthbar;
    public GameObject explosion;
    public Simple flashEffect;


    public Vector3[] positions;
    private int Index;
    void Start()
    {
        healthbar.SetMaxHealth(Leben);
    }


    public void TakeDamage(int damage)
    {
        Leben -= damage;
        flashEffect.Flash();
        if (Leben<= 0)
        {
            Die();
        }
        healthbar.SetHealth(Leben);

    }
    void Die()
    {
        Destroy(gameObject);
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, positions[Index], Time.deltaTime * speed);
        if (transform.position == positions[Index])
        {
            if (Index == positions.Length - 1)
            {
                Index = 0;
            }
            else
            {
                Index++;
            }

        }
    }
}
