using UnityEngine;

public class Fish : MonoBehaviour
{
    [SerializeField] private float m_MoveSpeed = 6f;

    [SerializeField] private MeshRenderer m_Renderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Fish active");
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Random.Range(-m_MoveSpeed, m_MoveSpeed);
        float moveY = Random.Range(-m_MoveSpeed, m_MoveSpeed);
        float moveZ = Random.Range(-m_MoveSpeed, m_MoveSpeed);
        transform.position += new Vector3(moveX, moveY, moveZ) * Time.deltaTime;

        float colorR = Random.Range(0f, 1f);
        float colorG = Random.Range(0f, 1f);
        float colorB = Random.Range(0f, 1f);
        m_Renderer.material.color = new Color(colorR, colorG, colorB, 1f);
    }
}
