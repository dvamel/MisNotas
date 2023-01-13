use  MisNotas;

go

CREATE PROCEDURE CreacionDeMaestros
	@Tipo int,
	@Nombre VARCHAR(200),
	@Codigo VARCHAR(50) null,
	@Visible bit =1,
	@IncluirEnListados bit NULL,
	@CategoriaId int null

AS  

BEGIN 
	BEGIN TRANSACTION
	
	BEGIN TRY


	IF (@Tipo=1)  
		BEGIN 
			IF NOT EXISTS (SELECT * FROM TiposPersona WHERE Codigo=@Codigo)  
					BEGIN 
						INSERT INTO dbo.TiposPersona (Nombre, Codigo,Visible,CategoriaId)
						VALUES(UPPER(@Nombre),@Codigo,@Visible,@CategoriaId)
			END 
			ELSE 
				BEGIN 
						UPDATE dbo.TiposPersona SET Nombre= UPPER(@Nombre), Visible=@Visible, CategoriaId=@CategoriaId  WHERE Codigo=@Codigo
			END 
		END 


	IF (@Tipo=2)  
		BEGIN 
			 IF NOT EXISTS (SELECT * FROM Estados WHERE Codigo=@Codigo)  
				BEGIN 
						INSERT INTO dbo.Estados (Nombre, Codigo,Visible,CategoriaId)
						VALUES(UPPER(@Nombre),@Codigo,@Visible,@CategoriaId)
				END 
			ELSE 
				BEGIN 
					UPDATE dbo.Estados SET Nombre= UPPER(@Nombre), Visible=@Visible,CategoriaId=@CategoriaId  WHERE Codigo=@Codigo
				END 

		END 


	IF (@Tipo=3)  
		BEGIN 
			IF NOT EXISTS (SELECT * FROM TiposDeAdjuntos WHERE Codigo=@Codigo)  
				BEGIN 
					INSERT INTO dbo.TiposDeAdjuntos (Nombre, Codigo,Visible,CategoriaId)
					VALUES(UPPER(@Nombre),@Codigo,@Visible,@CategoriaId)
				END 
			ELSE 
				BEGIN 
					UPDATE dbo.TiposDeAdjuntos SET Nombre= UPPER(@Nombre), Visible=@Visible,CategoriaId=@CategoriaId  WHERE Codigo=@Codigo
				END 
		END


	IF (@Tipo=4)  
		BEGIN 
			IF NOT EXISTS (SELECT * FROM TiposDeQuerys WHERE Codigo=@Codigo)  
				BEGIN 
					INSERT INTO dbo.TiposDeQuerys (Nombre, Codigo,Visible,CategoriaId)
					VALUES(UPPER(@Nombre),@Codigo,@Visible,@CategoriaId)
				END 
			ELSE 
				BEGIN 
					UPDATE dbo.TiposDeQuerys SET Nombre= UPPER(@Nombre), Visible=@Visible,CategoriaId=@CategoriaId  WHERE Codigo=@Codigo
				END 
		END


	IF (@Tipo=5)  
		BEGIN 
			IF NOT EXISTS (SELECT * FROM TiposDePendientes WHERE Codigo=@Codigo)  
				BEGIN 
					INSERT INTO dbo.TiposDePendientes (Nombre, Codigo,Visible,CategoriaId)
					VALUES(UPPER(@Nombre),@Codigo,@Visible,@CategoriaId)
				END 
			ELSE 
				BEGIN 
						UPDATE dbo.TiposDePendientes SET Nombre= UPPER(@Nombre), Visible=@Visible,CategoriaId=@CategoriaId  WHERE Codigo=@Codigo
				END 

		END

		IF (@Tipo=6)  
		BEGIN 
			IF NOT EXISTS (SELECT * FROM Categoria WHERE Nombre=@Nombre)  
				BEGIN 
					INSERT INTO dbo.Categoria (Nombre, IncluirEnListados)
					VALUES(UPPER(@Nombre),@IncluirEnListados)
				END 
			ELSE 
				BEGIN 
						UPDATE dbo.Categoria SET IncluirEnListados=@IncluirEnListados  WHERE Nombre=@Nombre
				END 

			

		END

	COMMIT TRANSACTION 
	END TRY
	BEGIN  CATCH
	ROLLBACK TRANSACTION
		SELECT 
		ERROR_LINE(),
		ERROR_MESSAGE(),
		ERROR_SEVERITY()

