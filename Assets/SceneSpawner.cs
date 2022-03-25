using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSpawner : MonoBehaviour
{
    public GameObject background;
    public GameObject thisObject;
    private bool shouldSpawn = true;
    public ParticleSystem burst;
    public float floatTime;

    // Start is called before the first frame update
    void Start()
    {
        this.background.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator disappearAfterSec(float time)
    {
        yield return new WaitForSeconds(time);


    }

    public void floatBurst()
    {
        Invoke("playBurst", this.floatTime);
        Invoke("spawnScene", this.floatTime);
    }

    private void playBurst()
    {
        this.burst.Play();
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
