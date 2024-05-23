CREATE DATABASE PROJECT
use PROJECT

CREATE TABLE Audit (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Action NVARCHAR(MAX),
    Time DATETIME DEFAULT GETDATE()
);
select* from USERS
select* from USER_GYM
select* from DietPlan
select* from BookingSessions
select* from Audit
select* from Exercise
select* from Workouts
select* from Meals

insert into BookingSessions VALUES (18,'08-12-2024','10:00',4, 2000,'pending',20,2);

INSERT INTO USERS (UserID, FName, LName, Gender, Address, Phone_No, Username,Password,Type,CNIC)
VALUES
(60, 'John', 'Doe', 'Male', '123 Main St', '123456789', 'johndoe','rtyuio','Member',3456789),
(61, 'Jane', 'Smith', 'Female', '456 Elm St', '987654321', 'janesmith','ertyui','Trainer',3456789);

INSERT INTO USER_GYM (UserID, GymID, JoiningDate)
VALUES
(60, 18, '2024-05-01'),
(61, 18, '2024-05-01');

INSERT INTO BookingSessions (BookingID, Date, Time, Duration, Price, Status, TrainerID, MemberID)
VALUES
(60, '2024-05-01', '08:00', 1, 50, 'pending', 23, 60),
(61, '2024-05-01', '09:00', 1, 50, 'pending', 23, 61);

INSERT INTO USER_GYM (UserID, GymID, JoiningDate)
VALUES 
    (60, 16, '2023-01-01'),
    (61, 16, '2023-01-01');

INSERT INTO DietPlan (PlanID, User_ID, Plan_Name,Breakfast,Lunch,Dinner)
VALUES 
    (40, 60, 'Weight Loss Plan',1,2,3),
    (41, 61, 'Muscle Building Plan',1,3,4);

	INSERT INTO Gyms (GymID, Name,Location,OwnerID)
VALUES 
    (40, 'Flex Trainer Gym','FAST NUCES',1);
--///////////////////////////////////Foriegn key CONSTRAINTS///////////////////////////////////////////////////////////
ALTER TABLE BookingSessions
ADD CONSTRAINT fk_trainer_id
FOREIGN KEY (TrainerID)
REFERENCES Users(UserID);

ALTER TABLE BookingSessions
ADD CONSTRAINT fk_member_id
FOREIGN KEY (MemberID)
REFERENCES Users(UserID);

ALTER TABLE DietPlan
ADD CONSTRAINT fk_user_id
FOREIGN KEY (User_ID)
REFERENCES USERS(UserID);

ALTER TABLE DietPlan
ADD CONSTRAINT fk_breakfast_meal_id
FOREIGN KEY (Breakfast)
REFERENCES Meals(MealID);

ALTER TABLE DietPlan
ADD CONSTRAINT fk_lunch_meal_id
FOREIGN KEY (Lunch)
REFERENCES Meals(MealID);

ALTER TABLE DietPlan
ADD CONSTRAINT fk_dinner_meal_id
FOREIGN KEY (Dinner)
REFERENCES Meals(MealID);

ALTER TABLE Exercise_Machine
ADD CONSTRAINT fk_exercise_id
FOREIGN KEY (ExerciseID)
REFERENCES Exercise(ExerciseID);

ALTER TABLE Exercise_Machine
ADD CONSTRAINT fk_machine_id
FOREIGN KEY (MachineID)
REFERENCES Machine(MachineID);

ALTER TABLE Feedback
ADD CONSTRAINT fk_booking_id
FOREIGN KEY (BookingID)
REFERENCES BookingSessions(BookingID);

ALTER TABLE GymPerformance
ADD CONSTRAINT fk_gym_id
FOREIGN KEY (GYM_ID)
REFERENCES Gyms(GymID);

ALTER TABLE Gyms
ADD CONSTRAINT fk_owner_id
FOREIGN KEY (OwnerID)
REFERENCES Users(UserID);

ALTER TABLE RegistrationRequests
ADD CONSTRAINT fk_admin_id
FOREIGN KEY (AdminID)
REFERENCES Users(UserID);

ALTER TABLE User_Gym
ADD CONSTRAINT fk_user_id_user
FOREIGN KEY (UserID)
REFERENCES Users(UserID);

