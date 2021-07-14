using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    Material material;

    void Start()
    {
        transform.position = Vector3.zero;
        transform.localScale = Vector3.one * 1.3f;
        
        material = Renderer.material;

        InvokeRepeating("MyFunction", 0f, 1.0f);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        transform.position += new Vector3(0.0f, 0.0f, 3.0f * Time.deltaTime);
        transform.localScale += Vector3.one * 0.1f * Time.deltaTime;
    }

    void MyFunction()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);

        material.color = newColor;


        Debug.Log("1 Sec");
    }
}
