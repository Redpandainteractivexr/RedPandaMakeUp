using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARFaceFilters : MonoBehaviour
{
    [SerializeField]
    private ARFaceManager faceManager;
    [SerializeField]
    private List<Material> FaceMaterials = new List<Material>();

    // private int materialIndex;

    // Start is called before the first frame update
    void Start()
    {
        faceManager = GetComponent<ARFaceManager>();
    }

    public void FaceFilter(int index)
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<Renderer>().material = FaceMaterials[index];
        }
    }
}
