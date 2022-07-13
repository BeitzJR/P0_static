
DROP TABLE monsters;

CREATE TABLE monsters (
    IDkey INT PRIMARY KEY IDENTITY,
    npcName VARCHAR(64) NOT NULL,
    hp int NOT NULL,
    att int NOT NULL,
    savMod int NOT NULL,
    --specAtt1 int,
    --specAtt2 int,
    --specAtt3 int,
)

INSERT INTO monsters(npcName, hp, att, savMod) VALUES
    ('Goblin', 5, 2, 1),
    ('Kobold', 8, 2, 2);

SELECT * FROM monsters;
