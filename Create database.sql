USE [master]
GO
/****** Object:  Database [Project_PRG281]    Script Date: 2022/07/31 18:19:01 ******/
CREATE DATABASE [Project_PRG281]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project_PRG281', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Project_PRG281.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Project_PRG281_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Project_PRG281_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Project_PRG281] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project_PRG281].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project_PRG281] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project_PRG281] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project_PRG281] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project_PRG281] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project_PRG281] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project_PRG281] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Project_PRG281] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project_PRG281] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project_PRG281] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project_PRG281] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project_PRG281] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project_PRG281] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project_PRG281] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project_PRG281] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project_PRG281] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Project_PRG281] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project_PRG281] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project_PRG281] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project_PRG281] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project_PRG281] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project_PRG281] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project_PRG281] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project_PRG281] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Project_PRG281] SET  MULTI_USER 
GO
ALTER DATABASE [Project_PRG281] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project_PRG281] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project_PRG281] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project_PRG281] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Project_PRG281] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Project_PRG281] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Project_PRG281] SET QUERY_STORE = OFF
GO
USE [Project_PRG281]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 2022/07/31 18:19:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](100) NOT NULL,
	[Password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2022/07/31 18:19:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Product] [varchar](100) NOT NULL,
	[Price] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 2022/07/31 18:19:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SalesID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK__Sales__C952FB1287161FE7] PRIMARY KEY CLUSTERED 
(
	[SalesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_SalesLogin] FOREIGN KEY([UserID])
REFERENCES [dbo].[Login] ([UserID])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_SalesLogin]
GO
ALTER TABLE [dbo].[Sales]  WITH CHECK ADD  CONSTRAINT [FK_SalesProduct] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Sales] CHECK CONSTRAINT [FK_SalesProduct]
GO
USE [master]
GO
ALTER DATABASE [Project_PRG281] SET  READ_WRITE 
GO


INSERT INTO Product(Product, Price) VALUES('Small Chips','11');
INSERT INTO Product(Product, Price) VALUES('Medium Chips','18');
INSERT INTO Product(Product, Price) VALUES('Beef Burger','30');
INSERT INTO Product(Product, Price) VALUES('Beef Burger + Small Chips','40');
INSERT INTO Product(Product, Price) VALUES('Beef Burger + Medium Chips','47');
INSERT INTO Product(Product, Price) VALUES('Chicken Burger','30');
INSERT INTO Product(Product, Price) VALUES('Chicken Burger + Small Chips','40');
INSERT INTO Product(Product, Price) VALUES('Chicken Burger + Medium Chips','47');
INSERT INTO Product(Product, Price) VALUES('Toasted Cheese','13');
INSERT INTO Product(Product, Price) VALUES('Toasted Tomato + Cheese','18');
INSERT INTO Product(Product, Price) VALUES('Toasted Ham + Cheese','22');
INSERT INTO Product(Product, Price) VALUES('Toasted Ham + Tomato + Cheese','26');
INSERT INTO Product(Product, Price) VALUES('Braaibroodjie','20');
INSERT INTO Product(Product, Price) VALUES('Toasted Chicken Mayo','26');
INSERT INTO Product(Product, Price) VALUES('Plat Anna','30');
INSERT INTO Product(Product, Price) VALUES('Barber','45');
INSERT INTO Product(Product, Price) VALUES('Supreme Toast','26');
INSERT INTO Product(Product, Price) VALUES('Chicken Strips','28');
INSERT INTO Product(Product, Price) VALUES('Chicken Strips + Small Chips','38');
INSERT INTO Product(Product, Price) VALUES('Chicken Strips + Medium Chips','45');
INSERT INTO Product(Product, Price) VALUES('Russian Long','15');
INSERT INTO Product(Product, Price) VALUES('Russian Roll','22');
INSERT INTO Product(Product, Price) VALUES('Russian + Medium Chips','32');
INSERT INTO Product(Product, Price) VALUES('Footlong','26');
INSERT INTO Product(Product, Price) VALUES('Extra Cheese','6');
INSERT INTO Product(Product, Price) VALUES('Extra Meat','17');
INSERT INTO Product(Product, Price) VALUES('Extra Ham','8');
INSERT INTO Product(Product, Price) VALUES('440ml Assorted','16');
INSERT INTO Product(Product, Price) VALUES('500ml Water','8');
INSERT INTO Product(Product, Price) VALUES('500ml Flavoured Water','15');
INSERT INTO Product(Product, Price) VALUES('500ml Energade','15');
INSERT INTO Product(Product, Price) VALUES('500ml Switch/Dragon/Real','13');
INSERT INTO Product(Product, Price) VALUES('500ml Monster','23');
INSERT INTO Product(Product, Price) VALUES('300ml Red Bull','25');
INSERT INTO Product(Product, Price) VALUES('Ice Cappucino','17');
INSERT INTO Product(Product, Price) VALUES('Cappucino','17');
INSERT INTO Product(Product, Price) VALUES('Red Cappucino','17');
INSERT INTO Product(Product, Price) VALUES('Hot Chocolate','17');	

INSERT INTO Login(Username, Password) VALUES('Admin','Password1');

	