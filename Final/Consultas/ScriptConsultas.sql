/* DESCRIPCION: CONSULTAS SOLICITADAS EN EVALUACION
*  NOMBRE: DULCE CAJAS
*  FECHA: 24/09/2020
*/

-- N°1 --> PUESTOS POR EMPRESA:
SELECT emp.Nombre Empresa , count (pue.PuestoID) totalPuestos
FROM DbEvaluacion.DBO.TblEmpresas emp
	JOIN DbEvaluacion.DBO.TblPuestos pue
		ON  emp.EmpresaID = pue.EmpresaID
GROUP BY emp.Nombre
ORDER BY emp.Nombre ;

-- N°2 --> MODIFICAR NOMBRE INCORRECTO DE EMPRESA 01:
UPDATE DbEvaluacion.DBO.TblEmpresas
SET Nombre ='Empresa De Evaluaciones'
WHERE EmpresaCodigo ='01';

-- N°3 --> PUESTOS ACTIVOS POR EMPRESA:
SELECT emp.Nombre Empresa , count (pue.PuestoID) totalPuestos
FROM DbEvaluacion.DBO.TblEmpresas emp
	JOIN DbEvaluacion.DBO.TblPuestos pue
		ON  emp.EmpresaID = pue.EmpresaID
			AND pue.FechaDeBaja is null
GROUP BY emp.Nombre
ORDER BY emp.Nombre ;


-- N°4 --> PUESTOS ACTIVOS POR EMPRESA:
SELECT 
	A.Empresa,
	--B.totalBaj,
	--A.totalPuestos,
	cast(cast(round(((B.totalBaj * 100)/a.totalPuestos),2) AS DECIMAL(18,2)) as varchar(100)) + ' %' Porcentaje_puestos_bajas
FROM(SELECT
	 emp.EmpresaCodigo,
	 emp.Nombre Empresa ,
	 count (pue.PuestoID) totalPuestos
	FROM DbEvaluacion.DBO.TblEmpresas emp
		JOIN DbEvaluacion.DBO.TblPuestos pue
			ON  emp.EmpresaID = pue.EmpresaID
	GROUP BY emp.EmpresaCodigo,emp.Nombre
)A
JOIN(SELECT
	 emp.EmpresaCodigo,
	 emp.Nombre Empresa ,
	 count (pue.PuestoID) totalBaj
	FROM DbEvaluacion.DBO.TblEmpresas emp
		JOIN DbEvaluacion.DBO.TblPuestos pue
			ON  emp.EmpresaID = pue.EmpresaID
				AND pue.FechaDeBaja is not null
	GROUP BY emp.EmpresaCodigo,emp.Nombre
)B ON A.EmpresaCodigo = B.EmpresaCodigo
ORDER BY A.Empresa;


