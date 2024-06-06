-- Enable IDENTITY_INSERT for Organizer Table
SET IDENTITY_INSERT Organizers ON;

-- Insert Data into Organizer Table
INSERT INTO Organizers (OrganizerId, OrganizerName, ContactEmail, ContactPhone)
VALUES
(1, 'Tech Events Inc', 'contact@techevents.com', '123-456-7890'),
(2, 'Music Mania', 'info@musicmania.com', '987-654-3210'),
(3, 'Art World', 'support@artworld.com', '555-666-7777');

-- Disable IDENTITY_INSERT for Organizer Table
SET IDENTITY_INSERT Organizers OFF;

-- Enable IDENTITY_INSERT for Event Table
SET IDENTITY_INSERT Events ON;

-- Insert Data into Event Table
INSERT INTO Events (EventId, EventName, EventDate, EventTime, Location, Description, OrganizerId)
VALUES
(1, 'Tech Conference', '2024-07-15', '09:00:00', 'New York, NY', 'Annual tech conference', 1),
(2, 'Music Festival', '2024-08-20', '15:00:00', 'Los Angeles, CA', 'Summer music festival', 2),
(3, 'Art Exhibition', '2024-09-10', '11:00:00', 'Chicago, IL', 'Exhibition of modern art', 3);

-- Disable IDENTITY_INSERT for Event Table
SET IDENTITY_INSERT Events OFF;

-- Enable IDENTITY_INSERT for Attendee Table
SET IDENTITY_INSERT Attendees ON;

-- Insert Data into Attendee Table
INSERT INTO Attendees (AttendeeId, FirstName, LastName, Email, Phone, RegistrationDate, EventId)
VALUES
(1, 'John', 'Doe', 'john.doe@example.com', '111-222-3333', '2024-06-01', 1),
(2, 'Jane', 'Smith', 'jane.smith@example.com', '444-555-6666', '2024-06-05', 1),
(3, 'Alice', 'Johnson', 'alice.j@example.com', '777-888-9999', '2024-06-10', 2),
(4, 'Bob', 'Brown', 'bob.b@example.com', '000-111-2222', '2024-06-15', 2),
(5, 'Charlie', 'Davis', 'charlie.d@example.com', '333-444-5555', '2024-06-20', 3);

-- Disable IDENTITY_INSERT for Attendee Table
SET IDENTITY_INSERT Attendees OFF;
