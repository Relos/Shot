using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        if(GUI.Button(new Rect(380,350,60,30), "退出"))
        {
            Application.Quit();
        }
        if (GUI.Button(new Rect(480, 350, 60, 30), "开始游戏"))
        {
            Application.LoadLevel("Shot");
        }
    }
}
