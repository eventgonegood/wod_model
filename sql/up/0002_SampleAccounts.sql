WITH o AS (
  INSERT INTO accounts.organizations (id, name)
  VALUES (DEFAULT, 'demo')
  RETURNING id, 1 AS link
), r AS (
  INSERT INTO accounts.roles (id, name)
  VALUES (DEFAULT, 'sa')
  RETURNING id, 1 AS link
), u AS (
  INSERT INTO accounts.users (id, name, username, password)
  VALUES (DEFAULT, 'Dru Sellers', 'drusellers','password')
  RETURNING id, 1 AS link
)
INSERT INTO accounts.memberships (organization_id, user_id, role_id)
SELECT o.id, u.id, r.id
FROM o
    INNER JOIN u ON u.link = o.link
    INNER JOIN r ON r.link = o.link
