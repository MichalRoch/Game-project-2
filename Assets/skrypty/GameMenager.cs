using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
public class GameMenager : MonoBehaviour
{
    [Header("Ball settings")]
    public GameObject Gracz;
    public Transform pozycjaStartowa;

    [Header("Time settings")]
    public TextMeshProUGUI timeText;
    public float time;

    [Header("Points settings")]
    public TextMeshProUGUI pointsText;
    public float points;
    private void Awake()
    {
        Instantiate(Gracz, pozycjaStartowa.position, Quaternion.identity);
    }
    private void Update()
    {
        time += Time.deltaTime;
        timeText.text = "Czas: " + Mathf.Clamp(Mathf.FloorToInt(time), 0, int.MaxValue).ToString();

        pointsText.text = "Punktacja: " + Mathf.Clamp(points, 0, int.MaxValue).ToString();
    }
}