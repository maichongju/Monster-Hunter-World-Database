/*
parameter:
@lang language 
*/
SELECT monster_id AS MonsterID,
       rank AS Rank,
       item_id AS ItemID,
       stack AS Stack,
       percentage AS Percentage,
       monster_reward_condition_text.name AS ConditionName,
       icon_name AS IconName,
       icon_color AS IconColor,
       item_text.name AS ItemName
  FROM monster_reward
       JOIN
       monster_reward_condition_text ON monster_reward.condition_id = monster_reward_condition_text.id
       JOIN
       item ON item.id = monster_reward.item_id
       JOIN
       item_text ON item_text.id = monster_reward.item_id
 WHERE monster_reward_condition_text.lang_id = @lang AND 
       item_text.lang_id = @lang
 ORDER BY monster_id,
          monster_reward.rank DESC,
          monster_reward.condition_id,
          item.id;

