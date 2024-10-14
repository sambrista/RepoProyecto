using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position; 
    }
    void OnMove(InputValue movementValue)
    {
        // Convert the input value into a Vector2 for movement.
        Vector2 movementVector = movementValue.Get<Vector2>();

        // Store the X and Y components of the movement.
        transform.rotation = new Quaternion(movementVector.x, movementVector.y, transform.rotation.z, transform.rotation.w); 
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset; 
    }


}
