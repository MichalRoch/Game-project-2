using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraDiagnostyka : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Poziom za³adowany");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Naciœniêto spacjê");
        }
    }

    void OnApplicationQuit()
    {
        Debug.Log("Zamykanie aplikacji");
    }
}