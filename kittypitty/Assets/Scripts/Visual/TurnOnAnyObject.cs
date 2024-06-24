using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnAnyObject : MonoBehaviour
{
    [SerializeField] List<GameObject> anyTurnOn;

   /* private void Awake() {
        for(int i = 0; i < anyTurnOn.Count; i++) {
            anyTurnOn[i].SetActive(false);
        }
        
    }*/

    private void OnTriggerEnter2D(Collider2D collision) {
        for (int i = 0; i < anyTurnOn.Count; i++) {
            anyTurnOn[i].SetActive(true);
        }
    }


}
