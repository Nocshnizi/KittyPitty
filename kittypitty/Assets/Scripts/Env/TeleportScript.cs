using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    [SerializeField] private Transform destination;
    [SerializeField] private GameObject player;
    private Animator animator;
    private bool isTeleported;

    private void Start() {
        animator = GetComponent<Animator>();

        isTeleported = false;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.CompareTag("Player") ) { 
           if(Vector2.Distance(player.transform.position, transform.position) > 0.3f) {
                player.transform.position = destination.transform.position;
                isTeleported = true;
           } 
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            isTeleported = false;
        }
        
    }


    public bool IsPossibleToTeleport() {
        return isTeleported;
    }

}
