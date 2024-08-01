using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlaceBuild : MonoBehaviour
{
    public GameObject building;

    // Метод для создания здания
    public void PlaceBuildsMethod(Vector3 position, Quaternion rotation)
    {
        if (building != null)
        {
            Instantiate(building, position, rotation);
        }
        else
        {
            Debug.LogError("Building prefab is not assigned.");
        }
    }
}
