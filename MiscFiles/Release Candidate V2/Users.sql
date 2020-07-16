CREATE USER 'viewerapp'@'%' IDENTIFIED BY 'toor';
CREATE USER 'adminapp'@'%' IDENTIFIED BY 'toor';

GRANT SELECT ON VeteransMuseum.* TO 'viewerapp'@'%';
GRANT INSERT ON VeteransMuseum.UserComments TO 'viewerapp'@'%';

GRANT ALL PRIVILEGES ON VeteransMuseum.* TO 'adminapp'@'%';