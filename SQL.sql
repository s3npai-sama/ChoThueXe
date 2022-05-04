
-- Chạy câu lệnh tạo database rồi comment dòng dưới đi 
CREATE DATABASE Quanlyxedulichh

--create database Quanlyxedulichh;

use Quanlyxedulichh;

create table dbo.[Type]
(
	carType nvarchar(25) not null PRIMARY KEY,
	
	pricePerDayExceed int not null,
	interest int not null,
)




create table dbo.Car
(
	carID int IDENTITY(1,1) PRIMARY KEY,
	carName NVArCHAR(25) NOT NULL,
	brand nvarchar(25) not null,
	carType nvarchar(25) not null ,
	seatNumber NVArCHAR(25) not null,
	licencePlate NVARCHAR(25) not null,
	rentPricePerDay int not null,
	status NVARCHAR(25) not null,
	CONSTRAINT FK_CarType foreign key (carType) references dbo.[Type]([carType]),
)




 /* tenxe,biensoxe,id_baidoxe,ngayguixe,ngaylayxe,chiphi,id_chusohuu  */
CREATE TABLE dbo.Contract
(
	[contractID] int IDENTITY(1,1) PRIMARY KEY, 
	[customerID] NVARCHAR(25) NOT NULL ,
	[customerName] CHAR(30) NOT NULL ,
	[phoneNumber] NVARCHAR(11) NOT NULL ,
	[carID] int NOT NULL,
	[dateRent] DATE NOT NULL, 
	[dateReturnExpected] date not null,
	[dateReturn] Date,
	[deposit] int not null,
	[payment] int not null,
	CONSTRAINT FK_CarID foreign key (carID) references dbo.[Car]([CarID]),
)

