USE [SCUT2015];

CREATE TABLE [Employee] (
[EmpNo] VARCHAR(20) PRIMARY KEY,
[EmpName] VARCHAR(50) NOT NULL,
[EmpSex] VARCHAR(10) NOT NULL CHECK([EmpSex] = '男' or [EmpSex] = '女'),
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

INSERT INTO [Employee] VALUES ('E01', '张三', '女', 32);
INSERT INTO [Employee] VALUES ('E02', '李四', '男', 28);
INSERT INTO [Employee] VALUES ('E03', '王五', '女', 42);
INSERT INTO [Employee] VALUES ('E04', '赵六', '男', 37);
INSERT INTO [Employee] VALUES ('E05', '陈七', '男', 51);

INSERT INTO [Company] VALUES ('C01', '阳光科技');
INSERT INTO [Company] VALUES ('C02', '晨光科技');
INSERT INTO [Company] VALUES ('C03', '未来科技');

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