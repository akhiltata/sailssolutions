//linq example

IList<Student> studentList = new List<Student>() { 
    new Student() { StudentID = 1, StudentName = "akhil", Age = 18, StandardID = 1 } ,
    new Student() { StudentID = 2, StudentName = "alekhya",  Age = 21, StandardID = 1 } ,
    new Student() { StudentID = 3, StudentName = "ram",  Age = 18, StandardID = 2 } ,
    new Student() { StudentID = 4, StudentName = "siva" , Age = 20, StandardID = 2 } , 
};
IList<Standard> standardList = new List<Standard>() { 
    new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
};

var studentsGroup = from stad in standardList
                    join s in studentList
                    on stad.StandardID equals s.StandardID
                        into sg
                        select new { 
                                        StandardName = stad.StandardName, 
                                        Students = sg 
                                    };

foreach (var group in studentsGroup)
{
    Console.WriteLine(group.StandardName);
    
    group.Students.ToList().ForEach(st => Console.WriteLine(st.StudentName));
}