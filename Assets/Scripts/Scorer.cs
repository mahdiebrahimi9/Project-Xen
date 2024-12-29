using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log($"You've Bumped into a thing  this many times : {hits} ");
    }

}
