SELECT armor.id as ArmorID,
       armor_text.name as Name,
       rarity as Rarity,
       rank as Rank,
       armor_type as ArmorType,
       armorset_id as ArmorsetId,
       slot_1 AS Slot1,
       slot_2 as Slot2,
       slot_3 as Slot3,
       defense_base as DefenseBase,
       defense_augment_max AS DefenseMax,
       fire as Fire,
       water as Water,
       thunder as Thunder,
       ice as Ice,
       dragon as Dragon,
       skilltree_id as SkillTreeID,
       level as Level,
       max_level as MaxLevel,
       skill_name as SkillName,
       skill_title as SkillTitle,
       description as Description,
       item_id as ItemID,
       quantity as Quantity,
       item_name as ItemName,
       icon_name as IconName,
       icon_color
  FROM armor
       JOIN
       armor_text ON armor.id = armor_text.id
       LEFT OUTER JOIN
       (
           SELECT armor_skill.armor_id,
                  armor_skill.skilltree_id,
                  armor_skill.level,
                  skilltree.max_level,
                  name AS skill_name,
                  skilltree_text.description AS skill_title,
                  skill.description
             FROM armor_skill
                  JOIN
                  skilltree_text ON armor_skill.skilltree_id = skilltree_text.id
                  JOIN
                  skill ON skill.skilltree_id = armor_skill.skilltree_id AND 
                           armor_skill.level = skill.level
                  JOIN
                  skilltree ON skilltree.id = armor_skill.skilltree_id
            WHERE skill.lang_id = @lang AND 
                  skilltree_text.lang_id = @lang
       )
       AS armor_skilltree ON armor_skilltree.armor_id = armor.id
       LEFT OUTER JOIN
       (
           SELECT armor_id,
                  item_id,
                  quantity,
                  item_name,
                  icon_name,
                  icon_color
             FROM armor_recipe
                  LEFT OUTER JOIN
                  (
                      SELECT item.id,
                             name AS item_name,
                             icon_name,
                             icon_color
                        FROM item
                             JOIN
                             item_text ON item.id = item_text.id
                       WHERE lang_id = @lang
                  )
                  AS item_name ON item_name.id = armor_recipe.item_id
       )
       AS armor_item_name ON armor_item_name.armor_id = armor.id
 WHERE armor_text.lang_id = @lang AND 
       armor.armor_type = @armortype
 ORDER BY armor.id;
