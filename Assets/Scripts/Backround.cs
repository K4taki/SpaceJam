using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backround : MonoBehaviour
{
    public Transform t;
    public float speed;
    
    
    

    void Update()
    {
        t.Translate(-speed * Time.deltaTime, 0, 0);
        if (t.transform.position.x < -25f)
        {
            t.transform.position = new Vector3(0, 0, 10f);
        }
    }
}
