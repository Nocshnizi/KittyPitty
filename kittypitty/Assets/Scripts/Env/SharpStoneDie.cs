using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SharpStoneDie : MonoBehaviour
{
    [SerializeField] private Transform respam;
    [SerializeField] private GameObject player;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            StartCoroutine(Respam());
        }
    }


    IEnumerator Respam() {
        player.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        player.transform.position = respam.position;
        player.SetActive(true);
    }

         

}
