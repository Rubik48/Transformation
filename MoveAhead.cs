using UnityEngine;

public class MoveAhead : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0f;
    private void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
