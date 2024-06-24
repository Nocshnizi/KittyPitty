using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PinkMonsterPIPA : MonoBehaviour, IInteracted {

    public Dialog dialogWithPipa;
    [SerializeField] private GameObject heart;
    private void Awake() {
        dialogWithPipa.enabled = false;
        heart.SetActive(false);
    }

    private void Update() {
        if(dialogWithPipa.index == 12) {
            heart.SetActive(true);
        }
    }

    public void InteractObject() {
        dialogWithPipa.enabled = true;
        dialogWithPipa.dialogObject.SetActive(true);
        if (dialogWithPipa.index == 0) {
            dialogWithPipa.StartDialog();
        }

    }
}
