

REM Change these attributes to path, and password
REM --------------------------------------------
set BackupFilePath="<Path\to\Backup\Folder>"
Set Password="<adminapp password>"
REM --------------------------------------------

REM this block parses the date time for the time stamp on the output file
echo off
set CUR_YYYY=%date:~10,4%
set CUR_MM=%date:~4,2%
set CUR_DD=%date:~7,2%
set CUR_HH=%time:~0,2%
if %CUR_HH% lss 10 (set CUR_HH=0%time:~1,1%)

set CUR_NN=%time:~3,2%
set CUR_SS=%time:~6,2%
set CUR_MS=%time:~9,2%

set datetime=%CUR_MM%%CUR_DD%%CUR_YYYY%-%CUR_HH%%CUR_NN%%CUR_SS%

REM move to the directory with the mariadb binary file
cd C:\"Program Files <x86>"\"MariaDB 10.4"\bin

REM dump contents of SQL instance into flat file appended with datetime
mysqldump --user=adminapp --password=%Password% --databases veteransmuseum > %BackupFilePath%\dailybackup_%datetime%.sql

REM mirror the contents of the image files into the backup directory
robocopy/mir C:\MuseumApp\images %BackupFilePath%\images

REM References used to creat script
REM https://mariadb.com/kb/en/mysqldump/#mysqldump-in-mariadb-103-and-higher
REM https://www.tutorialspoint.com/batch_script/index.htm
REM https://tecadmin.net/create-filename-with-datetime-windows-batch-script/
REM https://www.computerhope.com/robocopy.htm

