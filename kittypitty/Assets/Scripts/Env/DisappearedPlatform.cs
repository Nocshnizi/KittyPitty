using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

public class DisappearedPlatform : MonoBehaviour {
    [SerializeField] private GameObject platform;
    [SerializeField] private GameObject smoke;

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            transform.DOShakePosition(2, new Vector3(0.15f,0,0), 15, 0, false, true);
            StartCoroutine(Timer(2));
        }
    }

    private IEnumerator Timer(int seconds) {
        yield return new WaitForSeconds(seconds);
        Instantiate(smoke, this.gameObject.transform);
        Destroy(platform, 0.4f);
    }



}