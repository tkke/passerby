using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScript : MonoBehaviour
{
    public float speed = 5;


    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -1) * speed * Time.deltaTime;
        if (transform.position.z < -200)
            Destroy(transform.gameObject);
    }
}
