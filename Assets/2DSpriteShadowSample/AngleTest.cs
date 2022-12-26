using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class AngleTest : MonoBehaviour
{
    [Range(10f, 80f)]
    public float m_cameraAngle = 45f;
    public Transform m_rotateObject;
    public Transform m_groundObject;
    public Transform m_characterObject;
    
    // Update is called once per frame
    void Update()
    {
        if (m_rotateObject != null)
        {
            m_rotateObject.transform.localEulerAngles = new Vector3 (m_cameraAngle, 0f, 0f);
        }

        if (m_groundObject != null)
        {
            float groundScale = 1f/Mathf.Cos(Mathf.Deg2Rad*m_cameraAngle);
            m_groundObject.transform.localScale = new Vector3 (1, groundScale, 1);
        }

        if (m_characterObject != null)
        {
            float characterScale = 1f / Mathf.Cos(Mathf.Deg2Rad * (90f - m_cameraAngle));
            m_characterObject.transform.localScale = new Vector3(1, characterScale, 1);
        }
    }
}
