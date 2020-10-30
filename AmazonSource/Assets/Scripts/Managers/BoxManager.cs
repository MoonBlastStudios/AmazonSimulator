using System;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class BoxManager : MonoBehaviour
    {
        private static BoxManager _instance;
        private List<TestBox> m_activeBoxes;
        private void Awake()
        {
            BindInstance();
        }

        // Start is called before the first frame update
        private void Start()
        {
            Initialize();
        }

        // Update is called once per frame
        private void Update()
        {
        
        }

        private void BindInstance()
        {
            if (_instance == null)
            {
                _instance = this;
                return;
            }

            Destroy(gameObject);
        }

        private void Initialize()
        {
            m_activeBoxes = new List<TestBox>();
        }

        public static void AddBox(TestBox p_box)
        {
            _instance.m_activeBoxes.Add(p_box);
        }

        public static void UpdateBox()
        {
            foreach (var box in _instance.m_activeBoxes)
            {
                try
                {
                    box.UpdateFall();
                }
                catch (Exception e)
                {
                    // ignored
                }
            }
        }

        public static void RemoveBox(TestBox p_box)
        {
            _instance.m_activeBoxes.Remove(p_box);
        }
    }
}
