using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speedIncrease;

    private void Update()
    {
        transform.localScale += Vector3.one * _speedIncrease * Time.deltaTime;
    }
}
