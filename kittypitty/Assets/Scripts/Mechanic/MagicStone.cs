using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicStone : MonoBehaviour, IInteracted
{
    [SerializeField] private GameObject quiz;

    private void Start() {
        quiz.SetActive(false);
    }

    public void InteractObject() {
        quiz.SetActive(true);
    }



}
