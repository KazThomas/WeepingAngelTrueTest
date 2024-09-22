using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] float speedVert = 1.6f;
    [SerializeField] float speedHorz = 1.6f;

    private float rotateX = 0f;
    private float rotateY = 0f;

    // Update is called once per frame
    void Update()
    {
        rotateY += speedVert * Input.GetAxis("Mouse X");
        rotateX -= speedHorz * Input.GetAxis("Mouse Y");

        //removes the ability to do a full 360 if player looks too far up or too far down
        rotateX = Mathf.Clamp(rotateX, -30f, 30f);

        transform.eulerAngles = new Vector3 (rotateX, rotateY, 0f);
    }
}
