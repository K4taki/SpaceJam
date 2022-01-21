using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screenshake : MonoBehaviour
{
    public Animator camanim;
    public void CamShake()
    {
        camanim.SetTrigger("Shaker");
    }
   
}
