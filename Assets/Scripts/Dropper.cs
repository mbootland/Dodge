using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    // Variables
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
    
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
        myMeshRenderer.enabled = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            myRigidbody.useGravity = true;
            myMeshRenderer.enabled = true;
        }
    }
}
