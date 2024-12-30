using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] GameObject projectTile;
    [SerializeField] GameObject projectTile2;
    [SerializeField] GameObject projectTile3;
    [SerializeField] GameObject projectTile4;
    [SerializeField] GameObject projectTile5;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projectTile.SetActive(true);
            projectTile2.SetActive(true);
            projectTile3.SetActive(true);
            projectTile4.SetActive(true);
            projectTile5.SetActive(true);
        }
    }
}
