using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private const float JUMPING_FORCE = 5f;
    [SerializeField] private const float MOVEMENT_SPEED = 3f;

    private Rigidbody playerRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        Jump();
    }

    public void Jump(){
        if(Input.GetButtonDown("Jump")){
            playerRigidbody.velocity = new Vector3(playerRigidbody.velocity.x, JUMPING_FORCE, playerRigidbody.velocity.z);
        }
    }

    public void Walk(){
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRigidbody.velocity = new Vector3(horizontalInput * MOVEMENT_SPEED, playerRigidbody.velocity.y, verticalInput * MOVEMENT_SPEED);
    }
}
