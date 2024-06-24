using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chamomile : MonoBehaviour, IInteracted {

    [SerializeField] private GameObject info;
    private Animator animator;
    private bool isTriggered = true;
    private const string CLOSEBOOK = "CloseBook";
    private void Start() {
        animator = info.GetComponent<Animator>();
        info.SetActive(!isTriggered);
    }

    public void InteractObject() {
        info.SetActive(true);
        isTriggered = !isTriggered;

        if (isTriggered) {
            StartCoroutine(TimerAnimation());
        }
        else {
            animator.SetBool(CLOSEBOOK, false);
        }
    }

    IEnumerator TimerAnimation() {
        animator.SetBool(CLOSEBOOK, true);
        yield return new WaitForSeconds(0.3f);
        info.SetActive(false);

    }

    private void OnTriggerExit2D(Collider2D collision) {
        StartCoroutine(TimerAnimation());
    }
}
