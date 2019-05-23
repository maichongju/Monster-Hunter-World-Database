/*
Parameter
@lang Language need to select from
*/
SELECT monster_id AS MonsterID,
       name AS PartName,
       cut AS Cut,
       impact AS Impact,
       shot AS Shot,
       fire AS Fire,
       water AS Water,
       ice AS Ice,
       thunder AS Thunder,
       dragon AS Dragon,
       ko AS KO
  FROM monster_hitzone
       JOIN
       monster_hitzone_text ON monster_hitzone.id = monster_hitzone_text.id
 WHERE lang_id = @lang
 ORDER BY monster_hitzone.monster_id,
          monster_hitzone.id;
