BEGIN TRANSACTION;
CREATE TABLE "user" ("userid" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL  ,"username" VARCHAR(45)  NOT NULL  COLLATE NOCASE,"password" VARCHAR(32)  NOT NULL  COLLATE NOCASE,"admin" SMALLINT  NULL DEFAULT NULL );
CREATE TABLE "permission" ("groupid" INT  NOT NULL  ,"userid" INT  NOT NULL  ,PRIMARY KEY ("groupid","userid"),CONSTRAINT `fk_permission_group1` FOREIGN KEY (`groupid`) REFERENCES groups (`groupid`) ON DELETE NO ACTION ON UPDATE NO ACTION,CONSTRAINT `fk_permission_user1` FOREIGN KEY (`userid`) REFERENCES user (`userid`) ON DELETE NO ACTION ON UPDATE NO ACTION);
CREATE TABLE "groups" ("groupid" INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL  ,"name" VARCHAR(45)  NOT NULL  COLLATE NOCASE);
CREATE TABLE "devicetypes" ("type" INT PRIMARY KEY NOT NULL  ,"name" VARCHAR(45)  NOT NULL  COLLATE NOCASE);
INSERT INTO `devicetypes` (type,name) VALUES (1,'DimmableLight'),
 (2,'ServoMotor'),
 (3,'StepperMotor'),
 (4,'TemperatureSensor'),
 (5,'LightSensor');
CREATE TABLE "device_group" ("deviceid" INT  NOT NULL  ,"groupid" INT  NOT NULL  ,PRIMARY KEY ("deviceid","groupid"),CONSTRAINT `fk_device_group_device1` FOREIGN KEY (`deviceid`) REFERENCES device (`deviceid`) ON DELETE NO ACTION ON UPDATE NO ACTION,CONSTRAINT `fk_device_group_group1` FOREIGN KEY (`groupid`) REFERENCES groups (`groupid`) ON DELETE NO ACTION ON UPDATE NO ACTION);
CREATE TABLE "device" ("deviceid" INTEGER  NOT NULL  ,"name" VARCHAR(32)  NOT NULL  COLLATE NOCASE,"value" INTEGER  NOT NULL  ,"type" INT  NOT NULL  ,PRIMARY KEY ("deviceid","type"),CONSTRAINT `fk_device_devicetypes` FOREIGN KEY (`type`) REFERENCES devicetypes (`type`) ON DELETE NO ACTION ON UPDATE NO ACTION);
CREATE UNIQUE INDEX 'userid_UNIQUE' ON 'user' (`userid` DESC);
CREATE UNIQUE INDEX 'roomid_UNIQUE' ON 'groups' (`groupid` DESC);
CREATE UNIQUE INDEX 'lightid_UNIQUE' ON 'device' (`deviceid` DESC);
CREATE INDEX 'fk_permission_user1_idx' ON 'permission' (`userid` DESC);
CREATE INDEX 'fk_device_group_group1_idx' ON 'device_group' (`groupid` DESC);
CREATE INDEX 'fk_device_devicetypes_idx' ON 'device' (`type` DESC);
COMMIT;