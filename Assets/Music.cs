using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
   
    public void  Awake()
    {
       
       
    }
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public  void OnSceneLoaded(Scene scene,LoadSceneMode mode)
    {
       
        if (scene.name == "Menu")
        {
            DontDestroyOnLoad(this);
        }
        else if (scene.name == "Start")
         {
            DontDestroyOnLoad(this);
         }
        if (scene.name == "EndScreen")
        {
            Destroy(this);
        }
    }
   


}
