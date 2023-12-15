using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleMovement : MonoBehaviour
{
    public float speed;
    public Vector3 minPosition, maxPosition;
    private float horizontalInput;
    private float verticalInput;


    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 newPosition = transform.position;
        newPosition += Vector3.right * horizontalInput * speed * Time.deltaTime;
        newPosition += Vector3.forward * verticalInput * speed * Time.deltaTime;

        newPosition.x = Mathf.Clamp(newPosition.x, minPosition.x, maxPosition.x);
        newPosition.y = Mathf.Clamp(newPosition.y, minPosition.y, maxPosition.y);
        newPosition.z = Mathf.Clamp(newPosition.z, minPosition.z, maxPosition.z);

        transform.position = newPosition;
    }
}
