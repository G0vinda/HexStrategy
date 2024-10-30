//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Input/Controls.inputactions
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

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""c08e998a-6331-45e5-8e29-8b8d1803f5d5"",
            ""actions"": [
                {
                    ""name"": ""PointerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""20fbd17f-bd66-4119-938f-373ffb3ff8d7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MainPointerDown"",
                    ""type"": ""Button"",
                    ""id"": ""f0083a93-fd69-4e35-b3f5-db8d6dc50ef0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MainPointerUp"",
                    ""type"": ""Button"",
                    ""id"": ""16f8579f-5bc6-48c7-a027-0c6cc20ab62d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""d9c7fa9b-d526-4118-9d10-3cd15b88f666"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TestSwitchCycle"",
                    ""type"": ""Button"",
                    ""id"": ""ed90d52b-1d3a-4eb6-a668-97b1df3788c7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ZoomScroll"",
                    ""type"": ""Value"",
                    ""id"": ""aaf40730-3a1a-47c4-8bfa-9a1777a2a5a4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""255be60f-dac2-4ee0-bb2e-110a8ec4d47b"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard & Mouse"",
                    ""action"": ""PointerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22eb8355-d878-4fe6-9689-6eea9b0e9787"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard & Mouse"",
                    ""action"": ""MainPointerDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""788efeb7-f887-4085-8be1-0d2ae830dc33"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard & Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0886fd98-528a-4e92-b2b3-e7431615e702"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard & Mouse"",
                    ""action"": ""TestSwitchCycle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50b90715-9ab4-45fe-afda-44d0fbc9eaf3"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard & Mouse"",
                    ""action"": ""ZoomScroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfcd833b-b863-455d-b18e-28cb6b2496c3"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MainPointerUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_PointerPosition = m_Player.FindAction("PointerPosition", throwIfNotFound: true);
        m_Player_MainPointerDown = m_Player.FindAction("MainPointerDown", throwIfNotFound: true);
        m_Player_MainPointerUp = m_Player.FindAction("MainPointerUp", throwIfNotFound: true);
        m_Player_RightClick = m_Player.FindAction("RightClick", throwIfNotFound: true);
        m_Player_TestSwitchCycle = m_Player.FindAction("TestSwitchCycle", throwIfNotFound: true);
        m_Player_ZoomScroll = m_Player.FindAction("ZoomScroll", throwIfNotFound: true);
    }

    ~@Controls()
    {
        UnityEngine.Debug.Assert(!m_Player.enabled, "This will cause a leak and performance issues, Controls.Player.Disable() has not been called.");
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
    private readonly InputAction m_Player_PointerPosition;
    private readonly InputAction m_Player_MainPointerDown;
    private readonly InputAction m_Player_MainPointerUp;
    private readonly InputAction m_Player_RightClick;
    private readonly InputAction m_Player_TestSwitchCycle;
    private readonly InputAction m_Player_ZoomScroll;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PointerPosition => m_Wrapper.m_Player_PointerPosition;
        public InputAction @MainPointerDown => m_Wrapper.m_Player_MainPointerDown;
        public InputAction @MainPointerUp => m_Wrapper.m_Player_MainPointerUp;
        public InputAction @RightClick => m_Wrapper.m_Player_RightClick;
        public InputAction @TestSwitchCycle => m_Wrapper.m_Player_TestSwitchCycle;
        public InputAction @ZoomScroll => m_Wrapper.m_Player_ZoomScroll;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @PointerPosition.started += instance.OnPointerPosition;
            @PointerPosition.performed += instance.OnPointerPosition;
            @PointerPosition.canceled += instance.OnPointerPosition;
            @MainPointerDown.started += instance.OnMainPointerDown;
            @MainPointerDown.performed += instance.OnMainPointerDown;
            @MainPointerDown.canceled += instance.OnMainPointerDown;
            @MainPointerUp.started += instance.OnMainPointerUp;
            @MainPointerUp.performed += instance.OnMainPointerUp;
            @MainPointerUp.canceled += instance.OnMainPointerUp;
            @RightClick.started += instance.OnRightClick;
            @RightClick.performed += instance.OnRightClick;
            @RightClick.canceled += instance.OnRightClick;
            @TestSwitchCycle.started += instance.OnTestSwitchCycle;
            @TestSwitchCycle.performed += instance.OnTestSwitchCycle;
            @TestSwitchCycle.canceled += instance.OnTestSwitchCycle;
            @ZoomScroll.started += instance.OnZoomScroll;
            @ZoomScroll.performed += instance.OnZoomScroll;
            @ZoomScroll.canceled += instance.OnZoomScroll;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @PointerPosition.started -= instance.OnPointerPosition;
            @PointerPosition.performed -= instance.OnPointerPosition;
            @PointerPosition.canceled -= instance.OnPointerPosition;
            @MainPointerDown.started -= instance.OnMainPointerDown;
            @MainPointerDown.performed -= instance.OnMainPointerDown;
            @MainPointerDown.canceled -= instance.OnMainPointerDown;
            @MainPointerUp.started -= instance.OnMainPointerUp;
            @MainPointerUp.performed -= instance.OnMainPointerUp;
            @MainPointerUp.canceled -= instance.OnMainPointerUp;
            @RightClick.started -= instance.OnRightClick;
            @RightClick.performed -= instance.OnRightClick;
            @RightClick.canceled -= instance.OnRightClick;
            @TestSwitchCycle.started -= instance.OnTestSwitchCycle;
            @TestSwitchCycle.performed -= instance.OnTestSwitchCycle;
            @TestSwitchCycle.canceled -= instance.OnTestSwitchCycle;
            @ZoomScroll.started -= instance.OnZoomScroll;
            @ZoomScroll.performed -= instance.OnZoomScroll;
            @ZoomScroll.canceled -= instance.OnZoomScroll;
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
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnPointerPosition(InputAction.CallbackContext context);
        void OnMainPointerDown(InputAction.CallbackContext context);
        void OnMainPointerUp(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnTestSwitchCycle(InputAction.CallbackContext context);
        void OnZoomScroll(InputAction.CallbackContext context);
    }
}
