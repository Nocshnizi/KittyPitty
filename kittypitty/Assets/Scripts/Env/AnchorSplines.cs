using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class testSplines : MonoBehaviour {

    [SerializeField] Rigidbody2D rb;

    private void Awake() {
        rb.bodyType = RigidbodyType2D.Static;
    }


    private void OnTriggerEnter2D(Collider2D collision) {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

}
