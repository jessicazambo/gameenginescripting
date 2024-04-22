using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RosalinaAnimationController : MonoBehaviour
{
    private Animator animator;
    private Week13.Player player;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<Week13.Player>();
        player.SpeedChangedEvent.AddListener(OnPlayerSpeedChanged);
    }

    void OnPlayerSpeedChanged(float speed)
    {
        if (speed == 0) DoIdle();
        else if (speed <= 5) DoWalk();
        else if (speed <= 8) DoRun();
        else DoRunFaster();
    }

    [ContextMenu("Do Walk")]
    void DoWalk()
    {
        animator.SetInteger("speed", 3);
    }

    [ContextMenu("Do Run")]
    void DoRun()
    {
        animator.SetInteger("speed", 8);
        animator.SetFloat("speed_multiplier", 1);
    }

    [ContextMenu("Do Run Faster")]
    void DoRunFaster()
    {
        animator.SetInteger("speed", 8);
        animator.SetFloat("speed_multiplier", 2);
    }

    [ContextMenu("Do Idle")]
    void DoIdle()
    {
        animator.SetInteger("speed", 0);
    }
}