--Hiện thị tất cả loại xe
	SELECT * FROM dbo.Type ;

	--hiện thị các loại xe giống với loại xe điền trong textbox
		 SELECT * FROM dbo.Type WHERE Type.carType ='" + tbxCarType.Text.Trim() + "';
	
	--insert vào table loại xe 
		insert into dbo.[Type](carType, pricePerDayExceed, interest) values (N'" + tbxCarType.Text + "', '" + tbxPricePerKmExceed.Text + "','" + tbxPricePerHourExceed.Text + "');
	
	--Chỉnh sửa thông tin loại xe 
		UPDATE dbo.[Type] set carType = N'" + tbxCarType.Text.Trim() + "', pricePerDayExceed = '" + tbxPricePerKmExceed.Text.Trim() + "',interest = '" + tbxPricePerHourExceed.Text.Trim() + "' where carType = '" + tbxCarType.Text + "' ;
	
	--Xóa loại xe 
		DELETE FROM dbo.[Type] where carType ='" + tbxCarType.Text.Trim() + "'
	
	--Tìm loại xe nếu loại xe nhập vào là số 
		SELECT * FROM dbo.[Type] WHERE Type.carType ='" + keyword + "'
	
	--Tìm loại xe nếu loại xe khác rỗng 
		SELECT * FROM dbo.[Type] WHERE [Type].carType like N'%" + keyword + "%'

    --Hiện thị tất cả xe
        SELECT * FROM dbo.[Car] 

    --Hiển thi tất cả xe có mã xe bằng mã xe nhập
        SELECT * FROM dbo.[Car] WHERE [Car].carID ='" + tbxCarID.Text.Trim() + "'
    --insert vào table xe
        insert into dbo.[Car](carName,brand,carType,seatNumber,licencePlate,rentPricePerDay,status ) values (N'" + tbxCarName.Text+"',N'"+cbxBrand.SelectedItem.ToString()+"','"+ cbxCarType.SelectedValue.ToString() + "',N'"+cbxSeatNumber.SelectedItem.ToString() + "',N'"+tbxLicencePlate.Text+"',N'"+tbxRentPricePerDay.Text+"',N'"+cbxStatus.SelectedItem.ToString() + "')

    --Chỉnh sửa thông tin xe
        UPDATE dbo.[Car] set carName = N'"+tbxCarName.Text.Trim()+"',brand = N'"+cbxBrand.SelectedItem.ToString()+"',carType = '" + cbxCarType.SelectedValue.ToString() + "',seatNumber = N'" + cbxSeatNumber.SelectedItem.ToString() + "',licencePlate = '"+tbxLicencePlate.Text+"',rentPricePerDay = '"+tbxRentPricePerDay.Text+"',status =N'"+cbxStatus.SelectedItem.ToString()+"'  where carID = '" + tbxCarID.Text + "'

    --xóa xe
        DELETE FROM dbo.[Car] where carID ='" + tbxCarID.Text.Trim() + "'

    --TÌm xe 
        SELECT * FROM dbo.[Car] WHERE Car.carName ='" + keyword + "'
	--hoặc gần giống
        SELECT * FROM dbo.[Car] WHERE [Car].carName like N'%" + keyword + "%'

    --Hiển thị tất cả hợp đồng
        SELECT * FROM dbo.[Contract]

    --HIển thị 
        SELECT * FROM dbo.Contract WHERE Contract.contractID ='" + tbxContractID.Text.Trim() + "'

    --Insert vào table Contract
        insert into dbo.[Contract](customerName,customerID,phoneNumber,carID,dateRent,dateReturnExpected,dateReturn,deposit,payment,status ) values (N'" + tbxCustomerName.Text + "',N'" + tbxCustomerID.Text + "','" + tbxPhoneNumber.Text + "',N'" + cbxCarID.SelectedValue.ToString() + "','" + dtpDateRent.Value.ToString("yyyy/MM/dd") + "','" + dtpDateReturnExpected.Value.ToString("yyyy/MM/dd") + "', NULL,'" + tbxDeposit.Text+"','0',N'" + cbxStatus.SelectedItem.ToString() + "')

    --Chỉnh sửa số tiền thuê xe
        UPDATE Contract set payment = (Car.rentPricePerDay * (DATEDIFF(day, Contract.daterent, Contract.dateReturnExpected)) + (DATEDIFF(day, Contract.dateReturnExpected, Contract.dateReturn)) * Type.pricePerDayExceed) FROM Contract, Car, Type where(Car.carID = Contract.carId) AND(Car.carType = Type.carType) AND (Contract.contractID = N'"+tbxContractID+"')

    --Chỉnh sửa thông tin hợp đồng
     --   UPDATE dbo.Contract set customerName =N'" + tbxCustomerName + "', customerID = N'" + tbxCustomerID + "',phoneNumber = '" + tbxPhoneNumber + "' ,carID ='" + cbxCarID.SelectedItem.ToString() + "',dateRent = '" + dtpDateRent.Value.ToString("yyyy/MM/dd") + "',dateReturnExpected = '" + dtpDateReturnExpected.Value.ToString("yyyy / MM / dd") + "',dateReturn = 'NULL',deposit = '"+tbxDeposit.ToString("YYYY/MMM/DD") + "', 'N" + cbxStatus.SelectedItem.ToString("") + "')

    --Xóa hợp đồng
        DELETE FROM dbo.[Contract] where contractID ='" + tbxContractID.Text.Trim() + "'
 
    --Hiện thị hợp đồng với mã nhập vào 
        SELECT * FROM dbo.[Contract] WHERE Contract.contractID ='" + keyword + "'
        SELECT * FROM dbo.[Contract] WHERE [Contract].contractID like N'%" + keyword + "%'
     
	--Thống kê thông tin xe
        SELECT Car.[carID],Car.[carName],Car.[brand],Car.[carType],Car.[seatNumber],Car.[licencePlate],Car.[rentPricePerDay],Type.[pricePerDayExceed],Type.[interest],Car.[Status] FROM dbo.[Car], dbo.[Type] where Car.[carType] = Type.[carType] ;

    --Thống kê xe được thuê
        Select dbo.Car.carID, dbo.Car.carName, dbo.Car.brand, dbo.Car.carType, dbo.Car.seatNumber, dbo.Car.licencePlate, dbo.Car.rentPricePerDay, dbo.Type.pricePerDayExceed, dbo.Type.interest, dbo.Contract.dateRent, dbo.Contract.dateReturnExpected,dbo.Contract.dateReturn
                                   from dbo.Car, dbo.Type , dbo.Contract 
                                   where(dbo.Car.carType = dbo.Type.carType and dbo.Car.carID = dbo.Contract.carID and dbo.Contract.dateReturn is NULL);
    
	--Thống kê tất cả hợp đồng
        SELECT * FROM dbo.[Contract]

    --Thống kê hợp đồng trong tháng
        Select * from dbo.Contract
		      	where (MONTH(dbo.Contract.dateRent) = MONTH(GETDATE()) 
			AND YEAR(dbo.Contract.dateRent) = YEAR(GETDATE()));

    --Thống kê hợp đồng đã thanh toán trong tháng 
        Select * from dbo.Contract 
		        where (MONTH(dbo.Contract.dateReturn) = MONTH(GETDATE()) 
			AND YEAR(dbo.Contract.dateReturn) = YEAR(GETDATE()));

    --Thống kê hợp đồng chưa chả 
        Select * from dbo.Contract where (dbo.Contract.dateReturn is NULL);

    --Thống kê hợp đồng theo ngày tùy chọn
        Select * from dbo.Contract 
		        where (dbo.Contract.dateRent >='" + dtpStartDate.Value.Date.ToString("yyyy/MM/dd") + "' AND dbo.Contract.dateRent <= '" + dtpEndDate.Value.Date.ToString("yyyy/MM/dd") + "');

    --Thống kê hợp đồng thanh toán theo ngày tùy chọn
        Select * from dbo.Contract 
		        where (dbo.Contract.dateRent >='" + dtpStartDate.Value.Date.ToString("yyyy/MM/dd") + "' AND dbo.Contract.dateRent <= '" + dtpEndDate.Value.Date.ToString("yyyy/MM/dd") + "');

     --Thống kê doanh thu
        SELECT temp.carID, temp.carName,  count(Contract.contractID) as numberOfContractID ,sum(Contract.payment * temp.interest ) as sumOfInterestPayment from  (select Car.carID, Car.carName,  Type.interest from  Car inner join Type on Car.[carType] = Type.[carType]) as temp, Contract where  Contract.CarID = temp.CarID group by temp.carID, temp.carName;

     --Thống kê doanh thu theo ngày tùy chọn
        SELECT temp.carID, temp.carName,  count(Contract.contractID) as numberOfContractID ,sum(Contract.payment * temp.interest) as sumOfInterestPayment from(select Car.carID, Car.carName, Type.interest from Car inner join Type on Car.[carType] = Type.[carType]) as temp, Contract where  (Contract.CarID = temp.CarID) AND (dbo.Contract.dateRent = '" + dateTimePicker1.Value.Date.ToString("yyyy / MM / dd") + "' AND (dbo.Contract.dateReturn <= '" + dateTimePicker2.Value.Date.ToString("yyyy / MM / dd") + "') AND (Contract.payment != 0)) group by temp.carID, temp.carName;


--Xóa bảng 
/*
DROP TABLE dbo.[Contract] ;
DROP TABLE dbo.[Car] ;
DROP TABLE dbo.[Type]; 




drop database Quanlyxedulichh;
*/