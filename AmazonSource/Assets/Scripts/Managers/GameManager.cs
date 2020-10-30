using System;
using AngeloExamples.UI;
using Character;
using Tools.Managers;
using UnityEngine;

namespace Managers
{
    public class GameManager : BaseGameManager
    {
        [SerializeField] private int m_scorePerBox = 100;

        [Header("Components")] 
        [SerializeField] private CamController m_camController;
        [SerializeField] private TrackMouse m_aimCursor;
        
        [Header("Layer Data")]
        [SerializeField] private float[] m_layerSpeeds;
        [SerializeField] private float m_slowdownValue;
        [SerializeField] private float m_defaultValue = 1;
        
        private int m_currentScore = 0;

        protected override void Awake()
        {
            base.Awake();
            InitializeSpeeds();
        }

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        private void InitializeSpeeds()
        {
            for (var i = 0; i < m_layerSpeeds.Length; i++)
            {
                m_layerSpeeds[i] = m_defaultValue;
            }
        }

        public static GameManager Manager()
        {
            return _instance as GameManager;
        }


        public static TrackMouse AimCursor
        {
            get
            {
                if (_instance != null)
                {
                    return Manager().m_aimCursor;
                }
                
                throw new Exception("PLEASE PUT GAME MANAGER IN THE SCENE");
            }
        }

        public static void UpdateCurrentScore()
        {
            var curManager = Manager();
            curManager.m_currentScore += curManager.m_scorePerBox;
            UIController.UpdateScore(curManager.m_currentScore);
        }


        public static void AssignBox(TestBox p_box)
        {
            Manager().m_camController.GetRandomLayer(out var layer, out var unityLayer);
            p_box.SetCamLayer(layer, unityLayer);
        }

        public static bool ValidateBox(int p_layer)
        {
            var curLayer = Manager().m_camController.GetCurrentLayer();
            return p_layer == curLayer;
        }

        public static float DefaultSpeed => Manager().m_defaultValue;

        public static float SlowdownValue => Manager().m_slowdownValue;
    }
}
