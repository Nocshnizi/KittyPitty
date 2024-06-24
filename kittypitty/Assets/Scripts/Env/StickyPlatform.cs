using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour {
    [SerializeField] GameInput player;

    private void OnCollisionEnter2D(Collision2D collision) {
         if (player.IsGrounded() && collision.gameObject.CompareTag("Player")) {
            player.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision) {
        player.transform.SetParent(null);
    }
}
