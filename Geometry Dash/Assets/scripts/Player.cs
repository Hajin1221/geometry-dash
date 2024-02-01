using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PhysicsObject
{

    [SerializeField] private float MaxSpeed;
    [SerializeField] private float JumpPower;

    private int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetVelocity = new Vector2(direction*MaxSpeed, 0);

        if (Input.GetButtonDown("Jump") && grounded)
        {
            velocity.y = JumpPower;
        }

    }
}
