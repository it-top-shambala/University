classDiagram
direction BT
class tab_faculties {
   varchar(255) faculty
   int(11) id
}
class tab_persons {
   varchar(200) first_name
   varchar(200) last_name
   int(11) id
}
class tab_students {
   int(11) person_id
   int(11) faculty_id
   int(11) id
}
class tab_subjects {
   varchar(255) subject
   int(11) id
}
class tab_teachers {
   int(11) person_id
   int(11) subject_id
   int(11) id
}

tab_students  -->  tab_faculties : faculty_id:id
tab_students  -->  tab_persons : person_id:id
tab_teachers  -->  tab_persons : person_id:id
tab_teachers  -->  tab_subjects : subject_id:id
