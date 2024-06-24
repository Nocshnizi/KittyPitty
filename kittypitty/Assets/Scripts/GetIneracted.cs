using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetIneracted : MonoBehaviour
{
    [SerializeField] private GameInput player;

    private void Awake() {
         player.OnObjectDetection += Player_OnObjectDetection;
    }

    private void Player_OnObjectDetection(object sender, System.EventArgs e) {
        ObjectDetection();
    }

    public void ObjectDetection() {

        Collider2D collider2D = Physics2D.OverlapCircle(player.wallCheck.position, 0.2f, player.objectLayer);
        if (collider2D) {
            if (collider2D.TryGetComponent(out IInteracted objectOut)) {
                if (objectOut != this) {
                    player.SetSelectedObject(objectOut);
                    Interact(objectOut);
                }
            }

            else {

                player.SetSelectedObject(null);
            }
        }

        else {
            player.SetSelectedObject(null);
            player.EButton.SetActive(false);
        }
    }

    private void Interact(IInteracted iObject) {
        iObject.InteractObject();
    }
}
