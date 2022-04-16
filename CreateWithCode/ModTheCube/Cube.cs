using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    
    void Start()
    {
        
        
        
        
        
    }
    
    void Update()
    {
        transform.position = new Vector3(Random.Range(0,5), Random.Range(0,5), Random.Range(0,5));
        transform.localScale = Vector3.one * Random.Range(0f,5f);
        Material material = Renderer.material;
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        material.color = new Color(Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f));
    }
}
