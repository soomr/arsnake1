using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController : MonoBehaviour
{
    // Start is called before the first frame update
    public static GamePlayController instance;
    public GameObject fruit_Pickup;
    private float min_x = -0.237f, max_x = 0.329f, min_z = -0.074f, max_z = 0.1818f;
    private float y_pos = 0.023429f;
    void Start()
    {
        Invoke("StartSpawning",0f);
    }

    // Update is called once per frame
    void Update()
    {
        MakeInstance();
    }
    void MakeInstance(){
    	if(instance == null)
    	{
    		instance = this;
    	}
    }
    void StartSpawning()
    {
    	StartCoroutine(SpawnPickups());
    }
    IEnumerator SpawnPickups() {
    	yield return new WaitForSeconds(Random.Range(1f, 1.5f));
    	Instantiate(fruit_Pickup, new Vector3(Random.Range(min_x,max_x),y_pos, Random.Range(
    		min_z, max_z)), Quaternion.identity);
    	Invoke("StartSpawning",0f);
    }
}
