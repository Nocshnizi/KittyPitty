using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
{
    [SerializeField] private Dialog dialogWithWitch;
    private void Awake() {
        dialogWithWitch.enabled = false;
    }
    public void InteractObject() {
        dialogWithWitch.enabled = true;
        dialogWithWitch.dialogObject.SetActive(true);
        if (dialogWithWitch.index == 0) {
            dialogWithWitch.StartDialog();
        }

    }
}
