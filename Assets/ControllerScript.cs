using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public static ControllerScript _thisCon;
    void Awake() {
        if (_thisCon == null)
        {
            _thisCon = this;
        }
        else {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
