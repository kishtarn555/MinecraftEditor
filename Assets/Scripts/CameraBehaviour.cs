using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BedrockTools.Nbt.Elements;

public class CameraBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Test");
        NbtInt nb = new NbtInt(10);
        Debug.Log(nb.ToString());
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
