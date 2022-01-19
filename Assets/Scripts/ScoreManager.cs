using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager: MonoBehaviour
{
    public Text scoreText ;

    public float scoreCount;
    public float pointsPerSecond;
    public bool scoreIncreasing;

    void Start()
    {
        
    }

    
    void Update()
    {
        scoreText.text = "" + Mathf.Round(scoreCount);
        scoreCount += pointsPerSecond * Time.deltaTime;
    }    
}
