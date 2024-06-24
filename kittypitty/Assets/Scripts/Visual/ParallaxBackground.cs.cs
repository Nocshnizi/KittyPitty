using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ParallaxBackground : MonoBehaviour
{
   Material material;
    float distance;

    [Range(0f, 0.5f)]
    public float speed = 0.2f; 
    private void Start() {
        material = GetComponent<Renderer>().sharedMaterial;
    }

    private void Update() {
        distance += Time.deltaTime * speed;
        material.SetTextureOffset("_MainTex", Vector2.right *  distance);
    }
}