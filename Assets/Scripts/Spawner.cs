using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject BoxPrefabGameObject;
    [SerializeField]
    private GameObject _altBoxPrefabGameObject;


    public void SpawnBox()
    {
        Instantiate(_altBoxPrefabGameObject, this.transform.position, Quaternion.identity);
    }

	// Use this for initialization
	void Start ()
	{
	    _altBoxPrefabGameObject = Resources.Load("Box") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown("Jump"))
	    {
	        Instantiate(_altBoxPrefabGameObject, this.transform.position, Quaternion.identity);
	    }
	}
}