ALTER TABLE User_Gym
ADD CONSTRAINT fk_gym_id_gym
FOREIGN KEY (GymID)
REFERENCES Gyms(GymID);


ALTER TABLE Workouts
ADD CONSTRAINT fk_Ex1
FOREIGN KEY (Exercise_1)
REFERENCES Exercise(ExerciseID);

ALTER TABLE Workouts
ADD CONSTRAINT fk_Ex2
FOREIGN KEY (Exercise_2)
REFERENCES Exercise(ExerciseID);

ALTER TABLE Workouts
ADD CONSTRAINT fk_Ex3
FOREIGN KEY (Exercise_3)
REFERENCES Exercise(ExerciseID);

ALTER TABLE Workouts
ADD CONSTRAINT fk_user_id_workout
FOREIGN KEY (User_ID)
REFERENCES USERS(UserID);

--///////////////////////////////////////////////////Triggers///////////////////////////////////////////////////////
CREATE TRIGGER trg_InsertBookingSession
ON BookingSessions
AFTER INSERT
AS
BEGIN
    -- Insert action into the audit table
    DECLARE @Action NVARCHAR(MAX)
    DECLARE @BookingID INT

    SELECT @BookingID = BookingID FROM inserted

    SET @Action = 'New booking session added. Booking ID: ' + CAST(@BookingID AS NVARCHAR(MAX))

    INSERT INTO Audit (Action)
    VALUES (@Action)
END;

CREATE TRIGGER Exercise_Added
ON Exercise
AFTER INSERT
AS
BEGIN
    DECLARE @ExerciseName NVARCHAR(MAX)
    SELECT @ExerciseName = ExerciseName FROM inserted
    INSERT INTO Audit (Action) VALUES ('Exercise ' + @ExerciseName + ' added.')
END;

CREATE TRIGGER trg_InsertMeal
ON Meals
AFTER INSERT
AS
BEGIN
    -- Insert action into the audit table
    DECLARE @Action NVARCHAR(MAX)
    DECLARE @MealID INT

    SELECT @MealID = MealID FROM inserted

    SET @Action = 'New meal added. Meal ID: ' + CAST(@MealID AS NVARCHAR(MAX))

    INSERT INTO Audit (Action)
    VALUES (@Action)
END;

CREATE TRIGGER trg_InsertDietPlan
ON DietPlan
AFTER INSERT
AS
BEGIN
    -- Insert action into the audit table
    DECLARE @Action NVARCHAR(MAX)
    DECLARE @PlanID INT

    SELECT @PlanID = PlanID FROM inserted

    SET @Action = 'New diet plan added. Plan ID: ' + CAST(@PlanID AS NVARCHAR(MAX))

    INSERT INTO Audit (Action)
    VALUES (@Action)
END;

CREATE TRIGGER trg_InsertWorkout
ON Workouts
AFTER INSERT
AS
BEGIN
    -- Insert action into the audit table
    DECLARE @Action NVARCHAR(MAX)
    DECLARE @WorkoutID INT

    SELECT @WorkoutID = WorkoutID FROM inserted

    SET @Action = 'New workout added. Workout ID: ' + CAST(@WorkoutID AS NVARCHAR(MAX))

    INSERT INTO Audit (Action)
    VALUES (@Action)
END;

CREATE TRIGGER trg_InsertUser
ON Users
AFTER INSERT
AS
BEGIN
    -- Insert action into the audit table
    DECLARE @Action NVARCHAR(MAX)
    DECLARE @Username NVARCHAR(MAX)

    SELECT @Username = Username FROM inserted

    SET @Action = 'New user registered. Username: ' + @Username

    INSERT INTO Audit (Action)
    VALUES (@Action)
END;

CREATE TRIGGER trg_DeleteUser
ON Users
AFTER DELETE
AS
BEGIN
    -- Insert action into the audit table
    DECLARE @Action NVARCHAR(MAX)
    DECLARE @Username NVARCHAR(MAX)

    SELECT @Username = Username FROM deleted

    SET @Action = 'User deleted. Username: ' + @Username

    INSERT INTO Audit (Action)
    VALUES (@Action)
END;

