using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bbutton : MonoBehaviour {

    public void EnterRoom()
    {
        Debug.Log("部屋に入るぞ！！");
        GameObject aaa = GameObject.Find("DirectorUI");
        aaa.GetComponent<clientBUI>().next();
    }

    public void useMagic()
    {
        Debug.Log("力を使います");
        GameObject bbb = GameObject.Find("DirectorUI");
        bbb.GetComponent<clientBUI>().addDeathPoint();
        bbb.GetComponent<clientBUI>().removebutton();
        bbb.GetComponent<clientBUI>().removeMsg();
    }

    public void noMagic()
    {
        Debug.Log("力を使わない");
        GameObject ccc = GameObject.Find("DirectorUI");
        ccc.GetComponent<clientBUI>().addGoodPointAndNormalPoint();
        ccc.GetComponent<clientBUI>().removebutton();
        ccc.GetComponent<clientBUI>().removeMsg();

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
