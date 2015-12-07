using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public AudioSource music;
    void OnGUI()
    {
        if (GUILayout.Button("退出"))
        //if (GUILayout.Button(new Rect(0, 0, 60, 30), "退出"))
            {
            //Application.Quit();
            print("退出");
        }
        if (GUILayout.Button("重新开始"))
        //if (GUILayout.Button(new Rect(0, 100, 60, 30), "重新开始"))
        {
            Application.LoadLevel("01");
        }
        if(GUILayout.Button("Play"))
        //if(GUILayout.Button(new Rect(10, 160, 100, 50), "Play"))
        {
            music.Play();            
        }
        if (GUILayout.Button("Pause"))
        //if (GUILayout.Button(new Rect(10, 160, 100, 50), "Pause"))
        {
            music.Pause();
        }
        if (GUILayout.Button("Stop"))
        //if (GUILayout.Button(new Rect(10, 160, 100, 50), "Stop"))
        {
            music.Stop();
        }
        print("ongui");
        music.Play();
    }
}
