using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jump : MonoBehaviour
{
    public float jumpPower;

    Rigidbody rb;
    private float jumpActivition;
    private Transform positionPlayer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        positionPlayer = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && Physics.Raycast(positionPlayer.position, Vector3.down, jumpActivition))
        {
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
    private void FixedUpdate()
    {
        jumpActivition = gameObject.transform.localScale.y;
    }
}
