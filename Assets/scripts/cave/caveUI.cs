using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class caveUI : MonoBehaviour {

    public static int deathPoint;
    public static int goodPoint;
    public static int normalPoint;
    GameObject end3Text;
    GameObject end2Text;
    GameObject end1Text;
    GameObject end3NameText;
    GameObject end2NameText;
    GameObject end1NameText;
    Button ButtonReplay;

    //public AudioClip bgm;
    //private AudioSource audioSource;


    // end3 危機一髪で男は助かる
    public void end3()
    {
        end3Text.GetComponent<Text>().enabled = true;
        end3Text.GetComponent<allText>().end3();
        end3Text.GetComponent<allText>();
        //end3NameText.GetComponent<allText>().after3();
        //Invoke("end3Name", 1f);
    }

    // end2 優柔不断。安堵のため息でロウソクが消えて男は死ぬ
    public void end2()
    {
        end2Text.GetComponent<Text>().enabled = true;
        end2Text.GetComponent<allText>().end2();
        end2Text.GetComponent<allText>();
    }

    // end1 男は死ぬ。
    public void end1()
    {
        end1Text.GetComponent<Text>().enabled = true;
        end1Text.GetComponent<allText>().end1();
        end1Text.GetComponent<allText>();

    }

    public void end3Name()
    {
        end3NameText.GetComponent<Text>().enabled = true;
        ButtonReplay.gameObject.SetActive(true);
    }

    public void end2Name()
    {
        end2NameText.GetComponent<Text>().enabled = true;
        ButtonReplay.gameObject.SetActive(true);
    }


    public void end1Name()
    {
        end1NameText.GetComponent<Text>().enabled = true;
        ButtonReplay.gameObject.SetActive(true);
    }
    // Use this for initialization
    void Start () {
        //audioSource = gameObject.GetComponent<AudioSource>();
        ButtonReplay = GameObject.Find("ButtonReplay").GetComponent<Button>();
        end3Text = GameObject.Find("end3Text");
        end2Text = GameObject.Find("end2Text");
        end1Text = GameObject.Find("end1Text");
        end3NameText = GameObject.Find("end3");
        end2NameText = GameObject.Find("end2");
        end1NameText = GameObject.Find("end1");
        ButtonReplay.gameObject.SetActive(false);
        end3NameText.GetComponent<Text>().enabled = false;
        end2NameText.GetComponent<Text>().enabled = false;
        end1NameText.GetComponent<Text>().enabled = false;

        deathPoint = clientCUI.deathPoint;
        goodPoint = clientCUI.goodPoint;
        normalPoint = clientCUI.normalPoint;
        Debug.Log("死神ポイント；" + deathPoint);
        Debug.Log("goodポイント；" + goodPoint);
        Debug.Log("normalポイント；" + normalPoint);
        end3Text.GetComponent<Text>().enabled = false;
        //end3();
        end2Text.GetComponent<Text>().enabled = false;
        //end2();
        end1Text.GetComponent<Text>().enabled = false;
        end1();

        //if (normalPoint >= 2)
        //{
        //    Debug.Log("end3 危機一髪で男は助かる");
        //    end3();
        //}
        //else if (goodPoint >= 2)
        //{
        //    Debug.Log("end2 優柔不断。安堵のため息でロウソクが消えて男は死ぬ");
        //}
        //else if (deathPoint >= 2)
        //{
        //    Debug.Log("end1 男は死ぬ");
        //}
        //else
        //{
        //    Debug.Log("?");
        //}

    }

    // Update is called once per frame
    void Update () {
        //audioSource.PlayOneShot(bgm);
		
	}
}
