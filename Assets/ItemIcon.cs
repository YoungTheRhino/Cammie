using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemIcon : MonoBehaviour {

    public Sprite itemSprite;
    Image image;
    Thing itemRef;
    int stock;
    Text text;
    CanvasGroup canvasGroup;
    bool known = false;
    public bool hover = false;
    float fadedFloat = .4f;
    int textSizeChange = 10;
    
	// Use this for initialization
	void Start () {
        itemSprite = GetComponent<Sprite>();
        image = GetComponent<Image>();
        text = GetComponentInChildren<Text>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = fadedFloat;
    }
	
    public void DataSet(Thing item)
    {
        
            if(!itemRef)
            {
                itemRef = item;
                itemSprite = item.sprite;
                image.sprite = itemSprite;
            }
            
            stock = item.stock;
            
            if(item.known)
            {
                known = true;
                //canvasGroup.alpha = fadedFloat;
            }
            
            text.text = stock.ToString();
        }
        
    public void Hover()
    {
        Debug.Log("Hover Start");
        canvasGroup.alpha = 1.0f;
        if (!hover)
        {
            Debug.Log("!hover");
            hover = true;
        }
        else
        {
            Debug.Log("Hover Leave");
            canvasGroup.alpha = fadedFloat;
            hover = false;
        }
        
    }
	// Update is called once per frame
	void Update () {
		
	}

    public void Enlarge()
    {
        if(!hover)
        {
            
            text.fontSize += textSizeChange;
            hover = true;
        }
        else
        {
            text.fontSize -= textSizeChange;
            hover = false;
        }
    }
}
