using UnityEngine;
using System.Collections;

public class CutsceneManager : ManagerBase {

    TextManager textManager;

    public GameObject combatCamera;
    public CombatCamera combatCamScript;
    public Texture2D black;
    public float fadeSpeed;
    public static CutsceneManager instance;

    int drawDepth = -1000;
    int fadeDir = -1;
    float alpha = 1.0f;

    void Awake()
    {

        CutsceneManager cutsceneManager = CutsceneManager.instance;
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
    public void CameraAssign(GameObject camera)
    {
        combatCamera = camera;
        combatCamScript = camera.GetComponent<CombatCamera>();
    }

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
    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return (fadeSpeed);
    }




}
