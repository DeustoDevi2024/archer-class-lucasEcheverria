using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField]
    private Light ligth;
    // Start is called before the first frame update
    void Start()
    {
        ligth = GetComponent<Light>();
        ligth.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
