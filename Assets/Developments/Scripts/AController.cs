using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AController : MonoBehaviour {

    [SerializeField] GameObject[] fires;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            for (int i = 0; i < fires.Length; i++)
            {
                fires[i].transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Fire")
        {
            //Destroy(this.gameObject);
            Debug.Log("OnTriggerEnter");
        }
    }
}
