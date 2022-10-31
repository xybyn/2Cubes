using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FinishPoint : MonoBehaviour
{
    public GameObject target;
    public UnityEvent OnFinished = new UnityEvent();
    public float finishingRadius = 0.1f;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(target.tag))
        {
            if ((other.transform.position - transform.position).sqrMagnitude < finishingRadius * finishingRadius)
            {
                OnFinished.Invoke();
                Destroy(this);
            }
        }
    }
}
