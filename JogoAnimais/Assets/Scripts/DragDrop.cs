using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IPointerDownHandler, IEndDragHandler, IDragHandler
{
   
   private RectTransform rt;
   private CanvasGroup grupo;
   private Vector2 posicaoOriginal;

   public static bool colouCerto;
   
   
   private void Awake() 
   {
        rt = GetComponent<RectTransform>();
        grupo = GetComponent<CanvasGroup>();
        posicaoOriginal = rt.anchoredPosition;
        colouCerto = false;
   }
   
   public void OnBeginDrag(PointerEventData eventData)
   {
    Debug.Log("Funfou o primeiro click");
    grupo.alpha = 0.3f;
    grupo.blocksRaycasts = false;
   }

   public void OnDrag(PointerEventData eventData)
   {
    rt.anchoredPosition += eventData.delta;
    Debug.Log("Dragou");
   }

   public void OnPointerDown(PointerEventData eventData)
   {
    Debug.Log("Clicou");
   }
   
   public void OnEndDrag(PointerEventData eventData)
   {
    Debug.Log("Final");
    grupo.alpha = 1f;
    grupo.blocksRaycasts = true;

    if(colouCerto == false)
    {
        rt.anchoredPosition = posicaoOriginal;
    }
    colouCerto = false;
   }
}
