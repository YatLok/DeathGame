using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class allButton : MonoBehaviour {

    GameObject IntroDirector;

    public void ButtonGameStart()
    {
        FadeManager.Instance.LoadScene("Town1", 1f);
        Debug.Log("ゲームスタート");
    }

    public void ButtonHowToGame()
    {
        IntroDirector = GameObject.Find("DirectorUI");
        IntroDirector.GetComponent<introUI>().TextHowTo();
        IntroDirector.GetComponent<introUI>().ButtonOff();
        Debug.Log("ゲームの遊び方");

    }
    public void ButtonReturn()
    {
        FadeManager.Instance.LoadScene("intro", 1f) ;
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
