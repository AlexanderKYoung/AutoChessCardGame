using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, 
IDragHandler, IEndDragHandler{

    private Canvas canvas = null;
    
    public Transform parentToReturnTo = null;
    private RectTransform rectTransform = null;
    private CanvasGroup canvasGroup = null;

    public enum Slot {BUYING, PLAYING, SELLING, SOLD};
    public Slot actionType = Slot.PLAYING;

    public GameObject placeholder = null;
    public Transform placeholderParent = null;

    private void Awake() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        parentToReturnTo = GetComponent<Transform>();
        placeholderParent = GetComponent<Transform>();
        canvas = GameObject.FindGameObjectWithTag("MainCanvas").GetComponent<Canvas>();
    }

    public void OnPointerDown(PointerEventData eventData) {
        
    }

    public void OnBeginDrag(PointerEventData eventData) {
        canvasGroup.blocksRaycasts = false;
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.root);

        placeholder = new GameObject();
        placeholder.transform.SetParent(this.transform.parent);
        LayoutElement le = placeholder.AddComponent<LayoutElement>();
        le.preferredWidth = placeholder.GetComponent<LayoutElement>().preferredWidth;
        le.preferredHeight = placeholder.GetComponent<LayoutElement>().preferredHeight;
        le.flexibleWidth = 0;
        le.flexibleHeight = 0;

        placeholder.transform.SetSiblingIndex(this.transform.GetSiblingIndex());
    }

    public void OnEndDrag(PointerEventData eventData) {
        canvasGroup.blocksRaycasts = true;
        this.transform.SetParent(this.parentToReturnTo);
        this.transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());

        Destroy(placeholder);
    }

    public void OnDrag(PointerEventData eventData) {
        
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

        if (placeholder.transform.parent != placeholderParent){
            placeholder.transform.SetParent(placeholderParent);
        }

        int newSiblingIndex = placeholderParent.childCount;

        for (int i = 0; i < placeholderParent.childCount; i++){
            if (this.transform.position.x < placeholderParent.GetChild(i).position.x){
                
                newSiblingIndex = i;

                if (placeholderParent.transform.GetSiblingIndex() < newSiblingIndex)
                    newSiblingIndex--;
                break;
            }
        }

        placeholder.transform.SetSiblingIndex(newSiblingIndex);
    }
}
