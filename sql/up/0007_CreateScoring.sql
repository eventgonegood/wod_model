CREATE SCHEMA scores;

CREATE TABLE scores.scoresheets
(
	id serial NOT NULL,
	organization_id int NOT NULL,
	user_id int NOT NULL,
	session_id int NOT NULL,
	measured_on timestamp NOT NULL DEFAULT current_date,
	priority workouts.priority NOT NULL,
	score int NOT NULL DEFAULT 0,
	score_uom char(2) NOT NULL DEFAULT 'na',
	CONSTRAINT pk_scoresheets PRIMARY KEY (id),
  CONSTRAINT uq_movements_name UNIQUE (organization_id, user_id, session_id)
);

CREATE TABLE scores.scoresheet_entries
(
	id serial NOT NULL,
	scoresheet_id int NOT NULL,
	line_id int NOT NULL,
	movement_name text NOT NULL,
	load int NOT NULL,
	load_uom char(2) NOT NULL,
	qty int NOT NULL,
	qty_uom char(2) NOT NULL,
	CONSTRAINT pk_scoresheet_entries PRIMARY KEY (id),
  CONSTRAINT uq_scoresheet_line UNIQUE (scoresheet_id, line_id)
);


