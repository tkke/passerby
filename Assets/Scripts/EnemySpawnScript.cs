using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject[] enemies;
    public float interval = 3.0f;
    private float time = 0;
    private int num;
    private Vector3 pos_x;


    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > interval)
        {
            num = Random.Range(0, enemies.Length);
            pos_x = transform.position + new Vector3(Random.Range(-3, 9), 0, 0);
            Instantiate(enemies[num], pos_x, Quaternion.Euler(0, 180, 0));
            time = 0;
        }
    }
}
