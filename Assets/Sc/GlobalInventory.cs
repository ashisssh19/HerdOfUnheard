using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalInventory : MonoBehaviour
{
    public static bool firstDoorKey = false;
    public bool internalDoorKey;
    // Start is called before the first frame update
    void Update()
    {
        internalDoorKey = firstDoorKey;
    }
}
