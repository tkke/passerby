using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSpawnerScript : MonoBehaviour
{
    public GameObject player;
    public GameObject stage;
    public bool flg;
    // Use this for initialization
    void Start()
    {
        flg = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (flg && transform.position.z - player.transform.position.z < 40)
        {
            Instantiate(stage, transform.position, Quaternion.identity);
            flg = false;
        }
    }
}
