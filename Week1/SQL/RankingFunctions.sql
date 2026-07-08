-- ROW_NUMBER()

SELECT
    EmployeeID,
    FirstName,
    LastName,
    DepartmentID,
    Salary,
    ROW_NUMBER() OVER
    (
        PARTITION BY DepartmentID
        ORDER BY Salary DESC
    ) AS RowNumber
FROM Employees;

-- RANK()

SELECT
    EmployeeID,
    FirstName,
    LastName,
    DepartmentID,
    Salary,
    RANK() OVER
    (
        PARTITION BY DepartmentID
        ORDER BY Salary DESC
    ) AS RankNumber
FROM Employees;

-- DENSE_RANK()

SELECT
    EmployeeID,
    FirstName,
    LastName,
    DepartmentID,
    Salary,
    DENSE_RANK() OVER
    (
        PARTITION BY DepartmentID
        ORDER BY Salary DESC
    ) AS DenseRankNumber
FROM Employees;

-- Top 3 highest paid employees in each department

SELECT *
FROM
(
    SELECT
        EmployeeID,
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        ROW_NUMBER() OVER
        (
            PARTITION BY DepartmentID
            ORDER BY Salary DESC
        ) AS RowNumber
    FROM Employees
) AS RankedEmployees
WHERE RowNumber <= 3;