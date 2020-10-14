using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenInteraction : MonoBehaviour
{
    public AudioSource voiceOver;
    public AudioClip voiceOverClip;
    private PlayerControls playerControls;

    public string sceneName;

    private void Awake()
    {
        playerControls = new PlayerControls();

        voiceOver = gameObject.AddComponent<AudioSource>();
    }

    void Start()
    {
        voiceOver.PlayOneShot(voiceOverClip);

        playerControls.Menus.pressStart.performed += _ => SceneSwitch(sceneName);
    }

    void SceneSwitch(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
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
