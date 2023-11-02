using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
        => transform.position += new Vector3(0, 0, _speed * Time.deltaTime);
}//сосоать