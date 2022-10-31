using UnityEngine;

public class CubesGroup : Player
{
    [SerializeField]
    private CubePlayer _redPlayer;
    [SerializeField]
    private CubePlayer _bluePlayer;

    private void Start()
    {
        _redPlayer.OnGameOver.AddListener((s) => OnGameOver.Invoke(s));
        _bluePlayer.OnGameOver.AddListener((s) => OnGameOver.Invoke(s));
    }

}
