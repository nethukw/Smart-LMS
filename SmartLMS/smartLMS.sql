-- Drop and Create Database
DROP DATABASE SmartLMS;
CREATE DATABASE SmartLMS;
USE SmartLMS; 

-- Drop tables if they exist to avoid errors on rerun
DROP TABLE IF EXISTS ExportLogs;
DROP TABLE IF EXISTS CalendarEvents;
DROP TABLE IF EXISTS HelpArticles;
DROP TABLE IF EXISTS SupportTickets;
DROP TABLE IF EXISTS Analytics;
DROP TABLE IF EXISTS Settings;
DROP TABLE IF EXISTS Notifications;
DROP TABLE IF EXISTS Discussions;
DROP TABLE IF EXISTS Grades;
DROP TABLE IF EXISTS Submissions;
DROP TABLE IF EXISTS Assignments;
DROP TABLE IF EXISTS Materials;
DROP TABLE IF EXISTS Courses;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS Roles;

-- Create Roles table
CREATE TABLE Roles (
    RoleId INT AUTO_INCREMENT PRIMARY KEY,
    RoleName VARCHAR(50) NOT NULL UNIQUE
);

-- Create Users table
CREATE TABLE Users (
    UserId INT AUTO_INCREMENT PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NOT NULL UNIQUE,
    PasswordHash VARCHAR(255) NOT NULL,
    RoleId INT NOT NULL,
    ProfilePicture VARCHAR(255),
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
);
UPDATE Users 
SET ProfilePicture = 'C:/Users/YourName/Pictures/myphoto.jpg' 
WHERE UserId = 1;
drop table Users;

Update  Users (
    UserId INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Phone VARCHAR(15),
    Username VARCHAR(50) UNIQUE,
    PasswordHash VARCHAR(255),
    DOB DATE,
    Gender VARCHAR(10),
    Address TEXT,
    ProfileImage LONGBLOB,
    RoleId INT,
    FOREIGN KEY (RoleId) REFERENCES Roles(RoleId)
);


CREATE TABLE Roles (
    RoleId INT AUTO_INCREMENT PRIMARY KEY,
    RoleName VARCHAR(50) NOT NULL
);

-- Create Courses table
CREATE TABLE Courses (
    CourseId INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(100) NOT NULL,
    Description TEXT,
    LecturerId INT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (LecturerId) REFERENCES Users(UserId)
);

-- Create Materials table
CREATE TABLE Materials (
    MaterialID INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    Description TEXT,
    Course VARCHAR(50) NOT NULL,
    FilePath VARCHAR(255) NOT NULL,
    UploadedBy VARCHAR(100),
    UploadDate DATETIME DEFAULT CURRENT_TIMESTAMP
);



drop table materials;

drop table Materials;

-- Create Assignments table
CREATE TABLE Assignments (
    AssignmentId INT AUTO_INCREMENT PRIMARY KEY,
    CourseId INT NOT NULL,
    Title VARCHAR(100) NOT NULL,
    Description TEXT,
    DueDate DATETIME,
    FilePath VARCHAR(255),
    CreatedBy INT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CourseId) REFERENCES Courses(CourseId),
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserId)
);

-- Create Submissions table
CREATE TABLE Submissions (
    SubmissionId INT AUTO_INCREMENT PRIMARY KEY,
    AssignmentId INT NOT NULL,
    StudentId INT NOT NULL,
    FilePath VARCHAR(255),
    SubmittedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (AssignmentId) REFERENCES Assignments(AssignmentId),
    FOREIGN KEY (StudentId) REFERENCES Users(UserId)
);

-- Create Grades table
CREATE TABLE Grades (
    GradeId INT AUTO_INCREMENT PRIMARY KEY,
    SubmissionId INT NOT NULL,
    Grade FLOAT,
    Feedback TEXT,
    GradedBy INT NOT NULL,
    GradedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (SubmissionId) REFERENCES Submissions(SubmissionId),
    FOREIGN KEY (GradedBy) REFERENCES Users(UserId)
);

-- Create Discussions table
CREATE TABLE Discussions (
    DiscussionId INT AUTO_INCREMENT PRIMARY KEY,
    CourseId INT NOT NULL,
    UserId INT NOT NULL,
    Message TEXT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CourseId) REFERENCES Courses(CourseId),
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

