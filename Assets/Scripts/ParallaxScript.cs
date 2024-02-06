using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ParallaxScript : MonoBehaviour
{
    private float speed;
    void Awake()
    {
        speed = 0.5f;
    }

    void Update()
    {
        GetComponent<RawImage>().materialForRendering.mainTextureOffset = new Vector2(0, Time.time * speed);
    }
}
