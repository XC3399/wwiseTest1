using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("button0"))
        {
            AkSoundEngine.SetRTPCValue("musicProgression", 0);
        }

        else if (collider.CompareTag("button1"))
        {
            AkSoundEngine.SetRTPCValue("musicProgression", 20);
        }

        else if (collider.CompareTag("button2"))
        {
            AkSoundEngine.SetRTPCValue("musicProgression", 40);
        }

        else if (collider.CompareTag("button3"))
        {
            AkSoundEngine.SetRTPCValue("musicProgression", 60);
        }

        else if (collider.CompareTag("button4"))
        {
            AkSoundEngine.SetRTPCValue("musicProgression", 80);
        }

        else if (collider.CompareTag("button5"))
        {
            AkSoundEngine.SetRTPCValue("musicProgression", 100);
        }
    }

  
    


}

