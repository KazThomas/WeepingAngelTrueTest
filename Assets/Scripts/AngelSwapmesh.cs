using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelSwapmesh : MonoBehaviour
{
    public Mesh angelClosed;
    public Mesh angelOpen;

    public GameObject angel;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        float distanceThreshold = 5f; 

        Vector3 angelPosition = angel.transform.position;
        Vector3 playerPosition = player.transform.position;

        float distance = Vector3.Distance(angelPosition, playerPosition); //checks the distance between two object positions

        if (distance < distanceThreshold) //if angel is close enough to player be scary
        {
            angel.GetComponent<MeshFilter>().mesh = angelOpen; 
        }
        else //if the player is far enough away from the angel then just be a statue
        {
            angel.GetComponent<MeshFilter>().mesh = angelClosed;
        }

    }
}
