using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disappear : MonoBehaviour
{
    public Text points;
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        points.text = "Score: 0";
        manager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Rocket")
        {
            manager.GetComponent<MyGameManager>().points++;
            points.text = "Score: " + manager.GetComponent<MyGameManager>().points;
            Destroy(gameObject);
        }
    }
}
