using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DOnt : MonoBehaviour
{
    public void Awake()
    {

        {
            DontDestroyOnLoad(this);
        }

    }
}
