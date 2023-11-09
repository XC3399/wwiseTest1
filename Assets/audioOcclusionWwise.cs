using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioOcclusionWwise : MonoBehaviour
{   
    // the audio listener on the camera
    public GameObject audioListener;

    // how long the ray should be
    private float maxDistanceOcclusion;

    // whether to use occlusion if the noise should not be occluded outside of a range
    public bool useOcclusion = false;

    public string RTPC_LoPass = "RTPC_Occlusion_LoPass";
    public string RTPC_Volume = "RTPC_Occlusion_Volume";

    public float loPassMax = 1;
    public float volumeMax = 1;

    public bool useDebug = false;

    public string nameOfListener = "3rdPersonCamera";

    // incase the ray is hitting itsself or some objects need to be exempt from occlusion
    public string ignoreTypeOccluder = "insert name";



    // Start is called before the first frame update
    void Start()
    {
        //set the raycast distance to sphere collider
        maxDistanceOcclusion = GetComponent<SphereCollider>().radius;
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //do not occlude if out of occlusion range DEVIATION  
        

        //do nothing if audio not defined or useOcclusion is false
        if (!useOcclusion || audioListener == null) { return; }

        //get direction from audio listener to this
        Vector3 direction = audioListener.transform.position - this.transform.position;

        //racast stored as vairable
        RaycastHit outInfo;
        //raycast
        bool hit = Physics.Raycast(this.transform.position, direction, out outInfo, maxDistanceOcclusion);

        //debug
        if (hit)
            if (useDebug) { print(outInfo.collider.gameObject.name); }

        if (outInfo.collider.gameObject.name != nameOfListener && outInfo.collider.gameObject.name != ignoreTypeOccluder) 
        {
            //gameobject means that the value will be set per game object so can be used indavidualy per game object. 
            AkSoundEngine.SetRTPCValue(RTPC_LoPass, loPassMax, gameObject);
            AkSoundEngine.SetRTPCValue(RTPC_Volume, volumeMax, gameObject);
        }
        else
        {
            AkSoundEngine.SetRTPCValue(RTPC_LoPass, 0, gameObject);
            AkSoundEngine.SetRTPCValue(RTPC_Volume, 0, gameObject);
        }


    }
}
