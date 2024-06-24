using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperMushroom : MonoBehaviour
{
    [SerializeField] GameInput gameInput;
    [SerializeField] LayerMask superMushroom;

    public float mushroomJump = 9f;

    public bool isSuperMushroom() {
        return Physics2D.OverlapCircle(gameInput.groundChek.position, 0.3f, superMushroom);
    }

    private void Update() {
        if(isSuperMushroom()) {
            gameInput.rigidbody2D.velocity = new Vector2(gameInput.rigidbody2D.velocity.x, mushroomJump);
        } 
    }
     
}
