using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class MoveTowards : MonoBehaviour
{
    public GameObject Angel; //sphere
    public GameObject Player; //cube

    public float speed;

    private Camera cam;
    public bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        cam = FindObjectOfType<Camera>();
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
        Angel.transform.position = Vector3.MoveTowards(Angel.transform.position, Player.transform.position, speed);
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
