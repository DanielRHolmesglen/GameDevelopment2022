using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SineMover : MonoBehaviour
{
    RectTransform rect;
    public float xSpeed, ySpeed, zSpeed;

    Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        startPosition = rect.position;
    }

    // Update is called once per frame
    void Update()
    {
        

        rect.transform.Translate(new Vector3(Mathf.Sin(rect.position.x * xSpeed) * Time.deltaTime, 0, 0)) ;
    }
        
}
