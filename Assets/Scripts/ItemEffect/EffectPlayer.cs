using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class EffectPlayer : UsableItem.UsageEffect
{
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(3);
        return true;
    }
}
