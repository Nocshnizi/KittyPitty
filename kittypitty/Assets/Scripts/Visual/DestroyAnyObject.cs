using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAnyObject : MonoBehaviour
{
    [SerializeField] private List<GameObject> destroyObjectList;

    private void OnTriggerEnter2D(Collider2D collision) {
        foreach (GameObject obj in destroyObjectList) {
            Destroy(obj);
        }
    }
}
