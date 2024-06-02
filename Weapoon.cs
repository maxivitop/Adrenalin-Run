using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapoon : MonoBehaviour
{
    private float timeShot = 0;
    public Transform spawner;
    public GameObject bullet;
    public void Fire()
    {
         Debug.LogError(Time.timeSinceLevelLoad + " " + timeShot);
        if (Time.timeSinceLevelLoad - timeShot >= 50000)
        {
            Debug.LogError(Time.timeSinceLevelLoad + " " + timeShot);
            Instantiate(bullet, spawner.position, spawner.rotation*bullet.transform.rotation);
            timeShot = Time.timeSinceLevelLoad;
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

                
}
