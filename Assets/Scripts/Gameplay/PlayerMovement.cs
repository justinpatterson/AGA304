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
        Vector3 currentPosition = playerTransform.position;
        Vector3 displacement = currentAcceleration * Time.deltaTime * 2f;
        displacement.z = 0f;
        displacement.y = 0f;
        Vector3 nextPosition = playerTransform.position + displacement;
        playerTransform.position = nextPosition;
    }

    bool ShouldJump()
    {
        Debug.Log("Input.Touches = " + Input.touches.Length);
        if(Input.touches.Length > 0 )
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                return true;
            }
        }
        return false;
    }

    IEnumerator DoJump()
    {
        yield return null;
    }
}
