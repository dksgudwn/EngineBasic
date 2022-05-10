using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Material bgMat;
    public float scrollSpeed = 0.2f;
    void Start()
    {
       // bgMat = GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.up;
        bgMat.mainTextureOffset += scrollSpeed * Time.deltaTime * direction;
    }
}
