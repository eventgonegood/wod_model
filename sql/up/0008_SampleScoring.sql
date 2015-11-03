--sample fran score
DO $$

DECLARE sheetid int;
DECLARE orgid int;
DECLARE userid int;
DECLARE sessionid int;

BEGIN
  SELECT id INTO orgid
  FROM accounts.organizations
  WHERE name = 'demo';

  SELECT id INTO userid
  FROM accounts.users
  WHERE username = 'drusellers';

  SELECT id INTO sessionid
  FROM workouts.sessions
  WHERE name = 'Fran';

  INSERT INTO scores.scoresheets (organization_id, user_id, session_id, measured_on, priority, score, score_uom)
  VALUES (orgid, userid, sessionid, DEFAULT, 'time', 136, 'sc')
  RETURNING id INTO sheetid;


  INSERT INTO scores.scoresheet_entries (scoresheet_id, line_id, load, load_uom, qty, qty_uom, movement_name)
  VALUES (sheetid, 1, 95, 'lb', 21, 'rp', 'Thruster'),
         (sheetid, 2, 0, 'bw', 21, 'rp', 'Pull Ups'),
         (sheetid, 3, 95, 'lb', 15, 'rp', 'Thruster'),
         (sheetid, 4, 0, 'bw', 15, 'rp', 'Pull Ups'),
         (sheetid, 5, 95, 'lb', 9, 'rp', 'Thruster'),
         (sheetid, 6, 0, 'bw', 9, 'rp', 'Pull Ups');
END $$;
