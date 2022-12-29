using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public Joystick joystick;
    private float moveInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        joystick = GameObject.FindGameObjectWithTag("JoystickObject").GetComponent<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = joystick.Vertical;
        playerDirection = new Vector2(0, moveInput).normalized;
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
