SELECT monster_id AS MonsterID,
       flinch AS Flinch,
       wound AS Wound,
       sever AS Sever,
       extract AS Extract,
       part_name AS PartName
  FROM monster_break
       JOIN
       monster_break_text ON monster_break.id = monster_break_text.id
 WHERE lang_id = @lang
 ORDER BY monster_break.monster_id,monster_break.id;

