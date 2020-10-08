using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.UIElements;

public class AlienMovement : MonoBehaviour
{
    public GameObject player;

    public int maxEmotion;
    private int currentEmotion;

    public float walkSpeed;
    public float runSpeed;
    public int hesitation;

    private enum AlienBehaviour { Idle, Approaching, Fleeing, Hiding };
    private AlienBehaviour currentState;
    private Vector3 dist;
    private float hideTimer;
    private float idleTimer;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start playing");
        currentEmotion = maxEmotion;
        currentState = AlienBehaviour.Idle;
        hideTimer = 0;
        idleTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        dist = this.transform.position - player.transform.position;
        hideTimer = currentState == AlienBehaviour.Hiding ? hideTimer : 0;

        // Conditions to trigger certain behaviour
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentEmotion -= 1;
            changeBehaviourTo(AlienBehaviour.Approaching);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            changeBehaviourTo(AlienBehaviour.Fleeing);
        }

        Debug.Log("Switch (" + currentState + ")");
        // Movement depends on the state of the alien
        switch (currentState)
        {
            case AlienBehaviour.Approaching:
                approaching();
                break;
            case AlienBehaviour.Fleeing:
                fleeing();
                break;
            case AlienBehaviour.Hiding:
                hiding();
                break;
            case AlienBehaviour.Idle:
            default:
                movingIdle();
                break;
        }

    }

    void approaching()
    {
        Debug.Log("Approaching");
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
    }


    void fleeing()
    {
        Debug.Log("Fleeing");
        currentEmotion = maxEmotion;
        // We need the alien to move away from the player
        if ((dist + dist.normalized).magnitude < dist.magnitude)
            dist = -dist;

        if (dist.magnitude < maxEmotion)
            move(runSpeed);
        else
            changeBehaviourTo(AlienBehaviour.Hiding);
    }

    void hiding()
    {
        Debug.Log("Hiding");
        hideTimer += Time.deltaTime;

        if (hideTimer >= hesitation)
            changeBehaviourTo(AlienBehaviour.Idle);
    }

    void move(float speed) {
        this.transform.position += dist.normalized * Time.deltaTime * speed;
    }

    void movingIdle()
    {
        Debug.Log("Moving idle");
        idleTimer += Time.deltaTime * walkSpeed * 0.1f;
        Debug.Log("idleTimer is now " + idleTimer);

        Vector3 offset = new Vector3(Mathf.Sin(idleTimer), 0, Mathf.Cos(idleTimer)) * dist.magnitude;
        Debug.Log("Offset: " + offset);
        this.transform.position = player.transform.position + offset;
    }

}
