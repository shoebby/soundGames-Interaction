﻿using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.UIElements;

public class AlienMovement : MonoBehaviour
{
    public GameObject player;
    private PlayerControls playerControls;

    public int maxDistance;
    private int currentDistance;

    public float walkSpeed;
    public float runSpeed;
    public int hesitation;
    private float audioTimer = 0f;
    public float audioLoop;
    public float screamDelay;

    private enum AlienBehaviour { Idle, Approaching, Fleeing, Hiding };
    private AlienBehaviour currentState;
    private Vector3 dist;
    private float hideTimer = 0;
    private float idleTimer = 0;
    private float inputDelayTimer = 0;
    public float inputThreshold;
    private bool isReadyToScream = false;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start playing");
        currentDistance = maxDistance;
        currentState = AlienBehaviour.Idle;

        playerControls.Sounds.kralenKetting.performed += _ => ChangeBehaviourTo(AlienBehaviour.Approaching);

        playerControls.Sounds.klittenBand.performed += _ => ChangeBehaviourTo(AlienBehaviour.Approaching);

        playerControls.Sounds.liniaal.performed += _ => ChangeBehaviourTo(AlienBehaviour.Approaching);

        playerControls.Sounds.ocarina.performed += _ => ChangeBehaviourTo(AlienBehaviour.Fleeing);

        playerControls.Sounds.ijsSchep.performed += _ => ChangeBehaviourTo(AlienBehaviour.Fleeing);

        playerControls.Sounds.sleutels.performed += _ => ChangeBehaviourTo(AlienBehaviour.Hiding);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentDistance <= 0)
        {
            // you are a winner! :D
        }
        else if (currentDistance > maxDistance)
            currentDistance = maxDistance;

        dist = this.transform.position - player.transform.position;
        hideTimer = currentState == AlienBehaviour.Hiding ? hideTimer : 0;

        inputDelayTimer += Time.deltaTime;
        audioTimer += Time.deltaTime;
        if (audioTimer > audioLoop + screamDelay)
            isReadyToScream = true;

        // Call this part of the Update() loop if the alien needs to cry
        if (isReadyToScream)
        {
            PlayAlienVO("alienVoiceOver");
            audioTimer = 0f;
            isReadyToScream = false;
        }

        // Movement depends on the state of the alien
        switch (currentState)
        {
            case AlienBehaviour.Approaching:
                UpdateApproaching();
                break;
            case AlienBehaviour.Fleeing:
                UpdateFleeing();
                break;
            case AlienBehaviour.Hiding:
                UpdateHiding();
                break;
            case AlienBehaviour.Idle:
            default:
                UpdateIdle();
                break;
        }
    }

    void InputControl(AlienBehaviour state)
    {
        // Ignore input for a certain amount of time (below threshold)
        if (inputDelayTimer < inputThreshold)
            return;
        ChangeBehaviourTo(state);
    }

    void UpdateApproaching()
    {
        //Debug.Log("Approaching");

        // We need the alien to move towards the player
        if ((dist + dist.normalized).magnitude > dist.magnitude)
            dist = -dist;

        if (dist.magnitude > currentDistance)
            this.transform.position += dist.normalized * Time.deltaTime * walkSpeed;
        else
            ChangeBehaviourTo(AlienBehaviour.Idle);

    }

    void ChangeBehaviourTo(AlienBehaviour state)
    {
        Debug.Log("Changing behaviour to " + state);

        currentState = state;
        audioTimer = 0f;

        switch (state)
        {
            case AlienBehaviour.Approaching:
                currentDistance--;
                isReadyToScream = true;
                break;
            case AlienBehaviour.Fleeing:
                currentDistance++;
                isReadyToScream = true;
                break;
            default:
                break;
        }
    }

    void UpdateFleeing()
    {
        //Debug.Log("Fleeing");

        // We need the alien to move away from the player
        if ((dist + dist.normalized).magnitude < dist.magnitude)
            dist = -dist;

        if (dist.magnitude < currentDistance)
            this.transform.position += dist.normalized * Time.deltaTime * runSpeed;
        else
            ChangeBehaviourTo(AlienBehaviour.Idle);
    }

    void UpdateHiding()
    {
        //Debug.Log("Hiding");
        hideTimer += Time.deltaTime;
        if (hideTimer >= hesitation)
            ChangeBehaviourTo(AlienBehaviour.Idle);
    }

    void UpdateIdle()
    {
        idleTimer += Time.deltaTime * walkSpeed * 0.1f;
        Vector3 offset = new Vector3(Mathf.Sin(idleTimer), 0, Mathf.Cos(idleTimer)) * dist.magnitude;
        this.transform.position = player.transform.position + offset;
    }

    void PlayAlienVO(string clipname)
    {
        Debug.Log("alien screeeeech");

        int alienClipNumber = Random.Range(1, 18);

        FindObjectOfType<alienAudioManager>().AlienPlay(clipname + alienClipNumber);
    }

}