END CATCH


END 

go 

create PROCEDURE CreacionDePersonas
    @Tipo int,
	@TipoId INT,
	@EstadoId INT ,
	@Nombre VARCHAR(50),
	@Observaciones VARCHAR(1000) null,
	@NombreUsuario VARCHAR(20) null,
	@Password VARCHAR(max) null,
	@Activo bit NULL,
	@Correo VARCHAR(200) null,
	@DetalleTecnico VARCHAR(max) null,
	@Aplicaciones VARCHAR(max) null,
	@Contactos VARCHAR(max) null
AS  

BEGIN 
	BEGIN TRANSACTION
	BEGIN TRY
		IF (@Tipo=1) 
			BEGIN 
				IF NOT EXISTS(SELECT * FROM Personas WHERE Nombre=UPPER(@Nombre) ) 
					BEGIN 
						INSERT INTO Personas (TipoId,EstadoId,Nombre,Observaciones,NombreUsuario,Password,Activo,Correo)
						VALUES (@TipoId,@EstadoId,UPPER(@Nombre),@Observaciones,@NombreUsuario,@Password,@Activo,@Correo)
					END 
				ELSE
					BEGIN 
						UPDATE dbo.Personas SET  
							TipoId=@TipoId,
							EstadoId=@EstadoId,
							Nombre=UPPER(@Nombre),
							Observaciones=@Observaciones,
							NombreUsuario=@NombreUsuario,
							Password=@Password,
							Activo=@Activo,
							Correo=@Correo
						WHERE Nombre=@Nombre
					END
				
			END 


		IF (@Tipo=2) 
			BEGIN 
				DECLARE @Id INT

				IF NOT EXISTS(SELECT * FROM Personas WHERE Nombre=UPPER(@Nombre)) 
					BEGIN 
						INSERT INTO Personas (TipoId,EstadoId,Nombre,Observaciones,NombreUsuario,Password,Activo,Correo)
						VALUES (@TipoId,@EstadoId,UPPER(@Nombre),@Observaciones,@NombreUsuario,@Password,@Activo,@Correo)

						SET @Id =SCOPE_IDENTITY();

						INSERT INTO Clientes (Personaid,DetalleTecnico,Aplicaciones,Contactos)
						VALUES(@Id,@DetalleTecnico,@Aplicaciones,@Contactos) 
					END 
				ELSE
					BEGIN 
						UPDATE dbo.Personas SET  
							TipoId=@TipoId,
							EstadoId=@EstadoId,
							Nombre=UPPER(@Nombre),
							Observaciones=@Observaciones,
							NombreUsuario=@NombreUsuario,
							Password=@Password,
							Activo=@Activo,
							Correo=@Correo
						WHERE Nombre=UPPER(@Nombre)

						UPDATE dbo.Clientes SET  
						DetalleTecnico=@DetalleTecnico, 
						Aplicaciones=@Aplicaciones, 
						Contactos=@Contactos  WHERE PersonaId IN (SELECT id FROM Personas WHERE Nombre=UPPER(@Nombre))
					END
			END 



		COMMIT TRANSACTION 
	END TRY
	BEGIN  CATCH
	ROLLBACK TRANSACTION
		SELECT 
		ERROR_LINE(),
		ERROR_MESSAGE(),
		ERROR_SEVERITY()

END CATCH


END 


go 


CREATE PROCEDURE CreacionDePendientes
	@Nombre VARCHAR(100),
	@EstadoId INT,
	@Fecha DATE,
	@FechaEntrega DATE,
	@HoraDeEntrega time null,
	@Observaciones VARCHAR(max),
	@TipoDePendienteId int ,
	@Id INT = null

