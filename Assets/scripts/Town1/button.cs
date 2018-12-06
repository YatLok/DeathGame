using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour {

    GameObject death;

    public void sceneMap(){
        FadeManager.Instance.LoadScene("map", 1.0f);
        //SceneManager.LoadScene("map");
    }

    public void sceneClient()
    {
        FadeManager.Instance.LoadScene("clientA", 1.0f);
        //SceneManager.LoadScene("clientA");
        Destroy(death);
    }

    // Use this for initialization
    void Start () {
        if(GameObject.Find("skeleton_static")){
            death = GameObject.Find("skeleton_static");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
