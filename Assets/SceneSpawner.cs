using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSpawner : MonoBehaviour
{
    public GameObject background;
    private bool shouldSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        this.background.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnScene()
    {
        if(this.shouldSpawn == true)
        {
            this.background.SetActive(true);
        } else
        {
            this.shouldSpawn = true;
        }
    }

    public void deSpawnScene()
    {
        this.background.SetActive(false);
        this.shouldSpawn = false;
    }
}
