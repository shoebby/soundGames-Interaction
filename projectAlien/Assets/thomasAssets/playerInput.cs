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

        playerControls.Sounds.chipsZak.performed += _ => playNoise("chipszak");

        playerControls.Sounds.eiSnijder.performed += _ => playNoise("eisnijder");

        playerControls.Sounds.ijsSchep.performed += _ => playNoise("ijsschep");

        playerControls.Sounds.klittenBand.performed += _ => playNoise("klittenband");

        playerControls.Sounds.legoDoos.performed += _ => playNoise("legodoos");

        playerControls.Sounds.liniaal.performed += _ => playNoise("liniaal");

        playerControls.Sounds.muis.performed += _ => playNoise("muis");

        playerControls.Sounds.ocarina.performed += _ => playNoise("ocarina");

        playerControls.Sounds.pen.performed += _ => playNoise("pen");

        playerControls.Sounds.sleutels.performed += _ => playNoise("sleutels");

        playerControls.Sounds.zandKoker.performed += _ => playNoise("zandkoker");
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
