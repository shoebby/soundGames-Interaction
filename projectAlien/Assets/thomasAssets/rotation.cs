using UnityEngine;

public class rotation : MonoBehaviour
{
    public float rotationSpeed;
    public float moveSpeed;

    private PlayerControls playerControls;

    private void Awake()
    {
        playerControls = new PlayerControls();
    }

    private void Start()
    {
        playerControls.Alien.randomSound.performed += _ => playAlienVO("alienVoiceOver");
    }

    public void Update()
    {
        transform.RotateAround(transform.parent.position, new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);
    }

    void playAlienVO(string clipname)
    {
        Debug.Log("alien screeeeech");
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
