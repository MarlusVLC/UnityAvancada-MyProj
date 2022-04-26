using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBehaviour : StateMachineBehaviour
{
    public Transform target;
     // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Debug.Log("Animation Started: " + stateInfo.IsName("Idle01") );
        // Debug.Log(layerIndex.ToString());
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (Input.GetButton("Fire1"))
        {
                animator.MatchTarget(target.position, target.rotation, AvatarTarget.RightHand,
                    new MatchTargetWeightMask(Vector3.one, 1f), 0.2f, 0.8f);
        }
                
    }

     // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // Debug.Log("Animation ended");
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
