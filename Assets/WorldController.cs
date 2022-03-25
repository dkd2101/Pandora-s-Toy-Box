using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    public GameObject one = null;
    public GameObject two = null;
    public GameObject three = null;
    public GameObject four = null;
    public GameObject five = null;

    private bool shouldSpawn = true;
 


    // Start is called before the first frame update
    void Start()
    {
        this.one.SetActive(false);
        this.two.SetActive(false);
        this.three.SetActive(false);
        this.four.SetActive(false);
        this.five.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateObjects()
    {
        if (this.shouldSpawn)
        {
            this.one.SetActive(true);
            this.two.SetActive(true);
            this.three.SetActive(true);
            this.four.SetActive(true);
            this.five.SetActive(true);
        } else
        {
            this.shouldSpawn = true;
        }
    }

    public void deactivateObjects()
    {
        this.one.SetActive(false);
        this.two.SetActive(false);
        this.three.SetActive(false);
        this.four.SetActive(false);
        this.five.SetActive(false);
        this.shouldSpawn = false;
    }
}
