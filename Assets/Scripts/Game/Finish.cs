using UnityEngine;
using UnityEngine.Events;

public class Finish : MonoBehaviour
{
    public UnityEvent LoseEvent;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Ice>())
        {
            LoseEvent.Invoke();
        }
    }
}
