BEGIN TRY
    BEGIN TRANSACTION;
    SET IDENTITY_INSERT BikeTypes ON;

    INSERT INTO BikeTypes (Id, Name) VALUES
    (1, 'Mountain'),
    (2, 'Road'),
    (3, 'Gravel'),
    (4, 'Touring'),
    (5, 'Cross'),
    (6, 'City'),
    (7, 'Electric'),
    (8, 'Folding'),
    (9, 'Kids'),
    (10, 'BMX'),
    (11, 'Chopper'),
    (12, 'Recumbent'),
    (13, 'Triathlon'),
    (14, 'Track'),
    (15, 'Dirt'),
    (16, 'Freeride'),
    (17, 'Fixie'),
    (18, 'Cargo'),
    (19, 'Bikepacking'),
    (20, 'Full Suspension'),
    (21, 'Racing');

	SET IDENTITY_INSERT BikeTypes OFF;
	SET IDENTITY_INSERT Vendors ON;
    
    INSERT INTO Vendors (Id, Name) VALUES
    (1, 'Zenthos Dynamics'),
    (2, 'Quorix Supply'),
    (3, 'Varnex Systems'),
    (4, 'Tromida Solutions'),
    (5, 'Lunexon Ltd.'),
    (6, 'Brelvix Partners'),
    (7, 'Xandora Group'),
    (8, 'Trevax Industries'),
    (9, 'Zymanta Equipments'),
    (10, 'Norvico Gear'),
    (11, 'Veltria Vendors'),
    (12, 'Kromeda Co.'),
    (13, 'Exloren Dynamics'),
    (14, 'Farnox Ventures'),
    (15, 'Jenvora Supplies'),
    (16, 'Yarnex Corp.'),
    (17, 'Droxion Ltd.'),
    (18, 'Vexilo Traders'),
    (19, 'Grenthos Inc.'),
    (20, 'Lurexia Systems'),
    (21, 'Prevolta Supply'),
    (22, 'Bravixo Group'),
    (23, 'Morlith Vendors'),
    (24, 'Zorentha Co.'),
    (25, 'Kelvinar Equipments'),
    (26, 'Trovanta Solutions'),
    (27, 'Plunera Partners'),
    (28, 'Xelvior Industries'),
    (29, 'Deraxa Corp.'),
    (30, 'Nuvatra Ltd.');

    SET IDENTITY_INSERT Vendors OFF;
    SET IDENTITY_INSERT Images ON;

    INSERT INTO Images (Id, Path) VALUES
    (1,'cross.png'),
    (2,'city.png'),
    (3,'mtb.png');

    SET IDENTITY_INSERT Images OFF;
	SET IDENTITY_INSERT Bikes ON;

    INSERT INTO Bikes (Id, Model, VendorId, TypeId, ImageId, IsAvailable, Durability, LastMaintenanceId) VALUES
    (1, 'Velora Trekker 100', 1, 5, 1, 1, 88, NULL),
    (2, 'Falcon Ridge 300', 2, 11, 2, 1, 71, NULL),
    (3, 'Zypher Storm-X', 3, 8, 1, 1, 59, NULL),
    (4, 'TerraCruze Elite', 4, 2, 3, 1, 95, NULL),
    (5, 'CrystaFlow Z5', 5, 13, 2, 1, 82, NULL),
    (6, 'Mistral Aero 7', 6, 3, 1, 1, 77, NULL),
    (7, 'Ravix ProEdge 200', 7, 17, 1, 1, 49, NULL),
    (8, 'Astora Path 400', 8, 10, 2, 1, 63, NULL),
    (9, 'Lumina Peak 800', 9, 6, 3, 1, 91, NULL),
    (10, 'Driftline NX', 10, 1, 2, 1, 33, NULL),
    (11, 'Ventro MaxRide', 11, 14, 3, 1, 55, NULL),
    (12, 'Novar Trail GX', 12, 4, 2, 1, 67, NULL),
    (13, 'PyroVolt ZX', 13, 7, 1, 1, 42, NULL),
    (14, 'EchoCruze Motion', 14, 18, 3, 1, 79, NULL),
    (15, 'Glideon Swift', 15, 9, 2, 1, 60, NULL),
    (16, 'Hawker FX', 16, 12, 1, 1, 73, NULL),
    (17, 'Xylon Pulse 2', 17, 20, 2, 1, 37, NULL),
    (18, 'Strado Voyager', 18, 15, 3, 1, 84, NULL),
    (19, 'RevoWave E-Line', 19, 16, 1, 1, 96, NULL),
    (20, 'Altura MTX', 20, 21, 2, 1, 69, NULL),
    (21, 'Lunaris Ride', 21, 19, 2, 1, 58, NULL),
    (22, 'NeoQuest Glide', 22, 11, 3, 1, 61, NULL),
    (23, 'Ironclad Summit', 23, 2, 1, 1, 90, NULL),
    (24, 'Aether Spark 5', 24, 6, 1, 1, 48, NULL),
    (25, 'Skybound Arrow', 25, 7, 2, 1, 70, NULL),
    (26, 'Blazion Trix', 26, 3, 3, 1, 66, NULL),
    (27, 'Nimbus Dash XR', 27, 4, 1, 1, 53, NULL),
    (28, 'Vertex Cyclone', 28, 8, 3, 1, 92, NULL),
    (29, 'Trailor Nimbus S', 29, 9, 2, 1, 85, NULL),
    (30, 'Typhon Charge', 30, 5, 1, 1, 76, NULL);

    SET IDENTITY_INSERT Bikes OFF;
	SET IDENTITY_INSERT Maintenances ON;

    INSERT INTO Maintenances (Id, BikeId, MaintenanceDate, Description) VALUES
    (1, 12, '2023-03-18 14:30:00', 'Replaced worn brake pads and adjusted brakes.'),
    (2, 7, '2022-11-05 10:15:00', 'True front wheel and lubricated the chain.'),
    (3, 19, '2024-06-14 09:00:00', 'Repaired the rear derailleur and replaced the cable.'),
    (4, 4, '2021-08-27 11:45:00', 'Replaced the inner tube and checked tire pressure.'),
    (5, 26, '2023-02-10 16:30:00', 'Adjusted the handlebar and checked headset bearings.'),
    (6, 15, '2022-07-03 08:00:00', 'Replaced the chain and cleaned the drivetrain.'),
    (7, 8, '2023-10-21 13:00:00', 'Repaired the fender and tightened loose bolts.'),
    (8, 21, '2024-04-12 11:30:00', 'Replaced the pedals and checked bottom bracket play.'),
    (9, 3, '2022-05-19 15:00:00', 'Replaced the rear brake cable and adjusted braking force.'),
    (10, 29, '2024-01-06 17:45:00', 'General checkup, lubricated moving parts, cleaned the bike.'),
    (11, 11, '2021-09-14 14:00:00', 'Replaced the tires and checked tire pressure.'),
    (12, 6, '2023-06-30 09:30:00', 'Repaired the gear shift lever and replaced the shifter.'),
    (13, 25, '2022-12-11 10:45:00', 'Tightened the crankset and checked bottom bracket play.'),
    (14, 1, '2023-08-23 12:00:00', 'Adjusted the disc brakes and checked brake rotor condition.'),
    (15, 17, '2024-03-04 18:00:00', 'Replaced the rear hub bearings and lubricated freewheel mechanism.');

    UPDATE Bikes SET LastMaintenanceId = 1 WHERE Id = 1;
    UPDATE Bikes SET LastMaintenanceId = 2 WHERE Id = 2;
    UPDATE Bikes SET LastMaintenanceId = 3 WHERE Id = 3;
    UPDATE Bikes SET LastMaintenanceId = 4 WHERE Id = 4;
    UPDATE Bikes SET LastMaintenanceId = 5 WHERE Id = 5;
    UPDATE Bikes SET LastMaintenanceId = 6 WHERE Id = 6;
    UPDATE Bikes SET LastMaintenanceId = 7 WHERE Id = 7;
    UPDATE Bikes SET LastMaintenanceId = 8 WHERE Id = 8;
    UPDATE Bikes SET LastMaintenanceId = 9 WHERE Id = 9;
    UPDATE Bikes SET LastMaintenanceId = 10 WHERE Id = 10;
    UPDATE Bikes SET LastMaintenanceId = 11 WHERE Id = 11;
    UPDATE Bikes SET LastMaintenanceId = 12 WHERE Id = 12;
    UPDATE Bikes SET LastMaintenanceId = 13 WHERE Id = 13;
    UPDATE Bikes SET LastMaintenanceId = 14 WHERE Id = 14;
    UPDATE Bikes SET LastMaintenanceId = 15 WHERE Id = 15;

	SET IDENTITY_INSERT Maintenances OFF;
	SET IDENTITY_INSERT Clients ON;

    INSERT INTO Clients (Id, IdentityNumber, FirstName, LastName, PhoneNumber) VALUES
    (1, 'ID983271', 'Leran', 'Valkor', '580123456'),
    (2, 'ID837241', 'Mirel', 'Quantor', '579982214'),
    (3, 'ID993827', 'Trena', 'Silvak', '593345782'),
    (4, 'ID774512', 'Borik', 'Tarnel', '582908877'),
    (5, 'ID554392', 'Javon', 'Merkil', '590003421'),
    (6, 'ID662311', 'Elyra', 'Zenrik', '588238765'),
    (7, 'ID887234', 'Narek', 'Jostan', '589111322'),
    (8, 'ID334598', 'Velia', 'Durnak', '581234567'),
    (9, 'ID458293', 'Sorin', 'Luvor', '594789120'),
    (10, 'ID123742', 'Kirel', 'Branor', '597312045'),
    (11, 'ID998231', 'Darin', 'Kovrek', '586543212'),
    (12, 'ID823471', 'Falia', 'Vintor', '599128877'),
    (13, 'ID233674', 'Miren', 'Torven', '585321476'),
    (14, 'ID374829', 'Tharon', 'Velnik', '598904431'),
    (15, 'ID142398', 'Yarel', 'Mordak', '590876123'),
    (16, 'ID567123', 'Lenir', 'Gorvak', '591298762'),
    (17, 'ID986742', 'Silra', 'Xandor', '582999123'),
    (18, 'ID813246', 'Giren', 'Wolten', '594120865'),
    (19, 'ID274851', 'Tarin', 'Kelros', '586531274'),
    (20, 'ID349827', 'Orila', 'Vendak', '597003742'),
    (21, 'ID985634', 'Neran', 'Zuriel', '598472193'),
    (22, 'ID752483', 'Harol', 'Yentil', '582139845'),
    (23, 'ID541287', 'Ebron', 'Vurtek', '593918472'),
    (24, 'ID918347', 'Zerin', 'Palvek', '589473218'),
    (25, 'ID214785', 'Revan', 'Dorven', '591274829'),
    (26, 'ID657843', 'Calen', 'Jarnak', '590347281'),
    (27, 'ID873214', 'Vena', 'Torel', '593178294'),
    (28, 'ID928374', 'Lorik', 'Fandor', '596785412'),
    (29, 'ID124789', 'Eran', 'Talven', '588902134'),
    (30, 'ID781243', 'Selin', 'Zornak', '594738291');

	SET IDENTITY_INSERT Clients OFF;
	SET IDENTITY_INSERT Rentals ON;

    INSERT INTO Rentals (Id, ClientID, RentedFrom, RentedTo, AllBikesReturned) VALUES
    (1, 5, '2023-07-15 08:30:00', '2023-07-20 10:00:00', 1),
    (2, 12, '2022-05-22 09:00:00', '2022-05-25 14:30:00', 1),
    (3, 8, '2024-04-01 11:15:00', '2024-04-05 16:45:00', 1),
    (4, 20, '2023-11-12 13:00:00', '2023-11-14 12:30:00', 1),
    (5, 3, '2022-08-10 10:00:00', '2022-08-14 09:30:00', 1),
    (6, 7, '2024-02-14 14:30:00', '2024-02-18 11:00:00', 1),
    (7, 25, '2023-09-19 08:45:00', '2023-09-22 17:00:00', 1),
    (8, 18, '2022-06-27 16:00:00', '2022-06-30 12:15:00', 1),
    (9, 14, '2023-01-11 09:30:00', '2023-01-15 10:00:00', 1),
    (10, 19, '2024-05-02 08:00:00', '2024-05-05 18:00:00', 1),
    (11, 6, '2022-07-03 10:30:00', '2022-07-07 15:00:00', 1),
    (12, 22, '2023-10-25 14:00:00', '2023-10-29 13:30:00', 1),
    (13, 11, '2024-03-08 12:00:00', '2024-03-11 10:00:00', 1),
    (14, 16, '2023-08-17 13:30:00', '2023-08-20 11:30:00', 1),
    (15, 30, '2024-01-22 09:00:00', '2024-01-25 16:00:00', 1);

	SET IDENTITY_INSERT Rentals OFF;

    INSERT INTO RentedBikes (BikeId, RentalId, ReturnDate, ReturnStatusDescription) VALUES
    (1, 1, '2023-07-20 10:30:00', ''),
    (2, 1, '2023-07-20 10:30:00', 'Bike returned with a flat tire.'),
    (3, 2, '2022-05-25 14:30:00', 'Returned with minor scratches on the frame.'),
    (4, 3, '2024-04-05 16:00:00', 'Returned with dirty tires and unlubricated chain.'),
    (5, 3, '2024-04-05 16:00:00', 'Returned in excellent condition.'),
    (6, 4, '2023-11-14 12:00:00', ''),
    (7, 5, '2022-08-14 09:30:00', ''),
    (8, 6, '2024-02-18 11:00:00', 'Bike returned in perfect condition, no issues.'),
    (9, 6, '2024-02-18 11:00:00', 'Bike returned with a slightly bent rim.'),
    (10, 7, '2023-09-22 17:00:00', 'Bike returned with no visible damage.'),
    (11, 8, '2022-06-30 12:00:00', 'Bike returned with a broken rear light.'),
    (12, 9, '2023-01-15 10:00:00', 'Returned with minor wear on tires.'),
    (13, 10, '2024-05-05 18:00:00', ''),
    (14, 11, '2022-07-07 15:00:00', 'Bike returned with some scratches and dirt.'),
    (15, 12, '2023-10-29 13:30:00', 'Returned with a flat front tire.'),
    (16, 13, '2024-03-11 10:00:00', 'Bike returned with a broken bell, needs replacement.'),
    (17, 14, '2023-08-20 11:30:00', ''),
    (18, 15, '2024-01-25 16:00:00', 'Bike returned in perfect working condition.'),
    (19, 1, '2023-07-20 10:30:00', 'Returned with broken handlebar grips.'),
    (20, 2, '2022-05-25 14:30:00', 'Returned with a dent in the front wheel.'),
    (21, 3, '2024-04-05 16:00:00', 'Returned with greasy chain, needs cleaning.'),
    (22, 4, '2023-11-14 12:00:00', 'Bike returned in excellent condition.'),
    (23, 5, '2022-08-14 09:30:00', 'Bike returned with worn-out tires.'),
    (24, 6, '2024-02-18 11:00:00', 'Returned with scratches on the seat frame.'),
    (25, 7, '2023-09-22 17:00:00', 'Bike returned with broken rear derailleur.'),
    (26, 8, '2022-06-30 12:00:00', ''),
    (27, 9, '2023-01-15 10:00:00', 'Bike returned with clean and properly inflated tires.'),
    (28, 10, '2024-05-05 18:00:00', ''),
    (29, 11, '2022-07-07 15:00:00', 'Bike returned with missing water bottle holder.'),
    (30, 12, '2023-10-29 13:30:00', 'Bike returned with some dirt on the frame, no issues.'),
    (10, 13, '2024-03-11 10:00:00', 'Returned with broken front light.'),
    (11, 14, '2023-08-20 11:30:00', 'Bike returned with small damage to the rear wheel.'),
    (12, 15, '2024-01-25 16:00:00', ''),
    (13, 1, '2023-07-20 10:30:00', ''),
    (14, 2, '2022-05-25 14:30:00', 'Returned with broken kickstand.'),
    (15, 3, '2024-04-05 16:00:00', ''),
    (16, 4, '2023-11-14 12:00:00', 'Bike returned with scratches on the saddle.'),
    (17, 5, '2022-08-14 09:30:00', ''),
    (18, 6, '2024-02-18 11:00:00', 'Bike returned with the brakes needing adjustment.'),
    (19, 7, '2023-09-22 17:00:00', '');

    COMMIT;
END TRY
BEGIN CATCH
    ROLLBACK;
    PRINT ERROR_MESSAGE();
END CATCH