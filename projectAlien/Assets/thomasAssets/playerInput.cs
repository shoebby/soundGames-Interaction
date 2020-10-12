using UnityEngine;

public class playerInput : MonoBehaviour
{
    private PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void Start()
    {
        playerControls.Sounds.kralenKetting.performed += _ => playNoise("kralenketting");

        playerControls.Sounds.ijsSchep.performed += _ => playNoise("ijsschep");

        playerControls.Sounds.klittenBand.performed += _ => playNoise("klittenband");

        playerControls.Sounds.liniaal.performed += _ => playNoise("liniaal");

        playerControls.Sounds.ocarina.performed += _ => playNoise("ocarina");

        playerControls.Sounds.sleutels.performed += _ => playNoise("sleutels");
    }

    void playNoise(string clipName)
    {
        int clipNumber = Random.Range(1, 7);
        FindObjectOfType<playerAudioManager>().Play(clipName + clipNumber);
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
