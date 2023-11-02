Create database StudentManagement
GO

USE StudentManagement
GO

CREATE TABLE Account (
    Email VARCHAR(255) PRIMARY KEY,
    Password VARCHAR(255) NOT NULL,
    FullName VARCHAR(255),
	Role INT
);

CREATE TABLE Class (
    ClassID VARCHAR(255) PRIMARY KEY,
    ClassName VARCHAR(255) NOT NULL,
    Description VARCHAR(255)
);

CREATE TABLE Student (
    StudentID VARCHAR(255) PRIMARY KEY,
    FullName VARCHAR(255) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender VARCHAR(50),
    Address VARCHAR(255),
    Email VARCHAR(255),
    ClassID VARCHAR(255),
    FOREIGN KEY (ClassID) REFERENCES Class(ClassID)
);

CREATE TABLE Subject (
    SubjectID VARCHAR(255) PRIMARY KEY,
    SubjectName VARCHAR(255) NOT NULL
);

CREATE TABLE Score (
    StudentID VARCHAR(255),
    SubjectID VARCHAR(255),
    ScoreValue FLOAT CHECK (ScoreValue >= 0 AND ScoreValue <= 10),
    PRIMARY KEY (StudentID, SubjectID),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID)
);

INSERT INTO Class (ClassID, ClassName, Description) VALUES
('C001', 'Class A1', 'Mathematics Specialization'),
('C002', 'Class A2', 'Physics Specialization'),
('C003', 'Class A3', 'Chemistry Specialization'),
('C004', 'Class A4', 'English Specialization');

INSERT INTO Student (StudentID, FullName, DateOfBirth, Gender, Address, Email, ClassID) VALUES
('SE111', 'Duong Thien A', '2000-06-06', 'male', '09 Nguyen Trai Street, Vinh Long', 'duonga@yahoo.com.vn', 'C001'),
('SE222', 'Tran Thi B', '2000-02-02', 'female', '456 Street 2, Hanoi', 'tranb@email.com.vn', 'C001'),
('SE333', 'Ta Van C', '2000-10-10', 'male', '778 Street 3, Da Nang', 'tac@email.com', 'C003'),
('SE444', 'Le Thi D', '2000-04-05', 'female', '101 Street 4, Can Tho', 'led@email.com', 'C004');


INSERT INTO Subject (SubjectID, SubjectName) VALUES
('M01', 'Math'),
('P01', 'Physical'),
('C01', 'Chemistry'),
('E01', 'English');

INSERT INTO Score (StudentID, SubjectID, ScoreValue) VALUES
('SE111', 'M01', 8.5),
('SE111', 'P01', 7.5),
('SE111', 'C01', 9),
('SE111', 'E01', 9.5),
('SE222', 'M01', 8.2),
('SE222', 'P01', 9.3),
('SE222', 'C01', 9.1),
('SE222', 'E01', 7),
('SE333', 'M01', 9),
('SE333', 'P01', 9),
('SE333', 'C01', 7),
('SE333', 'E01', 9),
('SE444', 'M01', 9.2),
('SE444', 'P01', 6.5),
('SE444', 'C01', 6.8),
('SE444', 'E01', 9);

INSERT INTO Account(Email, Password, FullName, Role) Values
('admin@gmail.com', '123@', 'Ngo Vy Khang', 1),
('staff@gmail.com', '123@', 'Nguyen Thi A', 2);





