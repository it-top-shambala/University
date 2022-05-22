CREATE TABLE tab_persons
(
    id         INT          NOT NULL PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(200) NOT NULL,
    last_name  VARCHAR(200) NOT NULL
);

CREATE TABLE tab_faculties
(
    id         INT          NOT NULL PRIMARY KEY AUTO_INCREMENT,
    faculty VARCHAR(255) NOT NULL
);

CREATE TABLE tab_subjects
(
    id         INT          NOT NULL PRIMARY KEY AUTO_INCREMENT,
    subject VARCHAR(255) NOT NULL
);

CREATE TABLE tab_students
(
    id        INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    person_id INT NOT NULL,
    faculty_id INT NOT NULL,


    FOREIGN KEY (person_id) REFERENCES tab_persons (id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,

    FOREIGN KEY (faculty_id) REFERENCES tab_faculties (id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION
);

CREATE TABLE tab_teachers
(
    id        INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    person_id INT NOT NULL,
    subject_id INT NOT NULL,

    FOREIGN KEY (person_id) REFERENCES tab_persons (id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,

    FOREIGN KEY (subject_id) REFERENCES tab_subjects (id)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION
);