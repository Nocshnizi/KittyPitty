using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class EyesLight : MonoBehaviour
{
    public GameObject eyesLight;
    private bool isEyesLightOn = false;
    void Start()
    {
        eyesLight.SetActive(isEyesLightOn);
    }

    public void IsEyesLightOn() {
        Debug.Log("IS EYES LIGHT ON YES" + isEyesLightOn);
        eyesLight.SetActive(!isEyesLightOn);
        isEyesLightOn = !isEyesLightOn;
    }
}
