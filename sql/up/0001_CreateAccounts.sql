CREATE SCHEMA accounts;

CREATE TABLE accounts.organizations
(
  id serial NOT NULL,
  name text NOT NULL,
  CONSTRAINT pk_organizations PRIMARY KEY (id),
  CONSTRAINT uq_organizations_name UNIQUE (name)
);

CREATE TABLE accounts.users
(
  id serial NOT NULL,
  name text NOT NULL DEFAULT ''::text,
  username text NOT NULL,
  password text NOT NULL,
  CONSTRAINT pk_users PRIMARY KEY (id),
  CONSTRAINT uq_users_username UNIQUE (username)
);

CREATE TABLE accounts.roles
(
  id serial NOT NULL,
  name text NOT NULL,
  CONSTRAINT pk_roles PRIMARY KEY (id),
  CONSTRAINT uq_roles_name UNIQUE (name)
);

CREATE TABLE accounts.memberships
(
  organization_id int NOT NULL,
  user_id int NOT NULL,
  role_id int NOT NULL,
  CONSTRAINT pk_memberships PRIMARY KEY (organization_id, user_id),
  CONSTRAINT fk_memberships_organizations FOREIGN KEY (organization_id)
    REFERENCES accounts.organizations (id) MATCH SIMPLE,
  CONSTRAINT fk_memberships_users FOREIGN KEY (user_id)
    REFERENCES accounts.organizations (id) MATCH SIMPLE,
  CONSTRAINT fk_memberships_roles FOREIGN KEY (role_id)
    REFERENCES accounts.roles (id) MATCH SIMPLE
);