CREATE TRIGGER trg_InsertGym
ON Gyms
AFTER INSERT
AS
BEGIN
    -- Insert action into the audit table
    DECLARE @Action NVARCHAR(MAX)
    DECLARE @GymName NVARCHAR(MAX)

    SELECT @GymName = Name FROM inserted

    SET @Action = 'New gym inserted. Gym Name: ' + @GymName

    INSERT INTO Audit (Action)
    VALUES (@Action)
END;

CREATE TRIGGER trg_DeleteGym
ON Gyms
AFTER DELETE
AS
BEGIN
    -- Insert action into the audit table
    DECLARE @Action NVARCHAR(MAX)
    DECLARE @GymName NVARCHAR(MAX)

    SELECT @GymName = Name FROM deleted

    SET @Action = 'Gym deleted. Gym Name: ' + @GymName

    INSERT INTO Audit (Action)
    VALUES (@Action)
END;


--////////////////////////////////////////////Queries/////////////////////////////////////////////////////////////////////


--show type of the USER to load a specific interface member/trainer/admin/owner
SELECT Type
FROM Users
WHERE Username = 'jdoe';


--add new user if not present in the database if present then return username already exits
DECLARE @NewUserID INT
DECLARE @MaxUserID INT
-- Check if the username already exists
IF EXISTS (SELECT 1 FROM Users WHERE Username = 'new_username')
BEGIN
    PRINT 'Username already exists'
END
ELSE
BEGIN
    SELECT @MaxUserID = ISNULL(MAX(UserID), 0) FROM Users
    SET @NewUserID = @MaxUserID + 1
    INSERT INTO Users (UserID, FName, LName, Gender, Address, Phone_No, CNIC, Username, [Password], [Type])
    VALUES (@NewUserID, 'New_FirstName', 'New_LastName', 'Male', 'New_Address', 'New_PhoneNo', 'New_CNIC', 'new_username', 'new_password', 'Member')
    PRINT 'User inserted successfully'
END


--show username and userID by searching on basis of username
SELECT UserID, FName + ' ' + LName AS Name
FROM Users
WHERE Username = 'jdoe';

--Add a new workout
DECLARE @NewWorkoutID INT
DECLARE @MaxWorkoutID INT
SELECT @MaxWorkoutID = ISNULL(MAX(WorkoutID), 0) FROM Workouts
SET @NewWorkoutID = @MaxWorkoutID + 1
INSERT INTO Workouts (WorkoutID, Workout_Name, User_ID, Exercise_1, Exercise_2, Exercise_3)
VALUES (@NewWorkoutID, 'New_Workout', 1, 3, 4, 5);

--add new exercise
DECLARE @NewExerciseID INT
DECLARE @MaxExerciseID INT
SELECT @MaxExerciseID = ISNULL(MAX(ExerciseID), 0) FROM Exercise
SET @NewExerciseID = @MaxExerciseID + 1
INSERT INTO Exercise (ExerciseID, ExerciseName, Sets, Reps, Goal, Type)
VALUES (@NewExerciseID, 'New_Exercise', 3, 10, 'Strength Training', 'Public');

--add new diet plan
DECLARE @NewPlanID INT
DECLARE @MaxPlanID INT
SELECT @MaxPlanID = ISNULL(MAX(PlanID), 0) FROM DietPlan
SET @NewPlanID = @MaxPlanID + 1
INSERT INTO DietPlan (PlanID, Plan_Name, User_ID, Breakfast, Lunch, Dinner)
VALUES (@NewPlanID, 'New_Plan', 4, 2, 3, 4);

--add new meal
DECLARE @NewMealID INT
DECLARE @MaxMealID INT
SELECT @MaxMealID = ISNULL(MAX(MealID), 0) FROM Meals
SET @NewMealID = @MaxMealID + 1
INSERT INTO Meals (MealID, MealName, Carbohydrates, Fats, Proteins, PortionSize, allergens)
VALUES (@NewMealID, 'New_Meal', 50, 30, 20, 1, 'Tree nuts');

--display all workouts
select* from Workouts
SELECT w.WorkoutID, w.Workout_Name, w.User_ID, u.FName + ' ' + u.LName AS UserName
FROM Workouts w
INNER JOIN Users u ON w.User_ID = u.UserID;

