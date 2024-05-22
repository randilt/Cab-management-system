CREATE TABLE customers (
    customer_id INT PRIMARY KEY IDENTITY(1,1),  -- Auto-increment primary key
    name NVARCHAR(100) NOT NULL,                -- Customer name
    contact_number NVARCHAR(15) NOT NULL,       -- Contact number
    email NVARCHAR(100) NOT NULL,               -- Email address
    nic NVARCHAR(20) NOT NULL,                  -- NIC number

);
