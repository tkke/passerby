using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Vector3 touchStartPos;
    private Vector3 touchEndPos;
    float directionX;

    public float speed = 3f;
    Flick flick;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchStartPos = new Vector3(Input.mousePosition.x,
                                        Input.mousePosition.y,
                                        Input.mousePosition.z);
            Debug.Log(touchStartPos);
        }

        if (Input.GetMouseButtonUp(0))
        {
            touchEndPos = new Vector3(Input.mousePosition.x,
                                      Input.mousePosition.y,
                                      Input.mousePosition.z);
            Debug.Log(touchEndPos);
            directionX = touchEndPos.x - touchStartPos.x;
        }


        if (30 < directionX)
        {
            if (transform.position.x < 9.0f)
            {
                transform.position += new Vector3(2, 0, 0);
                directionX = 0;
                //touchStartPos = Vector3.zero;
                //touchEndPos = Vector3.zero;
                //transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;

            }
        }
        if (-30 > directionX)
        {
            if (transform.position.x > -3.5f)
            {
                transform.position += new Vector3(-2, 0, 0);
                directionX = 0;
                //touchStartPos = Vector3.zero;
                //touchEndPos = Vector3.zero;
                //transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
            SceneManager.LoadScene("GameOver");
    }
}