-- Create Notifications table
CREATE TABLE Notifications (
    NotificationId INT AUTO_INCREMENT PRIMARY KEY,
    UserId INT NOT NULL,
    Message VARCHAR(255) NOT NULL,
    IsRead BOOLEAN DEFAULT FALSE,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

-- Create Settings table
CREATE TABLE Settings (
    SettingId INT AUTO_INCREMENT PRIMARY KEY,
    UserId INT NOT NULL,
    Theme VARCHAR(50),
    Language VARCHAR(50),
    NotificationsEnabled BOOLEAN DEFAULT TRUE,
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

-- Create Analytics table
CREATE TABLE Analytics (
    LogId INT AUTO_INCREMENT PRIMARY KEY,
    UserId INT NOT NULL,
    Action VARCHAR(255),
    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

-- Create SupportTickets table
CREATE TABLE SupportTickets (
    TicketId INT AUTO_INCREMENT PRIMARY KEY,
    UserId INT NOT NULL,
    Title VARCHAR(100) NOT NULL,
    Description TEXT,
    Status VARCHAR(50) DEFAULT 'Open',
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

INSERT INTO Courses (Title, Description, LecturerId)
VALUES ('DSA', 'Data Structures', 1),
       ('Math III', 'Advanced Math', 2);

-- Create HelpArticles table
CREATE TABLE HelpArticles (
    ArticleId INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(100) NOT NULL,
    Content TEXT NOT NULL,
    CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Create CalendarEvents table
CREATE TABLE CalendarEvents (
    EventId INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(100) NOT NULL,
    Description TEXT,
    EventDate DATETIME NOT NULL,
    CreatedBy INT NOT NULL,
    FOREIGN KEY (CreatedBy) REFERENCES Users(UserId)
);

-- Create ExportLogs table
CREATE TABLE ExportLogs (
    ExportId INT AUTO_INCREMENT PRIMARY KEY,
    UserId INT NOT NULL,
    ExportType VARCHAR(50) NOT NULL,
    FilePath VARCHAR(255) NOT NULL,
    ExportedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (UserId) REFERENCES Users(UserId)
);

CREATE TABLE Enrollments (
    EnrollmentId INT AUTO_INCREMENT PRIMARY KEY,
    StudentId INT NOT NULL,
    CourseId INT NOT NULL,
    FOREIGN KEY (StudentId) REFERENCES Users(UserId),
    FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
);


SET FOREIGN_KEY_CHECKS = 0;

DELETE FROM Roles 
WHERE RoleName IN ('Admin', 'Lecturer', 'Student');

SET FOREIGN_KEY_CHECKS = 1;

INSERT INTO Roles (RoleId, RoleName) VALUES
(1, 'Student'),
(2, 'Lecturer'),
(3, 'Administrator'); --



-- Insert sample users
INSERT INTO Users (FullName, Email, PasswordHash, RoleId)
VALUES 
('Admin User', 'admin@example.com', SHA2('admin123', 256), (SELECT RoleId FROM Roles WHERE RoleName='Admin')),
('Lecturer User', 'lecturer@example.com', SHA2('lecturer123', 256), (SELECT RoleId FROM Roles WHERE RoleName='Lecturer')),
('Student User', 'student@example.com', SHA2('student123', 256), (SELECT RoleId FROM Roles WHERE RoleName='Student'));

-- Lecturer (RoleId = 2)
INSERT INTO Users (FullName, Email, PasswordHash, RoleId)
VALUES ('Mr. John Smith', 'john@lms.com', 'lecturer123', 2);

-- Student (RoleId = 1)
INSERT INTO Users (FullName, Email, PasswordHash, RoleId)
VALUES ('Nethmi Wijekoon', 'nethmi@student.com', 'student123', 1);

INSERT INTO Courses (Title, Description, LecturerId)
VALUES 
('Data Structures', 'Learn about stacks, queues, and trees.', 1),
('Database Systems', 'Introduction to MySQL and relational databases.', 1);

INSERT INTO Assignments (CourseId, Title, Description, DueDate)
VALUES 
(1, 'Stack Implementation', 'Implement a stack in Java.', '2025-07-25'),
(2, 'SQL Joins', 'Practice INNER and OUTER joins.', '2025-07-23');

INSERT IGNORE INTO Roles (RoleId, RoleName) VALUES
('student', 'Student'),
('lecturer', 'Lecturer'),
('admin', 'Administrator');

-- Lecturer (will use this as CreatedBy)
INSERT INTO Users (FullName, Email, PasswordHash, RoleId)
VALUES ('Mr. John Smith', 'john@lms.com', 'lecturer123', 'lecturer');

-- Student
INSERT INTO Users (FullName, Email, PasswordHash, RoleId)
VALUES ('Nethmi Wijekoon', 'nethmi@student.com', 'student123', 'student');

INSERT INTO Submissions (AssignmentId, StudentId, FilePath, SubmittedAt)
VALUES 
(1, 2, 'stack.java', '2025-07-18 10:00:00'),
(2, 2, 'joins.sql', '2025-07-18 11:30:00');

INSERT INTO Grades (SubmissionId, Grade, Feedback)
VALUES 
(1, 'A', 'Great work with stack logic!'),
(2, 'B+', 'Joins are correct, minor syntax issues.');












