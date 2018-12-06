using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cliAenterButton : MonoBehaviour {

    public void EnterRoom()
    {
        Debug.Log("部屋に入るぞ！！");
        GameObject aaa = GameObject.Find("DirectorUI");
        aaa.GetComponent<cliAdireUI>().next();
    }

    public void useMagic()
    {
        Debug.Log("力を使います");
        GameObject bbb = GameObject.Find("DirectorUI");
        bbb.GetComponent<cliAdireUI>().addDeathPoint();
        bbb.GetComponent<cliAdireUI>().removebutton();
        bbb.GetComponent<cliAdireUI>().removeMsg();
    }

    public void noMagic()
    {
        Debug.Log("力を使わない");
        GameObject ccc = GameObject.Find("DirectorUI");
        ccc.GetComponent<cliAdireUI>().addGoodPointAndNormalPoint();
        ccc.GetComponent<cliAdireUI>().removebutton();
        ccc.GetComponent<cliAdireUI>().removeMsg();

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
