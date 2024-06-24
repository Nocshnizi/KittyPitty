using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineVisual : MonoBehaviour, IInteracted {

    [SerializeField] GameObject[] pages;
    private bool isShown = false;

    private void Start() {
        for (int i = 0; i < pages.Length; i++) {
            pages[i].SetActive(isShown);
        }  
    }

    public void InteractObject() {
        for (int i = 0; i < pages.Length; i++) {
            pages[i].SetActive(!isShown);
            isShown = !isShown;
        }
    }
}
