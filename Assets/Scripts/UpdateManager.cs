using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class UpdateManager : MonoBehaviour
    {
        [SerialzeField]
        private ScroptableEvent _updateEvent;

        [SerialzeField]
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
