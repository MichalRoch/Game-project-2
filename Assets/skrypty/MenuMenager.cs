using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMenager : MonoBehaviour
{
    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
