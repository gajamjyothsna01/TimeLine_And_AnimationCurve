using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    public AnimationCurve animationCurve;
    // public float curveTime = 2f;
    public float playerSpeed = 3f;
    // Animation playerAnimation;
    // public Vector3 currentPosition;
    Transform characterTransform;
    // Start is called before the first frame update
    void Start()
    {
        //playerAnimation = GetComponent<Animation>();
        characterTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        currentPosition = transform.position;
        currentPosition.z += playerSpeed * Time.deltaTime;
        curveTime = Mathf.PingPong(0f,1f);
        
       // Debug.Log(curveTime);
        currentPosition.y = animationCurve.Evaluate(curveTime);
        Debug.Log(currentPosition.y);
        transform.position = currentPosition;
        */
       characterTransform.position += playerSpeed * characterTransform.forward * Time.deltaTime;
        float valueY = animationCurve.Evaluate(Mathf.PingPong(Time.time, 1));
        //float valueY = animationCurve.Evaluate(Mathf.Clamp(Time.time, 1);
        characterTransform.position = new Vector3(characterTransform.position.x, valueY, characterTransform.position.z);


    }
}
