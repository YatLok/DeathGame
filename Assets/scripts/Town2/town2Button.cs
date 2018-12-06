using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class town2Button : MonoBehaviour {

    public void sceneMap()
    {

        //FadeManager.Instance.LoadScene("map", 1.0f);
        GameObject aaa = GameObject.Find("Town2UI2");
        aaa.GetComponent<town2UI2>().gohome();
        //SceneManager.LoadScene("map");
    }

    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
