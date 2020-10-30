using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Tools.Managers
{
    public class BaseGameManager : MonoBehaviour
    {
        [Tooltip("The Custom Timescale that the game will run at, a number lower then 1 = slow motion, > 1 = fast forward")]
        [Range(0, 1)]
        [SerializeField] private float m_timeScale;
        [SerializeField] private bool m_dontDestroyOnLoad;
        
        protected static BaseGameManager _instance;
        private MasterInput m_masterInput;
        private Camera m_camera;
        private Vector2 m_mousePosition;
        private UnityEvent m_leftClickEvent;
        

        protected virtual void Awake()
        {
			BindInstance();
            GetCamera();
            Initialize();
            CreateMasterInput();
        }

        private void BindInstance()
        {
            if (_instance != null)
            {
                Destroy(gameObject);
                return;
            }
            else
            {
                _instance = this;
                
                if(m_dontDestroyOnLoad)
                    DontDestroyOnLoad(gameObject);
            }
        }

        protected virtual void Initialize()
        {
            m_leftClickEvent = new UnityEvent();
        }

        private void GetCamera()
        {
            m_camera = Camera.main;
        }

        private void CreateMasterInput()
        {
            m_masterInput = new MasterInput();
            m_masterInput.Game.MousePosition.performed += GrabMousePosition;
            m_masterInput.Game.LeftClick.performed += LeftClickPressed;
            
            m_masterInput.Enable();
        }

        private void LeftClickPressed(InputAction.CallbackContext p_obj)
        {
            m_leftClickEvent.Invoke();
        }

        private void GrabMousePosition(InputAction.CallbackContext p_obj)
        {
            m_mousePosition = p_obj.action.ReadValue<Vector2>();
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

        public static MasterInput MasterInputs
        {
            get
            {
                if (_instance != null)
                {
                    return _instance.m_masterInput;
                }

                throw new Exception("PLEASE PUT GAME MANAGER IN THE SCENE");
            }
        }

        public static Vector2 MousePosition
        {
            get
            {
                if (_instance != null)
                {
                    return _instance.m_mousePosition;
                }
                
                throw new Exception("PLEASE PUT GAME MANAGER IN THE SCENE");
            }
        }

        public static UnityEvent LeftClickEvent
        {
            get
            {
                if (_instance != null)
                {
                    return _instance.m_leftClickEvent;
                }

                throw new Exception("PLEASE PUT GAME MANAGER IN THE SCENE");
            }
        }
    }
}
