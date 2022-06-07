using System.Collections;
using UnityEngine;

public class Enable_Move : MonoBehaviour
{
    private Vector3 m_Position_Default;
    [SerializeField] protected Vector3 m_Position_End;
    [SerializeField] protected float m_RunTime = 1.0f;

    private void Awake()
    {
        m_Position_Default = transform.position;
    }

    private void OnEnable()
    {
        StartCoroutine(Run(m_RunTime));
    }

    IEnumerator Run(float duration)
    {
        var runTime = 0.0f;

        while (runTime < duration)
        {
            runTime += Time.deltaTime;

            transform.position = Vector3.Lerp(m_Position_Default, m_Position_End, runTime / duration);

            yield return null;
        }
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(30, 30, 100, 100), "Move 1"))
            StartCoroutine(Run(1));
        if (GUI.Button(new Rect(150, 30, 100, 100), "Move 2"))
            StartCoroutine(Run(2));
        if (GUI.Button(new Rect(270, 30, 100, 100), "Move 3"))
            StartCoroutine(Run(3));
    }
}