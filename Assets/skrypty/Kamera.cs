using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{

    public Vector3 distance;
    public float lookUp;
    public float lerpAmount;

    private GameObject Gracz;

    void Start()
    {
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 100;

        Gracz = GameObject.FindGameObjectWithTag("Player");
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Gracz.transform.position + distance, lerpAmount * Time.deltaTime);
        transform.LookAt(Gracz.transform.position);
        transform.Rotate(-lookUp, 0, 0);
    }


}
