using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flick : MonoBehaviour
{
    private Vector3 touchStartPos;
    private Vector3 touchEndPos;
    string Direction;
    public void Flicks()
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
            GetDirection();
        }
    }

    public string GetDirection()
    {
        float directionX = touchEndPos.x - touchStartPos.x;

        if (10 < directionX)
        {
            //右向きにフリック
            Direction = "right";
        }
        else if (-10 > directionX)
        {
            //左向きにフリック
            Direction = "left";
        }
        else
        {
            //タッチを検出
            Direction = "touch";
        }

        return Direction;
    }



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
