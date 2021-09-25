using Events;
using UnityEngine;

namespace Game
{
    public class UptateManager : MonoBehaviour
    {
        [SerializeField]
            private ScriptableEvent _updateEvent;

        [SerializeField]
        private ScriptableEvent _fixedEvent;

        private void Update()
        {
            _updateEvent.Dispatch();
        }

        private void FixedUpdate()
        {
            _fixedEvent.Dispatch();
        }
    }

}