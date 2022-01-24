using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float currentTime;
    public float startingTime;
    public float multiTime= 2;

   

    public Text countdownText;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime +=1 * multiTime * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        
    }

    public void StopCountdown()
    {
        countdownText.gameObject.SetActive(false);
    }
}
