using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public UnityEvent<GameOverStates> OnGameOver = new UnityEvent<GameOverStates>();
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            OnGameOver.Invoke(GameOverStates.DEAD);
        }
    }
}
