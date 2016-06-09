using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class ControlTest : MonoBehaviour {
    public SteamVR_TrackedObject rightTrackedObj;
    public SteamVR_TrackedObject leftTrackedObj;


	// Use this for initialization
	void Start () {
	
	}
	
    void Awake() {
        rightTrackedObj = rightTrackedObj.GetComponent<SteamVR_TrackedObject>();
        leftTrackedObj = leftTrackedObj.GetComponent<SteamVR_TrackedObject>();
    }

    void Update() {
        SteamVR_Controller.Device rightDevice = SteamVR_Controller.Input((int)rightTrackedObj.index);
        SteamVR_Controller.Device leftDevice = SteamVR_Controller.Input((int)leftTrackedObj.index);

        if (rightDevice.GetTouch(SteamVR_Controller.ButtonMask.Trigger)) {
            Debug.Log("You have pulled the RIGHT trigger");

        }
        if (rightDevice.GetTouch(SteamVR_Controller.ButtonMask.Grip)) {

            Debug.Log("You have Pressed the RIGHT grip");
        }


    }
}



