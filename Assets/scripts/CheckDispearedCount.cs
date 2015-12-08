using UnityEngine;
using System.Collections;

public class CheckDispearedCount : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0f)
        {
            ShotIt shotit = GameObject.Find("Main Camera").GetComponent<ShotIt>();
            shotit.destoryobjectcount++;
            if (shotit.destoryobjectcount >= 15)
            {
                GameObject.Find("Canvas/zidancount").GetComponent<UnityEngine.UI.Text>().text = "恭喜过关";
                GameObject.Find("Main Camera").GetComponent<ShotIt>().enabled = false;
                GameObject.Find("dimian").GetComponent<Restart>().enabled = true;
            }
            Destroy(gameObject);
        }
    }
}
