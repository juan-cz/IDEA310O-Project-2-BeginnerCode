using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class EquipScript : EquipmentItem.EquippedEffect
{
     public override void Equipped(CharacterData user)
     {
          user.Stats.ChangeHealth(5);
     }
     
     public override void Removed(CharacterData user)
     {
          user.Stats.ChangeHealth(-5);
     }
}
