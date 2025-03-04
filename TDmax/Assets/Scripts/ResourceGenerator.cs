using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour {
   [SerializeField] private ResourceManager resourceManager;
private BuildingTypeSO buildingType;
 private float timer;
 private float timerMax;

 private void Awake() {
    buildingType = GetComponent<BuildingTypeHolder>().buildingType;
    timerMax = buildingType.resourceGeneratorData.timerMax;
 }

 private void Update () {
    timer -= Time.deltaTime;
    if (timer <= 0f) {
        timer += timerMax;
        Debug.Log("ASD" + buildingType.resourceGeneratorData.resourceType.nameString);
    }
 }
}