using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Vector3 GetMouseWorldPosition()
    {
        Vector3 result = Input.mousePosition;
        //Get Mouse world position
        result.z = Camera.main.WorldToScreenPoint(transform.position).z;
        result = Camera.main.ScreenToWorldPoint(result);
        //return mouse pos
        return result;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = GetMouseWorldPosition();

            //check if mouse position overlaps with shape collider

            Collider2D collider2D = Physics2D.OverlapPoint(mousePos);

            if(collider2D != null)
            {
                //clicked on 2d collider
                if(collider2D.TryGetComponent(out InteractIF interact))
                {
                    interact.Interact();
                }
            }
        }
    }
}
