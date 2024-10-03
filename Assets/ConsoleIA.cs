//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/ConsoleIA.inputactions
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

public partial class @ConsoleIA: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ConsoleIA()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ConsoleIA"",
    ""maps"": [
        {
            ""name"": ""Console"",
            ""id"": ""c37108e5-8068-4307-93d2-499fa0fc9821"",
            ""actions"": [
                {
                    ""name"": ""OpenConsole"",
                    ""type"": ""Button"",
                    ""id"": ""58bd3f8d-58ac-4f65-b9f7-802ca6c7613f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CloseConsole"",
                    ""type"": ""Button"",
                    ""id"": ""256d8724-8753-4984-9786-93a3e025da89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SubmitCommand"",
                    ""type"": ""Button"",
                    ""id"": ""9953530a-f301-4769-8750-c247c1325797"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3d8f0797-571c-4dc5-b062-0feab645ac49"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OpenConsole"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""03d82b3a-7f15-4856-9473-f0f8d0b85164"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseConsole"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""a994c578-f88b-4b20-a9de-18c070741254"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseConsole"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""d5f5516d-e356-4011-af1d-4551a732ebca"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CloseConsole"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""df18c48a-9b64-4444-90e4-8abe17413bb9"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SubmitCommand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Console
        m_Console = asset.FindActionMap("Console", throwIfNotFound: true);
        m_Console_OpenConsole = m_Console.FindAction("OpenConsole", throwIfNotFound: true);
        m_Console_CloseConsole = m_Console.FindAction("CloseConsole", throwIfNotFound: true);
        m_Console_SubmitCommand = m_Console.FindAction("SubmitCommand", throwIfNotFound: true);
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

    // Console
    private readonly InputActionMap m_Console;
    private List<IConsoleActions> m_ConsoleActionsCallbackInterfaces = new List<IConsoleActions>();
    private readonly InputAction m_Console_OpenConsole;
    private readonly InputAction m_Console_CloseConsole;
    private readonly InputAction m_Console_SubmitCommand;
    public struct ConsoleActions
    {
        private @ConsoleIA m_Wrapper;
        public ConsoleActions(@ConsoleIA wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenConsole => m_Wrapper.m_Console_OpenConsole;
        public InputAction @CloseConsole => m_Wrapper.m_Console_CloseConsole;
        public InputAction @SubmitCommand => m_Wrapper.m_Console_SubmitCommand;
        public InputActionMap Get() { return m_Wrapper.m_Console; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ConsoleActions set) { return set.Get(); }
        public void AddCallbacks(IConsoleActions instance)
        {
            if (instance == null || m_Wrapper.m_ConsoleActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ConsoleActionsCallbackInterfaces.Add(instance);
            @OpenConsole.started += instance.OnOpenConsole;
            @OpenConsole.performed += instance.OnOpenConsole;
            @OpenConsole.canceled += instance.OnOpenConsole;
            @CloseConsole.started += instance.OnCloseConsole;
            @CloseConsole.performed += instance.OnCloseConsole;
            @CloseConsole.canceled += instance.OnCloseConsole;
            @SubmitCommand.started += instance.OnSubmitCommand;
            @SubmitCommand.performed += instance.OnSubmitCommand;
            @SubmitCommand.canceled += instance.OnSubmitCommand;
        }

        private void UnregisterCallbacks(IConsoleActions instance)
        {
            @OpenConsole.started -= instance.OnOpenConsole;
            @OpenConsole.performed -= instance.OnOpenConsole;
            @OpenConsole.canceled -= instance.OnOpenConsole;
            @CloseConsole.started -= instance.OnCloseConsole;
            @CloseConsole.performed -= instance.OnCloseConsole;
            @CloseConsole.canceled -= instance.OnCloseConsole;
            @SubmitCommand.started -= instance.OnSubmitCommand;
            @SubmitCommand.performed -= instance.OnSubmitCommand;
            @SubmitCommand.canceled -= instance.OnSubmitCommand;
        }

        public void RemoveCallbacks(IConsoleActions instance)
        {
            if (m_Wrapper.m_ConsoleActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IConsoleActions instance)
        {
            foreach (var item in m_Wrapper.m_ConsoleActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ConsoleActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ConsoleActions @Console => new ConsoleActions(this);
    public interface IConsoleActions
    {
        void OnOpenConsole(InputAction.CallbackContext context);
        void OnCloseConsole(InputAction.CallbackContext context);
        void OnSubmitCommand(InputAction.CallbackContext context);
    }
}