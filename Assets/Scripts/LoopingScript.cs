using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingScript : MonoBehaviour
{
    float length = 0;
    private float startPos;
    private GameObject cam;
    [SerializeField] private float parralaxEffect;
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        startPos = transform.position.x;
        length = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
    }
    void Update()
    {
        float temp = (cam.transform.position.x * (1 - parralaxEffect));
        float distance = (cam.transform.position.x * parralaxEffect);
        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);
        if  (temp > startPos + length)
        {
            startPos += length;
        }
        else if (temp < startPos - length)
        {
            startPos -= length;
        }
    }
}

