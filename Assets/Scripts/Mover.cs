using UnityEngine;
using UnityEngine.InputSystem.Controls;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1f;

    void Start()
    {

    }

    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }
}
