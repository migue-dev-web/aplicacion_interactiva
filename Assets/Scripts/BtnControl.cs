using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class BtnControl : MonoBehaviour
{
    public GameObject SpriteArrastrable;
    public TMP_Text textcambi;
    public TMP_FontAsset nuevaFuente;
   
    public DragHandler dragHandler;
    
    private bool isEn = false;


   

    public void ActivateDrag(){
        isEn = !isEn;
        dragHandler.EnDrag(isEn);
    }
    

    public void cambiarfuente(){
        if (textcambi != null && nuevaFuente != null)
        {
            textcambi.font = nuevaFuente;
        }
        else
        {
            Debug.LogWarning("Faltan elementos: Asigna el texto y la fuente en el Inspector.");
        }
    }
}
