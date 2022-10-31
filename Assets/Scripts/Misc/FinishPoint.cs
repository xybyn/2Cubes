using UnityEngine;
using UnityEngine.Events;

public class FinishPoint : MonoBehaviour
{
    public UnityEvent OnFinished = new UnityEvent();

    [SerializeField]
    private GameObject _target;

    private float finishingRadius = 0.1f;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(_target.tag))
        {
            if ((other.transform.position - transform.position).sqrMagnitude < finishingRadius * finishingRadius)
            {
                OnFinished.Invoke();
                Destroy(this);
            }
        }
    }
}
