using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_FallCube : Enemy
{
    public Vector3 FallDirection = Vector3.down;
    public Animator EnemyAnimator;

    public override void MovementBehavior()
    {
        base.MovementBehavior();
        if (_hasDied == false)
        {
            Vector3 currentPosition = transform.position;
            Vector3 nextPosition = currentPosition + (FallDirection * enemySpeed * Time.deltaTime);
            transform.position = nextPosition;
        }
    }

    public override void Die()
    {
        _hasDied = true;
        EnemyAnimator.SetTrigger("HasDied");
        Destroy(gameObject, .8f);

    }


    private void OnTriggerEnter(Collider other)
    {
        if (_hasDied == true)
            return;

        if (other.CompareTag("Player"))
        {
            //(1) HURT THE PLAYER

            //(2) DIE
            TakeDamage(maxHealth);
        }
        else if (other.CompareTag("Bounds"))
        {
            //(1) DIE
            TakeDamage(maxHealth);
        }
    }
}
