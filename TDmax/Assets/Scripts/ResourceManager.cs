using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance { get; private set; }

  

    private Dictionary<ResourceTypeSO, int> resourceAmountDictionary;
          
    private void Awake() { 
        Instance = this;
        resourceAmountDictionary = new Dictionary<ResourceTypeSO, int>();
 
       ResourceTypeListSO resourceTypeList = Resources.Load<ResourceTypeListSO>(typeof(ResourceTypeListSO).Name);

       foreach (ResourceTypeSO resourceType in resourceTypeList.list) 
       {
        resourceAmountDictionary[resourceType] = 0;
       }
   
    }
      private void TestLogResourceAmountDictionary()
       {
    
      
        foreach (ResourceTypeSO resourceType in resourceAmountDictionary.Keys) 
        {
            Debug.Log(resourceType.nameString + ": " + resourceAmountDictionary[resourceType]);
        }
     }
       
    }

