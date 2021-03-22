using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClippingController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }    void OnTriggerEnter(Collider other)
    {
        // 衝突したコイン・コーン・カーをDestroyする。
        if(other.gameObject.tag == "CoinTag" || other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag")
        {
            Destroy(other.gameObject);
        }
    }
}
