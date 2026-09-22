using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMove : MonoBehaviour
{
    public float speed = 1f;
    public float sila = 1f;
    public float maxAngularVelocity;
    public Rigidbody rb;

    private bool isRigidbody;
    void Start()
    {
        if (isRigidbody = TryGetComponent<Rigidbody>(out rb))
        {
            rb.maxAngularVelocity = maxAngularVelocity;
        }
    }
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float Hdirection;
        float Vdirection;

        if (isRigidbody && (Hdirection = Input.GetAxis("Horizontal")) != 0)
        {
            rb.AddTorque(0, 0, -Hdirection * speed);
            rb.AddForce(Hdirection * sila, 0, 0);
        }
        if (isRigidbody && (Vdirection = Input.GetAxis("Vertical")) != 0)
        {
            rb.AddTorque(Vdirection * speed, 0, 0);
            rb.AddForce(0, 0, Vdirection * sila);
        }
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
