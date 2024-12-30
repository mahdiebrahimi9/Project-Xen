using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;

    MeshRenderer meshRenderer;
    Rigidbody rigidbody;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;

        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {

        DropTime();
    
    }


    void DropTime()
    {

        if (Time.time > timeToWait)
        {

            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
