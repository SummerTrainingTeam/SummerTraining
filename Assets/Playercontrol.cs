using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour {
    public float MoveSpeed = 10.0f;
    private textset blood;
    private sroceset score;
    private int count = 0;
	// Use this for initialization
	void Start () {
        blood = GameObject.Find("Canvas/Blood").GetComponent<textset>();
        score = GameObject.Find("Canvas/Score").GetComponent<sroceset>();

        //GameObject tmp = Resources.Load("Cube2")as GameObject;
        GameObject obj1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj1.transform.position = new Vector3(-1, -2, 0);
        obj1.transform.localScale = new Vector3(3.86415f, 0.5569274f, 1);
        obj1.name = "Cube2";

        //obj1.renderer.material.mainTexture = (Texture) Resources.Load("")
    }
	    

    void Fall()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
        }
        count++;
        score.score = count / 10;
    }

    void OnCollisionEnter(Collision thing)
    {
        var name = thing.collider.name;
        Debug.Log("Thing is " + name);
        if(name == "Cube2")
        {
            blood.a = 10;
        }
        else if(name == "Cube3")
        {
            Destroy(thing.collider);
        }
        else if (name == "Cube4")
        {
            
        }
        else if(name == "Cube5")
        {
            //transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
        }
    }
    
    void OnCollisionExit(Collision thing)
    {
        blood.a = 0;
    }

    void OnCollisionStay(Collision thing)
    {
        blood.a = 0;
        var name = thing.collider.name;
        Debug.Log("Thing is " + name);
        if (name == "Cube2")
        {
            //blood.a = 10;
        }
        else if (name == "Cube3")
        {
            //Destroy(thing.collider);
        }
        else if (name == "Cube4") // slide left cube
        {
            transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime * 0.1f);
        }
        else if (name == "Cube5") // slide right cube
        {
            transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime * 0.1f);
        }
    }

	// Update is called once per frame
	void Update () {
        Fall();
        
    }
}
