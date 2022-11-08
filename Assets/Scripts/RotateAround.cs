using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField] private Space _space = Space.Self;
    [SerializeField] private Vector3 _anglesPerSec;

    void Update()
    {
        transform.Rotate(_anglesPerSec * Time.deltaTime, _space);
    }
}
