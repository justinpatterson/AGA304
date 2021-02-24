using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform playerTransform;
    public Animator playerAnimator;
    public float speed = 2f;

    private void Update()
    {
        HorizontalMovementBehavior();
        if (ShouldJump())
        {
            playerAnimator.SetTrigger("Jump");
        }
    }

    void HorizontalMovementBehavior()
    {
        Vector2 currentAcceleration = Input.acceleration;
        float keyboardHorizontal = Input.GetAxis("Horizontal");
        if (keyboardHorizontal != 0f)
        {
            currentAcceleration = new Vector2(keyboardHorizontal, 0f);
        }


        Vector3 currentPosition = playerTransform.position;
        Vector3 displacement = currentAcceleration * Time.deltaTime * speed;
        displacement.z = 0f;
        displacement.y = 0f;
        Vector3 nextPosition = currentPosition + displacement;

        //add some clamping to the "next position" in case it's out of bounds / etcetera etcetera

        playerTransform.position = nextPosition;
    }

    bool ShouldJump()
    {
        //Debug.Log("Input.Touches = " + Input.touches.Length);
        if(Input.touches.Length > 0 )
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                return true;
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            return true;
        }
        return false;
    }
}
