using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class shit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var manager = GetComponent<ARTrackedImageManager>();
        var dat = manager.descriptor.Create();
    }
}
