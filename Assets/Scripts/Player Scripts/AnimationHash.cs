using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AnimationHash
{
    public static readonly int walkFront = Animator.StringToHash("isWalkingFront");
    public static readonly int walkBack = Animator.StringToHash("isWalkingBack");
    public static readonly int walkSide = Animator.StringToHash("isWalkingSide");
}
