SELECT item_id AS ItemID,
       quantity AS Quantity,
       name AS Name,
       icon_name AS iconName,
       icon_color AS iconColor
  FROM weapon_recipe
       JOIN
       item_text ON weapon_recipe.item_id = item_text.id
       JOIN
       item ON item.id = weapon_recipe.item_id
 WHERE lang_id = @lang AND 
       weapon_id = @WeaponID;
