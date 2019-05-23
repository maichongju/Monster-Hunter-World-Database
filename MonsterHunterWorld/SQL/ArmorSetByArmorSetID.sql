SELECT armorset.id,
       rank,
       monster_id,
       rarity,
       armorset_bonus_id,
       armorset_text.name,
       setbonus_id,
       required,
       set_bonus_name,
       description,
       monster_name,
       defense_base,
       defense_max,
       fire,
       water,
       thunder,
       ice,
       dragon
  FROM armorset
       JOIN
       armorset_text ON armorset.id = armorset_text.id
       JOIN
       (
           SELECT armorset.id,
                  setbonus_id,
                  skilltree_id,
                  required,
                  name AS set_bonus_name,
                  description
             FROM armorset
                  LEFT OUTER JOIN
                  (
                      SELECT setbonus_id,
                             skilltree_id,
                             required,
                             name,
                             description
                        FROM armorset_bonus_skill AS abk
                             JOIN
                             skilltree_text AS st ON abk.skilltree_id = st.id
                       WHERE lang_id = @lang
                  )
                  AS bonus_skill ON bonus_skill.setbonus_id = armorset.armorset_bonus_id
       )
       AS armorset_bouns ON armorset.id = armorset_bouns.id
       JOIN
       (
           SELECT armorset.id,
                  name AS monster_name
             FROM armorset
                  LEFT OUTER JOIN
                  monster_text ON monster_text.id = armorset.monster_id
            WHERE lang_id = @lang OR
                  lang_id IS NULL
       )
       AS armorset_monster ON armorset_monster.id = armorset.id
       JOIN
       (
           SELECT armorset_id,
                  sum(defense_base) AS defense_base,
                  sum(defense_augment_max) AS defense_max,
                  sum(fire) AS fire,
                  sum(water) AS water,
                  sum(thunder) AS thunder,
                  sum(ice) AS ice,
                  sum(dragon) AS dragon
             FROM armor
            GROUP BY armorset_id
       )
       AS armorset_defense ON armorset_defense.armorset_id = armorset.id
       JOIN
       (
           SELECT armorset.id,
                  rarity
             FROM armorset
                  LEFT OUTER JOIN
                  armor ON armorset.id = armor.armorset_id
            GROUP BY armorset.id
       )
       AS armorset_rarity ON armorset_rarity.id = armorset.id
 WHERE armorset_text.lang_id = @lang and armorset.id = @asid;