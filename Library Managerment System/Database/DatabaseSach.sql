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
