DELETE FROM 'user';
DELETE FROM sqlite_sequence WHERE name='user' OR name='groups' OR name='device';
DELETE FROM 'groups';
DELETE FROM 'device';
DELETE FROM 'permission';
DELETE FROM 'device_group';

INSERT INTO 'user' (username, password, admin) VALUES ('admin', '21232F297A57A5A743894A0E4A801FC3', 0),
('henk', 'D97CCED53D3E05658F7F7A6165DC1194', 0),
('swaghetti', 'D97CCED53D3E05658F7F7A6165DC1194', 0),
('abcdefghijklmnopqrstuvwxyz', 'E944B3D207121547B9DE4F97D1E43B89', 0);
/*passwords: admin, steen, yolonaise, poeperdepoep*/
INSERT INTO 'groups' (name) VALUES ('woonkamer'), ('toilet'), ('slaapkamer'), ('badkamer');
INSERT INTO 'device' (deviceid, name, value, type, pin, status)  VALUES (1, 'lampje', 1, 1, 1, 1), (2, 'lamp', 2, 2, 0, 2);
INSERT INTO 'device_group' (deviceid, groupid) VALUES (1, 1), (1, 2), (1, 3), (1, 4), (2, 1), (2, 2), (2, 3), (2, 4);
INSERT INTO 'permission' (groupid, userid) VALUES (1, 1), (2, 2), (3, 3), (4, 4);