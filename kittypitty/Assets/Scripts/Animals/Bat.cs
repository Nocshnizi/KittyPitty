using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour, IInteracted {

    [SerializeField] private Dialog dialogWithBat;
    private void Awake() {
        dialogWithBat.enabled = false;
    }
    public void InteractObject() {
        dialogWithBat.enabled = true;
        dialogWithBat.dialogObject.SetActive(true);
        if (dialogWithBat.index == 0) {
            dialogWithBat.StartDialog();
        }

    }

}
