using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lavander : MonoBehaviour, IInteracted {
    [SerializeField] private GameObject infoPrefab;
    [SerializeField] private GameObject parent;
    [SerializeField] private FlowerBook book;
    private Animator animator;
    private bool isOpened = false;
    private const string CLOSEBOOK = "CloseBook";
    private GameObject currentInfo;


    private void Start() {

    }

    public void InteractObject() {
        if (!isOpened) {
            if (currentInfo == null) {
                currentInfo = Instantiate(infoPrefab, parent.transform);
                animator = currentInfo.GetComponent<Animator>();
                book.flowerPages[2] = currentInfo;
            }
            else {
                currentInfo.SetActive(true);
            }

            isOpened = true;
            animator.SetBool(CLOSEBOOK, false);
        }
        else {
            isOpened = false;
            if (animator != null) {
                animator.SetBool(CLOSEBOOK, true);
            }
            StartCoroutine(TimerAnimation());
        }
    }

    IEnumerator TimerAnimation() {
        animator.SetBool(CLOSEBOOK, true);
        yield return new WaitForSeconds(0.3f);
        if (currentInfo != null) {
            currentInfo.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        StartCoroutine(TimerAnimation());
    }
}
