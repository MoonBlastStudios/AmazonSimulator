// GENERATED AUTOMATICALLY FROM 'Assets/Resources/MasterInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MasterInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MasterInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MasterInput"",
    ""maps"": [
        {
            ""name"": ""Game"",
            ""id"": ""9456ed18-8b5e-42c0-974f-b23e751d367a"",
            ""actions"": [
                {
                    ""name"": ""LayerCam"",
                    ""type"": ""PassThrough"",
                    ""id"": ""43925ecb-e692-4526-b0fe-7721c586d83a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LayerCam1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9226802d-69b2-4f1a-94c7-547ac62421f5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LayerCam2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""481352ca-ec59-418a-8381-0ced4778c5bf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LayerCam3"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8d5ef4b0-c441-4d89-b303-ddd7586533d2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LayerCam4"",
                    ""type"": ""PassThrough"",
                    ""id"": ""018dfe6d-36a7-471c-8bc9-4ff6f64cb1bd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""fa5035c4-4ef5-49ca-9fad-2ea06e45a17d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""e517f09e-75f3-40c1-b73e-107d432c2b6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""24574f6c-0b54-4ef6-8577-92af97a30370"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LayerCam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6a13573-fee4-4627-81c3-d0692df2cd4a"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LayerCam1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""582b374e-a6d5-467f-9255-5ed95e68e22d"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LayerCam2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c906ea7c-6c67-4ef7-9d74-341f97bbb40e"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LayerCam3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b91b9e57-982e-4014-a8cf-8c3e3e6f5748"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LayerCam4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d664cb2-fcac-4c51-b59b-05a312f894f4"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4f49862-b01d-4d02-8b77-85d493e1bcae"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": []
        }
    ]
}");
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_LayerCam = m_Game.FindAction("LayerCam", throwIfNotFound: true);
        m_Game_LayerCam1 = m_Game.FindAction("LayerCam1", throwIfNotFound: true);
        m_Game_LayerCam2 = m_Game.FindAction("LayerCam2", throwIfNotFound: true);
        m_Game_LayerCam3 = m_Game.FindAction("LayerCam3", throwIfNotFound: true);
        m_Game_LayerCam4 = m_Game.FindAction("LayerCam4", throwIfNotFound: true);
        m_Game_MousePosition = m_Game.FindAction("MousePosition", throwIfNotFound: true);
        m_Game_LeftClick = m_Game.FindAction("LeftClick", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_LayerCam;
    private readonly InputAction m_Game_LayerCam1;
    private readonly InputAction m_Game_LayerCam2;
    private readonly InputAction m_Game_LayerCam3;
    private readonly InputAction m_Game_LayerCam4;
    private readonly InputAction m_Game_MousePosition;
    private readonly InputAction m_Game_LeftClick;
    public struct GameActions
    {
        private @MasterInput m_Wrapper;
        public GameActions(@MasterInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @LayerCam => m_Wrapper.m_Game_LayerCam;
        public InputAction @LayerCam1 => m_Wrapper.m_Game_LayerCam1;
        public InputAction @LayerCam2 => m_Wrapper.m_Game_LayerCam2;
        public InputAction @LayerCam3 => m_Wrapper.m_Game_LayerCam3;
        public InputAction @LayerCam4 => m_Wrapper.m_Game_LayerCam4;
        public InputAction @MousePosition => m_Wrapper.m_Game_MousePosition;
        public InputAction @LeftClick => m_Wrapper.m_Game_LeftClick;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @LayerCam.started -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam;
                @LayerCam.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam;
                @LayerCam.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam;
                @LayerCam1.started -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam1;
                @LayerCam1.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam1;
                @LayerCam1.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam1;
                @LayerCam2.started -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam2;
                @LayerCam2.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam2;
                @LayerCam2.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam2;
                @LayerCam3.started -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam3;
                @LayerCam3.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam3;
                @LayerCam3.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam3;
                @LayerCam4.started -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam4;
                @LayerCam4.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam4;
                @LayerCam4.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnLayerCam4;
                @MousePosition.started -= m_Wrapper.m_GameActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnMousePosition;
                @LeftClick.started -= m_Wrapper.m_GameActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnLeftClick;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LayerCam.started += instance.OnLayerCam;
                @LayerCam.performed += instance.OnLayerCam;
                @LayerCam.canceled += instance.OnLayerCam;
                @LayerCam1.started += instance.OnLayerCam1;
                @LayerCam1.performed += instance.OnLayerCam1;
                @LayerCam1.canceled += instance.OnLayerCam1;
                @LayerCam2.started += instance.OnLayerCam2;
                @LayerCam2.performed += instance.OnLayerCam2;
                @LayerCam2.canceled += instance.OnLayerCam2;
                @LayerCam3.started += instance.OnLayerCam3;
                @LayerCam3.performed += instance.OnLayerCam3;
                @LayerCam3.canceled += instance.OnLayerCam3;
                @LayerCam4.started += instance.OnLayerCam4;
                @LayerCam4.performed += instance.OnLayerCam4;
                @LayerCam4.canceled += instance.OnLayerCam4;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
            }
        }
    }
    public GameActions @Game => new GameActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface IGameActions
    {
        void OnLayerCam(InputAction.CallbackContext context);
        void OnLayerCam1(InputAction.CallbackContext context);
        void OnLayerCam2(InputAction.CallbackContext context);
        void OnLayerCam3(InputAction.CallbackContext context);
        void OnLayerCam4(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
    }
}
