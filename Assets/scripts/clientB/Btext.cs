using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btext : MonoBehaviour {

    public void deathMsgStart()
    {
        Text messageText = GameObject.Find("DeathMsg").GetComponent<Text>();
        messageText.text = "患者の元へとやってきた。\n" +
            "死神は患者の足元にいる。\n"
            + "力を使いますか？";
        GameObject button = GameObject.Find("DirectorUI");
        button.GetComponent<clientBUI>().addbutton();
    }

    public void usemagicMsgStart()
    {
        Text useMgcText = GameObject.Find("UseMagicMsg").GetComponent<Text>();
        useMgcText.text = "呪文を唱えた！\n"
            + "さらに呪文を唱えた！！";
    }
    public void usemagicMsg2Start()
    {
        Text magicAfter = GameObject.Find("UseMagicMsg2").GetComponent<Text>();
        magicAfter.text = "死神は消え、大喜びの患者の家族から大金を手に入れた。";
    }

    public void nomagicMsg()
    {
        Text nomagicAfter = GameObject.Find("noMagicMsg").GetComponent<Text>();
        nomagicAfter.text = "男は力を使わず、家に帰ることにした。";
    }

    //public void enterRoom()
    //{
    //    Text enterText = GameObject.Find("TextEventPoint").GetComponent<Text>();
    //    enterText.text = "部屋に入りますか？";
    //}


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
