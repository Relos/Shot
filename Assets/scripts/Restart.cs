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
        if (GUI.Button(new Rect(0, 10, 60, 30), "退出"))
        {
            Application.Quit();
        }
        if (GUI.Button(new Rect(100, 10, 60, 30), "重新开始"))
        {
            Application.LoadLevel("Shot");
        }
        if(GUI.Button(new Rect(10, 50, 60, 30), "Play"))
        {
            music.Play();            
        }
        if (GUI.Button(new Rect(10, 100, 60, 30), "Pause"))
        {
            music.Pause();
        }
        if (GUI.Button(new Rect(10, 150, 60, 30), "Stop"))
        {
            music.Stop();
        }
        print("ongui");
    }
}
