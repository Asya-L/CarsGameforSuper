using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Events;

namespace Game{
    public class Save1 : MonoBehaviour
    {
        public class SaveData {
            public string date;
            public string score;
        }

        [SerializeField]
        private EventListener _carCollisionEventListener;

        [SerializeFiled]
        private ScriptableIntValue _currentScore;

        private List<SaveData>  _savedData;
        private const string Records_Key = "records";

        private void Awake() {
            _savedData = new List<SavedData>();

        }

        private void OnEnable(){
                _carCollisionEventListener.OnEventHappened += OnCarCollision;

        }

        private void OnDisable(){
                _carCollisionEventListener.OnEventHappened -= OnCarCollision;

        }

        private void OnCarCollisiion (){
            var newRecord = new SaveData {
                date = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
                score = _currentScore.value.ToString()
            };
            _savedData.Add(newRecord);

            SaveDataToPlayerPrefs();
        }

        private void SaveDataToPlayerPrefs(){
            var json = JsonUtility.ToJson(_savedData);
            PlayerPrefs.SetString(RECORDS_KEY, json);
        }




    }
}