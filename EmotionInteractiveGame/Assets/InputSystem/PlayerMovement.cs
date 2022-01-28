// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/PlayerMovement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerMovement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""Player actions"",
            ""id"": ""795891aa-5f68-4244-9c08-1317ec2901a8"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""59cfa1be-0e91-4f35-adba-2a1b32164a04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""13a40930-1af4-4f8d-b7ac-9036a9ecd44f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6fa3c519-c47d-4e4a-bf40-ee720dc6614a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3c2cc56b-5e6d-4844-9ffb-cdc49135dfa4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f0dd345a-99cd-4362-9bd1-6545f8876430"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e6ebbc9c-336a-440d-aee8-a0758a781beb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player actions
        m_Playeractions = asset.FindActionMap("Player actions", throwIfNotFound: true);
        m_Playeractions_Movement = m_Playeractions.FindAction("Movement", throwIfNotFound: true);
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

    // Player actions
    private readonly InputActionMap m_Playeractions;
    private IPlayeractionsActions m_PlayeractionsActionsCallbackInterface;
    private readonly InputAction m_Playeractions_Movement;
    public struct PlayeractionsActions
    {
        private @PlayerMovement m_Wrapper;
        public PlayeractionsActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Playeractions_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Playeractions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayeractionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayeractionsActions instance)
        {
            if (m_Wrapper.m_PlayeractionsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayeractionsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayeractionsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayeractionsActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayeractionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayeractionsActions @Playeractions => new PlayeractionsActions(this);
    public interface IPlayeractionsActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
