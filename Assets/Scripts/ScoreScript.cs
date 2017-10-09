using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public static float score;
    public float rate = 10f;

    private void Start()
    {
        score = 0;
    }


    // Update is called once per frame
    void Update()
    {
        score += rate * Time.deltaTime;
        scoreText.text = "Score\t\t" + score.ToString("f0");
    }
}
