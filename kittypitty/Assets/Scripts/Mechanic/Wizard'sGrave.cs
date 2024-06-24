using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardsGrave : MonoBehaviour, IInteracted {

    [SerializeField] private GameObject wind;

    private void Start() {
        wind.SetActive(false);
    }

    public void InteractObject() {
        Debug.Log("i open a wind for you!");
        wind.SetActive(true);
    }
}
