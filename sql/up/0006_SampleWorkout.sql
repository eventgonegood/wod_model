--fran
DO $$
DECLARE pid int;
DECLARE tid int;
DECLARE puid int;
BEGIN
	INSERT INTO workouts.sessions (organization_id, name)
	VALUES (1, 'Fran');


	INSERT INTO workouts.parts (id, session_id, rounds, priority)
	VALUES (DEFAULT, (SELECT id FROM workouts.sessions WHERE name = 'Fran'), 1, 'time')
	RETURNING id INTO pid;

  SELECT id INTO tid FROM workouts.movements WHERE name = 'Thruster';
  SELECT id INTO puid FROM workouts.movements WHERE name = 'Pull Up';

	INSERT INTO workouts.steps (session_part_id, line, movement, load, load_uom, qty, qty_uom)
	VALUES (pid, 1, tid, 95, 'lb', 21, 'rp'),
	       (pid, 2, puid, 0, 'bw', 21, 'rp'),
	       (pid, 3, tid, 95, 'lb', 15, 'rp'),
	       (pid, 4, puid, 0, 'bw', 15, 'rp'),
	       (pid, 5, tid, 95, 'lb', 9, 'rp'),
	       (pid, 6, puid, 0, 'bw', 9, 'rp');
END $$;

/*


-- row
WITH aRow AS (
	INSERT INTO workouts.sessions (id, name)
    VALUES (DEFAULT, 'A Big Row')
	RETURNING id
), part AS (
	INSERT INTO workout_parts (id, workout_id, rounds, priority)
	VALUES (DEFAULT, aRow.id, 1, 'work')
	RETURING id
), steps as (
	INSERT INTO steps (workout_id, line, movement, load, load_uom, qty, qty_uom)
	VALUES (part.id, 1, 'Row', 5, 'dm', 5, 'km')
)

--verve
WITH fran AS (
	INSERT INTO workouts.sessions (id, name)
    VALUES (DEFAULT, '20151025')
	RETURNING id
), part AS (
	INSERT INTO workout_parts (id, workout_id, rounds, priority)
	VALUES (DEFAULT fran.id, 1, 'time')
	RETURING id
), steps as (
	INSERT INTO steps (workout_id, line, movement, value, uom)
	VALUES (fran.id, 1, 'Ab Mat Sit Ups', 0, 'bw', 50, 'rp'),
		   (fran.id, 2, 'Muscle Ups',  0, 'bw', 5, 'rp'),
		   (fran.id, 1, 'Ab Mat Sit Ups', 0, 'bw', 40, 'rp'),
		   (fran.id, 2, 'Muscle Ups', 0, 'bw', 4, 'rp'),
		   (fran.id, 1, 'Ab Mat Sit Ups', 0, 'bw', 30, 'rp'),
		   (fran.id, 2, 'Muscle Ups', 0, 'bw', 3, 'rp'),
		   (fran.id, 1, 'Ab Mat Sit Ups', 0, 'bw', 20, 'rp'),
		   (fran.id, 2, 'Muscle Ups', 0, 'bw', 2, 'rp'),
		   (fran.id, 1, 'Ab Mat Sit Ups', 0, 'bw', 10, 'rp'),
		   (fran.id, 2, 'Muscle Ups', 0, 'bw', 1, 'rp')
)


--winchester

WITH c AS (
	INSERT INTO workouts.sessions (id, org_id, name)
	VALUES (DEFAULT, 'karhu', '20151025', 'summary')
	RETURNING id
), part AS (
	INSERT INTO workouts.parts (id, workout_id, rounds, priority)
	VALUES (DEFAULT c.id, 1, 'time')
	RETURING id
), steps AS (
	INSERT INTO workouts.steps (workout_id, line, movement, load, load_uom, qty, qty_uom)
	VALUES (part.id, 1, 'zercher carry', 300, 'lb', 100, 'ft'),
		   (part.id, 2, 'farmer carry', 190, 'lb', 200, 'ft'),
		   (part.id, 3, 'sled pull', 225, 'lb', 100, 'ft')
);

--2 mile run

WITH c AS (
	INSERT INTO workouts.sessions (id, org_id, name)
	VALUES (DEFAULT, 'karhu', '20151026', 'summary')
	RETURNING id
), part AS (
	INSERT INTO workouts.parts (id, workout_id, rounds, priority)
	VALUES (DEFAULT c.id, 1, 'time')
	RETURING id
), steps AS (
	INSERT INTO workouts.steps (workout_id, line, movement, load, load_uom, qty, qty_uom)
	VALUES (part.id, 1, 'Run', 0, 'bw', 2, 'ml')
)
*/
