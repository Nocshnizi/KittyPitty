using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonQuiz : MonoBehaviour
{
    [SerializeField] GameObject wind;
    [SerializeField] GameObject quiz;
    [SerializeField] GameObject arrows;
    [SerializeField] GameObject stoneLight;

    private void Awake() {
        wind.SetActive(false);
        arrows.SetActive(false);
        stoneLight.SetActive(false);
    }

    public void CorrectAnswer() {
        wind.SetActive(true);
        
        StartCoroutine(TimerToClose());
          stoneLight.SetActive(true);
        arrows.SetActive(true);

    }

    public void IncorrectAnswer() {
        stoneLight.SetActive(false);
        StartCoroutine(TimerToClose());
    }

    IEnumerator TimerToClose() {
        yield return new WaitForSeconds(1);
        quiz.SetActive(false);
      
    }
}
