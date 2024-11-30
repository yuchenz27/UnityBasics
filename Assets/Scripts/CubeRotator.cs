using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 2f;
    
    private void Start()
    {
        //Debug.Log($"{gameObject.name} Start");
    }

    private void Update()
    {
        //Debug.Log($"{gameObject.name} Update {Time.time}");

        transform.Rotate(new Vector3(0f, rotationSpeed * Time.deltaTime, 0f));
    }
}
