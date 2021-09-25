using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Events
{

    public class EventDispatcher : MonoBehaviour
    {
        [Serialzefield]
        private ScriptsbleEvent _someEvent;

        public void Dispath()
        {
            _someEvent.Dispath();
        }
    }
}
