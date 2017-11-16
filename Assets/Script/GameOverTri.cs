using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverTri : MonoBehaviour {

    public GameObject gameOverPanel;
    public GameObject thirdPersonController;
    public GameObject endText;
    public GameObject distanceText;
    public GameObject tearGen;
    // Use this for initialization
    void Start () {
        gameOverPanel = GameObject.Find("GameOverPanel");
        thirdPersonController = GameObject.Find("ThirdPersonController");
        endText = GameObject.Find("EndText");
        distanceText = GameObject.Find("DistanceText");
        tearGen = GameObject.Find("TearGen");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Tear" && !thirdPersonController.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().isEnd)
        {
            gameOverPanel.transform.localScale = Vector3.one;
            thirdPersonController.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().isEnd = true;
            thirdPersonController.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().startspeed = 0;
            endText.GetComponent<Text>().text = "It’s never easy right?";
            float distance = thirdPersonController.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().distance;
            distanceText.GetComponent<Text>().text = ((int)(distance)).ToString();
        }

        if (col.name == "EndTrigger" && !thirdPersonController.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().isEnd)
        {
            gameOverPanel.transform.localScale = Vector3.one;
            thirdPersonController.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().isEnd = true;
            thirdPersonController.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().startspeed = 0;
            endText.GetComponent<Text>().text = "It could be easier, right?";
            float distance = thirdPersonController.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>().distance;
            distanceText.GetComponent<Text>().text = ((int)(distance)).ToString();

            tearGen.SetActive(false);
        }
    }
}
