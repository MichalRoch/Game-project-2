using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDiagnostyka : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Gra rozpoczêta");
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
