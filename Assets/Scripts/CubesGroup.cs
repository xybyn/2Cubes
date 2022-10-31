using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CubesGroup : Player
{
    public CubePlayer redPlayer;
    public CubePlayer bluePlayer;

    private void Start()
    {
        redPlayer.OnGameOver.AddListener((s) => OnGameOver.Invoke(s));       
        bluePlayer.OnGameOver.AddListener((s) => OnGameOver.Invoke(s));       
    }

}
