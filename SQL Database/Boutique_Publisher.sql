/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     08/05/2026 12:02:35 AM                       */
/*==============================================================*/



-- ============================================================
--  CREATE NEW DATABASE
-- ============================================================
CREATE DATABASE BoutiquePublisherDB;
GO

USE BoutiquePublisherDB;
GO


/*==============================================================*/
/* Table: AUTHOR                                                */
/*==============================================================*/
CREATE TABLE AUTHOR (
   AUTHOR_ID            INT                  IDENTITY(1,1) NOT NULL,
   NAME                 NVARCHAR(50)         NOT NULL,
   BIOGRAPHY            NVARCHAR(50)         NULL, 
   ROYALTY_PERCENTAGE   DECIMAL(8,2)         NULL,
   CONSTRAINT PK_AUTHOR PRIMARY KEY CLUSTERED (AUTHOR_ID)
)
GO

/*==============================================================*/
/* Table: BOOK                                                  */
/*==============================================================*/
CREATE TABLE BOOK (
   ISBN                 NVARCHAR(30)         NOT NULL,
   TITLE                NVARCHAR(255)        NULL, 
   GENRE                NVARCHAR(50)         NULL,
   TARGETAGEGROUP       NVARCHAR(50)         NULL,
   CONSTRAINT PK_BOOK PRIMARY KEY CLUSTERED (ISBN)
)
GO

/*==============================================================*/
/* Table: AUTHOR_BOOK                                           */
/*==============================================================*/
CREATE TABLE AUTHOR_BOOK (
   AUTHOR_ID            INT                  NOT NULL,
   ISBN                 NVARCHAR(30)         NOT NULL,
   CONSTRAINT PK_AUTHOR_BOOK PRIMARY KEY CLUSTERED (AUTHOR_ID, ISBN)
)
GO

/*==============================================================*/
/* Table: FORMAT                                                */
/*==============================================================*/
CREATE TABLE FORMAT (
   FORMAT_ID            INT                  IDENTITY(1,1) NOT NULL,
   ISBN                 NVARCHAR(30)         NOT NULL,
   FORMAT_TYPE          NVARCHAR(50)         NULL,
   PRODUCTION_COST      DECIMAL(10,2)        NULL,
   RETAIL_PRICE         DECIMAL(10,2)        NULL,
   CONSTRAINT PK_FORMAT PRIMARY KEY CLUSTERED (FORMAT_ID)
)
GO

/*==============================================================*/
/* Table: RETAILPARTNER                                         */
/*==============================================================*/
CREATE TABLE RETAILPARTNER (
   PARTNER_ID           INT                  IDENTITY(1,1) NOT NULL,
   PARTNER_NAME         NVARCHAR(50)         NULL,
   CONSTRAINT PK_RETAILPARTNER PRIMARY KEY CLUSTERED (PARTNER_ID)
)
GO

/*==============================================================*/
/* Table: [ORDER]                                               */
/*==============================================================*/
CREATE TABLE [ORDER] (
   ORDER_ID             INT                  IDENTITY(1,1) NOT NULL,
   FORMAT_ID            INT                  NOT NULL,
   PARTNER_ID           INT                  NOT NULL,
   ORDER_DATE           DATETIME             NULL, 
   QUANTITY             INT                  NOT NULL,
   CONSTRAINT PK_ORDER PRIMARY KEY CLUSTERED (ORDER_ID)
)
GO

-- ============================================================
--  ADD FOREIGN KEY CONSTRAINTS
-- ============================================================

ALTER TABLE AUTHOR_BOOK
   ADD CONSTRAINT FK_AUTHOR_BOOK_AUTHOR FOREIGN KEY (AUTHOR_ID) REFERENCES AUTHOR (AUTHOR_ID) ON DELETE CASCADE
GO

ALTER TABLE AUTHOR_BOOK
   ADD CONSTRAINT FK_AUTHOR_BOOK_BOOK FOREIGN KEY (ISBN) REFERENCES BOOK (ISBN) ON DELETE CASCADE
GO

ALTER TABLE FORMAT
   ADD CONSTRAINT FK_FORMAT_BOOK FOREIGN KEY (ISBN) REFERENCES BOOK (ISBN) ON DELETE CASCADE
GO

ALTER TABLE [ORDER]
   ADD CONSTRAINT FK_ORDER_RETAILPARTNER FOREIGN KEY (PARTNER_ID) REFERENCES RETAILPARTNER (PARTNER_ID)
GO

ALTER TABLE [ORDER]
   ADD CONSTRAINT FK_ORDER_FORMAT FOREIGN KEY (FORMAT_ID) REFERENCES FORMAT (FORMAT_ID)
GO

