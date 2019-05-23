SELECT item.id,
       category,
       subcategory,
       rarity,
       buy_price,
       sell_price,
       carry_limit,
       points,
       icon_name,
       icon_color,
       lang_id,
       name,
       description
  FROM item
       JOIN
       item_text ON item.id = item_text.id
 WHERE lang_id = @lang AND
    item.id = @ItemID;