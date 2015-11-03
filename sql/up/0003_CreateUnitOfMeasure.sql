-- this exists in public for now
--http://www.jdetables.com/?schema=910&column=UM
--http://dba.stackexchange.com/questions/12590/whats-a-good-relational-structure-for-units-and-complex-unit-conversions

CREATE TABLE units
(
	unit char(2),
	description text,
    CONSTRAINT pk_units PRIMARY KEY (unit)
);

CREATE TABLE unit_conversions
(
	unit char(2) NOT NULL,
	related_unit char(2) NOT NULL,
	conversion decimal NOT NULL,
    CONSTRAINT pk_unit_conversions PRIMARY KEY (unit, related_unit)
);

INSERT INTO units (unit, description)
VALUES ('lb', 'Pounds'),
       ('kg', 'Kilograms'),
       ('pd', 'Pood'),
  	   ('bw', 'Body Weight'),
  	   ('km', 'Kilometers'),
  	   ('ft', 'Feet'),
  	   ('ml', 'Miles'),
  	   ('dm', 'Damper'),
       ('rp', 'Reps'),
       ('sc', 'Seconds'),
       ('na', 'Not Applicable');

INSERT INTO unit_conversions (unit, related_unit, conversion)
VALUES ('lb','kg', 0.453592),
       ('lb','pd', 0.0276907);
