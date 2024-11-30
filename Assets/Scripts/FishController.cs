using UnityEngine;

public class FishController : MonoBehaviour
{
    [SerializeField] private GameObject m_Fish;

    private float m_ActiveTime = 5f;

    private void Update()
    {
        if (!m_Fish.activeSelf & Time.time > m_ActiveTime)
        {
            m_Fish.SetActive(true);
        }
    }
}
