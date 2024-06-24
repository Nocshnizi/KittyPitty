using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffAnyObject : MonoBehaviour
{
    [SerializeField] List<GameObject> anyTurnOff;

    private void OnTriggerEnter2D(Collider2D collision) {
        for (int i = 0; i < anyTurnOff.Count; i++) {
            anyTurnOff[i].SetActive(false);
        }
    }


}
