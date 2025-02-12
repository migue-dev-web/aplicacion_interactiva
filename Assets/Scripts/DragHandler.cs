using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    public bool drag = false;
    
    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    
    public void OnBeginDrag(PointerEventData eventData)
    {
        if(drag){
            canvasGroup.alpha = 0.6f;
            canvasGroup.blocksRaycasts = false;
        }
       
         
    }


    public void OnDrag(PointerEventData eventData)
    {
        if(drag){
            rectTransform.anchoredPosition += eventData.delta;
        }
        
    }

   
    public void OnEndDrag(PointerEventData eventData)
    {
        
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void EnDrag(bool enable){
        drag = enable;
    }
}
