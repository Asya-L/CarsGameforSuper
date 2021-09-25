using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events
{




    public class EventListener : MonoBehaviour
    {

        [SerializeField]
        private ScriptableEvent _someEvent;

        public event Action OnEventHappend = delegate { };

        private void OnEnable()
        {
            _someEvent.AddListener(EventHappend);
        }

        private void OnEnable()
        {
            _someEvent.AddListener(EventHappened);
        }

        private void OnDisable()
        {
            _someEvent.RemoveListener(EventHappend);
        }

        private void EventHappend()
        {

            OnEventHappend.Invoke();
        }


        public void Dispatch()
        {
            _someEvent.Dispatch();
        }

    }

}