--display all diet plans
select* from DietPlan
SELECT w.PlanID, w.Plan_Name, w.User_ID, u.FName + ' ' + u.LName AS UserName
FROM DietPlan w
INNER JOIN Users u ON w.User_ID = u.UserID;

--shows appointments with pending status
SELECT * 
FROM BookingSessions
WHERE TrainerID = 13 AND Status like 'pending';

-- update booking session from pedning to approve/dissapprove
UPDATE BookingSessions
SET Status = 'approve'
WHERE BookingID = 1;
--show booking session with complete status
SELECT * 
FROM BookingSessions
WHERE TrainerID = 13 AND Status like 'complete';
--show feedback of a booking session 
SELECT  f.Review, f.Rating
FROM Feedback f
INNER JOIN BookingSessions bs ON f.BookingID = bs.BookingID
WHERE bs.BookingID = 5;


--delete trainer 
BEGIN TRY
    BEGIN TRANSACTION;

    DECLARE @bookingID INT = 1; 

    IF EXISTS (SELECT 1 FROM BookingSessions WHERE BookingID = @bookingID AND Status <> 'complete')
    BEGIN
        DELETE FROM Feedback WHERE BookingID = @bookingID;

        DELETE FROM BookingSessions WHERE BookingID = @bookingID;

        PRINT 'Booking session with BookingID ' + CAST(@bookingID AS NVARCHAR(10)) + ' has been deleted.';
    END
    ELSE
    BEGIN
        PRINT 'Booking session with BookingID ' + CAST(@bookingID AS NVARCHAR(10)) + ' either does not exist or is already approved. No action performed.';
    END

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
        PRINT 'Transaction rolled back.';
    END

    PRINT 'Error: ' + ERROR_MESSAGE();
END CATCH;

--Add a new trainer (kaf ne owner ki jaga admin ke sath link kiya hai lekin yeh owner ke form me jaye ga)
SELECT RR.RequestID, RR.TrainerID, U.FName +' '+U.LName AS TrainerName
FROM RegistrationRequests RR
JOIN Users U ON RR.TrainerID = U.UserID
WHERE RR.AdminID =7;

--add new gym
DECLARE @NextGymID INT;
SELECT @NextGymID = ISNULL(MAX(GymID), 0) + 1 FROM Gyms;
INSERT INTO Gyms (GymID, Name, Location, OwnerID)
VALUES (@NextGymID, 'New Gym', 'New York, NY', 10);

--show gyms with performance
SELECT g.GymID, g.Name AS GymName, g.Location, g.OwnerID,
       p.MembershipGrowth, p.FinancialPerformance, p.ClassAttendanceRates, p.CustomerSatisfaction
FROM Gyms g
LEFT JOIN GymPerformance p ON g.GymID = p.GYM_ID;

UPDATE GymRequests
SET Status = 'Approved'
WHERE ReqID = 2;



--add new gym from gym req table and remove from gym req table
BEGIN TRANSACTION;
DECLARE @MaxGymID INT;
SELECT @MaxGymID = ISNULL(MAX(GymID), 0) FROM Gyms;
SET @MaxGymID = @MaxGymID + 1;
DECLARE @GymName NVARCHAR(100) = (SELECT Name FROM GymRequests WHERE ReqID = 13);
DECLARE @Location NVARCHAR(100) = (SELECT Location FROM GymRequests WHERE ReqID = 13);
UPDATE GymRequests
SET Status = 'Approved'
WHERE ReqID = 13;
INSERT INTO Gyms (GymID, Name, Location, OwnerID)
VALUES (@MaxGymID, @GymName, @Location, 1);
DELETE FROM GymRequests
WHERE ReqID = 13;
COMMIT TRANSACTION;



--remove gym
BEGIN TRANSACTION;
DECLARE @DeletedGymID INT = 1;
UPDATE USERS
SET Type = 'Undefined'
WHERE UserID IN (SELECT UserID FROM USER_GYM WHERE GymID = @DeletedGymID);
DELETE FROM USER_GYM
WHERE GymID = @DeletedGymID;
DELETE FROM GymPerformance
WHERE GYM_ID = @DeletedGymID;
DELETE FROM Gyms
WHERE GymID = @DeletedGymID;
COMMIT TRANSACTION;

select* from Audit

--add new booking by member
DECLARE @NextBookingID INT;

