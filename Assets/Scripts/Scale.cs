using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float scaleSpeed = 2f;

    //private float scaleValue = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //scaleValue = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        float scaleValue = scaleSpeed * Time.deltaTime;
        transform.localScale = transform.localScale + new Vector3(scaleValue, scaleValue, scaleValue);
    }

    public void ChangeScaleValue(float newValue)
    {
        //scaleValue = newValue;
    }
}