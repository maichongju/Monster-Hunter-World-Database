SELECT charm.id AS CharmID,
       previous_id AS PreviousID,
       rarity AS Rarity,
       charm_text.name AS Name,
       SkillTreeID,
       SkillLevel,
       MaxLevel,
       SkillName,
       ItemID,
       ItemIconName,
       ItemIconColor,
       Quantity,
       ItemName
  FROM charm
       JOIN
       charm_text ON charm_text.id = charm.id
       LEFT OUTER JOIN
       (
           SELECT charm_id,
                  skilltree_id AS SkillTreeID,
                  level AS SkillLevel,
                  max_level AS MaxLevel,
                  name AS SkillName
             FROM charm_skill
                  JOIN
                  skilltree ON skilltree.id = charm_skill.skilltree_id
                  JOIN
                  skilltree_text ON skilltree_text.id = charm_skill.skilltree_id
            WHERE skilltree_text.lang_id = @lang
       )
       AS CharmSkill ON CharmSkill.charm_id = charm.id
       LEFT OUTER JOIN
       (
           SELECT charm.id,
                  item_id AS ItemID,
                  item.icon_name AS ItemIconName,
                  item.icon_color AS ItemIconColor,
                  quantity AS Quantity,
                  name AS ItemName
             FROM charm
                  JOIN
                  charm_recipe ON charm.id = charm_recipe.charm_id
                  JOIN
                  item_text ON item_text.id = charm_recipe.item_id
                  JOIN
                  item ON item.id = item_text.id
            WHERE item_text.lang_id = @lang
       )
       AS CharmItem ON CharmItem.id = charm.id
 WHERE charm_text.lang_id = @lang
 ORDER BY CharmID,
          ItemID;
