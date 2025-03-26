-- Create Tables
CREATE TABLE Items (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX),
    Quantity INT NOT NULL,
    Barcode NVARCHAR(50),
    QRCode NVARCHAR(50),
    PurchasePrice DECIMAL(18,2),
    PurchaseDate DATE,
    VendorName NVARCHAR(255),
    ModelNumber NVARCHAR(50),
    SerialNumber NVARCHAR(50),
    Notes NVARCHAR(MAX)
);

CREATE TABLE Assets (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX),
    AssetTag NVARCHAR(50) NOT NULL,
    SerialNumber NVARCHAR(50),
    ModelNumber NVARCHAR(50),
    Vendor NVARCHAR(255),
    PurchaseDate DATE,
    PurchasePrice DECIMAL(18,2),
    StartDate DATE,
    EndDate DATE,
    Location NVARCHAR(255),
    Status NVARCHAR(50),
    AssignedTo NVARCHAR(255),
    Notes NVARCHAR(MAX)
);

CREATE TABLE Tickets (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX),
    Priority NVARCHAR(50) NOT NULL,
    Status NVARCHAR(50) NOT NULL,
    CreatedDate DATETIME NOT NULL,
    ClosedDate DATETIME,
    AssignedTo NVARCHAR(255),
    ReportedBy NVARCHAR(255),
    Attachments NVARCHAR(MAX),
    Notes NVARCHAR(MAX)
);

CREATE TABLE Reports (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX),
    CreatedDate DATETIME NOT NULL,
    ReportType NVARCHAR(50),
    ReportData NVARCHAR(MAX),
    Notes NVARCHAR(MAX)
);

CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    UserName NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(255),
    PhoneNumber NVARCHAR(50),
    IsActive BIT,
    CreatedDate DATETIME,
    Roles NVARCHAR(255)
);

-- Insert Sample Data
-- Items
INSERT INTO Items (Name, Description, Quantity, PurchasePrice, VendorName) VALUES
('لابتوب', 'لابتوب Dell XPS 13', 10, 1200.00, 'Dell'),
('شاشة', 'شاشة LG 27 بوصة', 20, 250.00, 'LG');

-- Assets
INSERT INTO Assets (Name, Description, AssetTag, Location, Status) VALUES
('لابتوب', 'لابتوب Dell XPS 13', 'DELL001', 'المكتب', 'In Use'),
('شاشة', 'شاشة LG 27 بوصة', 'LG001', 'المكتب', 'Available');

-- Tickets
INSERT INTO Tickets (Title, Description, Priority, Status, CreatedDate, ReportedBy) VALUES
('مشكلة في الشبكة', 'لا يمكن الاتصال بالإنترنت', 'عالية', 'مفتوحة', GETDATE(), 'أحمد'),
('مشكلة في الطابعة', 'الطابعة لا تطبع', 'متوسطة', 'قيد المعالجة', GETDATE(), 'سارة');

-- Reports
INSERT INTO Reports (Name, ReportType, CreatedDate) VALUES
('تقرير المخزون', 'Inventory', GETDATE()),
('تقرير الأصول', 'Asset', GETDATE());

-- Users
INSERT INTO Users (UserName, Email, Password, FullName, IsActive, Roles) VALUES
('admin', 'admin@example.com', 'password', 'Admin User', 1, 'Admin'),
('user', 'user@example.com', 'password', 'Regular User', 1, 'User');