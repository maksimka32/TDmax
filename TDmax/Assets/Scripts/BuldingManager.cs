using UnityEngine;
public class BuildingManager : MonoBehaviour{
    private Camera mainCamera;
    [SerializeField] private BuildingTypeSO buildingType;
    private void Start() {
        mainCamera = Camera.main;
    }
    private Vector3 GetMouseWorldPosition(){
        Vector3 MousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        MousePos.z = 0f;
        return MousePos;
                }
    private void Update(){  
       if (Input.GetMouseButtonDown(0)) {
        Vector3 spawnPosition = GetMouseWorldPosition();
        Instantiate (buildingType.prefab, spawnPosition, Quaternion.identity);
       }
    }
}