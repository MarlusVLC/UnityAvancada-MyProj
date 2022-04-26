using System;
using UnityEngine;

public class AnimationTesting : MonoBehaviour
{
    public Transform target;
    public int eventTester;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.MatchTarget(target.position, target.rotation, AvatarTarget.RightHand,
                new MatchTargetWeightMask(Vector3.one, 0f), 0.2f, 0.8f);
        }
    }

    public void TestEvent(int a)
    {
        Debug.Log((a+eventTester).ToString());
    }
}