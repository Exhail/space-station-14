﻿using System.Numerics;

namespace Content.Shared.Clothing.Components;

/// <summary>
/// Defines something as causing waddling when worn.
/// </summary>
[RegisterComponent]
public sealed partial class WaddleWhenWornComponent : Component
{
    ///<summary>
    /// How high should they hop during the waddle? Higher hop = more energy.
    /// </summary>
    [DataField]
    public Vector2 HopIntensity = new(0, 0.25f);

    /// <summary>
    /// How far should they rock backward and forward during the waddle?
    /// Each step will alternate between this being a positive and negative rotation. More rock = more scary.
    /// </summary>
    [DataField]
    public float TumbleIntensity = 20.0f;

    /// <summary>
    /// How long should a complete step take? Less time = more chaos.
    /// </summary>
    [DataField]
    public float AnimationLength = 0.66f;

    /// <summary>
    /// How much shorter should the animation be when running?
    /// </summary>
    [DataField]
    public float RunAnimationLengthMultiplier = 0.568f;
}
