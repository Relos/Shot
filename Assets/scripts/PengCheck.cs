using UnityEngine;
using System.Collections;

public class PengCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter()
    {
        GameObject.Find("Canvas/tips").GetComponent<UnityEngine.UI.Text>().text = "Hey,U hit me!";
        GameObject.Find("Spotlight").GetComponent<Light>().enabled = false;
        GameObject.Find("arealight").GetComponent<Light>().enabled = false;
        GameObject.Find("pingxinglight").GetComponent<Light>().enabled = false;
    }
}
