using UnityEngine;

public class Line : MonoBehaviour
{
   
    private LineRenderer _lineRenderer;
    

    private void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.positionCount = 0;
        _lineRenderer.startWidth = 0.1f;
        _lineRenderer.endWidth = 0.1f;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lineRenderer.positionCount = 0;
        }
        if (Input.GetMouseButton(0))
        {
            var currentPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y , 1);
            var mousePosition = Camera.main.ScreenToWorldPoint(currentPosition);
            _lineRenderer.positionCount++;
            _lineRenderer.SetPosition(_lineRenderer.positionCount - 1, mousePosition);
        }
    }

    

    
}
