REM cd into directory of mariadb binary

cd C:\"Program Files <x86>"\"MariaDB 10.4"\bin

REM add backup file name and password to restore database from backup file

mysql --user=adminapp --password=<adminapp password>  <  <path\to\backup\file.sql>
