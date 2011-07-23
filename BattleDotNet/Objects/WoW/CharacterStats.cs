﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class CharacterStats
    {
        [JsonProperty("health")]
        public int Health { get; private set; }

        [JsonProperty("power")]
        public int Power { get; private set; }

        [JsonProperty("str")]
        public int Strength { get; private set; }

        [JsonProperty("agi")]
        public int Agility { get; private set; }

        [JsonProperty("sta")]
        public int Stamina { get; private set; }

        [JsonProperty("int")]
        public int Intellect { get; private set; }

        [JsonProperty("spr")]
        public int Spirit { get; private set; }

        [JsonProperty("attackPower")]
        public int AttackPower { get; private set; }

        [JsonProperty("rangedAttackPower")]
        public int RangedAttackPower { get; private set; }

        [JsonProperty("mastery")]
        public double Mastery { get; private set; }

        [JsonProperty("masteryRating")]
        public int MasteryRating { get; private set; }

        [JsonProperty("crit")]
        public double Crit { get; private set; }

        [JsonProperty("critRating")]
        public int CritRating { get; private set; }

        [JsonProperty("hitPercent")]
        public double HitPercent { get; private set; }

        [JsonProperty("hitRating")]
        public int HitRating { get; private set; }

        [JsonProperty("hasteRating")]
        public int HasteRating { get; private set; }

        [JsonProperty("expertiseRating")]
        public int ExpertiseRating { get; private set; }

        [JsonProperty("spellPower")]
        public int SpellPower { get; private set; }

        [JsonProperty("spellPen")]
        public int SpellPen { get; private set; }

        [JsonProperty("spellCrit")]
        public double SpellCrit { get; private set; }

        [JsonProperty("spellCritRating")]
        public int SpellCritRating { get; private set; }

        [JsonProperty("spellHitPercent")]
        public double SpellHitPercent { get; private set; }

        [JsonProperty("spellHitRating")]
        public int SpellHitRating { get; private set; }

        [JsonProperty("mana5")]
        public int ManaPer5 { get; private set; }

        [JsonProperty("mana5combat")]
        public int ManaPer5InCombat { get; private set; }

        [JsonProperty("armor")]
        public int Armor { get; private set; }

        [JsonProperty("dodge")]
        public double Dodge { get; private set; }

        [JsonProperty("dodgeRating")]
        public int DodgeRating { get; private set; }

        [JsonProperty("parry")]
        public double Parry { get; private set; }

        [JsonProperty("parryRating")]
        public int ParryRating { get; private set; }

        [JsonProperty("block")]
        public double Block { get; private set; }

        [JsonProperty("blockRating")]
        public int BlockRating { get; private set; }

        [JsonProperty("resil")]
        public int Resillience { get; private set; }

        [JsonProperty("mainHandDmgMin")]
        public int MainHandDamageMin { get; private set; }

        [JsonProperty("mainHandDmgMax")]
        public int MainHandDamageMax { get; private set; }

        [JsonProperty("mainHandSpeed")]
        public double MainHandSpeed { get; private set; }

        [JsonProperty("mainHandDps")]
        public double MainHandDps { get; private set; }

        [JsonProperty("mainHandExpertise")]
        public double MainHandExpertise { get; private set; }

        [JsonProperty("offHandDmgMin")]
        public int OffHandDamageMin { get; private set; }

        [JsonProperty("offHandDmgMax")]
        public int OffHandDamageMax { get; private set; }

        [JsonProperty("offHandSpeed")]
        public double OffHandSpeed { get; private set; }

        [JsonProperty("offHandDps")]
        public double OffHandDps { get; private set; }

        [JsonProperty("offHandExpertise")]
        public double OffHandExpertise { get; private set; }

        [JsonProperty("rangedDmgMin")]
        public int RangedDamageMin { get; private set; }

        [JsonProperty("rangedDmgMax")]
        public int RangedDamageMax { get; private set; }

        [JsonProperty("rangedSpeed")]
        public double RangedSpeed { get; private set; }

        [JsonProperty("rangedDps")]
        public double RangedDps { get; private set; }

        [JsonProperty("rangedCrit")]
        public double RangedCrit { get; private set; }

        [JsonProperty("rangedCritRating")]
        public int RangedCritRating { get; private set; }

        [JsonProperty("rangedHitPercent")]
        public double RangedHitPercent { get; private set; }

        [JsonProperty("rangedHitRating")]
        public int RangedHitRating { get; private set; }
    }
}   
