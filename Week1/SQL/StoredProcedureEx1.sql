-- Retrieve employees by department

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;

-- Insert employee

CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees
    (
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (
        @FirstName,
        @LastName,
        @DepartmentID,
        @Salary,
        @JoinDate
    );
END;

-- Example executions

EXEC sp_GetEmployeesByDepartment @DepartmentID = 1;

EXEC sp_InsertEmployee
    @FirstName = 'Robert',
    @LastName = 'Wilson',
    @DepartmentID = 2,
    @Salary = 6500,
    @JoinDate = '2024-05-20';