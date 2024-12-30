using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log($"You've Bumped into a thing  this many times : {hits} ");
        }

    }

}
