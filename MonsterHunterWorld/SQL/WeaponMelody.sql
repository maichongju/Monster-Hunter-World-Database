SELECT weapon_melody.id AS MelodyID,
       notes AS Notes,
       duration AS Duration,
       extension AS Extension,
       effect1 AS Effect1,
       effect2 AS Effect2
  FROM Weapon_melody
       JOIN
       weapon_melody_text ON weapon_melody.id = weapon_melody_text.id
 WHERE weapon_melody_text.lang_id = @lang;
