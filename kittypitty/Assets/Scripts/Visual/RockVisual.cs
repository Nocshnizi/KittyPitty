using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockVisual : MonoBehaviour {
    [SerializeField] private Rigidbody2D rb;

    private Animator animator;
    private const string IS_MOVING = "isMoving";

    private void FixedUpdate() {
        SetAnimation();
    }

    private void Start() {
        animator = GetComponent<Animator>();
        
    }

    private void SetAnimation() {
        if(rb.velocity.x > 1 || rb.velocity.x < -1) {
            animator.SetBool(IS_MOVING, true);
        }
        else {
            animator.SetBool(IS_MOVING, false);
        }
    }
}
