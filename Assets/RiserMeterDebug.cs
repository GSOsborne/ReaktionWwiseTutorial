using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiserMeterDebug : MonoBehaviour
{
    //set your RTPCID to the name of your desired gameparameter (under GameSyncs)
    public string rtpcID;

    // Update is called once per frame
    void Update()
    {

        // RTPCValue_type.RTPCValue_Global
        // for whatever reason, this constant isn‘t exposed by name by WWise C#/Unity headers
        int type = 1;

        // will contain the value of the RTPC parameter after the GetRTPCValue call
        float value;

        // retrieves current value of the RTPC parameter and stores it in ‘value‘
        AkSoundEngine.GetRTPCValue(rtpcID, gameObject, 0, out value, ref type);

        //
        // use ‘value‘ here

        Debug.Log("RTPC returned value of: " + value);
        //
        // e.g. transform.localScale += Vector3( value, 0, 0 );
        // which would scale by the value of the RTPC parameter
        //
        // or whatever else you want to do with the RTPC parameter value
        //
        // Note that WWise Meter output bus volume parameters are measured in decibels and so are negative
        // e.g. –60.0 (softer) to –20.0 (louder)
        //
    }
}
