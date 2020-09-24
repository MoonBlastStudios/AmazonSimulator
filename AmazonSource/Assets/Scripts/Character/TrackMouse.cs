using System;
using System.Collections.Generic;
using Tools;
using Tools.Managers;
using UnityEngine;

namespace Character
{
    public class TrackMouse : MonoBehaviour
    {
        [SerializeField] private bool m_hideCursor = false;

        private List<GameObject> m_boxesInRange;

        // Start is called before the first frame update
        void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            m_boxesInRange = new List<GameObject>();
            BaseGameManager.LeftClickEvent.AddListener(DestroyBox);
            if (!m_hideCursor) return;
            
            Cursor.visible = false;
        }
        
        // Update is called once per frame
        void Update()
        {
            Track();
        }

        private void Track()
        {
            //Debug.Log(BaseGameManager.MousePosition);
            transform.position = CameraTools.GetWorldPosition(BaseGameManager.MousePosition, 0);
        }

        private void DestroyBox()
        {
            Debug.Log("Destroy");
            
            if (m_boxesInRange.Count <= 0) return;
            
            foreach (var box in m_boxesInRange)
            {
                Destroy(box);
            }
        }

        public void AddBoxToList(GameObject p_box)
        {
            m_boxesInRange.Add(p_box);
        }

        public void RemoveFromList(GameObject p_box)
        {
            m_boxesInRange.Remove(p_box);
        }
    }
}
