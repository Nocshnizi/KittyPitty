using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class ParallaxController : MonoBehaviour
{
    Transform camera;
    Vector3 cameraStartPosition;
    float distance;

    GameObject[] backgrounds;
    Material[] materials;
    float[] backSpeed;

    float farthestBack;

    [Range(0f, 0.5f)]
    public float parallaxSpeed;

    void Start()
    {
        camera = Camera.main.transform;
        cameraStartPosition = camera.position;

        int backCounts = transform.childCount;
        materials = new Material[backCounts];
        backSpeed = new float[backCounts];
        backgrounds = new GameObject[backCounts];

        for(int i = 0; i < backCounts; i++) {
            backgrounds[i] = transform.GetChild(i).gameObject;
            materials[i] = backgrounds[i].GetComponent<Renderer>().sharedMaterial;
        }

        BackSpeedCalculate(backCounts);
    }

    void BackSpeedCalculate(int backCount) {
        for(int i = 0;i < backCount;i++) {//fatgherest background
            if ((backgrounds[i].transform.position.z - camera.position.z) > farthestBack) {
                farthestBack = backgrounds[i].transform.position.z - camera.position.z;
            }
        }

        for(int i = 0;i < backCount ; i++) {//set speed of backgrounds
            backSpeed[i] = 1 - (backgrounds[i].transform.position.z - camera.position.z) / farthestBack;
        }
    }

    private void LateUpdate() {
        distance = camera.position.x - cameraStartPosition.x;
        transform.position = new Vector3(camera.position.x + 20, transform.position.y, 0f);


        for(int i = 0; i < backgrounds.Length; i++) {
            float speed = backSpeed[i] * parallaxSpeed;
            materials[i].SetTextureOffset("_MainTex", new Vector2(distance, 0)*speed);
        }
    }

}
