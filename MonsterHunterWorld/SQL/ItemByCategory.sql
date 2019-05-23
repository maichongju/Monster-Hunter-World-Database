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
       name,
       description,
       first_id,
       first_name,
       first_icon_name,
       first_icon_color,
       second_id,
       second_name,
       second_icon_name,
       second_icon_color,
       quantity
  FROM item
       LEFT OUTER JOIN
       item_text ON item.id = item_text.id
       LEFT OUTER JOIN
       (
           SELECT result_id,
                  first_id,
                  name AS first_name,
                  icon_name AS first_icon_name,
                  icon_color AS first_icon_color,
                  item_combination.second_id,
                  second_name,
                  second_icon_name,
                  second_icon_color,
                  quantity
             FROM item_combination
                  LEFT OUTER JOIN
                  item_text ON item_text.id = item_combination.first_id
                  LEFT OUTER JOIN
                  (
                      SELECT second_id,
                             name AS second_name,
                             icon_name AS second_icon_name,
                             icon_color AS second_icon_color
                        FROM item_combination
                             JOIN
                             item_text ON item_text.id = item_combination.second_id
                             JOIN
                             item ON item.id = second_id
                       WHERE lang_id = @lang
                  )
                  AS second_name ON second_name.second_id = item_combination.second_id
                  JOIN
                  item ON item.id = item_combination.first_id
            WHERE lang_id = @lang
            GROUP BY item_combination.id
       )
       AS item_combin_name ON item_combin_name.result_id = item.id
 WHERE lang_id = @lang and
category = @category
 ORDER BY item.id;