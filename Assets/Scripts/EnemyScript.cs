using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyScript : MonoBehaviour
{
    public float speed = 20;
    public GameObject player;
    int dir;
    RaycastHit hit;
    bool avoidFlg;
    // Use this for initialization
    void Start()
    {
        avoidFlg = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -1) * speed * Time.deltaTime;

        if (Physics.Raycast(transform.position, Vector3.back, out hit, 6))
        {
            if (hit.collider.tag == "Player")
            {
                dir = Random.Range(0, 3);
                if (dir == 0)
                {
                    transform.position += new Vector3(2, 0, 0);
                }
                else if (dir == 1)
                {
                    transform.position += new Vector3(-2, 0, 0);
                }
                avoidFlg = true;
            }
        }

        if (avoidFlg && player.transform.position.x - transform.position.x > 0)
        {
            ScoreScript.score += 300;
            avoidFlg = false;
            //ScoreScript.scoreText.text = "Score: " + ScoreScript.score.ToString("f0");
        }

    }

}
