using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour
{
    [SerialzeField]
    private ScriptableEvent _someEvent;

    public event Action OnEventHappened = delegate { };

    private void OnEneble()
    {
        _someEvent.AddListener(EventHappened);
    }

    private void OnDisable()
    {
        _someEvent.RemoveLostener(EventHappened);
    }
    private void EventHappened()
    {
        OnEventHappened.Invoke();
    }
}
