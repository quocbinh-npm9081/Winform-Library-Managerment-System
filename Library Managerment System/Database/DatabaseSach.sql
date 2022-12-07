use DBSachThuVien

--	CREATE TABLE BOOK

CREATE TABLE BOOK
(
	bookID char(10) primary key not null,
	bookName nvarchar(50) not null,
	bookAuthor nvarchar(50) not null,
	bookCategory char(10) not null,
	quantity int not null,
	releaseDate Date
)

select * from BOOK

--	  INSERT SOME VALUES HERE
INSERT INTO BOOK(bookID,bookName,bookAuthor,bookCategory,quantity,releaseDate)
VALUES ('111', 'Lord of the rings: Two towers', 'J.R.R Tolkien', 'PhieuLuu',100, GETDATE());
INSERT INTO BOOK(bookID,bookName,bookAuthor,bookCategory,quantity,releaseDate)
VALUES ('222', 'The Witcher: The wild hunt', 'Andrzej Sapkowski', 'PhieuLuu',50, GETDATE());
INSERT INTO BOOK(bookID,bookName,bookAuthor,bookCategory,quantity,releaseDate)
VALUES ('333', 'Dune', 'Frank Herbert', 'VienTuong',100, GETDATE());


--CREATE TABLE CATEGORY
CREATE TABLE CATEGORY
(
	categoryID char(10) primary key not null,
	categoryName nvarchar(50) not null,
)

select * from CATEGORY

--	  INSERT SOME VALUES HERE
INSERT INTO CATEGORY
VALUES ('PL','Phieu luu');

INSERT INTO CATEGORY
VALUES ('VT','Vien tuong');

ALTER TABLE BOOK ADD CONSTRAINT
FK_Book_Category FOREIGN KEY (bookCategory) REFERENCES CATEGORY(categoryID)


--CREATE TABLE ACCOUNT
CREATE TABLE ACCOUNT
(
	accountID char(10) primary key not null,
	username nvarchar(50) not null,
	passwd nvarchar(50) not null,
	phone char(10),
	kind nvarchar(10)
)
--INSERT VALUES HERE
INSERT INTO ACCOUNT VALUES ('001','student','student','1234567890','user')
INSERT INTO ACCOUNT VALUES ('002','student1','student','9999999990','user')
INSERT INTO ACCOUNT VALUES ('003','admin','admin','0000000000','admin')

SELECT * FROM ACCOUNT

--PROCEDURE LOGIN
GO
CREATE PROC pd_login @username nvarchar(50), @password nvarchar(50)
AS
BEGIN
	SELECT * FROM ACCOUNT WHERE username=@username and passwd=@password
END
GO

EXEC pd_login N'student', N'student'


--CREATE BORROWBOOK TABLE
CREATE TABLE BORROWBOOK
(
	billID int identity primary key,
	bookID char(10) not null,
	categoryID char(10) not null,
	amount int not null,
	borrowDate Date
)

SELECT * FROM BORROWBOOK
ALTER TABLE BORROWBOOK ADD CONSTRAINT
FK_BorrowBook_Account FOREIGN KEY (accountID) REFERENCES ACCOUNT(accountID)
ALTER TABLE BORROWBOOK ADD CONSTRAINT
FK_BorrowBook_Category FOREIGN KEY (categoryID) REFERENCES CATEGORY(categoryID)

INSERT INTO BORROWBOOK(bookID,categoryID,amount,borrowDate) VALUES (N'111',N'PL',5,GETDATE())
GO
CREATE TRIGGER trg_DatSach ON BORROWBOOK 
AFTER INSERT
AS
BEGIN
	UPDATE BOOK SET quantity= quantity-(SELECT amount FROM inserted WHERE bookID=inserted.bookID)
	FROM BOOK JOIN inserted ON BOOK.bookID=inserted.bookID
END


SELECT * FROM BOOK

GO
CREATE TRIGGER trg_TraSach ON BORROWBOOK 
FOR DELETE
AS
BEGIN
	UPDATE BOOK SET quantity= quantity+(SELECT amount FROM deleted WHERE bookID=deleted.bookID)
	FROM BOOK JOIN deleted ON BOOK.bookID=deleted.bookID
END


--CREATE TABLE CATEGORY
CREATE TABLE AUTHOR
(
	categoryName nvarchar(50) primary key not null,
	gender nvarchar(10),
	nation nvarchar(10),
	birthDate Date
)
SELECT * FROM AUTHOR
INSERT INTO AUTHOR VALUES(N'J.R.R Tolkien',N'male',N'United',N'3/1/1892')
INSERT INTO AUTHOR VALUES(N'Andrzej Sapkowski',N'male',N'Poland',N'6/21/1948')
INSERT INTO AUTHOR VALUES(N'Frank Herbert',N'male',N'USA',N'10/8/1920')
ALTER TABLE BOOK ADD CONSTRAINT FK_BOOK_AUTHOR FOREIGN KEY(bookAuthor) REFERENCES AUTHOR(authorName) 


