using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public GameObject dialogObject;
    public string[] lines;
    public float textSpeed;
 
    public int index;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Mouse0) && this.enabled) {
            if(textComponent.text == lines[index]) {
                NextLine();
            }
            else {
               StopAllCoroutines();
               textComponent.text = lines[index];
            }
        }
    }

    public void StartDialog() {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine() {
        foreach (char line in lines[index].ToCharArray()) {
            textComponent.text += line;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine() {
        if(index < lines.Length-1) {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine (TypeLine());
        }
        else {
            this.enabled = false;
            textComponent.text = string.Empty;
            dialogObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        StopAllCoroutines();
        textComponent.text = string.Empty;
        dialogObject.SetActive(false);
        this.enabled = false;
        index = 0;
    }
}
