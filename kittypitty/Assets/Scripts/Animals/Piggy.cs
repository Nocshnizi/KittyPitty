using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Piggy : MonoBehaviour, IInteracted {

    public event EventHandler OnSellerRemove;

    public Dialog dialogWithPiggy;


    private void Awake() {
        dialogWithPiggy.enabled = false;    
    }

    private void Update() {
        OnSellerRemove?.Invoke(this, EventArgs.Empty);
    }


    public void InteractObject() {
        dialogWithPiggy.enabled = true;
        dialogWithPiggy.dialogObject.SetActive(true);
        if (dialogWithPiggy.index == 0) {
            dialogWithPiggy.StartDialog();
        }

    }


}
