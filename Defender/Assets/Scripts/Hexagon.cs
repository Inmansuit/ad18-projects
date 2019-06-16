using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour

   
{
    public Rigidbody2D hexagon;

    public float shrinkSpeed = 3f;

    private LineRenderer lineRenderer;

   
    // Start is called before the first frame update
    void Start()
    {

        hexagon.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
        lineRenderer = hexagon.GetComponent<LineRenderer>();
        Color color = Random.ColorHSV(0.1f,1,0.1f,1,1,1);
        lineRenderer.SetColors(color,color);
    }

    // Update is called once per frame
    void Update()
    {
    transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

    if(transform.localScale.x <= .05f)
    {
        Destroy(gameObject);
    }
    }
}
