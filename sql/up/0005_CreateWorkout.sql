CREATE TYPE workouts.priority AS ENUM ('time','task');

/*
sessions (a training day / fittest games)
- parts
- - steps
*/

CREATE TABLE workouts.sessions
(
	id serial NOT NULL,
	organization_id int NOT NULL,
	name text NOT NULL,
	summary text NOT NULL DEFAULT ''::text,
    CONSTRAINT pk_sessions PRIMARY KEY (id),
    CONSTRAINT uq_sessions_name_organization UNIQUE (name, organization_id)
);

CREATE TABLE workouts.parts
(
	id serial NOT NULL,
	session_id int NOT NULL,
	duration interval NOT NULL DEFAULT '1:00:00'::interval,
	priority workouts.priority NOT NULL,
	rounds int NOT NULL DEFAULT 1,
    CONSTRAINT pk_parts PRIMARY KEY (id)
);

CREATE TABLE workouts.steps
(
	id serial NOT NULL,
	session_part_id int NOT NULL,
	line int NOT NULL,
	movement int NOT NULL,
	load int NOT NULL,
	load_uom char(2) NOT NULL,
	qty int NOT NULL,
	qty_uom char(2)	NOT NULL,
	notes text NOT NULL DEFAULT '',
    CONSTRAINT pk_steps PRIMARY KEY (id)
);
