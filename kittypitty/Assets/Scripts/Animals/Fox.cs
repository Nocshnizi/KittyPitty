using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour, IInteracted {

    [SerializeField] private Dialog dialogWithFox;
    private void Awake() {
        dialogWithFox.enabled = false;
    }
    public void InteractObject() {
        dialogWithFox.enabled = true;
        dialogWithFox.dialogObject.SetActive(true);
        if (dialogWithFox.index == 0) {
            dialogWithFox.StartDialog();
        }

    }
}
