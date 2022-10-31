using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIGame : MonoBehaviour
{
    public GameObject game;
    private void OnEnable()
    {
        //game.SetActive(true);
    }
    private void OnDisable()
    {
        //if (game.IsDestroyed())
        //    return;
        //game.SetActive(false);
    }
}
