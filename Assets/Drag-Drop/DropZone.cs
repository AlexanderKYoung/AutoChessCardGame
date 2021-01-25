using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, 
IPointerExitHandler
{
    public Drag.Slot actionType = Drag.Slot.PLAYING;
    
    public void OnDrop(PointerEventData eventData){
        Drag d = eventData.pointerDrag.GetComponent<Drag>();
        
        
        if (d != null){ 
            if (actionType == d.actionType){
                d.parentToReturnTo = this.transform;

                if (d.actionType == Drag.Slot.PLAYING){
                    d.actionType = Drag.Slot.SELLING;
                }

                else if (d.actionType == Drag.Slot.SELLING){
                    d.actionType = Drag.Slot.SOLD;
                }

                else if (d.actionType == Drag.Slot.BUYING){
                    d.actionType = Drag.Slot.PLAYING;
                }
            }else if (d.parentToReturnTo == this.transform.root){
                d.parentToReturnTo = this.transform;
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData){
        if (eventData.pointerDrag == null){
            return;
        }

        Drag d = eventData.pointerDrag.GetComponent<Drag>();
        if (d != null){
            d.placeholderParent = this.transform;
        }
    }

    public void OnPointerExit(PointerEventData eventData){
        if (eventData.pointerDrag == null){
            return;
        }

        Drag d = eventData.pointerDrag.GetComponent<Drag>();
        if (d != null && d.placeholderParent == this.transform){
            d.placeholderParent = d.parentToReturnTo;
        }
    }
}
