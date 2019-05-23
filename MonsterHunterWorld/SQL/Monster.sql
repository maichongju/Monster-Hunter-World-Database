/*
SQL for TempMonster
Parameter:
@lang Language for the text
*/

SELECT monster.id AS MonsterID,
       name AS Name,
	   size as Size,
       ecology AS Ecology,
       description AS Description,
       alt_state_description AS AltStateDescription,
       has_weakness AS HasWeakness,
       has_alt_weakness AS HasAltWeakness,
       weakness_fire AS WeaknessFire,
       weakness_water AS WeaknessWater,
       weakness_ice AS WeaknessIce,
       weakness_thunder AS WeaknessThunder,
       weakness_dragon AS WeaknessDragon,
       weakness_poison AS WeaknessPoison,
       weakness_sleep AS WeaknessSleep,
       weakness_paralysis AS WeaknessParalysis,
       weakness_blast AS WeaknessBlast,
       weakness_stun AS WeaknessStun,
       alt_weakness_fire AS AltWeaknessFire,
       alt_weakness_water AS AltWeaknessWater,
       alt_weakness_ice AS AltWeaknessIce,
       alt_weakness_thunder AS AltWeaknessThunder,
       alt_weakness_dragon AS AltWeaknessDragon,
       ailment_roar AS AilmentRoar,
       ailment_wind AS AilmentWind,
       ailment_tremor AS AilmentTremor,
       ailment_defensedown AS AilmentDefensedown,
       ailment_fireblight AS AilmentFireblight,
       ailment_waterblight AS AilmentWaterblight,
       ailment_thunderblight AS AilmentThunderblight,
       ailment_iceblight AS AilmentIceblight,
       ailment_dragonblight AS AilmentDragonblight,
       ailment_blastblight AS AilmentBlastblight,
       ailment_poison AS AilmentPoison,
       ailment_sleep AS AilmentSleep,
       ailment_paralysis AS AilmentParalysis,
       ailment_bleed AS AilmentBleed,
       ailment_stun AS AilmentStun,
       ailment_mud AS AilmentMud,
       ailment_effluvia AS AilmentEffluvia
  FROM monster
       JOIN
       monster_text ON monster.id = monster_text.id
 WHERE lang_id = @lang
 ORDER BY monster.id;
