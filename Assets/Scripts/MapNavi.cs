using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapNavi : MonoBehaviour
{
    LineRenderer lineRenderer;
    public Transform startPos;
    public Transform endPos;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

        lineRenderer.SetPosition(0, startPos.position);
        lineRenderer.SetPosition(1, endPos.position);
    }
}
