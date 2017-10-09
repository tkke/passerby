using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public static float score = 0;
    public float rate = 10f;


    // Update is called once per frame
    void Update()
    {
        score += rate * Time.deltaTime;
        scoreText.text = "Score: " + score.ToString("f0");
    }
}
