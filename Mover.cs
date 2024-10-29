using UnityEngine;
using UnityEngine.Serialization;

public class Mover : MonoBehaviour
{
    [FormerlySerializedAs("moveSpeed")] [SerializeField] private float _moveSpeed = 0f;
    
    private void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
}
