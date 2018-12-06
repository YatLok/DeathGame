using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CButton : MonoBehaviour {
    public void EnterRoom()
    {
        Debug.Log("部屋に入るぞ！！");
        GameObject aaa = GameObject.Find("DirectorUI");
        aaa.GetComponent<clientCUI>().next();
    }

    public void useMagic()
    {
        Debug.Log("力を使います");
        GameObject bbb = GameObject.Find("DirectorUI");
        bbb.GetComponent<clientCUI>().addDeathPoint();
        bbb.GetComponent<clientCUI>().removebutton();
        bbb.GetComponent<clientCUI>().removeMsg();
    }

    public void noMagic()
    {
        Debug.Log("力を使わない");
        GameObject ccc = GameObject.Find("DirectorUI");
        ccc.GetComponent<clientCUI>().addGoodPointAndNormalPoint();
        ccc.GetComponent<clientCUI>().removebutton();
        ccc.GetComponent<clientCUI>().removeMsg();

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
