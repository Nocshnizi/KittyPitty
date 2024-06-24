using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockBackgroundLogic : MonoBehaviour
{
    private void Update() {
        transform.up = Vector2.up;
        transform.localScale = Vector2.one;        
    }
}
