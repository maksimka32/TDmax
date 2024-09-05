using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuldingManager : MonoBehaviour { 

    private Camera mainCamera;

    private void Start() {
        mainCamera = Camera.main;
   }
    private void Update() {
    {
    private Vector3 GetMouseWorldPosition() {
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        return mouseWorldPosition;
        }
    }
    }
}