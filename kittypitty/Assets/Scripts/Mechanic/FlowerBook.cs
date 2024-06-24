using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBook : MonoBehaviour {
    public GameObject[] flowerPages;
    public GameObject buttons;

    private int i = 0;

    public void OnBookFlowerPage() {
        // Ensure the current page and buttons are visible
        if (flowerPages.Length > 0) {
            flowerPages[i].SetActive(true);
        }
        buttons.SetActive(true);
        
    }

    public void OnBookFlowerPageClose() {
        // Hide the current page and buttons
        if (flowerPages.Length > 0) {
            flowerPages[i].SetActive(false);
        }
        buttons.SetActive(false);
        flowerPages[i].SetActive(false);
    }

    public void OnBookFlowerPageNext() {
        // Check if there are more pages to show
        if (i < flowerPages.Length - 1) {
            flowerPages[i].SetActive(false);
            i++;
            flowerPages[i].SetActive(true);
        }
        else {
            buttons.SetActive(false);
            flowerPages[i].SetActive(false);
        }
    }

    public void OnBookFlowerPagePrev() {
        // Check if we can go back to a previous page
        if (i > 0) {
            flowerPages[i].SetActive(false);
            i--;
            flowerPages[i].SetActive(true);
        }
        else {
            buttons.SetActive(false);
            flowerPages[i].SetActive(false);
        }
    }
}
