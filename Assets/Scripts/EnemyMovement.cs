using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
    public float speed;
    public int Leben;
    
    
    public Vector3[] positions;
    private int Index;
    

    public void TakeDamage(int damage)
    {
        Leben -= damage;
        if(Leben<= 0)
        {
            Die();
        }
        
    }
    void Die()
    {
        Destroy(gameObject);
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
