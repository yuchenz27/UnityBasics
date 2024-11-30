using UnityEngine;

public class Run : MonoBehaviour
{
    [SerializeField] private float runSpeed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0f, 0f, runSpeed * Time.deltaTime);
    }
}
