using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CText : MonoBehaviour {
    public void deathMsgStart()
    {
        Text messageText = GameObject.Find("DeathMsg").GetComponent<Text>();
        messageText.text = "患者の元へとやってきた。\n"
            + "死神は患者の頭上にいる。しかし今回の報酬はとんでもない金額だ。\n" +
            "死神が眠るのを待ち、ずるをして力を使いますか？";
        GameObject button = GameObject.Find("DirectorUI");
        button.GetComponent<clientCUI>().addbutton();
    }

    public void usemagicMsgStart()
    {
        Text useMgcText = GameObject.Find("UseMagicMsg").GetComponent<Text>();
        useMgcText.text = "死神が寝た瞬間に患者の頭と足元を逆さした！\n"
            + "呪文を唱えた！！";
    }
    public void usemagicMsg2Start()
    {
        Text magicAfter = GameObject.Find("UseMagicMsg2").GetComponent<Text>();
        magicAfter.text = "死神は消えたが、窓の外にこちらをみている死神がいる…";
    }

    public void nomagicMsg()
    {
        Text nomagicAfter = GameObject.Find("noMagicMsg").GetComponent<Text>();
        nomagicAfter.text = "男は力を使わないことにした。";
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
