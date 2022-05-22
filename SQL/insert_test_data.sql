INSERT INTO tab_faculties (faculty) 
VALUES ('Design'),
       ('SoftDev');

INSERT INTO tab_persons (first_name, last_name) 
VALUES ('anonim', 'anonimus'),
       ('Andrey', 'Starinin');

INSERT INTO tab_students (person_id, faculty_id) 
VALUES (1, 2),
       (2, 1);

SELECT * FROM tab_faculties;
SELECT * FROM tab_persons;

SELECT tab_students.id AS 'id',
       person_id, first_name, last_name,
       faculty_id, faculty
FROM tab_students 
    JOIN tab_persons 
        ON tab_persons.id = tab_students.person_id 
    JOIN tab_faculties 
        ON tab_faculties.id = tab_students.faculty_id;