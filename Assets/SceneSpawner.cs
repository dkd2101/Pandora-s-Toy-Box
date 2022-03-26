using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSpawner : MonoBehaviour
{
    public GameObject background;
    public GameObject baseGround;
    private bool shouldSpawn = true;
    public ParticleSystem burst;
    public float floatTime;
    private Vector3 startPosition;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        this.background.SetActive(false);
        this.startPosition = this.gameObject.transform.position;
        this.rb = this.gameObject.GetComponent<Rigidbody>();
        this.rb.isKinematic = false;

    }
    // Update is called once per frame
    void Update()
    {
        
    }


    public void floatBurst()
    {
        Invoke("playBurst", this.floatTime);
        Invoke("spawnScene", this.floatTime);
        Invoke("resetPosition", this.floatTime + 1f);
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
            this.baseGround.SetActive(false);
            this.shouldSpawn = false;
        } else
        {
            this.background.SetActive(false);
            this.baseGround.SetActive(true);
            this.shouldSpawn = true;
        }
    }

    public void deSpawnScene()
    {
        this.background.SetActive(false);
        this.shouldSpawn = false;
    }

    public void resetPosition()
    {
        this.gameObject.transform.position = startPosition;
        this.rb.isKinematic = true;
    }
}
