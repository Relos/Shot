using UnityEngine;
using System.Collections;

public class ShotIt : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public int zidancount = 0;

    public int destoryobjectcount = 0;

    public float speed = 5;
    // Update is called once per frame
    public Transform original;
    void Update () {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(x, 0, z);
       

        if(Input.GetButtonDown("Fire1"))
        {
            print("Fire");
            Transform zidan = Instantiate(original, transform.position, transform.rotation) as Transform;
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            //zidan.rigidbody;
            Rigidbody rb = zidan.GetComponent<Rigidbody>();
            rb.AddForce(forward * 3500);

            zidancount++;
            GameObject.Find("Canvas/zidancount").GetComponent<UnityEngine.UI.Text>().text = "子弹数：" + zidancount +"   消灭数："+destoryobjectcount;
        }

        //镜头旋转
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -25 * Time.deltaTime, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 25 * Time.deltaTime, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(0, 0, 25 * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.X))
        {
            transform.Rotate(0, 0, -25 * Time.deltaTime, Space.Self);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(25 * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.G))
        {
            transform.Rotate(-25 * Time.deltaTime, 0, 0, Space.Self);
        }
    }
}
