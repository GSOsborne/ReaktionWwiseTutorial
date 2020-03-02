using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTPCDebug : MonoBehaviour
{
    public string RTPCName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int type = 1;
        float value;
        AkSoundEngine.GetRTPCValue(RTPCName, gameObject, 0, out value, ref type);
        Debug.Log(value);
    }
}
