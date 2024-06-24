using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EButtonVisual : MonoBehaviour
{
    private Animator animator;
    private const string IS_INTERACTING = "IsInteracting";
    [SerializeField] private GameObject button;


    private void Start() {
        animator = GetComponent<Animator>();
    }

    public void EButtonOFF() {
        animator.SetBool(IS_INTERACTING, false);
    }
    public void EButtonON() {
        animator.SetBool(IS_INTERACTING, true);
    }
}
