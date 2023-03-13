using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New DeathState", menuName = "Behavior/DeathState")]
public class DeathState : BehaviorState
{
    [SerializeField] AudioClip deathClip;

    public override void EnterState(BehaviorStateManager manager)
    {
        manager.SetAnimation(EnemyAnimationTriggers.Death);

        SoundManager.Instance.PlaySound(deathClip);
    }

    public override void ExitState(BehaviorStateManager manager)
    {

    }

    public override void UpdateState(BehaviorStateManager manager)
    {

    }

    public override void OnStateTriggerEnter(BehaviorStateManager manager, Collider2D other)
    {

    }

    public override void OnStateTriggerExit(BehaviorStateManager manager, Collider2D other)
    {

    }
}
