using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour, IInteracted {

    [SerializeField] private Dialog dialogWithiRabbit;
 
    public void InteractObject() {
        dialogWithiRabbit.enabled = true;
 
            dialogWithiRabbit.dialogObject.SetActive(true);
            dialogWithiRabbit.StartDialog();
    }
    private void Awake() {
        dialogWithiRabbit.enabled = false;
    }


}

