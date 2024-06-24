using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour, IInteracted {

    [SerializeField] private Dialog dialogWithBear;
    private void Awake() {
        dialogWithBear.enabled = false;
    }
    public void InteractObject() {
        dialogWithBear.enabled = true;
        dialogWithBear.dialogObject.SetActive(true);
        if(dialogWithBear.index == 0) {
            dialogWithBear.StartDialog();
        }
        
    }
}
