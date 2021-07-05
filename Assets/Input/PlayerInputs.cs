// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""b4379303-d25a-439a-a3a9-f22be94619b3"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""964cbb5b-47ca-455b-92ae-d7ae0f425c81"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""View"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a0968ed2-77b6-4f5a-8afd-5cf9ef5a57e2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SprintStart"",
                    ""type"": ""Button"",
                    ""id"": ""0d0a8114-0355-4f9d-967c-8e2682ead46f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SprintFinish"",
                    ""type"": ""Button"",
                    ""id"": ""c4805c94-3a63-4843-a8fb-ec0d005850dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""fa418583-8ab7-462c-88a1-c3d30da77d3c"",
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
                    ""id"": ""2e212ac8-5c04-4fd0-847f-31efccf076c6"",
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
                    ""id"": ""aec20fae-75f2-49ee-bfb9-717c0a5a5d5e"",
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
                    ""id"": ""869e63d2-9046-4263-ad93-27e71e11b3c4"",
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
                    ""id"": ""948391f4-7e1f-48e6-9a79-7acee2af865c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bd5862b6-8c83-4a84-bd7f-d4ff2f6f9274"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e91f183e-b7e8-4146-95c4-750ff4aa080e"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SprintStart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94ecf2ca-068f-4129-8329-e2d5a2afaf17"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SprintFinish"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Actions"",
            ""id"": ""231f4471-3358-4dd5-a2cc-1903eb5300a2"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3d362fdb-8227-4c87-9f92-1eb015243249"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SuperJump"",
                    ""type"": ""Button"",
                    ""id"": ""2e092b06-22e0-419e-8870-3886550e635d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""09498960-0577-4a55-9e5c-c412cfafd9db"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6ad5c81-1e90-4a36-8a0c-1ab57b4ab09c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold(duration=3,pressPoint=0.5)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SuperJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MouseScroll"",
            ""id"": ""954c8de5-3855-4706-afec-221277a68b89"",
            ""actions"": [
                {
                    ""name"": ""Scroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c47cf45e-6b5c-4fbb-907d-66a6ceba1f7f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""80142eab-fccc-4be1-a247-00006029cd26"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Movement = m_Movement.FindAction("Movement", throwIfNotFound: true);
        m_Movement_View = m_Movement.FindAction("View", throwIfNotFound: true);
        m_Movement_SprintStart = m_Movement.FindAction("SprintStart", throwIfNotFound: true);
        m_Movement_SprintFinish = m_Movement.FindAction("SprintFinish", throwIfNotFound: true);
        // Actions
        m_Actions = asset.FindActionMap("Actions", throwIfNotFound: true);
        m_Actions_Jump = m_Actions.FindAction("Jump", throwIfNotFound: true);
        m_Actions_SuperJump = m_Actions.FindAction("SuperJump", throwIfNotFound: true);
        // MouseScroll
        m_MouseScroll = asset.FindActionMap("MouseScroll", throwIfNotFound: true);
        m_MouseScroll_Scroll = m_MouseScroll.FindAction("Scroll", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Movement;
    private readonly InputAction m_Movement_View;
    private readonly InputAction m_Movement_SprintStart;
    private readonly InputAction m_Movement_SprintFinish;
    public struct MovementActions
    {
        private @PlayerInputs m_Wrapper;
        public MovementActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Movement_Movement;
        public InputAction @View => m_Wrapper.m_Movement_View;
        public InputAction @SprintStart => m_Wrapper.m_Movement_SprintStart;
        public InputAction @SprintFinish => m_Wrapper.m_Movement_SprintFinish;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovement;
                @View.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnView;
                @View.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnView;
                @View.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnView;
                @SprintStart.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprintStart;
                @SprintStart.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprintStart;
                @SprintStart.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprintStart;
                @SprintFinish.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprintFinish;
                @SprintFinish.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprintFinish;
                @SprintFinish.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprintFinish;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @View.started += instance.OnView;
                @View.performed += instance.OnView;
                @View.canceled += instance.OnView;
                @SprintStart.started += instance.OnSprintStart;
                @SprintStart.performed += instance.OnSprintStart;
                @SprintStart.canceled += instance.OnSprintStart;
                @SprintFinish.started += instance.OnSprintFinish;
                @SprintFinish.performed += instance.OnSprintFinish;
                @SprintFinish.canceled += instance.OnSprintFinish;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Actions
    private readonly InputActionMap m_Actions;
    private IActionsActions m_ActionsActionsCallbackInterface;
    private readonly InputAction m_Actions_Jump;
    private readonly InputAction m_Actions_SuperJump;
    public struct ActionsActions
    {
        private @PlayerInputs m_Wrapper;
        public ActionsActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Actions_Jump;
        public InputAction @SuperJump => m_Wrapper.m_Actions_SuperJump;
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnJump;
                @SuperJump.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSuperJump;
                @SuperJump.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSuperJump;
                @SuperJump.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnSuperJump;
            }
            m_Wrapper.m_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @SuperJump.started += instance.OnSuperJump;
                @SuperJump.performed += instance.OnSuperJump;
                @SuperJump.canceled += instance.OnSuperJump;
            }
        }
    }
    public ActionsActions @Actions => new ActionsActions(this);

    // MouseScroll
    private readonly InputActionMap m_MouseScroll;
    private IMouseScrollActions m_MouseScrollActionsCallbackInterface;
    private readonly InputAction m_MouseScroll_Scroll;
    public struct MouseScrollActions
    {
        private @PlayerInputs m_Wrapper;
        public MouseScrollActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Scroll => m_Wrapper.m_MouseScroll_Scroll;
        public InputActionMap Get() { return m_Wrapper.m_MouseScroll; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseScrollActions set) { return set.Get(); }
        public void SetCallbacks(IMouseScrollActions instance)
        {
            if (m_Wrapper.m_MouseScrollActionsCallbackInterface != null)
            {
                @Scroll.started -= m_Wrapper.m_MouseScrollActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_MouseScrollActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_MouseScrollActionsCallbackInterface.OnScroll;
            }
            m_Wrapper.m_MouseScrollActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
            }
        }
    }
    public MouseScrollActions @MouseScroll => new MouseScrollActions(this);
    public interface IMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnView(InputAction.CallbackContext context);
        void OnSprintStart(InputAction.CallbackContext context);
        void OnSprintFinish(InputAction.CallbackContext context);
    }
    public interface IActionsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnSuperJump(InputAction.CallbackContext context);
    }
    public interface IMouseScrollActions
    {
        void OnScroll(InputAction.CallbackContext context);
    }
}
