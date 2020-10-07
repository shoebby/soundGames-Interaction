using UnityEngine;

public class rotation : MonoBehaviour
{
    public float rotationSpeed;
    public float moveSpeed;

    public void Update()
    {
        transform.RotateAround(transform.parent.position, new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);
    }
}
