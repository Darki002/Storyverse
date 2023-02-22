CREATE TABLE story(
    ID INT NOT NULL IDENTITY PRIMARY KEY,
    title VARCHAR(100),
    story_text VARCHAR(MAX),
    creation_date DATETIME NOT NULL,
);

CREATE TABLE commentar(
    ID INT NOT NULL,
    comment_text VARCHAR(600) NOT NULL,
    registrated_user_id INT NOT NULL,
    story_id INT NOT NULL,

    CONSTRAINT primary_key_commentar PRIMARY KEY (ID),
    CONSTRAINT foreign_key_userid_commentar FOREIGN KEY (registrated_user_id) REFERENCES registrated_user(ID),
    CONSTRAINT foreign_key_storyid_commentar FOREIGN KEY (story_id) REFERENCES story(ID)
);

CREATE TABLE registrated_user(
    ID INT NOT NULL,
    USER_NAME VARCHAR(30) NOT NULL,
    EMAIL VARCHAR(60) NOT NULL,

    CONSTRAINT primary_key_userId PRIMARY KEY (ID)
);