using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FallowMouse : MonoBehaviour
{
    [SerializeField] Camera _maincamera;
    [SerializeField] Transform _target;

    Vector2 _oldMousePosition;
    private void OnMouseDown()
    {
            Debug.Log("Down");
        _oldMousePosition = _maincamera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDrag()
    { 
        Vector2 CurrentMousepPosition = _maincamera.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log($"MOusePosition {Input.mousePosition} World {CurrentMousepPosition}");
        _target.Translate(CurrentMousepPosition - _oldMousePosition, Space.World);
        _oldMousePosition = CurrentMousepPosition;
    }

    private void OnMouseUp()
    {
        Debug.Log("up");
    }
}
