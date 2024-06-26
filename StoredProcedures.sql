﻿-- spAddEvent
CREATE PROCEDURE spAddEvent
    @EventName VARCHAR(255),
    @EventDate DATE,
    @EventTime TIME,
    @Location VARCHAR(255),
    @Description TEXT,
    @OrganizerID INT
AS
BEGIN
    INSERT INTO Events (EventName, EventDate, EventTime, Location, Description, OrganizerId)
    VALUES (@EventName, @EventDate, @EventTime, @Location, @Description, @OrganizerID);
END
GO

-- spDeleteEvent
CREATE PROCEDURE spDeleteEvent
    @EventID INT
AS
BEGIN
    DELETE FROM Events WHERE EventId = @EventID;
END
GO

-- spGetEvent
CREATE PROCEDURE spGetEvent
    @EventID INT
AS
BEGIN
    SELECT e.EventId, e.EventName, e.EventDate, e.EventTime, e.Location, e.Description, e.OrganizerId
    FROM Events e
    WHERE e.EventId = @EventID;
END
GO

-- spGetEvents
CREATE PROCEDURE spGetEvents
AS
BEGIN
    SELECT e.EventId, e.EventName, e.EventDate, e.EventTime, e.Location, e.Description, e.OrganizerId
    FROM Events e;
END
GO

-- spUpdateEvent
CREATE PROCEDURE spUpdateEvent
    @EventID INT,
    @EventName VARCHAR(255),
    @EventDate DATE,
    @EventTime TIME,
    @Location VARCHAR(255),
    @Description TEXT,
    @OrganizerID INT
AS
BEGIN
    UPDATE Events
    SET EventName = @EventName,
        EventDate = @EventDate,
        EventTime = @EventTime,
        Location = @Location,
        Description = @Description,
        OrganizerId = @OrganizerID
    WHERE EventId = @EventID;
END
GO

-- spAddAttendee
CREATE PROCEDURE spAddAttendee
    @FirstName VARCHAR(255),
    @LastName VARCHAR(255),
    @Email VARCHAR(255),
    @Phone VARCHAR(50),
    @RegistrationDate DATE,
    @EventId INT
AS
BEGIN
    INSERT INTO Attendees (FirstName, LastName, Email, Phone, RegistrationDate, EventId)
    VALUES (@FirstName, @LastName, @Email, @Phone, @RegistrationDate, @EventId);
END
GO

CREATE PROCEDURE spAddAttendee
    @FirstName VARCHAR(255),
    @LastName VARCHAR(255),
    @Email VARCHAR(255),
    @Phone VARCHAR(50),
    @RegistrationDate DATE,
    @EventId INT
AS
BEGIN
    INSERT INTO Attendees (FirstName, LastName, Email, Phone, RegistrationDate, EventId)
    VALUES (@FirstName, @LastName, @Email, @Phone, @RegistrationDate, @EventId);
END
GO

CREATE PROCEDURE spUpdateAttendee
    @AttendeeId INT,
    @FirstName VARCHAR(255),
    @LastName VARCHAR(255),
    @Email VARCHAR(255),
    @Phone VARCHAR(50),
    @RegistrationDate DATE,
    @EventId INT
AS
BEGIN
    UPDATE Attendees
    SET FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email,
        Phone = @Phone,
        RegistrationDate = @RegistrationDate,
        EventId = @EventId
    WHERE AttendeeId = @AttendeeId;
END
GO

CREATE PROCEDURE spDeleteAttendee
    @AttendeeId INT
AS
BEGIN
    DELETE FROM Attendees WHERE AttendeeId = @AttendeeId;
END
GO

CREATE PROCEDURE spGetAttendee
    @AttendeeId INT
AS
BEGIN
    SELECT a.AttendeeId, a.FirstName, a.LastName, a.Email, a.Phone, a.RegistrationDate, a.EventId
    FROM Attendees a
    WHERE a.AttendeeId = @AttendeeId;
END
GO

CREATE PROCEDURE spGetAttendees
AS
BEGIN
    SELECT a.AttendeeId, a.FirstName, a.LastName, a.Email, a.Phone, a.RegistrationDate, a.EventId
    FROM Attendees a;
END
GO
