using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class MoveTowards : MonoBehaviour
{
    
    private GameObject player; 

    public float speed;

    private Camera cam;
    public bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        cam = FindObjectOfType<Camera>();
        player = GameObject.FindWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        CheckVisibility();

        if (CheckVisibility() == false)
        {
            canMove = true;
        }

        if (canMove == true)
        {
            AngelMove();
        }

        if (CheckVisibility() == true)
        {
            canMove = false;
        }
    }

    void AngelMove()
    {
       transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);
    }

    private bool CheckVisibility()
    {
        Vector3 screenPos = cam.WorldToScreenPoint(transform.position);
        bool onScreen = screenPos.x > 0f && screenPos.x < UnityEngine.Device.Screen.width && screenPos.y > 0f && screenPos.y < UnityEngine.Device.Screen.height;

        if (onScreen)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
