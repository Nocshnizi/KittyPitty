using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigSeller : MonoBehaviour {

    [SerializeField] private Piggy piggy;
    [SerializeField] private GameObject smoke;
    private bool isFacingRight;

    private void Start() {
        piggy.OnSellerRemove += Piggy_OnSellerRemove; 
    }

    private void Piggy_OnSellerRemove(object sender, EventArgs e) {
        if (piggy.dialogWithPiggy.index == 15 && isFacingRight) {
            Flip(piggy.gameObject);
            Instantiate(smoke, this.gameObject.transform);
            piggy.OnSellerRemove -= Piggy_OnSellerRemove;
            Destroy(gameObject, 0.6f);
        }
    }

    private void Flip(GameObject gameObject) {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        gameObject.transform.localScale = localScale;
    }



    private void Awake() {
        isFacingRight = true;
    }


}
