using UnityEngine;
using System.Collections;

public class CheckDispearedCount : MonoBehaviour
{
    ShotIt shotit;
    UnityEngine.UI.Text zidancount;
    Restart restart;
    // Use this for initialization
    void Start()
    {
        shotit = GameObject.Find("Main Camera").GetComponent<ShotIt>();
        zidancount = GameObject.Find("Canvas/zidancount").GetComponent<UnityEngine.UI.Text>();
        restart = GameObject.Find("dimian").GetComponent<Restart>();
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0f)
        {
            shotit.destoryobjectcount++;
            if (shotit.destoryobjectcount >= 15)
            {
                zidancount.text = "恭喜过关";
                shotit.enabled = false;
                restart.enabled = true;
            }
            Destroy(gameObject);
        }
    }
}
