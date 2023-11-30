CREATE TABLE
    IF NOT EXISTS accounts(
        id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
        name varchar(255) COMMENT 'User Name',
        email varchar(255) COMMENT 'User Email',
        picture varchar(255) COMMENT 'User Picture'
    ) default charset utf8 COMMENT '';

CREATE TABLE
    IF NOT EXISTS dogs(
        id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'this is the id of dog, it is a primary key it is unique ',
        name CHAR(255) NOT NULL COMMENT 'this is the name for ur little pookie bear doggie',
        breedType ENUM(
            'golden',
            'border collie',
            'lab'
        ) NOT NULL,
        hasLegs BOOLEAN NOT NULL DEFAULT true
    ) default charset utf8 COMMENT '';

INSERT INTO dogs (name) VALUES('drexler')

INSERT INTO dogs (name, breedType) VALUES('duke', 'lab')

INSERT INTO
    dogs (name, breedType, hasLegs)
VALUES
(
        'sophie',
        'border collie',
        false
    )

SELECT * FROM dogs

DROP TABLE dogs