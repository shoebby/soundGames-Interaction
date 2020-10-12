// GENERATED AUTOMATICALLY FROM 'Assets/thomasAssets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Sounds"",
            ""id"": ""2e354374-f287-476b-999e-7f531832063c"",
            ""actions"": [
                {
                    ""name"": ""kralenKetting"",
                    ""type"": ""Button"",
                    ""id"": ""93314822-adce-46fa-9d96-2561e63f94a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ijsSchep"",
                    ""type"": ""Button"",
                    ""id"": ""ce20d07f-b15e-46bc-9fe8-ba54d72ae625"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""klittenBand"",
                    ""type"": ""Button"",
                    ""id"": ""559ae414-5435-4d1d-a547-5e5a43760565"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""liniaal"",
                    ""type"": ""Button"",
                    ""id"": ""1606efee-f90e-4763-a04b-38df880988d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ocarina"",
                    ""type"": ""Button"",
                    ""id"": ""d8c37138-c95a-4447-b843-c4cb042eb411"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""sleutels"",
                    ""type"": ""Button"",
                    ""id"": ""62bd100c-78e2-4e39-a0ec-b029b055407b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e97877e7-659a-4822-81b4-80709958488e"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""kralenKetting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73c74ae3-fa3f-467a-a03a-d9344857bda0"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ijsSchep"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1b695ad-106b-44c1-8fc2-da801a0678a2"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""klittenBand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6695947-b80a-44c2-9798-4c726b2ed105"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""liniaal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0201bf7-617b-4437-b758-e69a60c281be"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ocarina"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edd0ae17-194a-4c41-ba20-377fca1a6bc9"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ocarina"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f3baa5e-252e-4f65-aaf2-4db48974e380"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sleutels"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f628b34-f538-432c-a413-830945dd1da1"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sleutels"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Alien"",
            ""id"": ""9473d1c7-d934-4b5c-b982-6f841480a816"",
            ""actions"": [
                {
                    ""name"": ""randomSound"",
                    ""type"": ""Button"",
                    ""id"": ""abf5888d-ed10-45a9-b28b-89ee191e57dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5478fab6-bb2d-4a64-97c3-7bd873b4f542"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""randomSound"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Sounds
        m_Sounds = asset.FindActionMap("Sounds", throwIfNotFound: true);
        m_Sounds_kralenKetting = m_Sounds.FindAction("kralenKetting", throwIfNotFound: true);
        m_Sounds_ijsSchep = m_Sounds.FindAction("ijsSchep", throwIfNotFound: true);
        m_Sounds_klittenBand = m_Sounds.FindAction("klittenBand", throwIfNotFound: true);
        m_Sounds_liniaal = m_Sounds.FindAction("liniaal", throwIfNotFound: true);
        m_Sounds_ocarina = m_Sounds.FindAction("ocarina", throwIfNotFound: true);
        m_Sounds_sleutels = m_Sounds.FindAction("sleutels", throwIfNotFound: true);
        // Alien
        m_Alien = asset.FindActionMap("Alien", throwIfNotFound: true);
        m_Alien_randomSound = m_Alien.FindAction("randomSound", throwIfNotFound: true);
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

    // Sounds
    private readonly InputActionMap m_Sounds;
    private ISoundsActions m_SoundsActionsCallbackInterface;
    private readonly InputAction m_Sounds_kralenKetting;
    private readonly InputAction m_Sounds_ijsSchep;
    private readonly InputAction m_Sounds_klittenBand;
    private readonly InputAction m_Sounds_liniaal;
    private readonly InputAction m_Sounds_ocarina;
    private readonly InputAction m_Sounds_sleutels;
    public struct SoundsActions
    {
        private @PlayerControls m_Wrapper;
        public SoundsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @kralenKetting => m_Wrapper.m_Sounds_kralenKetting;
        public InputAction @ijsSchep => m_Wrapper.m_Sounds_ijsSchep;
        public InputAction @klittenBand => m_Wrapper.m_Sounds_klittenBand;
        public InputAction @liniaal => m_Wrapper.m_Sounds_liniaal;
        public InputAction @ocarina => m_Wrapper.m_Sounds_ocarina;
        public InputAction @sleutels => m_Wrapper.m_Sounds_sleutels;
        public InputActionMap Get() { return m_Wrapper.m_Sounds; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SoundsActions set) { return set.Get(); }
        public void SetCallbacks(ISoundsActions instance)
        {
            if (m_Wrapper.m_SoundsActionsCallbackInterface != null)
            {
                @kralenKetting.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnKralenKetting;
                @kralenKetting.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnKralenKetting;
                @kralenKetting.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnKralenKetting;
                @ijsSchep.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnIjsSchep;
                @ijsSchep.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnIjsSchep;
                @ijsSchep.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnIjsSchep;
                @klittenBand.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnKlittenBand;
                @klittenBand.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnKlittenBand;
                @klittenBand.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnKlittenBand;
                @liniaal.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnLiniaal;
                @liniaal.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnLiniaal;
                @liniaal.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnLiniaal;
                @ocarina.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnOcarina;
                @ocarina.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnOcarina;
                @ocarina.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnOcarina;
                @sleutels.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnSleutels;
                @sleutels.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnSleutels;
                @sleutels.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnSleutels;
            }
            m_Wrapper.m_SoundsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @kralenKetting.started += instance.OnKralenKetting;
                @kralenKetting.performed += instance.OnKralenKetting;
                @kralenKetting.canceled += instance.OnKralenKetting;
                @ijsSchep.started += instance.OnIjsSchep;
                @ijsSchep.performed += instance.OnIjsSchep;
                @ijsSchep.canceled += instance.OnIjsSchep;
                @klittenBand.started += instance.OnKlittenBand;
                @klittenBand.performed += instance.OnKlittenBand;
                @klittenBand.canceled += instance.OnKlittenBand;
                @liniaal.started += instance.OnLiniaal;
                @liniaal.performed += instance.OnLiniaal;
                @liniaal.canceled += instance.OnLiniaal;
                @ocarina.started += instance.OnOcarina;
                @ocarina.performed += instance.OnOcarina;
                @ocarina.canceled += instance.OnOcarina;
                @sleutels.started += instance.OnSleutels;
                @sleutels.performed += instance.OnSleutels;
                @sleutels.canceled += instance.OnSleutels;
            }
        }
    }
    public SoundsActions @Sounds => new SoundsActions(this);

    // Alien
    private readonly InputActionMap m_Alien;
    private IAlienActions m_AlienActionsCallbackInterface;
    private readonly InputAction m_Alien_randomSound;
    public struct AlienActions
    {
        private @PlayerControls m_Wrapper;
        public AlienActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @randomSound => m_Wrapper.m_Alien_randomSound;
        public InputActionMap Get() { return m_Wrapper.m_Alien; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AlienActions set) { return set.Get(); }
        public void SetCallbacks(IAlienActions instance)
        {
            if (m_Wrapper.m_AlienActionsCallbackInterface != null)
            {
                @randomSound.started -= m_Wrapper.m_AlienActionsCallbackInterface.OnRandomSound;
                @randomSound.performed -= m_Wrapper.m_AlienActionsCallbackInterface.OnRandomSound;
                @randomSound.canceled -= m_Wrapper.m_AlienActionsCallbackInterface.OnRandomSound;
            }
            m_Wrapper.m_AlienActionsCallbackInterface = instance;
            if (instance != null)
            {
                @randomSound.started += instance.OnRandomSound;
                @randomSound.performed += instance.OnRandomSound;
                @randomSound.canceled += instance.OnRandomSound;
            }
        }
    }
    public AlienActions @Alien => new AlienActions(this);
    public interface ISoundsActions
    {
        void OnKralenKetting(InputAction.CallbackContext context);
        void OnIjsSchep(InputAction.CallbackContext context);
        void OnKlittenBand(InputAction.CallbackContext context);
        void OnLiniaal(InputAction.CallbackContext context);
        void OnOcarina(InputAction.CallbackContext context);
        void OnSleutels(InputAction.CallbackContext context);
    }
    public interface IAlienActions
    {
        void OnRandomSound(InputAction.CallbackContext context);
    }
}