AS  

BEGIN 
	BEGIN TRANSACTION

BEGIN TRY
	
	IF (ISNULL(@Id,0) =0) 
		BEGIN 
			INSERT INTO dbo.Pendientes (Nombre,EstadoId,Fecha,FechaEntrega ,HoraDeEntrega,Observaciones,TipoDePendienteId)
			VALUES(UPPER(@Nombre),@EstadoId,@Fecha,@FechaEntrega,@HoraDeEntrega,@Observaciones,@TipoDePendienteId)

			SELECT SCOPE_IDENTITY() Id
		END 
	ELSE 
		BEGIN 
		  UPDATE dbo.Pendientes SET  EstadoId=ISNULL(@EstadoId,EstadoId), FechaEntrega=ISNULL(@FechaEntrega,FechaEntrega),HoraDeEntrega=ISNULL(@HoraDeEntrega,HoraDeEntrega), Observaciones=ISNULL(@Observaciones,Observaciones), 
		  TipoDePendienteId=ISNULL(@TipoDePendienteId,TipoDePendienteId)  WHERE id=@Id
		END 

		
		
		COMMIT TRANSACTION 
	END TRY
	BEGIN  CATCH
	ROLLBACK TRANSACTION
		SELECT 
		ERROR_LINE(),
		ERROR_MESSAGE(),
		ERROR_SEVERITY()

END CATCH


END 


GO

CREATE PROCEDURE CreacionDeAdjuntos
		@Nombre VARCHAR(100),
		@Ruta VARCHAR(max),
		@Fecha DATE,
		@Observaciones VARCHAR(1000) null,
		@TipoDeAjuntoId int,
		@Documento varbinary(max)
AS  

BEGIN 
	BEGIN TRANSACTION

BEGIN TRY

		INSERT INTO dbo.Adjuntos (Nombre,Ruta,Fecha,Observaciones,TipoDeAjuntoId,Documento)
		VALUES(UPPER(@Nombre),@Ruta,@Fecha,@Observaciones,@TipoDeAjuntoId,@Documento )

		SELECT SCOPE_IDENTITY() Id

		COMMIT TRANSACTION 
	END TRY
	BEGIN  CATCH
	ROLLBACK TRANSACTION
		SELECT 
		ERROR_LINE(),
		ERROR_MESSAGE(),
		ERROR_SEVERITY()

END CATCH


END 


GO

create PROCEDURE CreacionDeQuerys
	@Nombre VARCHAR(100) ,
	@Observaciones VARCHAR(MAX),
	@PersonaCreadoraId INT,
	@EstadoId INT,
	@DetalleTecnico VARCHAR (max),
	@Aplicaciones  VARCHAR(max),
	@TipoDeQueryId int,
	@Id int null
AS  

BEGIN 
	BEGIN TRANSACTION

BEGIN TRY

	IF (ISNULL(@Id,0) =0) 
		BEGIN 

			INSERT INTO dbo.Querys (Nombre,Observaciones,PersonaCreadoraId,EstadoId,DetalleTecnico,Aplicaciones,TipoDeQueryId)
			VALUES(UPPER(@Nombre),@Observaciones,@PersonaCreadoraId,@EstadoId,@DetalleTecnico,@Aplicaciones,@TipoDeQueryId)

			SELECT SCOPE_IDENTITY() Id
		END 
	ELSE 
		BEGIN 
		  UPDATE dbo.Querys SET   Observaciones=ISNULL(@Observaciones,Observaciones), PersonaCreadoraId=ISNULL(@PersonaCreadoraId,PersonaCreadoraId), 
		  EstadoId=ISNULL(@EstadoId,EstadoId), DetalleTecnico=ISNULL(@DetalleTecnico,DetalleTecnico), Aplicaciones=ISNULL(@Aplicaciones,Aplicaciones)
		  , TipoDeQueryId=ISNULL(@TipoDeQueryId,TipoDeQueryId) WHERE id=@Id
		END 
		

		COMMIT TRANSACTION 
	END TRY
	BEGIN  CATCH
	ROLLBACK TRANSACTION
		SELECT 
		ERROR_LINE(),
		ERROR_MESSAGE(),
		ERROR_SEVERITY()

