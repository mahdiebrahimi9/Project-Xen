using UnityEngine;
using UnityEngine.InputSystem.Controls;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 10f;

    void Start()
    {
        InterStringLog();

    }

    void Update()
    {
        MovePlayer();
    }
   
    void InterStringLog()
    {
        Debug.Log("Welcome To My Game");
    }
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}
