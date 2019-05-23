SELECT decoration.id AS ID,
       decoration_text.name AS Name,
       rarity AS Rarity,
       skilltree_id AS SkillTreeID,
       max_level AS MaxLevel,
       skilltree_text.name AS SkillName,
       slot AS Slot,
       decoration.icon_color,
       mysterious_feystone_percent AS MysteriousFeystonePercent,
       glowing_feystone_percent AS GlowingFeystonePercent,
       worn_feystone_percent AS WornFeystonePercent,
       warped_feystone_percent AS WarpedFeystonePercent
  FROM decoration
       JOIN
       decoration_text ON decoration.id = decoration_text.id
       JOIN
       skilltree_text ON decoration.skilltree_id = skilltree_text.id
       JOIN
       skilltree ON skilltree.id = decoration.skilltree_id
 WHERE decoration_text.lang_id = @lang AND 
       skilltreE_text.lang_id = @lang;