END CATCH


END 


GO

create PROCEDURE CreacionDeRelaciones
  @Tipo int,
  @DocumentoId int,
  @RelacionId int

AS  

BEGIN 
	BEGIN TRANSACTION

BEGIN TRY

		IF(@Tipo=1)
		BEGIN

			INSERT INTO dbo.AdjuntosRelacionados (AdjuntoId,RelacionId)
			VALUES(@DocumentoId,@RelacionId)

		END


		IF(@Tipo=2)
		BEGIN

			INSERT INTO dbo.QuerysRelacionados (QueryId,RelacionId)
			VALUES(@DocumentoId,@RelacionId)

		END

		COMMIT TRANSACTION 
	END TRY
	BEGIN  CATCH
	ROLLBACK TRANSACTION
		SELECT 
		ERROR_LINE(),
		ERROR_MESSAGE(),
		ERROR_SEVERITY()

END CATCH


END 

go 


create PROCEDURE listados
	@Tipo INT ,
	@Nombre VARCHAR(max) = null,
	@Id INT = NULL
	
AS BEGIN 
		
		IF (@Tipo=1) 
			BEGIN 
				SELECT Id,Nombre,Codigo ,Visible,CategoriaId FROM TiposPersona   ORDER BY id desc
				RETURN
			END 

			IF (@Tipo=2) 
			BEGIN 
				SELECT Id,Nombre,Codigo  , Visible,CategoriaId  FROM Estados   ORDER BY id desc
				RETURN
			END

			IF (@Tipo=3) 
			BEGIN 
				SELECT Id,Nombre,Codigo  ,Visible,CategoriaId FROM TiposDeAdjuntos   ORDER BY id desc
			END

			IF (@Tipo=4) 
			BEGIN 
				SELECT Id,Nombre,Codigo  ,Visible,CategoriaId  FROM TiposDeQuerys    ORDER BY id desc
				RETURN
			END

			IF (@Tipo=5) 
			BEGIN 
				SELECT Id,Nombre,Codigo  ,Visible,CategoriaId   FROM TiposDePendientes  ORDER BY id desc
				RETURN
			END

			IF (@Tipo=6) 
			BEGIN 
				SELECT TOP 20
					p.Id, 
					p.FechaEntrega,
					p.Nombre + '   ['+convert(VARCHAR(10),p.FechaEntrega) + '  '+ convert(VARCHAR(10),FORMAT(convert(DATEtime,p.HoradeEntrega),'hh:mm')) +']'  Nombre, 
					Observaciones, 
					e.nombre Estado, 
					tp.nombre Tipodependiente, 
					case 
						WHEN p.FechaEntrega <= GETDATE() and FORMAT(convert(DATEtime,p.HoradeEntrega),'hh:mm') <=  FORMAT(GETDATE(),'hh:mm') then '#E61F00'  
						WHEN p.FechaEntrega <= GETDATE() then '#E65F0C'  
						WHEN  DATEdiff(day,GETDATE(),p.FechaEntrega) =1 then '#E65B14'  
						WHEN  DATEdiff(day,GETDATE(),p.FechaEntrega) =2 then '#E68F18'
						WHEN  DATEdiff(day,GETDATE(),p.FechaEntrega) BETWEEN 3 AND 5 then '#E69212'
						WHEN  DATEdiff(day,GETDATE(),p.FechaEntrega) BETWEEN 6 AND 15 then '#A7E621'
						WHEN  DATEdiff(day,GETDATE(),p.FechaEntrega) > 16 then '#28A5F0'
					END Color  
				
				FROM Pendientes p
				inner join estados e ON p.estadoid=e.id
				inner join TiposDePendientes tp ON p.tipodependienteid=tp.id
				inner join Categoria ct ON e.CategoriaId=ct.Id
				WHERE  ISNULL(ct.IncluirEnListados,0)  IN (1) 
				ORDER BY FechaEntrega asc
				RETURN
			END

			IF (@Tipo=7) 
			BEGIN 
				SELECT * FROM Adjuntos WHERE ID =ISNULL(@Id,ID)
				RETURN
			END

			IF (@Tipo=8) 
			BEGIN 
				SELECT id,Nombre,convert(VARCHAR(100),replace(Observaciones,char(10),'')) Observaciones, 1 Tipo, '' ObservacionesAdicionales1, '' ObservacionesAdicionales2, EstadoId INTO #ResultadoSinFiltro FROM Personas 
				union
				SELECT id,Nombre, convert(VARCHAR(100),replace(Observaciones,char(10),'')) Observaciones,2,'','',EstadoId FROM Pendientes 
				union 
				SELECT  id,Nombre,convert(VARCHAR(100),replace(Observaciones,char(10),'')) Observaciones,3,DetalleTecnico,Observaciones,EstadoId FROM Querys 
				

				SELECT r.* INTO #Resultado FROM #ResultadoSinFiltro r
				inner join estados e ON r.EstadoId=e.id 
				inner JOIN Categoria ct ON e.CategoriaId=ct.id AND ISNULL(ct.IncluirEnListados,0) IN (1)
				union
				SELECT id,Nombre, convert(VARCHAR(100),replace(Observaciones,char(10),'')) Observaciones,4,'','',1 FROM Adjuntos

				SELECT TOP 10 * FROM #Resultado r 
				WHERE r.nombre Like '%'+ISNULL(@Nombre,r.nombre)+'%'  or Observaciones Like '%'+ISNULL(@Nombre,r.nombre)+'%' or ObservacionesAdicionales2 Like '%'+ISNULL(@Nombre,r.nombre)+'%'
				or ObservacionesAdicionales1 Like '%'+ISNULL(@Nombre,r.nombre)+'%'
				
				RETURN
			END

			
			IF (@Tipo=9) 
			BEGIN 
				SELECT *  FROM Pendientes WHERE Id=@Id
				RETURN
			END

			IF (@Tipo=10) 
			BEGIN 
				SELECT a.*  FROM Pendientes p
				inner join AdjuntosRelacionados ad ON p.id=ad.RelacionId
				inner join Adjuntos a ON ad.AdjuntoId=a.Id
				WHERE p.Id=@Id or a.Id=@Id 

				RETURN
			END

			IF (@Tipo=11) 
			BEGIN 
				SELECT Id,Nombre FROM Personas  
				RETURN
			END 


			IF (@Tipo=12) 
			BEGIN 
				SELECT * FROM Querys q
				inner join estados e ON q.EstadoId=e.id
				inner join Categoria ct ON e.CategoriaId=ct.Id
				WHERE q.Id=@Id AND e.Visible=1 AND ISNULL(ct.IncluirEnListados,0)  IN (1)
				RETURN
			END 

			IF (@Tipo=13) 
			BEGIN 
				SELECT Id,Nombre,IncluirEnListados [Incluir En Listados]    FROM Categoria  ORDER BY id desc
				RETURN
			END

			IF (@Tipo=14) 
			BEGIN 
				SELECT p.* ,cl.DetalleTecnico,cl.Aplicaciones,cl.Contactos FROM Personas p
				left join Clientes cl ON p.id=cl.PersonaId 
				WHERE p.id=@Id
				RETURN
			END


END 

go

CREATE PROCEDURE ImprimirQuery
	@Id int


AS BEGIN 

		SELECT q.Nombre,q.Observaciones,q.DetalleTecnico,q.Aplicaciones,per.Nombre PersonaCreadora FROM Querys q
		INNER JOIN Personas PER ON q.PersonaCreadoraId=per.Id
				WHERE q.Id=@Id 
END