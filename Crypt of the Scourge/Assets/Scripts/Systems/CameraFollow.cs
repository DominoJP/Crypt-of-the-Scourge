using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple Script to allow camera to follow the player
public class CameraFollow : MonoBehaviour
{
    //Define variables and fields
    public float FollowSpeed = 2f;
    public Transform Target;

    
    // Update is called once per frame
    // We have no need for start because the camera is always running.
    void Update()
    {
        Vector3 newPos=new Vector3(Target.position.x, Target.position.y, -10f);     //Using Vector3 in a 2d game is weird but we have to consider the camera distance from the character.
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime);
    }
}
