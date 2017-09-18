using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TextManager : MonoBehaviour {

    public Text textBox;
    public TextAsset textFile;
    public string[] textLines;
    public string inputKey;

    Canvas textCanvas;


	void Start () {
        textBox = GetComponentInChildren<Text>();
        textCanvas = GetComponent<Canvas>();
        DisplayText(textFile);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
    
    public void DisplayText(TextAsset textInput)
    {
        Debug.Log("DisplayText");
        textCanvas.enabled = true;
        textLines = textInput.text.Split('\n');
        StartCoroutine(ScrollText());
        
    }

    IEnumerator ScrollText()
    {
        for (int i = 0; i < textLines.Length - 1; i++)
        {
            Debug.Log("Scroll Text" + i);
            textBox.text = textLines[i];
            yield return new WaitUntil(() => Input.GetKeyDown(inputKey));
            yield return new WaitUntil(() => Input.GetKeyUp(inputKey));
        }
        ExitText();
        
    }
    void ExitText()
    {
        System.Array.Clear(textLines, 0, textLines.Length);
        textCanvas.enabled = false;
    }
}
