using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

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

            Debug.Log($" beepppp beeeppp ! ");
        }
    }
}
