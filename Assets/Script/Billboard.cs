using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera mainCamera;
    
    void Start()
    {
        if (mainCamera == null)
            mainCamera = Camera.main;
    }
    
    void Update()
    {
        transform.LookAt(transform.position + mainCamera.transform.rotation * Vector3.forward,
            mainCamera.transform.rotation * Vector3.up);
    }
}
