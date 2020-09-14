using System;
using UnityEngine;

namespace Tools.Managers
{
    public class BaseGameManager : MonoBehaviour
    {
        private static BaseGameManager _instance;

        private Camera m_camera;

        protected virtual void Awake()
        {
			BindInstance();
            GetCamera();
        }

        protected void BindInstance()
        {
            if (_instance != null)
            {
                Destroy(gameObject);
                return;
            }
            else
            {
                _instance = this;
                DontDestroyOnLoad(gameObject);
            }
        }

        private void GetCamera()
        {
            m_camera = Camera.main;
        }

        public static BaseGameManager Instance => _instance;

        public static Camera Cam
        {
            get
            {
                if (_instance != null)
                {
                    return _instance.m_camera;
                }

                throw new Exception("PLEASE PUT GAME MANAGER IN THE SCENE");
            }
        }
    }
}
