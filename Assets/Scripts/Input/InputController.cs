//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Scripts/Input/InputController.inputactions
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

public partial class @InputController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""4fcb130f-e19e-42fb-a1c5-2b2d28fd6ce1"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0a3860ae-46a8-4cee-bf51-af47e85dafc2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RightStick"",
                    ""type"": ""Value"",
                    ""id"": ""4f3b2687-080e-4323-bf6e-3f5cda2f7add"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PowerPunch"",
                    ""type"": ""Button"",
                    ""id"": ""8ca826e9-cfe5-49c4-bcd2-b85675ced566"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""32cb5079-10db-4363-be0d-6d73337ca6f2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""JabRight"",
                    ""type"": ""Button"",
                    ""id"": ""f4a600ab-8c0d-47b4-b6da-f7a4060b9937"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""JabLeft"",
                    ""type"": ""Button"",
                    ""id"": ""74e963e2-4907-4ff1-87ca-cc26325996b4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HookRight"",
                    ""type"": ""Button"",
                    ""id"": ""9999c377-f4a2-415a-8397-e9bb66bdc86c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HooksLeft"",
                    ""type"": ""Button"",
                    ""id"": ""bd5496ed-5159-46c6-a5e5-2bb27cb733c3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Uppercut"",
                    ""type"": ""Button"",
                    ""id"": ""c2f70e30-e321-4591-b808-6bdf95091833"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""3554350a-175f-4fbb-a2fa-a8e1277de7f1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b5172239-25d9-41e5-83e5-89cf1e400577"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e169295f-c273-44e1-b96c-24ce0a7e6e7c"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""RightStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aac9b0ff-4d6b-4e69-a352-ead98bd7edec"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""PowerPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d863e91-5091-491f-85bf-25869f096ff9"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52e8bad1-3958-4bc0-9e08-d128b33c6529"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""JabRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e6d125d-e640-4bfc-a159-41e2f1fdfcc9"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""JabLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4da3204c-acd0-4773-9bfc-0add0912b0d8"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""HookRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7739a2e9-17a3-448d-ae66-fc5b965b0ea6"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""HooksLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd8a72c5-31cc-4843-82b5-2ac417687729"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Uppercut"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""833d39ea-abae-47c2-af46-a874bd9ec736"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cce8665e-226e-4e76-ad47-0ee4f41bc8e5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f94c5df9-65d4-43ca-a895-91db0dafb4f0"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81214028-36f4-434c-b4f3-0529dc5236ed"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Walk = m_Player.FindAction("Walk", throwIfNotFound: true);
        m_Player_RightStick = m_Player.FindAction("RightStick", throwIfNotFound: true);
        m_Player_PowerPunch = m_Player.FindAction("PowerPunch", throwIfNotFound: true);
        m_Player_Block = m_Player.FindAction("Block", throwIfNotFound: true);
        m_Player_JabRight = m_Player.FindAction("JabRight", throwIfNotFound: true);
        m_Player_JabLeft = m_Player.FindAction("JabLeft", throwIfNotFound: true);
        m_Player_HookRight = m_Player.FindAction("HookRight", throwIfNotFound: true);
        m_Player_HooksLeft = m_Player.FindAction("HooksLeft", throwIfNotFound: true);
        m_Player_Uppercut = m_Player.FindAction("Uppercut", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
    }

    ~@InputController()
    {
        UnityEngine.Debug.Assert(!m_Player.enabled, "This will cause a leak and performance issues, InputController.Player.Disable() has not been called.");
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
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Walk;
    private readonly InputAction m_Player_RightStick;
    private readonly InputAction m_Player_PowerPunch;
    private readonly InputAction m_Player_Block;
    private readonly InputAction m_Player_JabRight;
    private readonly InputAction m_Player_JabLeft;
    private readonly InputAction m_Player_HookRight;
    private readonly InputAction m_Player_HooksLeft;
    private readonly InputAction m_Player_Uppercut;
    private readonly InputAction m_Player_Pause;
    public struct PlayerActions
    {
        private @InputController m_Wrapper;
        public PlayerActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Player_Walk;
        public InputAction @RightStick => m_Wrapper.m_Player_RightStick;
        public InputAction @PowerPunch => m_Wrapper.m_Player_PowerPunch;
        public InputAction @Block => m_Wrapper.m_Player_Block;
        public InputAction @JabRight => m_Wrapper.m_Player_JabRight;
        public InputAction @JabLeft => m_Wrapper.m_Player_JabLeft;
        public InputAction @HookRight => m_Wrapper.m_Player_HookRight;
        public InputAction @HooksLeft => m_Wrapper.m_Player_HooksLeft;
        public InputAction @Uppercut => m_Wrapper.m_Player_Uppercut;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Walk.started += instance.OnWalk;
            @Walk.performed += instance.OnWalk;
            @Walk.canceled += instance.OnWalk;
            @RightStick.started += instance.OnRightStick;
            @RightStick.performed += instance.OnRightStick;
            @RightStick.canceled += instance.OnRightStick;
            @PowerPunch.started += instance.OnPowerPunch;
            @PowerPunch.performed += instance.OnPowerPunch;
            @PowerPunch.canceled += instance.OnPowerPunch;
            @Block.started += instance.OnBlock;
            @Block.performed += instance.OnBlock;
            @Block.canceled += instance.OnBlock;
            @JabRight.started += instance.OnJabRight;
            @JabRight.performed += instance.OnJabRight;
            @JabRight.canceled += instance.OnJabRight;
            @JabLeft.started += instance.OnJabLeft;
            @JabLeft.performed += instance.OnJabLeft;
            @JabLeft.canceled += instance.OnJabLeft;
            @HookRight.started += instance.OnHookRight;
            @HookRight.performed += instance.OnHookRight;
            @HookRight.canceled += instance.OnHookRight;
            @HooksLeft.started += instance.OnHooksLeft;
            @HooksLeft.performed += instance.OnHooksLeft;
            @HooksLeft.canceled += instance.OnHooksLeft;
            @Uppercut.started += instance.OnUppercut;
            @Uppercut.performed += instance.OnUppercut;
            @Uppercut.canceled += instance.OnUppercut;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Walk.started -= instance.OnWalk;
            @Walk.performed -= instance.OnWalk;
            @Walk.canceled -= instance.OnWalk;
            @RightStick.started -= instance.OnRightStick;
            @RightStick.performed -= instance.OnRightStick;
            @RightStick.canceled -= instance.OnRightStick;
            @PowerPunch.started -= instance.OnPowerPunch;
            @PowerPunch.performed -= instance.OnPowerPunch;
            @PowerPunch.canceled -= instance.OnPowerPunch;
            @Block.started -= instance.OnBlock;
            @Block.performed -= instance.OnBlock;
            @Block.canceled -= instance.OnBlock;
            @JabRight.started -= instance.OnJabRight;
            @JabRight.performed -= instance.OnJabRight;
            @JabRight.canceled -= instance.OnJabRight;
            @JabLeft.started -= instance.OnJabLeft;
            @JabLeft.performed -= instance.OnJabLeft;
            @JabLeft.canceled -= instance.OnJabLeft;
            @HookRight.started -= instance.OnHookRight;
            @HookRight.performed -= instance.OnHookRight;
            @HookRight.canceled -= instance.OnHookRight;
            @HooksLeft.started -= instance.OnHooksLeft;
            @HooksLeft.performed -= instance.OnHooksLeft;
            @HooksLeft.canceled -= instance.OnHooksLeft;
            @Uppercut.started -= instance.OnUppercut;
            @Uppercut.performed -= instance.OnUppercut;
            @Uppercut.canceled -= instance.OnUppercut;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnRightStick(InputAction.CallbackContext context);
        void OnPowerPunch(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
        void OnJabRight(InputAction.CallbackContext context);
        void OnJabLeft(InputAction.CallbackContext context);
        void OnHookRight(InputAction.CallbackContext context);
        void OnHooksLeft(InputAction.CallbackContext context);
        void OnUppercut(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
