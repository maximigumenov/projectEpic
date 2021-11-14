using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator controller;

    private TypeUnitAnimation currentType = TypeUnitAnimation.Idle;
    [ContextMenu("Idle")]
    public void Idle()
    {
        SetTriggerAnimation(TypeUnitAnimation.Idle, "idle");
    }

    [ContextMenu("Crouch")]
    public void Crouch()
    {
        SetTriggerAnimation(TypeUnitAnimation.Crouch, "crouch");
    }

    [ContextMenu("Walk")]
    public void Walk() {
        SetTriggerAnimation(TypeUnitAnimation.Walk, "walk");
    }

    [ContextMenu("CrouchWalk")]
    public void CrouchWalk()
    {
        SetTriggerAnimation(TypeUnitAnimation.CrouchWalk, "crouch_walk");
    }

    [ContextMenu("Run")]
    public void Run()
    {
        SetTriggerAnimation(TypeUnitAnimation.Run, "run");
    }

    [ContextMenu("ClimbRope")]
    public void ClimbRope()
    {
        SetTriggerAnimation(TypeUnitAnimation.ClimbRope, "climb_rope");
    }

    [ContextMenu("Climb")]
    public void Climb()
    {
        SetTriggerAnimation(TypeUnitAnimation.Climb, "climb");
    }

    [ContextMenu("Death")]
    public void Death()
    {
        SetTriggerAnimation(TypeUnitAnimation.Death, "death");
    }

    public void SetTriggerAnimation(TypeUnitAnimation type, string nameTrigger) {
        if (currentType != type)
        {
            controller.SetTrigger(nameTrigger);
            currentType = type;
        }
    }
}

public enum TypeUnitAnimation {
    Idle,
    Crouch,
    Walk,
    CrouchWalk,
    Run,
    ClimbRope,
    Climb,
    Death
}
