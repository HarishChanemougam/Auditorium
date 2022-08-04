using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class influnceggizmo : MonoBehaviour
{
    [SerializeField] Camera _mainCamera;

    [SerializeField] CircleCollider2D _areaCircle;
    [SerializeField] AreaEffector2D _areaEffector;

    Vector2 _oldMousePosition;
    private void OnMouseDown()
    {
        Debug.Log("Down On Influancer");

        _oldMousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    {
        Debug.Log("Work On Influencer");

        Vector2 currentMousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 deltaCursorPosition = currentMousePosition - _oldMousePosition;
        Vector2 position2D = transform.position;

        float distance = Vector2.Distance(position2D, currentMousePosition);
        _areaCircle.radius = Vector2.Distance(position2D, currentMousePosition);

        Debug.Log($"Orgin Position {position2D}");
        Debug.Log($"Cursor Position {currentMousePosition}");
        Debug.Log($"Distance {distance}");

        _areaCircle.radius = distance;
        transform.localScale = new Vector3(distance, distance, distance);

        //END
        _oldMousePosition = currentMousePosition;
    }
}

