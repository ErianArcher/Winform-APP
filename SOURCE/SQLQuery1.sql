USE [SCUT2015];

CREATE TABLE [Employee] (
[EmpNo] VARCHAR(20) PRIMARY KEY,
[EmpName] VARCHAR(50) NOT NULL,
[EmpSex] VARCHAR(10) NOT NULL CHECK([EmpSex] = '��' or [EmpSex] = 'Ů'),
[EmpAge] INT CHECK([EmpAge] > 0)
);

CREATE TABLE [Company] (
[CmpNo] VARCHAR(20) PRIMARY KEY,
[CmpName] VARCHAR(100)
);

CREATE TABLE [Works] (
[EmpNo] VARCHAR(20),
[CmpNo] VARCHAR(20),
[Salary] INT NOT NULL,
FOREIGN KEY(EmpNo) REFERENCES [Employee]([EmpNo]) ON DELETE CASCADE,
FOREIGN KEY(CmpNo) REFERENCES [Company](CmpNo) ON DELETE CASCADE
);

INSERT INTO [Employee] VALUES ('E01', '����', 'Ů', 32);
INSERT INTO [Employee] VALUES ('E02', '����', '��', 28);
INSERT INTO [Employee] VALUES ('E03', '����', 'Ů', 42);
INSERT INTO [Employee] VALUES ('E04', '����', '��', 37);
INSERT INTO [Employee] VALUES ('E05', '����', '��', 51);

INSERT INTO [Company] VALUES ('C01', '����Ƽ�');
INSERT INTO [Company] VALUES ('C02', '����Ƽ�');
INSERT INTO [Company] VALUES ('C03', 'δ���Ƽ�');

INSERT INTO [Works] VALUES ('E01', 'C01', 3000);
INSERT INTO [Works] VALUES ('E01', 'C02', 4000);
INSERT INTO [Works] VALUES ('E02', 'C02', 5000);
INSERT INTO [Works] VALUES ('E02', 'C03', 2500);
INSERT INTO [Works] VALUES ('E03', 'C01', 3500);
INSERT INTO [Works] VALUES ('E04', 'C02', 3000);
INSERT INTO [Works] VALUES ('E05', 'C03', 2000);

--query3-1
SELECT Employee.EmpNo, Employee.EmpName,
CASE WHEN Company.CmpName IS NULL THEN '' ELSE Company.CmpName END,
CASE WHEN Works.Salary IS NULL THEN 0 ELSE Works.Salary END
FROM ([Employee] Left JOIN [Works] ON [Employee].[EmpNo] = [Works].[EmpNo]) LEFT JOIN [Company] ON [Works].[CmpNo] = [Company].[CmpNo]
WHERE [Employee].[EmpNo] = 'E06';