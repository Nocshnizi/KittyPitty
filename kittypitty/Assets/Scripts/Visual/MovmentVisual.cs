using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentVisual : MonoBehaviour {

    [SerializeField] private GameInput gameInput;
    [SerializeField] private SuperMushroom superMushroom;
    //[SerializeField] private TeleportScript teleport;
    private Animator animator;
    private const string IS_WALKING = "IsWalking";
    private const string IS_JUMPING = "IsJumping";
    private const string IS_CLIMBING = "IsClimbing";
    private const string IS_TELEPORTING = "IsTeleporting";



    private void Start() {
        animator = GetComponent<Animator>();
    }

    public void SetAnimation() {
        animator.SetFloat("yVelocity", gameInput.rigidbody2D.velocity.y);
        

        if (!gameInput.IsGrounded() && gameInput.rigidbody2D.velocity.y != 0) {
            animator.SetBool(IS_JUMPING, true);
        }
        else {
            animator.SetBool(IS_JUMPING, false);
        }
        
        if (gameInput.IsWalking() && gameInput.IsGrounded()) {
            animator.SetBool(IS_WALKING, true);
        }
        else {
            animator.SetBool(IS_WALKING, false);
        }


        /*if (teleport.IsPossibleToTeleport()) {
            animator.SetBool(IS_TELEPORTING, true);
        }
        else {
            animator.SetBool(IS_TELEPORTING, false);
        }*/


       
    }



}
