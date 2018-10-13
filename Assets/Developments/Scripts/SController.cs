using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SController : MonoBehaviour {

    [SerializeField] GameObject[] fires;
    [SerializeField] GameObject firePrefab;
    bool isFirst = true;

	void Update () {
        if(Input.GetKey(KeyCode.S))
        {
            for(int i = 0; i < fires.Length; i++)
            {
                fires[i].transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            }
        }		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FireA" && isFirst)
        {
            Vector3 firePos = (gameObject.transform.position + other.gameObject.transform.position) / 2;
            Vector3 fireScale = (gameObject.transform.localScale + other.gameObject.transform.localScale) / 2;
            GameObject fire = Instantiate(firePrefab);
            fire.transform.localScale = fireScale;
            fire.transform.parent = gameObject.transform.parent.parent;
            isFirst = false;
        }
    }
}
