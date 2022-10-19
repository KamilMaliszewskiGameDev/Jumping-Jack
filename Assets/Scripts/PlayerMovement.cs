using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const int JUMPING_FORCE = 5;
    private const int MOVEMENT_SPEED = 3;

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
        if(Input.GetKeyDown(KeyCode.Space)){
            Jump();
        }
    }

    public void Jump(){
        playerRigidbody.velocity = Vector3.up * JUMPING_FORCE;
    }

    public void Walk(){
        if(Input.GetKey("up")){
            playerRigidbody.velocity = new Vector3(0, 0, 2);
        }
        if(Input.GetKey("down")){
            playerRigidbody.velocity = new Vector3(0, 0, -2);
        }
        if(Input.GetKey("left")){
            playerRigidbody.velocity = new Vector3(-2, 0, 0);
        }
        if(Input.GetKey("right")){
            playerRigidbody.velocity = new Vector3(2, 0, 0);
        }
    }
}
