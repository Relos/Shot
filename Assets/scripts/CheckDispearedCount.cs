using UnityEngine;
using System.Collections;

public class CheckDispearedCount : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    int zd;
    int xm;
    // Update is called once per frame
    void Update()
    {
        float y = transform.position.y;
        //print("y is：" + y);
        //print("y 《：" + (y < 0));
        print(gameObject+" xm:" + xm + ",zd:" + zd + "y:" + y);
        if (y < 0f)
        {
           
            xm = GameObject.Find("Main Camera").GetComponent<ShotIt>().destoryobjectcount++;
            zd = GameObject.Find("Main Camera").GetComponent<ShotIt>().zidancount;

            GameObject.Find("Canvas/zidancount").GetComponent<UnityEngine.UI.Text>().text = "子弹数：" + zd + "   消灭数：" + xm;
            if (xm >= 1)
            {
                GameObject.Find("Canvas/zidancount").GetComponent<UnityEngine.UI.Text>().text = "恭喜过关";
                GameObject.Find("Main Camera").GetComponent<ShotIt>().enabled = false;
            }
            Destroy(gameObject);
        }
    }
}
