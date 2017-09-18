using UnityEngine;
using System.Collections;

public class DeathCamera : MonoBehaviour {

    public Texture2D black;
    public float fadeSpeed;
    public float delay = 1.5f;

    int drawDepth = -1000;
    int fadeDir = -1;
    float alpha = 1.0f;


    void OnGUI()
    {
        // fade out/in the alpha value using a direction, a speed and Time.deltaTime to convert the operation to seconds
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        // force (clamp) the number to be between 0 and 1 because GUI.color uses Alpha values between 0 and 1
        alpha = Mathf.Clamp01(alpha);

        // set color of our GUI (in this case our texture). All color values remain the same & the Alpha is set to the alpha variable
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;                                                              // make the black texture render on top (drawn last)
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), black);       // draw the texture to fit the entire screen area
    }

    // sets fadeDir to the direction parameter making the scene fade in if -1 and out if 1
    public IEnumerator BeginFade(int direction)
    {
        yield return new WaitForSeconds(delay);
        fadeDir = direction;
    }
    /*
        public GUITexture blackScreen;
        public int color;

        void Start()
        {
            blackScreen = GetComponent<GUITexture>();
            blackScreen.pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
        }
        public IEnumerator FadeOut()
        {
            Debug.Log("Fadeout Death");

            for (float f = 0f; f < 1.0f; f += .01f )
            {
                Color c = blackScreen.color;
                c.a += f;
                blackScreen.color = c;
                yield return new WaitForSeconds(0.01f);
            }

        }
        */
}
