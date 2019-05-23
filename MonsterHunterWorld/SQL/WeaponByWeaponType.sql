SELECT weapon.id AS WeaponID,
       name AS Name,
       weapon_type AS WeaponType,
       rarity AS Rarity,
       category AS Category,
       attack AS Attack,
       attack_true AS AttackTrue,
       affinity AS Affinity,
       defense AS Defense,
       slot_1 AS Slot1,
       slot_2 AS Slot2,
       slot_3 AS Slot3,
       element1 AS Element1,
       element1_attack AS Element1Attack,
       element2 AS Element2,
       element2_attack AS Element2Attack,
       element_hidden AS ElementHidden,
       elderseal AS ElderSeal,
       sharpness AS Sharpness,
       sharpness_maxed AS SharpnessMaxed,
       previous_weapon_id AS PreviousWeaponID,
       craftable AS Craftable,
       final AS Final,
       kinsect_bonus AS KinsectBonus,
       phial AS Phial,
       phial_power AS PhialPower,
       shelling AS Shelling,
       shelling_level AS ShellingLevel,
       notes AS Notes,
       coating_close AS CoatingClose,
       coating_power AS CoatingPower,
       coating_paralysis AS CoatingParalysis,
       coating_poison AS CoatingPoison,
       coating_sleep AS CoatingSleep,
       coating_blast AS CoatingBlast,
       ammo_id AS AmmoID,
       SkillID,
       SkillName,
       SkillLevel,
       SkillMaxLevel,
       skill_icon_color,
       ItemID,
       ItemName,
       RecipeType,
       Quantity,
       IconName,
       IconColor
  FROM weapon
       JOIN
       weapon_text ON weapon_text.id = weapon.id
       LEFT OUTER JOIN
       (
           SELECT weapon_id,
                  item_id AS ItemID,
                  recipe_type AS RecipeType,
                  quantity AS Quantity,
                  name AS ItemName,
                  icon_name AS iconName,
                  icon_color AS iconColor
             FROM weapon_recipe
                  JOIN
                  item_text ON weapon_recipe.item_id = item_text.id
                  JOIN
                  item ON item.id = weapon_recipe.item_id
            WHERE lang_id = @lang
       )
       AS Craft ON Craft.weapon_id = weapon.id
       LEFT OUTER JOIN
       (
           SELECT weapon_id,
                  skilltree_id AS SkillID,
                  level AS SkillLevel,
                  max_level AS SkillMaxLevel,
                  name AS SkillName,
                  icon_color AS skill_icon_color
             FROM weapon_skill
                  JOIN
                  skilltree_text ON weapon_skill.skilltree_id = skilltree_Text.id AND 
                                    weapon_skill.level = weapon_skill.level
                  JOIN
                  skilltree ON skilltree.id = weapon_skill.skilltree_id
            WHERE skilltree_text.lang_id = @lang
       )
       AS WK ON WK.weapon_id = WeaponID
 WHERE weapon_text.lang_id = @lang AND 
       weapon.weapon_type = @weapontype;
