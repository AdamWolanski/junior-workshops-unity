using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCollider : MonoBehaviour
{

    private BoxCollider2D _boxCollider2D;

    private void Awake()
    {
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "box")
            Debug.Log("kolizja");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("trigger");
    }
}
