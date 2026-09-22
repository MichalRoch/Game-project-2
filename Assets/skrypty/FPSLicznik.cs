using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FPSLicznik : MonoBehaviour
{
    public TextMeshProUGUI fpsText;

    float timer = 0f;
    int frames = 0;

    void Update()
    {
        frames++;
        timer += Time.unscaledDeltaTime;

        if (timer >= 0.5f)
        {
            int fps = Mathf.RoundToInt(frames / timer);
            fpsText.text = fps + " FPS";

            frames = 0;
            timer = 0;
        }
    }
}
