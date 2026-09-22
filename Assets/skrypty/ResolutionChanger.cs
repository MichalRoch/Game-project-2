using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionChanger : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;

    void Start()
    {
        resolutionDropdown.ClearOptions();
        resolutionDropdown.AddOptions(new System.Collections.Generic.List<string>
        {
            "1920 x 1080",
            "1500 x 1000",
            "1000 x 1500"
        });

        resolutionDropdown.onValueChanged.AddListener(ChangeResolution);
    }

    public void ChangeResolution(int index)
    {
        if (index == 0)
            Screen.SetResolution(1920, 1080, Screen.fullScreen);
        else if (index == 1)
            Screen.SetResolution(1500, 1000, Screen.fullScreen);
        else if (index == 2)
            Screen.SetResolution(1000, 1500, Screen.fullScreen);
    }
}
