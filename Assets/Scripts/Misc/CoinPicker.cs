using UnityEngine;
using UnityEngine.Events;

public class CoinPicker : MonoBehaviour
{
    public UnityEvent OnCoinPicked = new UnityEvent();
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Coin"))
        {
            OnCoinPicked.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
