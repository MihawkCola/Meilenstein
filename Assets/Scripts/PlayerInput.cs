//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""64c759d1-928f-445f-9311-1074cfb27cac"",
            ""actions"": [
                {
                    ""name"": ""Movment"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d7c4b71f-e8a4-4d36-8f2d-709116fe76e0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""014a0e31-8b35-40fe-b1cc-288b54788fea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hit"",
                    ""type"": ""Button"",
                    ""id"": ""de4475b9-965d-4b2c-9da6-f92cbcc27190"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8a665b44-92b2-4674-831f-a94e1451c18f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Running"",
                    ""type"": ""Button"",
                    ""id"": ""67daa31e-3eea-47c6-9be4-22b18e90fb1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sneaking"",
                    ""type"": ""Button"",
                    ""id"": ""a269061d-6a47-41d4-a8d8-ddd42a49817d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchPlayer"",
                    ""type"": ""Button"",
                    ""id"": ""1877bd6a-5281-45f6-941f-690bcb93108b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ce6aff56-8229-4119-a416-606bb9d42e62"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""c5cead16-2046-4df5-ad01-8ff686dc48a6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""938da8b3-7289-4ce5-a92d-2ecfc9aee467"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""92e66511-97c7-4a76-a7d3-6d1c049d6416"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""764265ff-770c-4abc-9ee3-38e036abae33"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0bf45900-d264-462b-82be-9259eeea50c7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4eb7c280-aec2-44c2-bd6d-aeace49141e1"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4163b92f-5a70-404d-8ec4-50ced7ed5add"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67959743-185d-49bd-bfcb-8ef7d8a0fbf7"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""595f9d62-4608-43d8-a8e7-c6e493c6c671"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Running"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bef15b9-b089-4949-9f3f-ade9542fed6f"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sneaking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""778ee521-6f21-4108-b495-31c6709563c5"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Control"",
            ""bindingGroup"": ""Control"",
            ""devices"": []
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movment = m_Player.FindAction("Movment", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Hit = m_Player.FindAction("Hit", throwIfNotFound: true);
        m_Player_Camera = m_Player.FindAction("Camera", throwIfNotFound: true);
        m_Player_Running = m_Player.FindAction("Running", throwIfNotFound: true);
        m_Player_Sneaking = m_Player.FindAction("Sneaking", throwIfNotFound: true);
        m_Player_SwitchPlayer = m_Player.FindAction("SwitchPlayer", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movment;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Hit;
    private readonly InputAction m_Player_Camera;
    private readonly InputAction m_Player_Running;
    private readonly InputAction m_Player_Sneaking;
    private readonly InputAction m_Player_SwitchPlayer;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movment => m_Wrapper.m_Player_Movment;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Hit => m_Wrapper.m_Player_Hit;
        public InputAction @Camera => m_Wrapper.m_Player_Camera;
        public InputAction @Running => m_Wrapper.m_Player_Running;
        public InputAction @Sneaking => m_Wrapper.m_Player_Sneaking;
        public InputAction @SwitchPlayer => m_Wrapper.m_Player_SwitchPlayer;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movment.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovment;
                @Movment.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovment;
                @Movment.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovment;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Hit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHit;
                @Hit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHit;
                @Hit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHit;
                @Camera.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCamera;
                @Running.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRunning;
                @Running.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRunning;
                @Running.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRunning;
                @Sneaking.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSneaking;
                @Sneaking.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSneaking;
                @Sneaking.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSneaking;
                @SwitchPlayer.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchPlayer;
                @SwitchPlayer.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchPlayer;
                @SwitchPlayer.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchPlayer;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movment.started += instance.OnMovment;
                @Movment.performed += instance.OnMovment;
                @Movment.canceled += instance.OnMovment;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Hit.started += instance.OnHit;
                @Hit.performed += instance.OnHit;
                @Hit.canceled += instance.OnHit;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Running.started += instance.OnRunning;
                @Running.performed += instance.OnRunning;
                @Running.canceled += instance.OnRunning;
                @Sneaking.started += instance.OnSneaking;
                @Sneaking.performed += instance.OnSneaking;
                @Sneaking.canceled += instance.OnSneaking;
                @SwitchPlayer.started += instance.OnSwitchPlayer;
                @SwitchPlayer.performed += instance.OnSwitchPlayer;
                @SwitchPlayer.canceled += instance.OnSwitchPlayer;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_ControlSchemeIndex = -1;
    public InputControlScheme ControlScheme
    {
        get
        {
            if (m_ControlSchemeIndex == -1) m_ControlSchemeIndex = asset.FindControlSchemeIndex("Control");
            return asset.controlSchemes[m_ControlSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovment(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnHit(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnRunning(InputAction.CallbackContext context);
        void OnSneaking(InputAction.CallbackContext context);
        void OnSwitchPlayer(InputAction.CallbackContext context);
    }
}
