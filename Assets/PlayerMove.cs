using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float moveSpeed = 10f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");



        rb.AddForce(new Vector3 (vertical * moveSpeed * Time.deltaTime, 0, horizontal * moveSpeed * Time.deltaTime));
    }
}
