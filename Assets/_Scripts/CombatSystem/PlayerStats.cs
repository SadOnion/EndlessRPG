using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace CombatSystem.Stats
{
    public class PlayerStats 
    {
        public CharacterStat Vit;
        public CharacterStat Str;
        public CharacterStat Int;
        public CharacterStat Dex;

        public PlayerStats()
        {
            Vit = new CharacterStat(1);
            Str = new CharacterStat(1);
            Int = new CharacterStat(1);
            Dex = new CharacterStat(1);
        }
        
    }
   

}