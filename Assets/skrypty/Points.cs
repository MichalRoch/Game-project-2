using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points  : MonoBehaviour
{
    public float pointsAdd = 1f;
    GameMenager gameMenager;

    private void Start()
    {
        gameMenager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameMenager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameMenager.points += pointsAdd;
            Destroy(gameObject);
        }
    }
}
