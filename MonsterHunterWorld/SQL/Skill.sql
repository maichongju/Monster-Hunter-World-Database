SELECT skilltree.id as SkillId,
       skilltree.max_level as MaxLevel,
       skilltree.icon_color as IconColor,
       name as  Name,
       skilltree_text.description AS SkillTitle,
       skill.level as Level,
       skill.description as Description
  FROM skilltree
       JOIN
       skilltree_text ON skilltree_text.id = skilltree.id
       LEFT OUTER JOIN
       skill ON skilltree.id = skill.skilltree_id
 WHERE skilltree_text.lang_id = @lang AND 
       skill.lang_id = @lang
Order by skill.skilltree_id,skill.level       
;