-- Find the next booking ID
SELECT @NextBookingID = ISNULL(MAX(BookingID), 0) + 1 FROM BookingSessions;

-- Insert new booking session
INSERT INTO BookingSessions (BookingID, Date, Time, Duration, Price, Status, TrainerID, MemberID)
VALUES (@NextBookingID, '2024-05-08', '10:00', 1, 1500, 'pending', 17, 6);

--display all bookings by a specific member
SELECT *
FROM BookingSessions
WHERE MemberID = (SELECT UserID FROM Users WHERE Username = 'jsmith');

select Meals.MealID,Meals.MealName,Meals.Carbohydrates,Meals.Fats,Meals.allergens,Meals.Proteins,Meals.PortionSize
from Meals
--Report 1



	SELECT U.UserID, U.FName + ' ' + U.LName AS Name, UG.GymID,
    (SELECT CAST(RAND() * 1000 AS DECIMAL(10, 2))) AS RandomCost
FROM Users U
INNER JOIN User_Gym UG ON U.UserID = UG.UserID
WHERE U.Type = 'trainer';



BEGIN TRANSACTION;

-- Delete related records from DietPlan table
DELETE FROM DietPlan WHERE User_ID = 3;
DELETE FROM Workouts WHERE User_ID = 3;
-- Delete related records from Feedback table
DELETE FROM Feedback WHERE BookingID IN (SELECT BookingID FROM BookingSessions WHERE MemberID = 3);

-- Delete related records from BookingSessions table
DELETE FROM BookingSessions WHERE MemberID = 3;

-- Delete the user from USERS table
DELETE FROM USERS WHERE UserID = 3;

COMMIT TRANSACTION;



--member/trainer report
SELECT 
    U.UserID, U.FName, U.LName, U.Gender, U.Address, U.Phone_No, U.Username,
    G.Name AS GymName, UG.JoiningDate,
    DP.Plan_Name, M.MealName AS Breakfast, M2.MealName AS Lunch, M3.MealName AS Dinner
FROM USERS U
LEFT JOIN USER_GYM UG ON U.UserID = UG.UserID
LEFT JOIN Gyms G ON UG.GymID = G.GymID
LEFT JOIN DietPlan DP ON U.UserID = DP.User_ID
LEFT JOIN Meals M ON DP.Breakfast = M.MealID
LEFT JOIN Meals M2 ON DP.Lunch = M2.MealID
LEFT JOIN Meals M3 ON DP.Dinner = M3.MealID
WHERE U.UserID = 1;






--////////////////////////////////////////Additional Reports////////////////////////////////////////////////


--List of gym locations with the highest number of members:
SELECT G.Location, COUNT(UG.UserID) AS TotalMembers
FROM Gyms G
JOIN USER_GYM UG ON G.GymID = UG.GymID
GROUP BY G.Location
ORDER BY TotalMembers DESC;


--
DECLARE @TrainerID INT = 1;
DECLARE @Date DATE = '2024-05-01';

SELECT U.FName + ' ' + U.LName AS MemberName
FROM BookingSessions BS
JOIN USERS U ON BS.MemberID = U.UserID
WHERE BS.TrainerID = @TrainerID
AND BS.Date = @Date;


--List of workout plans that target weight loss (where at least one exercise is for weight loss).
SELECT w.WorkoutID, w.Workout_Name
FROM Workouts w
JOIN Exercise e ON w.Exercise_1 = e.ExerciseID OR 
 w.Exercise_2 = e.ExerciseID
OR w.Exercise_3 = e.ExerciseID
WHERE e.Goal = 'Weight Loss';

--Details of gyms with the highest customer satisfaction rate.
SELECT g.GymID, g.Name, g.Location, gp.CustomerSatisfaction
FROM Gyms g
JOIN GymPerformance gp ON g.GymID = gp.GYM_ID
WHERE gp.CustomerSatisfaction = (SELECT MAX(CustomerSatisfaction) FROM GymPerformance);


--List of gyms with the lowest membership growth rate.
SELECT g.GymID, g.Name, g.Location, gp.MembershipGrowth
FROM Gyms g
JOIN GymPerformance gp ON g.GymID = gp.Gym_ID
WHERE gp.MembershipGrowth = (SELECT MIN(MembershipGrowth) FROM GymPerformance);

