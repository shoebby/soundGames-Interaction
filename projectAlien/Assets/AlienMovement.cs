using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.UIElements;

public class AlienMovement : MonoBehaviour
{
    public GameObject player;
    private PlayerControls playerControls;

    public int maxEmotion;
    private int currentEmotion;

    public float walkSpeed;
    public float runSpeed;
    public int hesitation;
    public float audioTimer = 0f;

    private enum AlienBehaviour { Idle, Approaching, Fleeing, Hiding };
    private AlienBehaviour currentState;
    private Vector3 dist;
    private float hideTimer = 0;
    private float idleTimer = 0;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start playing");
        currentEmotion = maxEmotion;
        currentState = AlienBehaviour.Idle;

        playerControls.Sounds.kralenKetting.performed += _ => changeBehaviourTo(AlienBehaviour.Approaching);

        playerControls.Sounds.klittenBand.performed += _ => changeBehaviourTo(AlienBehaviour.Approaching);

        playerControls.Sounds.legoDoos.performed += _ => changeBehaviourTo(AlienBehaviour.Approaching);

        playerControls.Sounds.liniaal.performed += _ => changeBehaviourTo(AlienBehaviour.Approaching);

        playerControls.Sounds.chipsZak.performed += _ => changeBehaviourTo(AlienBehaviour.Fleeing);

        playerControls.Sounds.ocarina.performed += _ => changeBehaviourTo(AlienBehaviour.Fleeing);

        playerControls.Sounds.ijsSchep.performed += _ => changeBehaviourTo(AlienBehaviour.Fleeing);

        playerControls.Sounds.muis.performed += _ => changeBehaviourTo(AlienBehaviour.Hiding);

        playerControls.Sounds.eiSnijder.performed += _ => changeBehaviourTo(AlienBehaviour.Hiding);

        playerControls.Sounds.pen.performed += _ => changeBehaviourTo(AlienBehaviour.Hiding);

        playerControls.Sounds.sleutels.performed += _ => changeBehaviourTo(AlienBehaviour.Hiding);

        playerControls.Sounds.zandKoker.performed += _ => changeBehaviourTo(AlienBehaviour.Hiding);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentEmotion <= 0)
        {
            // you are a winner! :D
        }
        else if (currentEmotion > maxEmotion)
            currentEmotion = maxEmotion;

        dist = this.transform.position - player.transform.position;
        hideTimer = currentState == AlienBehaviour.Hiding ? hideTimer : 0;

        audioTimer += Time.deltaTime;
        if (audioTimer > 5f)
        {
            audioTimer = 0f;

            playAlienVO("alienVoiceOver");

           
        }

        // Conditions to trigger certain behaviour
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    currentEmotion -= 1;
        //    changeBehaviourTo(AlienBehaviour.Approaching);
        //}
        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    changeBehaviourTo(AlienBehaviour.Fleeing);
        //}

        // Movement depends on the state of the alien
        switch (currentState)
        {
            case AlienBehaviour.Approaching:
                updateApproaching();
                break;
            case AlienBehaviour.Fleeing:
                updateFleeing();
                break;
            case AlienBehaviour.Hiding:
                updateHiding();
                break;
            case AlienBehaviour.Idle:
            default:
                updateIdle();
                break;
        }
    }

    void updateApproaching()
    {
        //Debug.Log("Approaching");

        // We need the alien to move towards the player
        if ((dist + dist.normalized).magnitude > dist.magnitude)
            dist = -dist;

        if (dist.magnitude > currentEmotion)
            move(walkSpeed);
        else
            changeBehaviourTo(AlienBehaviour.Idle);

    }

    void changeBehaviourTo(AlienBehaviour state)
    {
        Debug.Log("Changing behaviour to " + state);

        currentState = state;
        audioTimer = 0;

        switch (state)
        {
            case AlienBehaviour.Approaching:
                currentEmotion--;
                playAlienVO("alienVoiceOver");
                break;
            case AlienBehaviour.Fleeing:
                currentEmotion++;
                playAlienVO("alienVoiceOver");
                break;
            default:
                break;
        }

        
    }


    void updateFleeing()
    {
        //Debug.Log("Fleeing");

        // We need the alien to move away from the player
        if ((dist + dist.normalized).magnitude < dist.magnitude)
            dist = -dist;

        if (dist.magnitude < currentEmotion)
            move(runSpeed);
        else
            changeBehaviourTo(AlienBehaviour.Idle);
    }

    void updateHiding()
    {
        //Debug.Log("Hiding");
        hideTimer += Time.deltaTime;
        if (hideTimer >= hesitation)
            changeBehaviourTo(AlienBehaviour.Idle);
    }

    void move(float speed) {
        this.transform.position += dist.normalized * Time.deltaTime * speed;
    }

    void updateIdle()
    {
        idleTimer += Time.deltaTime * walkSpeed * 0.1f;
        Vector3 offset = new Vector3(Mathf.Sin(idleTimer), 0, Mathf.Cos(idleTimer)) * dist.magnitude;
        this.transform.position = player.transform.position + offset;
    }

    void playAlienVO(string clipname)
    {
        Debug.Log("alien screeeeech");

        int alienClipNumber = Random.Range(1, 18);

        FindObjectOfType<alienAudioManager>().AlienPlay(clipname + alienClipNumber);
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
