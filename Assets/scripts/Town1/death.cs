using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour {


    void OnCollisionEnter(Collision other)
    {
        Debug.Log("死神に接触した");
        GameObject msg = GameObject.Find("MessageUI");
        msg.GetComponent<ui>().helloDeath();
    }

    void OnCollisionExit(Collision other)
    {
        Debug.Log("死神から離れた");
        GameObject msg = GameObject.Find("MessageUI");
        msg.GetComponent<ui>().byeDeath();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
