using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitScene : MonoBehaviour
{
    public AudioSource voiceOver;
    public AudioClip voiceOverClip;
    private PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();

        voiceOver = gameObject.AddComponent<AudioSource>();
    }

    void Start()
    {
        voiceOver.PlayOneShot(voiceOverClip);

        playerControls.Menus.pressStart.performed += _ => ExitApplication();
    }

    void ExitApplication()
    {
        Application.Quit();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
}
