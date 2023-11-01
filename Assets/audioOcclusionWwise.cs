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
    public float volume = 1;

    public bool useDebug = false;

    public string nameOfListener = "3rdPersonCamera";

    // incase the ray is hitting itsself or some objects need to be exempt from occlusion
    public string ignoreTypeOccluder = "insert name";



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
