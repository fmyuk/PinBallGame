using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    private float visiblePosZ = -6.5f;

    private GameObject gameoverText;

    private GameObject pointText;

    private int point = 0;

	// Use this for initialization
	void Start () {

        this.gameoverText = GameObject.Find("GameOverText");
        this.pointText = GameObject.Find("pointText");		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "SmallStarTag")
        {
            this.point += 5;
            this.pointText.GetComponent<Text>().text = "Point = " + this.point;
        }
        if(other.gameObject.tag == "LargeStarTag")
        {
            this.point += 30;
            this.pointText.GetComponent<Text>().text = "Point = " + this.point;
        }
        if(other.gameObject.tag == "SmallCloudTag")
        {
            this.point += 20;
            this.pointText.GetComponent<Text>().text = "Point = " + this.point;
        }
        if(other.gameObject.tag == "LargeCloudTag")
        {
            this.point += 100;
            this.pointText.GetComponent<Text>().text = "Point = " + this.point;
        }
    }
}
