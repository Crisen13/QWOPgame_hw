using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public HingeJoint2D LeftThigh;
    public HingeJoint2D RightThigh;
    public HingeJoint2D LeftLeg;
    public HingeJoint2D RightLeg;

    private JointMotor2D LeftThighMotorRef;
    private JointMotor2D RightThighMotorRef;
    private JointMotor2D LeftLegMotorRef;
    private JointMotor2D RightLegMotorRef;

    public float hingeSpeed = 35;

    // Start is called before the first frame update
    void Start()
    {
        LeftThighMotorRef = LeftThigh.motor;
        RightThighMotorRef = RightThigh.motor;
        LeftLegMotorRef = LeftLeg.motor;
        RightLegMotorRef = RightLeg.motor;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.Q))
        {
            RightThigh.useMotor = true;
            LeftThigh.useMotor = true;
            RightThighMotorRef.motorSpeed = -hingeSpeed;
            LeftThighMotorRef.motorSpeed = hingeSpeed;
            RightThigh.motor = RightThighMotorRef;
            LeftThigh.motor = LeftThighMotorRef;
        }
        else if(Input.GetKey(KeyCode.W))
        {
            RightThigh.useMotor = true;
            LeftThigh.useMotor = true;
            RightThighMotorRef.motorSpeed = hingeSpeed;
            LeftThighMotorRef.motorSpeed = -hingeSpeed;
            RightThigh.motor = RightThighMotorRef;
            LeftThigh.motor = LeftThighMotorRef;
        }
        else
        {
            RightThigh.useMotor = false;
            LeftThigh.useMotor = false;
        }

        if (Input.GetKey(KeyCode.O))
        {
            RightLeg.useMotor = true;
            LeftLeg.useMotor = true;
            RightLegMotorRef.motorSpeed = -hingeSpeed;
            LeftLegMotorRef.motorSpeed = hingeSpeed;
            RightLeg.motor = RightLegMotorRef;
            LeftLeg.motor = LeftLegMotorRef;
        }
        else if (Input.GetKey(KeyCode.P))
        {
            RightLeg.useMotor = true;
            LeftLeg.useMotor = true;
            RightLegMotorRef.motorSpeed = hingeSpeed;
            LeftLegMotorRef.motorSpeed = -hingeSpeed;
            RightLeg.motor = RightLegMotorRef;
            LeftLeg.motor = LeftLegMotorRef;
        }
        else
        {
            RightLeg.useMotor = false;
            LeftLeg.useMotor = false;
        }
    }
}