--Total revenue generated from completed bookings:
SELECT SUM(Price) AS TotalRevenue
FROM BookingSessions
WHERE Status = 'complete';


--List of bookings with their corresponding trainers, member names, and feedback ratings:
SELECT bs.BookingID, bs.Date, bs.Time, bs.Duration, bs.Price, bs.Status, t.FName AS TrainerFirstName, t.LName AS TrainerLastName, m.FName AS MemberFirstName, m.LName AS MemberLastName, f.Rating
FROM BookingSessions bs
JOIN USERS t ON bs.TrainerID = t.UserID
JOIN USERS m ON bs.MemberID = m.UserID
LEFT JOIN Feedback f ON bs.BookingID = f.BookingID;


--Total revenue generated from completed bookings in March:
SELECT MONTH(Date) AS Month, SUM(Price) AS TotalRevenue
FROM BookingSessions
WHERE Status = 'complete'
GROUP BY MONTH(Date);

--List of diet plans with their corresponding meals containing milk:
SELECT dp.PlanID, dp.Plan_Name, m.MealName
FROM DietPlan dp
JOIN Meals m ON dp.Breakfast = m.MealID OR dp.Lunch = m.MealID OR dp.Dinner = m.MealID
WHERE m.Allergens = 'Milk';

--List of diet plans with their corresponding gluten-free meals:
SELECT dp.PlanID, dp.Plan_Name, m.MealName
FROM DietPlan dp
JOIN Meals m ON dp.Breakfast = m.MealID OR dp.Lunch = m.MealID OR dp.Dinner = m.MealID
WHERE m.Allergens <> 'Wheat';

--List of diet plans with their corresponding meals containing tree nuts:
SELECT dp.PlanID, dp.Plan_Name, m.MealName
FROM DietPlan dp
JOIN Meals m ON dp.Breakfast = m.MealID OR dp.Lunch = m.MealID OR dp.Dinner = m.MealID
WHERE m.Allergens = 'Tree nuts';

--t plans with their corresponding high-protein meals:
SELECT dp.PlanID, dp.Plan_Name, m.MealName
FROM DietPlan dp
JOIN Meals m ON dp.Breakfast = m.MealID OR dp.Lunch = m.MealID OR dp.Dinner = m.MealID
WHERE m.Proteins > 40;



--List of diet plans with their corresponding low-carb meals:
SELECT dp.PlanID, dp.Plan_Name, m.MealName
FROM DietPlan dp
JOIN Meals m ON dp.Breakfast = m.MealID OR dp.Lunch = m.MealID OR dp.Dinner = m.MealID
WHERE m.Carbohydrates < 30;


--sList of diet plans with their corresponding meals containing peanuts:
SELECT dp.PlanID, dp.Plan_Name, m.MealName
FROM DietPlan dp
JOIN Meals m ON dp.Breakfast = m.MealID OR dp.Lunch = m.MealID OR dp.Dinner = m.MealID
WHERE m.Allergens = 'Peanuts';




SELECT 
    U.UserID,
    U.FName,
    U.LName,
    U.Gender,
    U.Address,
    U.Phone_No,
    U.Username,
    DP.PlanID,
    DP.Plan_Name,
	G.Name
FROM 
    USERS U
JOIN 
    USER_GYM UG ON U.UserID = UG.UserID
JOIN 
    DietPlan DP ON U.UserID = DP.User_ID  -- Assuming USERS table has a PlanID
JOIN
	Gyms G ON G.GymID = UG.GymID
WHERE 
    UG.GymID = 9  -- Replace [Specific_Gym_ID] with the actual GymID
    AND DP.PlanID = 16;


 SELECT 
     U.UserID,
     U.FName,
     U.LName,
     U.Gender,
     U.Address,
     U.Phone_No, 
     U.Username,
     DP.PlanID,
     DP.Plan_Name
 FROM 
     USERS U
 JOIN 
     USER_GYM UG ON U.UserID = UG.UserID
 JOIN 
     BookingSessions BS ON U.UserID = BS.MemberID
 JOIN 
     DietPlan DP ON U.UserID = DP.User_ID
 WHERE 
     BS.TrainerID = 20
     AND DP.PlanID = 2;