
CREATE TRIGGER tgiIncrementaEstoque 
ON itenscompra
FOR INSERT
AS
BEGIN
DECLARE @qtde float,
		@codigo integer
SELECT @codigo = pro_cod, @qtde = itc_qtde FROM INSERTED
UPDATE produto set pro_qtde= pro_qtde + @qtde
WHERE produto.pro_cod = @codigo
END
GO
------------------------------------------------------
CREATE TRIGGER tgiDecrementaEstoque 
ON itensvenda
FOR INSERT
AS
BEGIN
DECLARE @qtde float,
		@codigo integer
SELECT @codigo = pro_cod, @qtde = itv_qtde FROM INSERTED
UPDATE produto set pro_qtde = pro_qtde - @qtde
WHERE produto.pro_cod = @codigo
END
GO
------------------------------------------------------
CREATE TRIGGER tgiDecEstoquePorCompraCancelada 
ON itenscompra
FOR DELETE
AS
BEGIN
DECLARE @qtde float,
		@codigo integer
SELECT @codigo = pro_cod, @qtde =itc_qtde  FROM DELETED
UPDATE produto set pro_qtde = pro_qtde - @qtde
WHERE produto.pro_cod = @codigo
END
GO
-------------------------------------------------------
CREATE TRIGGER tgiIncEstoquePorVendaCancelada 
ON itensvenda
FOR DELETE
AS
BEGIN
DECLARE @qtde float,
		@codigo integer
SELECT @codigo = pro_cod, @qtde =itv_qtde  FROM DELETED
UPDATE produto set pro_qtde = pro_qtde + @qtde
WHERE produto.pro_cod = @codigo
END
GO
-------------------------------------------------------
--Não dá certo assim: --
CREATE TRIGGER compracancelada
ON itenscompra
FOR DELETE
AS 
BEGIN
	DECLARE @qtde float,
			@codigo integer
	DECLARE CURSOR_PRO cursor for

	SELECT @codigo = pro_cod, @qtde =itc_qtde FROM DELETED
	OPEN CURSOR_PRO
	FETCH NEXT FROM CURSOR_PRO INTO @codigo, @qtde
	WHILE @@FETCH_STATUS = 0
		BEGIN 
			UPDATE produto set pro_qtde = pro_qtde - @qtde
			WHERE produto.pro_cod = @codigo
			FETCH NEXT FROM CURSOR_PRO INTO @codigo, @qtde
		END
	CLOSE CURSOR_PRO
	DEALLOCATE CURSOR_PRO
END
GO
----------------------------------------------------------------

--Não dá certo assim: --
CREATE TRIGGER vendacancelada
ON itensvenda
FOR DELETE
AS 
BEGIN
	DECLARE @qtde float,
			@codigo integer
	DECLARE CURSOR_PRO cursor for

	SELECT @codigo = pro_cod, @qtde =itv_qtde FROM DELETED
	OPEN CURSOR_PRO
	FETCH NEXT FROM CURSOR_PRO INTO @codigo, @qtde
	WHILE @@FETCH_STATUS = 0
		BEGIN 
			UPDATE produto set pro_qtde = pro_qtde + @qtde
			WHERE produto.pro_cod = @codigo
			FETCH NEXT FROM CURSOR_PRO INTO @codigo, @qtde
		END
	CLOSE CURSOR_PRO
	DEALLOCATE CURSOR_PRO
END
GO
------------------------------------------------------------
use db_controledeestoque
select *from venda;
select *from itensvenda;
select *from parcelasvenda order by ven_cod, pve_cod;
select *from produto order by pro_cod;

SELECT count(com_cod) as qtde_parc FROM parcelascompra
WHERE pco_datapagto IS NULL AND 
pco_datavecto BETWEEN '2018-01-01' AND DATEADD(DAY, 1, CAST(getdate()as date))

SELECT count(ven_cod) as qtde_parc FROM parcelasvenda
WHERE pve_datapagto IS NULL AND 
pve_datavecto BETWEEN '2018-01-01' AND DATEADD(DAY, 1, CAST(getdate()as date))


select *from parcelascompra order by pco_datavecto;

--encontrar trigger no banco--
select * from dbo.sysobjects where type  = 'TR'

