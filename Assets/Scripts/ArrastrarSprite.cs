using UnityEngine;

public class ArrastrarSprite : MonoBehaviour
{
     private bool arrastrando = false;
    private Vector3 offset;

    void OnMouseDown()
    {
        arrastrando = true;
        offset = transform.position - ObtenerPosicionMouse();
    }

    void OnMouseUp()
    {
        arrastrando = false;
    }

    void Update()
    {
        if (arrastrando)
        {
            transform.position = ObtenerPosicionMouse() + offset;
        }
    }

    Vector3 ObtenerPosicionMouse()
    {
        Vector3 posicionMouse = Input.mousePosition;
        posicionMouse = Camera.main.ScreenToWorldPoint(posicionMouse);
        return new Vector3(posicionMouse.x, posicionMouse.y, 0);
    }
}
