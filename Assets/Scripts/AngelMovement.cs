using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.AI;
using System;

public class AngelMovement : MonoBehaviour
{
    //[SerializeField] private float AngelSpeed = 9f;


    private Camera cam;
    private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        cam = FindObjectOfType<Camera>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        CheckVisibility();

        if (!CheckVisibility())
        {
            SetPlayerDestination(navMeshAgent);
        }
    }

    private bool CheckVisibility()
    {
        Vector3 screenPos = cam.WorldToScreenPoint(transform.position);
        bool onScreen = screenPos.x > 0f && screenPos.x < UnityEngine.Device.Screen.width && screenPos.y > 0f && screenPos.y < UnityEngine.Device.Screen.height;

        return onScreen;
    }

    void SetPlayerDestination(NavMeshAgent navMeshAgent)
    {
        // Set the player's position as the destination
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
        }
    }
}
