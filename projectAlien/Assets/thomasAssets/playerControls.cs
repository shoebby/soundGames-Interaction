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
                    ""name"": ""chipsZak"",
                    ""type"": ""Button"",
                    ""id"": ""de4ae71e-5c0d-404b-b1eb-e02b017f9f38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""eiSnijder"",
                    ""type"": ""Button"",
                    ""id"": ""35daa635-3c13-4fe7-8319-9d886da84547"",
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
                    ""name"": ""legoDoos"",
                    ""type"": ""Button"",
                    ""id"": ""a2604200-62ba-428b-ae26-9ab298337f40"",
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
                    ""name"": ""muis"",
                    ""type"": ""Button"",
                    ""id"": ""4b4d63c5-a880-4aca-973f-dc3539c0c32a"",
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
                    ""name"": ""pen"",
                    ""type"": ""Button"",
                    ""id"": ""7c58aa8c-e309-4525-a2cf-11887781787c"",
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
                },
                {
                    ""name"": ""zandKoker"",
                    ""type"": ""Button"",
                    ""id"": ""5fa28f69-b5d0-430c-bcf1-af6b6f7b205f"",
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
                    ""id"": ""cda9effb-87df-4ac7-b6c4-813254ab6476"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""chipsZak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e48140a3-a8d7-4fc4-9430-3fd4a840a6b0"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""eiSnijder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73c74ae3-fa3f-467a-a03a-d9344857bda0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
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
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""klittenBand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39025563-fb8c-4653-8148-36e7f4867af6"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""legoDoos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6695947-b80a-44c2-9798-4c726b2ed105"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""liniaal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4bff0fba-53d8-4073-a972-3e60d43e00aa"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""muis"",
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
                    ""id"": ""e91442f9-8ac7-48d5-8b97-5b7d1f89a7fb"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pen"",
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
                    ""id"": ""8d1f54f2-26ef-45b3-97f8-3fe98372f9b1"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""zandKoker"",
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
        m_Sounds_chipsZak = m_Sounds.FindAction("chipsZak", throwIfNotFound: true);
        m_Sounds_eiSnijder = m_Sounds.FindAction("eiSnijder", throwIfNotFound: true);
        m_Sounds_ijsSchep = m_Sounds.FindAction("ijsSchep", throwIfNotFound: true);
        m_Sounds_klittenBand = m_Sounds.FindAction("klittenBand", throwIfNotFound: true);
        m_Sounds_legoDoos = m_Sounds.FindAction("legoDoos", throwIfNotFound: true);
        m_Sounds_liniaal = m_Sounds.FindAction("liniaal", throwIfNotFound: true);
        m_Sounds_muis = m_Sounds.FindAction("muis", throwIfNotFound: true);
        m_Sounds_ocarina = m_Sounds.FindAction("ocarina", throwIfNotFound: true);
        m_Sounds_pen = m_Sounds.FindAction("pen", throwIfNotFound: true);
        m_Sounds_sleutels = m_Sounds.FindAction("sleutels", throwIfNotFound: true);
        m_Sounds_zandKoker = m_Sounds.FindAction("zandKoker", throwIfNotFound: true);
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
    private readonly InputAction m_Sounds_chipsZak;
    private readonly InputAction m_Sounds_eiSnijder;
    private readonly InputAction m_Sounds_ijsSchep;
    private readonly InputAction m_Sounds_klittenBand;
    private readonly InputAction m_Sounds_legoDoos;
    private readonly InputAction m_Sounds_liniaal;
    private readonly InputAction m_Sounds_muis;
    private readonly InputAction m_Sounds_ocarina;
    private readonly InputAction m_Sounds_pen;
    private readonly InputAction m_Sounds_sleutels;
    private readonly InputAction m_Sounds_zandKoker;
    public struct SoundsActions
    {
        private @PlayerControls m_Wrapper;
        public SoundsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @kralenKetting => m_Wrapper.m_Sounds_kralenKetting;
        public InputAction @chipsZak => m_Wrapper.m_Sounds_chipsZak;
        public InputAction @eiSnijder => m_Wrapper.m_Sounds_eiSnijder;
        public InputAction @ijsSchep => m_Wrapper.m_Sounds_ijsSchep;
        public InputAction @klittenBand => m_Wrapper.m_Sounds_klittenBand;
        public InputAction @legoDoos => m_Wrapper.m_Sounds_legoDoos;
        public InputAction @liniaal => m_Wrapper.m_Sounds_liniaal;
        public InputAction @muis => m_Wrapper.m_Sounds_muis;
        public InputAction @ocarina => m_Wrapper.m_Sounds_ocarina;
        public InputAction @pen => m_Wrapper.m_Sounds_pen;
        public InputAction @sleutels => m_Wrapper.m_Sounds_sleutels;
        public InputAction @zandKoker => m_Wrapper.m_Sounds_zandKoker;
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
                @chipsZak.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnChipsZak;
                @chipsZak.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnChipsZak;
                @chipsZak.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnChipsZak;
                @eiSnijder.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnEiSnijder;
                @eiSnijder.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnEiSnijder;
                @eiSnijder.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnEiSnijder;
                @ijsSchep.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnIjsSchep;
                @ijsSchep.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnIjsSchep;
                @ijsSchep.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnIjsSchep;
                @klittenBand.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnKlittenBand;
                @klittenBand.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnKlittenBand;
                @klittenBand.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnKlittenBand;
                @legoDoos.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnLegoDoos;
                @legoDoos.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnLegoDoos;
                @legoDoos.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnLegoDoos;
                @liniaal.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnLiniaal;
                @liniaal.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnLiniaal;
                @liniaal.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnLiniaal;
                @muis.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnMuis;
                @muis.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnMuis;
                @muis.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnMuis;
                @ocarina.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnOcarina;
                @ocarina.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnOcarina;
                @ocarina.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnOcarina;
                @pen.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnPen;
                @pen.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnPen;
                @pen.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnPen;
                @sleutels.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnSleutels;
                @sleutels.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnSleutels;
                @sleutels.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnSleutels;
                @zandKoker.started -= m_Wrapper.m_SoundsActionsCallbackInterface.OnZandKoker;
                @zandKoker.performed -= m_Wrapper.m_SoundsActionsCallbackInterface.OnZandKoker;
                @zandKoker.canceled -= m_Wrapper.m_SoundsActionsCallbackInterface.OnZandKoker;
            }
            m_Wrapper.m_SoundsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @kralenKetting.started += instance.OnKralenKetting;
                @kralenKetting.performed += instance.OnKralenKetting;
                @kralenKetting.canceled += instance.OnKralenKetting;
                @chipsZak.started += instance.OnChipsZak;
                @chipsZak.performed += instance.OnChipsZak;
                @chipsZak.canceled += instance.OnChipsZak;
                @eiSnijder.started += instance.OnEiSnijder;
                @eiSnijder.performed += instance.OnEiSnijder;
                @eiSnijder.canceled += instance.OnEiSnijder;
                @ijsSchep.started += instance.OnIjsSchep;
                @ijsSchep.performed += instance.OnIjsSchep;
                @ijsSchep.canceled += instance.OnIjsSchep;
                @klittenBand.started += instance.OnKlittenBand;
                @klittenBand.performed += instance.OnKlittenBand;
                @klittenBand.canceled += instance.OnKlittenBand;
                @legoDoos.started += instance.OnLegoDoos;
                @legoDoos.performed += instance.OnLegoDoos;
                @legoDoos.canceled += instance.OnLegoDoos;
                @liniaal.started += instance.OnLiniaal;
                @liniaal.performed += instance.OnLiniaal;
                @liniaal.canceled += instance.OnLiniaal;
                @muis.started += instance.OnMuis;
                @muis.performed += instance.OnMuis;
                @muis.canceled += instance.OnMuis;
                @ocarina.started += instance.OnOcarina;
                @ocarina.performed += instance.OnOcarina;
                @ocarina.canceled += instance.OnOcarina;
                @pen.started += instance.OnPen;
                @pen.performed += instance.OnPen;
                @pen.canceled += instance.OnPen;
                @sleutels.started += instance.OnSleutels;
                @sleutels.performed += instance.OnSleutels;
                @sleutels.canceled += instance.OnSleutels;
                @zandKoker.started += instance.OnZandKoker;
                @zandKoker.performed += instance.OnZandKoker;
                @zandKoker.canceled += instance.OnZandKoker;
            }
        }
    }
    public SoundsActions @Sounds => new SoundsActions(this);
    public interface ISoundsActions
    {
        void OnKralenKetting(InputAction.CallbackContext context);
        void OnChipsZak(InputAction.CallbackContext context);
        void OnEiSnijder(InputAction.CallbackContext context);
        void OnIjsSchep(InputAction.CallbackContext context);
        void OnKlittenBand(InputAction.CallbackContext context);
        void OnLegoDoos(InputAction.CallbackContext context);
        void OnLiniaal(InputAction.CallbackContext context);
        void OnMuis(InputAction.CallbackContext context);
        void OnOcarina(InputAction.CallbackContext context);
        void OnPen(InputAction.CallbackContext context);
        void OnSleutels(InputAction.CallbackContext context);
        void OnZandKoker(InputAction.CallbackContext context);
    }
}
