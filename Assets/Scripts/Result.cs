using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Result : MonoBehaviour
{
    public Text resultscore;
    // Use this for initialization
    void Start()
    {

        resultscore.text = "Score\t\t" + ScoreScript.score.ToString("f0");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            SceneManager.LoadScene("Main");
    }
}
