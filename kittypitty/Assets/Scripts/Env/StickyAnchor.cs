using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyAnchor : MonoBehaviour {
    [SerializeField] Transform player;
    [SerializeField] GameInput gamePlayerObject;

    private float numForStandingOnAnchor = 0.6f;
    private float numForJumpOutOfAnchor = 0.7f;

    private bool onAnchor;

    private void Awake() {
        onAnchor = false;
 
    }

    private void FixedUpdate() {
        if (onAnchor == true) {
            player.position = new Vector2(transform.position.x, transform.position.y + numForStandingOnAnchor - 2.57967f);

            if (Input.GetKeyDown(KeyCode.Space)) {
                player.position = new Vector2(transform.position.x, transform.position.y + numForJumpOutOfAnchor );
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision) {
         if (collision.gameObject.CompareTag("Player")) {
            onAnchor = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        onAnchor = false;
    }
}
