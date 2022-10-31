using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInfo : MonoBehaviour
{
    public TMPro.TextMeshProUGUI infoText;
    public void OnCubeChanged(CubeTypes type)
    {
        switch (type)
        {
            case CubeTypes.RED_CUBE:
                infoText.SetText("Red");
                break;
            case CubeTypes.BLUE_CUBE:
                infoText.SetText("Blue");
                break;
            default:
                break;
        }
    }
}
