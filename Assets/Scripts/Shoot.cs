using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform ShootingPoint;
    public GameObject BulletPrefab;



    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shooting();
        }
    }
    void Shooting()
    {
        //Shooting Logic
        Instantiate(BulletPrefab, ShootingPoint.position, ShootingPoint.rotation);
    }
}
