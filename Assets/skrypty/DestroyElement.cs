using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyElement : MonoBehaviour
{
    public Color kolorStartowy;
    public Color kolorKoncowy;
    public int life;
    public bool isRigidbody = false;

    private Material material;
    private int maxLive = 3;
    Rigidbody rb;
    void Start()
    {
        life = Mathf.Clamp(life, 1, maxLive);
        material = GetComponent<MeshRenderer>().material;

        SetColor();

        if (isRigidbody)
        {
            rb = gameObject.AddComponent<Rigidbody>();
            rb.interpolation = RigidbodyInterpolation.Interpolate;
            rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
            rb.mass = 0.5f;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            life--;

            if(life > 0)
            {
                SetColor();
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
    void SetColor()
    {
        material.color = Color.Lerp(kolorKoncowy, kolorStartowy, (float)(life - 1) / (float)(maxLive - 1));
    }
    private void OnValidate()
    {
        material = GetComponent<MeshRenderer>().sharedMaterial;
        SetColor();
    }

}
