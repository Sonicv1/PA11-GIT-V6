using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawnerscript : MonoBehaviour
{
    public GameObject RedCube;
    public GameObject BrownCube;
    public GameObject GreenCube;
    public Text ScoreText;
    public int RandomNumber = 0;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        ObstacleMovement.Score = 0;
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score : " + ObstacleMovement.Score;


    }

    void SpawnObjects()
    {
        RandomNumber = Random.Range(0, 3);
        PositionY = Random.Range(4, -4f);
        switch (RandomNumber)
        {
            case 0:
                this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
                Instantiate(RedCube, transform.position, transform.rotation);
                break;
            case 1:
                this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
                Instantiate(BrownCube, transform.position, transform.rotation);
                break;
            case 2:
                this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
                Instantiate(GreenCube, transform.position, transform.rotation);
                break;
        }
    }
}
