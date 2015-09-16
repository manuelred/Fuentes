using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Reflection;
using System.Linq.Expressions;

namespace ExEngine_Client
{
	partial class LinqDBDataContext : System.Data.Linq.DataContext
	{
	#region "[Doc].[Documento_Del]"

	public class spType_TDoc_Documento_Del_Entrada
	{
		public System.Nullable<Int64> id  { get; set; }
	}
	public class spType_TDoc_Documento_Del_Salida_Vacia
	{
	}
	public class spType_TDoc_Documento_Del_Salida
	{
	}
	public IMultipleResults TDoc_Documento_Del_1(spType_TDoc_Documento_Del_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Documento_Del( ent.id);
		return resultados;
	}
	[Function(Name = "[Doc].[Documento_Del]")]
	[ResultType(typeof(spType_TDoc_Documento_Del_Salida_Vacia))]
	public IMultipleResults TDoc_Documento_Del(
				 [Parameter(Name = "id")] System.Nullable<Int64> id
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),id);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Documento_Lineas_Del]"

	public class spType_TDoc_Documento_Lineas_Del_Entrada
	{
		public System.Nullable<Int64> id  { get; set; }
	}
	public class spType_TDoc_Documento_Lineas_Del_Salida_Vacia
	{
	}
	public class spType_TDoc_Documento_Lineas_Del_Salida
	{
	}
	public IMultipleResults TDoc_Documento_Lineas_Del_1(spType_TDoc_Documento_Lineas_Del_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Documento_Lineas_Del( ent.id);
		return resultados;
	}
	[Function(Name = "[Doc].[Documento_Lineas_Del]")]
	[ResultType(typeof(spType_TDoc_Documento_Lineas_Del_Salida_Vacia))]
	public IMultipleResults TDoc_Documento_Lineas_Del(
				 [Parameter(Name = "id")] System.Nullable<Int64> id
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),id);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Documentos_Ins]"

	public class spType_TDoc_Documentos_Ins_Entrada
	{
		public System.Nullable<DateTime> FechaExpedicion  { get; set; }
		public System.Nullable<Int64> idAgente  { get; set; }
		public System.Nullable<Int64> idArea  { get; set; }
		public System.Nullable<Int64> idEjercicio  { get; set; }
		public System.Nullable<Int64> idEmisor  { get; set; }
		public System.Nullable<Int64> idReceptor  { get; set; }
		public System.Nullable<Int64> idSerie  { get; set; }
		public System.Nullable<Int64> idTipoDocumento  { get; set; }
	}
	public class spType_TDoc_Documentos_Ins_Salida_Id
	{
		public System.Nullable<Int64> id  { get; set; }
	}
	public class spType_TDoc_Documentos_Ins_Salida
	{
		public List<spType_TDoc_Documentos_Ins_Salida_Id> Id;
	}
	public IMultipleResults TDoc_Documentos_Ins_8(spType_TDoc_Documentos_Ins_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Documentos_Ins( ent.FechaExpedicion,ent.idAgente,ent.idArea,ent.idEjercicio,ent.idEmisor,ent.idReceptor,ent.idSerie,ent.idTipoDocumento);
		return resultados;
	}
	[Function(Name = "[Doc].[Documentos_Ins]")]
	[ResultType(typeof(spType_TDoc_Documentos_Ins_Salida_Id))]
	public IMultipleResults TDoc_Documentos_Ins(
				 [Parameter(Name = "FechaExpedicion")] System.Nullable<DateTime> FechaExpedicion
				,[Parameter(Name = "idAgente")] System.Nullable<Int64> idAgente
				,[Parameter(Name = "idArea")] System.Nullable<Int64> idArea
				,[Parameter(Name = "idEjercicio")] System.Nullable<Int64> idEjercicio
				,[Parameter(Name = "idEmisor")] System.Nullable<Int64> idEmisor
				,[Parameter(Name = "idReceptor")] System.Nullable<Int64> idReceptor
				,[Parameter(Name = "idSerie")] System.Nullable<Int64> idSerie
				,[Parameter(Name = "idTipoDocumento")] System.Nullable<Int64> idTipoDocumento
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),FechaExpedicion,idAgente,idArea,idEjercicio,idEmisor,idReceptor,idSerie,idTipoDocumento);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Documentos_Lineas_Actu]"

	public class spType_TDoc_Documentos_Lineas_Actu_Entrada
	{
		public String descripcion  { get; set; }
		public String dtoEscal  { get; set; }
		public System.Nullable<Decimal> dtoEur  { get; set; }
		public System.Nullable<Decimal> dtoTpc  { get; set; }
		public System.Nullable<Int64> id  { get; set; }
		public System.Nullable<Decimal> importe  { get; set; }
		public System.Nullable<Decimal> precio  { get; set; }
		public System.Nullable<Decimal> unidades  { get; set; }
	}
	public class spType_TDoc_Documentos_Lineas_Actu_Salida_Vacia
	{
	}
	public class spType_TDoc_Documentos_Lineas_Actu_Salida
	{
	}
	public IMultipleResults TDoc_Documentos_Lineas_Actu_8(spType_TDoc_Documentos_Lineas_Actu_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Documentos_Lineas_Actu( ent.descripcion,ent.dtoEscal,ent.dtoEur,ent.dtoTpc,ent.id,ent.importe,ent.precio,ent.unidades);
		return resultados;
	}
	[Function(Name = "[Doc].[Documentos_Lineas_Actu]")]
	[ResultType(typeof(spType_TDoc_Documentos_Lineas_Actu_Salida_Vacia))]
	public IMultipleResults TDoc_Documentos_Lineas_Actu(
				 [Parameter(Name = "descripcion")] String descripcion
				,[Parameter(Name = "dtoEscal")] String dtoEscal
				,[Parameter(Name = "dtoEur")] System.Nullable<Decimal> dtoEur
				,[Parameter(Name = "dtoTpc")] System.Nullable<Decimal> dtoTpc
				,[Parameter(Name = "id")] System.Nullable<Int64> id
				,[Parameter(Name = "importe")] System.Nullable<Decimal> importe
				,[Parameter(Name = "precio")] System.Nullable<Decimal> precio
				,[Parameter(Name = "unidades")] System.Nullable<Decimal> unidades
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),descripcion,dtoEscal,dtoEur,dtoTpc,id,importe,precio,unidades);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Documentos_Lineas_Costos_ViewAll]"

	public class spType_TDoc_Documentos_Lineas_Costos_ViewAll_Entrada
	{
		public System.Nullable<Int64> idListaDocsVal  { get; set; }
	}
	public class spType_TDoc_Documentos_Lineas_Costos_ViewAll_Salida_LineasPdtesVal
	{
		public System.Nullable<Decimal> cantidadTraz  { get; set; }
		public System.Nullable<Decimal> cantidadValor  { get; set; }
		public System.Nullable<Boolean> existenPosteriores  { get; set; }
		public System.Nullable<Boolean> existenSaldosPosteriores  { get; set; }
		public System.Nullable<Int64> idArticulo  { get; set; }
		public System.Nullable<Int64> idDocumento  { get; set; }
		public System.Nullable<Int64> idLinea  { get; set; }
		public System.Nullable<Int64> idTemp  { get; set; }
		public System.Nullable<Int64> idTipoControlCostos  { get; set; }
		public System.Nullable<Decimal> precio  { get; set; }
		public System.Nullable<Int16> tipo  { get; set; }
	}
	public class spType_TDoc_Documentos_Lineas_Costos_ViewAll_Salida
	{
		public List<spType_TDoc_Documentos_Lineas_Costos_ViewAll_Salida_LineasPdtesVal> LineasPdtesVal;
	}
	public IMultipleResults TDoc_Documentos_Lineas_Costos_ViewAll_1(spType_TDoc_Documentos_Lineas_Costos_ViewAll_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Documentos_Lineas_Costos_ViewAll( ent.idListaDocsVal);
		return resultados;
	}
	[Function(Name = "[Doc].[Documentos_Lineas_Costos_ViewAll]")]
	[ResultType(typeof(spType_TDoc_Documentos_Lineas_Costos_ViewAll_Salida_LineasPdtesVal))]
	public IMultipleResults TDoc_Documentos_Lineas_Costos_ViewAll(
				 [Parameter(Name = "idListaDocsVal")] System.Nullable<Int64> idListaDocsVal
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),idListaDocsVal);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Documentos_Lineas_CostosYaVal_ViewAll]"

	public class spType_TDoc_Documentos_Lineas_CostosYaVal_ViewAll_Entrada
	{
		public System.Nullable<Int64> idListaDocsVal  { get; set; }
	}
	public class spType_TDoc_Documentos_Lineas_CostosYaVal_ViewAll_Salida_LineasYaVal
	{
		public System.Nullable<Decimal> cantidadTraz  { get; set; }
		public System.Nullable<Decimal> cantidadValor  { get; set; }
		public System.Nullable<Boolean> existenPosteriores  { get; set; }
		public System.Nullable<Boolean> existenSaldosPosteriores  { get; set; }
		public System.Nullable<Int64> idArticulo  { get; set; }
		public System.Nullable<Int64> idCosto  { get; set; }
		public System.Nullable<Int64> idDocumento  { get; set; }
		public System.Nullable<Int64> idLinea  { get; set; }
		public System.Nullable<Int64> idTemp  { get; set; }
		public System.Nullable<Int64> idTipoControlCostos  { get; set; }
		public System.Nullable<Decimal> precio  { get; set; }
		public System.Nullable<Int16> tipo  { get; set; }
	}
	public class spType_TDoc_Documentos_Lineas_CostosYaVal_ViewAll_Salida
	{
		public List<spType_TDoc_Documentos_Lineas_CostosYaVal_ViewAll_Salida_LineasYaVal> LineasYaVal;
	}
	public IMultipleResults TDoc_Documentos_Lineas_CostosYaVal_ViewAll_1(spType_TDoc_Documentos_Lineas_CostosYaVal_ViewAll_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Documentos_Lineas_CostosYaVal_ViewAll( ent.idListaDocsVal);
		return resultados;
	}
	[Function(Name = "[Doc].[Documentos_Lineas_CostosYaVal_ViewAll]")]
	[ResultType(typeof(spType_TDoc_Documentos_Lineas_CostosYaVal_ViewAll_Salida_LineasYaVal))]
	public IMultipleResults TDoc_Documentos_Lineas_CostosYaVal_ViewAll(
				 [Parameter(Name = "idListaDocsVal")] System.Nullable<Int64> idListaDocsVal
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),idListaDocsVal);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Documentos_Lineas_Ins]"

	public class spType_TDoc_Documentos_Lineas_Ins_Entrada
	{
		public String descripcion  { get; set; }
		public String dtoEscal  { get; set; }
		public System.Nullable<Decimal> dtoEur  { get; set; }
		public System.Nullable<Decimal> dtoTpc  { get; set; }
		public System.Nullable<Int64> idArticulo  { get; set; }
		public System.Nullable<Int64> idDocumento  { get; set; }
		public System.Nullable<Decimal> importe  { get; set; }
		public System.Nullable<Decimal> precio  { get; set; }
		public System.Nullable<Decimal> unidades  { get; set; }
	}
	public class spType_TDoc_Documentos_Lineas_Ins_Salida_Id
	{
		public System.Nullable<Int64> id  { get; set; }
	}
	public class spType_TDoc_Documentos_Lineas_Ins_Salida
	{
		public List<spType_TDoc_Documentos_Lineas_Ins_Salida_Id> Id;
	}
	public IMultipleResults TDoc_Documentos_Lineas_Ins_9(spType_TDoc_Documentos_Lineas_Ins_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Documentos_Lineas_Ins( ent.descripcion,ent.dtoEscal,ent.dtoEur,ent.dtoTpc,ent.idArticulo,ent.idDocumento,ent.importe,ent.precio,ent.unidades);
		return resultados;
	}
	[Function(Name = "[Doc].[Documentos_Lineas_Ins]")]
	[ResultType(typeof(spType_TDoc_Documentos_Lineas_Ins_Salida_Id))]
	public IMultipleResults TDoc_Documentos_Lineas_Ins(
				 [Parameter(Name = "descripcion")] String descripcion
				,[Parameter(Name = "dtoEscal")] String dtoEscal
				,[Parameter(Name = "dtoEur")] System.Nullable<Decimal> dtoEur
				,[Parameter(Name = "dtoTpc")] System.Nullable<Decimal> dtoTpc
				,[Parameter(Name = "idArticulo")] System.Nullable<Int64> idArticulo
				,[Parameter(Name = "idDocumento")] System.Nullable<Int64> idDocumento
				,[Parameter(Name = "importe")] System.Nullable<Decimal> importe
				,[Parameter(Name = "precio")] System.Nullable<Decimal> precio
				,[Parameter(Name = "unidades")] System.Nullable<Decimal> unidades
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),descripcion,dtoEscal,dtoEur,dtoTpc,idArticulo,idDocumento,importe,precio,unidades);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Documentos_Seek]"

	public class spType_TDoc_Documentos_Seek_Entrada
	{
		public System.Nullable<Int64> Contador  { get; set; }
		public System.Nullable<DateTime> fechaExpDesde  { get; set; }
		public System.Nullable<DateTime> fechaExpHasta  { get; set; }
		public System.Nullable<Int64> idArea  { get; set; }
		public System.Nullable<Int64> idEjercicio  { get; set; }
		public System.Nullable<Int64> idEmisor  { get; set; }
		public System.Nullable<Int64> idEmpresa  { get; set; }
		public System.Nullable<Int64> idReceptor  { get; set; }
		public System.Nullable<Int64> idSerie  { get; set; }
		public System.Nullable<Int64> idSesion  { get; set; }
		public System.Nullable<Int64> idTipoDoc  { get; set; }
	}
	public class spType_TDoc_Documentos_Seek_Salida_Vacia
	{
	}
	public class spType_TDoc_Documentos_Seek_Salida
	{
	}
	public IMultipleResults TDoc_Documentos_Seek_11(spType_TDoc_Documentos_Seek_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Documentos_Seek( ent.Contador,ent.fechaExpDesde,ent.fechaExpHasta,ent.idArea,ent.idEjercicio,ent.idEmisor,ent.idEmpresa,ent.idReceptor,ent.idSerie,ent.idSesion,ent.idTipoDoc);
		return resultados;
	}
	[Function(Name = "[Doc].[Documentos_Seek]")]
	[ResultType(typeof(spType_TDoc_Documentos_Seek_Salida_Vacia))]
	public IMultipleResults TDoc_Documentos_Seek(
				 [Parameter(Name = "Contador")] System.Nullable<Int64> Contador
				,[Parameter(Name = "fechaExpDesde")] System.Nullable<DateTime> fechaExpDesde
				,[Parameter(Name = "fechaExpHasta")] System.Nullable<DateTime> fechaExpHasta
				,[Parameter(Name = "idArea")] System.Nullable<Int64> idArea
				,[Parameter(Name = "idEjercicio")] System.Nullable<Int64> idEjercicio
				,[Parameter(Name = "idEmisor")] System.Nullable<Int64> idEmisor
				,[Parameter(Name = "idEmpresa")] System.Nullable<Int64> idEmpresa
				,[Parameter(Name = "idReceptor")] System.Nullable<Int64> idReceptor
				,[Parameter(Name = "idSerie")] System.Nullable<Int64> idSerie
				,[Parameter(Name = "idSesion")] System.Nullable<Int64> idSesion
				,[Parameter(Name = "idTipoDoc")] System.Nullable<Int64> idTipoDoc
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),Contador,fechaExpDesde,fechaExpHasta,idArea,idEjercicio,idEmisor,idEmpresa,idReceptor,idSerie,idSesion,idTipoDoc);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Documentos_ValidarCostos]"

	public class spType_TDoc_Documentos_ValidarCostos_Entrada
	{
		public System.Nullable<Int64> idDoc  { get; set; }
		public System.Nullable<Int16> tipoVal  { get; set; }
	}
	public class spType_TDoc_Documentos_ValidarCostos_Salida_Vacia
	{
	}
	public class spType_TDoc_Documentos_ValidarCostos_Salida
	{
	}
	public IMultipleResults TDoc_Documentos_ValidarCostos_2(spType_TDoc_Documentos_ValidarCostos_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Documentos_ValidarCostos( ent.idDoc,ent.tipoVal);
		return resultados;
	}
	[Function(Name = "[Doc].[Documentos_ValidarCostos]")]
	[ResultType(typeof(spType_TDoc_Documentos_ValidarCostos_Salida_Vacia))]
	public IMultipleResults TDoc_Documentos_ValidarCostos(
				 [Parameter(Name = "idDoc")] System.Nullable<Int64> idDoc
				,[Parameter(Name = "tipoVal")] System.Nullable<Int16> tipoVal
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),idDoc,tipoVal);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Documentos_View]"

	public class spType_TDoc_Documentos_View_Entrada
	{
		public System.Nullable<Int64> idLista  { get; set; }
	}
	public class spType_TDoc_Documentos_View_Salida_Vacia
	{
	}
	public class spType_TDoc_Documentos_View_Salida
	{
	}
	public IMultipleResults TDoc_Documentos_View_1(spType_TDoc_Documentos_View_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Documentos_View( ent.idLista);
		return resultados;
	}
	[Function(Name = "[Doc].[Documentos_View]")]
	[ResultType(typeof(spType_TDoc_Documentos_View_Salida_Vacia))]
	public IMultipleResults TDoc_Documentos_View(
				 [Parameter(Name = "idLista")] System.Nullable<Int64> idLista
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),idLista);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Documentos_View1]"

	public class spType_TDoc_Documentos_View1_Entrada
	{
		public System.Nullable<Int64> id  { get; set; }
	}
	public class spType_TDoc_Documentos_View1_Salida_Cab
	{
		public System.Nullable<Int64> id  { get; set; }
		public System.Nullable<DateTime> FechaExpedicion  { get; set; }
		public String Documento  { get; set; }
		public String Contador  { get; set; }
		public String estado  { get; set; }
		public System.Nullable<Int64> idEjercicio  { get; set; }
		public System.Nullable<Int64> idEmisor  { get; set; }
		public String AliasEmisor  { get; set; }
		public String Emisor  { get; set; }
		public System.Nullable<Int64> idReceptor  { get; set; }
		public String AliasReceptor  { get; set; }
		public String Receptor  { get; set; }
		public System.Nullable<Int64> idAgente  { get; set; }
		public String AliasAgente  { get; set; }
		public String Agente  { get; set; }
		public System.Nullable<Int64> idSerie  { get; set; }
		public String Serie  { get; set; }
		public System.Nullable<Int64> idArea  { get; set; }
		public String Area  { get; set; }
		public System.Nullable<Int64> idTipoDocumento  { get; set; }
		public String TipoDoc_Descrip  { get; set; }
	}
	public class spType_TDoc_Documentos_View1_Salida_Lineas
	{
		public System.Nullable<Int64> id  { get; set; }
		public String descripcion  { get; set; }
		public System.Nullable<Decimal> unidades  { get; set; }
		public System.Nullable<Decimal> precio  { get; set; }
		public System.Nullable<Decimal> importe  { get; set; }
		public System.Nullable<Int64> idArticulo  { get; set; }
		public System.Nullable<Decimal> pverde  { get; set; }
		public System.Nullable<Decimal> dtoEur  { get; set; }
		public System.Nullable<Decimal> dtoTpc  { get; set; }
		public String dtoEscal  { get; set; }
		public System.Nullable<Int64> idImpuesto  { get; set; }
		public System.Nullable<Decimal> IVA  { get; set; }
		public System.Nullable<Decimal> RE  { get; set; }
		public System.Nullable<Boolean> UsaRecargo  { get; set; }
		public String descripArticulo  { get; set; }
	}
	public class spType_TDoc_Documentos_View1_Salida_EstadosHist
	{
		public System.Nullable<DateTime> instante  { get; set; }
		public System.Nullable<Int64> estado  { get; set; }
	}
	public class spType_TDoc_Documentos_View1_Salida
	{
		public List<spType_TDoc_Documentos_View1_Salida_Cab> Cab;
		public List<spType_TDoc_Documentos_View1_Salida_Lineas> Lineas;
		public List<spType_TDoc_Documentos_View1_Salida_EstadosHist> EstadosHist;
	}
	public IMultipleResults TDoc_Documentos_View1_1(spType_TDoc_Documentos_View1_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Documentos_View1( ent.id);
		return resultados;
	}
	[Function(Name = "[Doc].[Documentos_View1]")]
	[ResultType(typeof(spType_TDoc_Documentos_View1_Salida_Cab))]
	[ResultType(typeof(spType_TDoc_Documentos_View1_Salida_Lineas))]
	[ResultType(typeof(spType_TDoc_Documentos_View1_Salida_EstadosHist))]
	public IMultipleResults TDoc_Documentos_View1(
				 [Parameter(Name = "id")] System.Nullable<Int64> id
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),id);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[DocuPedi_Ins]"

	public class spType_TDoc_DocuPedi_Ins_Entrada
	{
		public String dtoCab  { get; set; }
		public System.Nullable<Int32> estado  { get; set; }
		public System.Nullable<DateTime> fechaDoc  { get; set; }
		public System.Nullable<DateTime> fechaServir  { get; set; }
		public Byte[] firma  { get; set; }
		public System.Nullable<Int64> idAgente  { get; set; }
		public System.Nullable<Int64> idAlmacen  { get; set; }
		public System.Nullable<Int64> idArea  { get; set; }
		public System.Nullable<Int64> idDelegacion  { get; set; }
		public System.Nullable<Int64> idEjercicio  { get; set; }
		public System.Nullable<Int64> idFormaPago  { get; set; }
		public System.Nullable<Int64> idRuta  { get; set; }
		public System.Nullable<Int64> idSerie  { get; set; }
		public System.Nullable<Int64> idSesionReparto  { get; set; }
		public System.Nullable<Int64> idTipoDocumento  { get; set; }
		public System.Nullable<Int64> idUsuario  { get; set; }
		public System.Nullable<Boolean> reserva  { get; set; }
	}
	public class spType_TDoc_DocuPedi_Ins_Salida_Vacia
	{
	}
	public class spType_TDoc_DocuPedi_Ins_Salida
	{
	}
	public IMultipleResults TDoc_DocuPedi_Ins_17(spType_TDoc_DocuPedi_Ins_Entrada ent)
	{
		IMultipleResults resultados = TDoc_DocuPedi_Ins( ent.dtoCab,ent.estado,ent.fechaDoc,ent.fechaServir,ent.firma,ent.idAgente,ent.idAlmacen,ent.idArea,ent.idDelegacion,ent.idEjercicio,ent.idFormaPago,ent.idRuta,ent.idSerie,ent.idSesionReparto,ent.idTipoDocumento,ent.idUsuario,ent.reserva);
		return resultados;
	}
	[Function(Name = "[Doc].[DocuPedi_Ins]")]
	[ResultType(typeof(spType_TDoc_DocuPedi_Ins_Salida_Vacia))]
	public IMultipleResults TDoc_DocuPedi_Ins(
				 [Parameter(Name = "dtoCab")] String dtoCab
				,[Parameter(Name = "estado")] System.Nullable<Int32> estado
				,[Parameter(Name = "fechaDoc")] System.Nullable<DateTime> fechaDoc
				,[Parameter(Name = "fechaServir")] System.Nullable<DateTime> fechaServir
				,[Parameter(Name = "firma")] Byte[] firma
				,[Parameter(Name = "idAgente")] System.Nullable<Int64> idAgente
				,[Parameter(Name = "idAlmacen")] System.Nullable<Int64> idAlmacen
				,[Parameter(Name = "idArea")] System.Nullable<Int64> idArea
				,[Parameter(Name = "idDelegacion")] System.Nullable<Int64> idDelegacion
				,[Parameter(Name = "idEjercicio")] System.Nullable<Int64> idEjercicio
				,[Parameter(Name = "idFormaPago")] System.Nullable<Int64> idFormaPago
				,[Parameter(Name = "idRuta")] System.Nullable<Int64> idRuta
				,[Parameter(Name = "idSerie")] System.Nullable<Int64> idSerie
				,[Parameter(Name = "idSesionReparto")] System.Nullable<Int64> idSesionReparto
				,[Parameter(Name = "idTipoDocumento")] System.Nullable<Int64> idTipoDocumento
				,[Parameter(Name = "idUsuario")] System.Nullable<Int64> idUsuario
				,[Parameter(Name = "reserva")] System.Nullable<Boolean> reserva
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),dtoCab,estado,fechaDoc,fechaServir,firma,idAgente,idAlmacen,idArea,idDelegacion,idEjercicio,idFormaPago,idRuta,idSerie,idSesionReparto,idTipoDocumento,idUsuario,reserva);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[DocuPedi_View1]"

	public class spType_TDoc_DocuPedi_View1_Entrada
	{
		public System.Nullable<Int64> id  { get; set; }
	}
	public class spType_TDoc_DocuPedi_View1_Salida_tb0
	{
		public System.Nullable<Int64> idDocu  { get; set; }
		public String strEjercicio  { get; set; }
		public String strSerie  { get; set; }
		public String strTipoDoc  { get; set; }
		public String DescrTipoDoc  { get; set; }
		public String strArea  { get; set; }
		public System.Nullable<Int64> Contador  { get; set; }
		public String EstadoCab  { get; set; }
		public String DescipcionAlmacen  { get; set; }
		public System.Nullable<DateTime> FechaDocumento  { get; set; }
		public System.Nullable<DateTime> FechaIntroduccion  { get; set; }
		public String TipoTributo  { get; set; }
		public System.Nullable<DateTime> fechaServir  { get; set; }
		public String dtoCab  { get; set; }
		public String FormaPago  { get; set; }
		public System.Nullable<Boolean> reserva  { get; set; }
		public String CodAgente  { get; set; }
		public String Agente  { get; set; }
		public String nombreDelegacion  { get; set; }
		public String AliasClieProv  { get; set; }
		public String NombreClieProv  { get; set; }
		public String nombreFiscal  { get; set; }
	}
	public class spType_TDoc_DocuPedi_View1_Salida_tb1
	{
		public System.Nullable<Int64> idLinea  { get; set; }
		public System.Nullable<Int64> idLinEnDocu  { get; set; }
		public String EstadoLin  { get; set; }
		public String ArtiAlias  { get; set; }
		public String ArtiDescripcionCorta  { get; set; }
		public String ArtiDescripcion  { get; set; }
		public String CodAlternativo  { get; set; }
		public String CantIntrodTrazable_Nomen  { get; set; }
		public String CantIntrodValorable_Nomen  { get; set; }
		public String CantTrazable_Nomen  { get; set; }
		public String CantValorable_Nomen  { get; set; }
		public System.Nullable<Decimal> precio  { get; set; }
		public String DtoStr  { get; set; }
		public System.Nullable<Decimal> ImporteLinea  { get; set; }
		public System.Nullable<DateTime> FechaServirRecibir  { get; set; }
		public System.Nullable<DateTime> FechaIntroduccion  { get; set; }
		public System.Nullable<Boolean> EsRegalo  { get; set; }
		public System.Nullable<Int32> idGrupoRegalo  { get; set; }
		public String DescripcionRegalo  { get; set; }
		public System.Nullable<Boolean> esEnvase  { get; set; }
		public System.Nullable<Int32> idGrupoEnvase  { get; set; }
		public String DescripcionEnvase  { get; set; }
	}
	public class spType_TDoc_DocuPedi_View1_Salida
	{
		public List<spType_TDoc_DocuPedi_View1_Salida_tb0> tb0;
		public List<spType_TDoc_DocuPedi_View1_Salida_tb1> tb1;
	}
	public IMultipleResults TDoc_DocuPedi_View1_1(spType_TDoc_DocuPedi_View1_Entrada ent)
	{
		IMultipleResults resultados = TDoc_DocuPedi_View1( ent.id);
		return resultados;
	}
	[Function(Name = "[Doc].[DocuPedi_View1]")]
	[ResultType(typeof(spType_TDoc_DocuPedi_View1_Salida_tb0))]
	[ResultType(typeof(spType_TDoc_DocuPedi_View1_Salida_tb1))]
	public IMultipleResults TDoc_DocuPedi_View1(
				 [Parameter(Name = "id")] System.Nullable<Int64> id
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),id);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[DocuPediTotal_View1]"

	public class spType_TDoc_DocuPediTotal_View1_Entrada
	{
		public System.Nullable<Int64> id  { get; set; }
	}
	public class spType_TDoc_DocuPediTotal_View1_Salida_tb0
	{
		public System.Nullable<Int64> idDocu  { get; set; }
		public System.Nullable<Int64> idEjercicio  { get; set; }
		public String strEjercicio  { get; set; }
		public System.Nullable<Int64> idSerie  { get; set; }
		public String strSerie  { get; set; }
		public System.Nullable<Int64> idTipoDocumento  { get; set; }
		public String strTipoDoc  { get; set; }
		public String DescrTipoDoc  { get; set; }
		public System.Nullable<Int64> idArea  { get; set; }
		public String strArea  { get; set; }
		public System.Nullable<Int64> Contador  { get; set; }
		public String EstadoCab  { get; set; }
		public System.Nullable<Int64> idAlmacen  { get; set; }
		public String DescipcionAlmacen  { get; set; }
		public System.Nullable<DateTime> FechaDocumento  { get; set; }
		public System.Nullable<DateTime> FechaIntroduccion  { get; set; }
		public System.Nullable<DateTime> fechaServir  { get; set; }
		public System.Nullable<Int32> idCV  { get; set; }
		public String dtoCab  { get; set; }
		public System.Nullable<Boolean> reserva  { get; set; }
		public System.Nullable<Int64> idAgente  { get; set; }
		public String CodAgente  { get; set; }
		public String Agente  { get; set; }
		public System.Nullable<Int64> idImpuestosGruposCtasCom  { get; set; }
		public String codigoImpuestosGruposCtasCom  { get; set; }
		public System.Nullable<Boolean> seccion  { get; set; }
		public System.Nullable<Int32> idFormaPago  { get; set; }
		public String DescripFormaPago  { get; set; }
		public String FormaPago  { get; set; }
		public System.Nullable<Int32> idInstrumento  { get; set; }
		public String DescripInstrumento  { get; set; }
		public System.Nullable<Int64> idDelegacion  { get; set; }
		public String nombreDelegacion  { get; set; }
		public System.Nullable<Int64> idCP  { get; set; }
		public System.Nullable<Int64> idTipoVia  { get; set; }
		public String nombreVia  { get; set; }
		public String imparInferior  { get; set; }
		public String imparSuperior  { get; set; }
		public String parInferior  { get; set; }
		public String parSuperior  { get; set; }
		public String cp  { get; set; }
		public System.Nullable<Int64> idPais  { get; set; }
		public System.Nullable<Int64> idRegion1  { get; set; }
		public System.Nullable<Int64> idRegion2  { get; set; }
		public System.Nullable<Int64> idRegion3  { get; set; }
		public System.Nullable<Int64> idRegion4  { get; set; }
		public String TipoVia_codigo  { get; set; }
		public String TipoVia_nombre  { get; set; }
		public String R1_nombre  { get; set; }
		public String R2_nombre  { get; set; }
		public String R3_nombre  { get; set; }
		public String R4_nombre  { get; set; }
		public String Pais_nombre  { get; set; }
		public String AliasClieProv  { get; set; }
		public String NombreClieProv  { get; set; }
		public String nombreFiscal  { get; set; }
	}
	public class spType_TDoc_DocuPediTotal_View1_Salida_tb1
	{
		public System.Nullable<Int64> idLinea  { get; set; }
		public System.Nullable<Int64> idLinEnDocu  { get; set; }
		public String EstadoLin  { get; set; }
		public String CantIntrodTrazable  { get; set; }
		public String CantIntrodTrazable_Nomen  { get; set; }
		public String CantIntrodValorable  { get; set; }
		public String CantIntrodValorable_Nomen  { get; set; }
		public String CantTrazable  { get; set; }
		public String CantTrazable_Nomen  { get; set; }
		public String CantValorable  { get; set; }
		public String CantValorable_Nomen  { get; set; }
		public System.Nullable<Decimal> precio  { get; set; }
		public String DtoStr  { get; set; }
		public System.Nullable<Decimal> ImporteLinea  { get; set; }
		public System.Nullable<DateTime> FechaServirRecibir  { get; set; }
		public System.Nullable<DateTime> FechaIntroduccion  { get; set; }
		public System.Nullable<Int64> ArtiId  { get; set; }
		public String ArtiAlias  { get; set; }
		public String ArtiDescripcionCorta  { get; set; }
		public String ArtiDescripcion  { get; set; }
		public String CodAlternativo  { get; set; }
		public System.Nullable<Int64> idProvHabitual  { get; set; }
		public System.Nullable<Boolean> EsRegalo  { get; set; }
		public System.Nullable<Int32> idGrupoRegalo  { get; set; }
		public String DescripcionRegalo  { get; set; }
		public System.Nullable<Boolean> esEnvase  { get; set; }
		public System.Nullable<Int32> idGrupoEnvase  { get; set; }
		public String DescripcionEnvase  { get; set; }
	}
	public class spType_TDoc_DocuPediTotal_View1_Salida
	{
		public List<spType_TDoc_DocuPediTotal_View1_Salida_tb0> tb0;
		public List<spType_TDoc_DocuPediTotal_View1_Salida_tb1> tb1;
	}
	public IMultipleResults TDoc_DocuPediTotal_View1_1(spType_TDoc_DocuPediTotal_View1_Entrada ent)
	{
		IMultipleResults resultados = TDoc_DocuPediTotal_View1( ent.id);
		return resultados;
	}
	[Function(Name = "[Doc].[DocuPediTotal_View1]")]
	[ResultType(typeof(spType_TDoc_DocuPediTotal_View1_Salida_tb0))]
	[ResultType(typeof(spType_TDoc_DocuPediTotal_View1_Salida_tb1))]
	public IMultipleResults TDoc_DocuPediTotal_View1(
				 [Parameter(Name = "id")] System.Nullable<Int64> id
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),id);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Linea_Tipo_Actu]"

	public class spType_TDoc_Linea_Tipo_Actu_Entrada
	{
		public String descripcion  { get; set; }
		public System.Nullable<Int16> id  { get; set; }
	}
	public class spType_TDoc_Linea_Tipo_Actu_Salida_Vacia
	{
	}
	public class spType_TDoc_Linea_Tipo_Actu_Salida
	{
	}
	public IMultipleResults TDoc_Linea_Tipo_Actu_2(spType_TDoc_Linea_Tipo_Actu_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Linea_Tipo_Actu( ent.descripcion,ent.id);
		return resultados;
	}
	[Function(Name = "[Doc].[Linea_Tipo_Actu]")]
	[ResultType(typeof(spType_TDoc_Linea_Tipo_Actu_Salida_Vacia))]
	public IMultipleResults TDoc_Linea_Tipo_Actu(
				 [Parameter(Name = "descripcion")] String descripcion
				,[Parameter(Name = "id")] System.Nullable<Int16> id
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),descripcion,id);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Linea_Tipo_Del]"

	public class spType_TDoc_Linea_Tipo_Del_Entrada
	{
		public System.Nullable<Int16> id  { get; set; }
	}
	public class spType_TDoc_Linea_Tipo_Del_Salida_Vacia
	{
	}
	public class spType_TDoc_Linea_Tipo_Del_Salida
	{
	}
	public IMultipleResults TDoc_Linea_Tipo_Del_1(spType_TDoc_Linea_Tipo_Del_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Linea_Tipo_Del( ent.id);
		return resultados;
	}
	[Function(Name = "[Doc].[Linea_Tipo_Del]")]
	[ResultType(typeof(spType_TDoc_Linea_Tipo_Del_Salida_Vacia))]
	public IMultipleResults TDoc_Linea_Tipo_Del(
				 [Parameter(Name = "id")] System.Nullable<Int16> id
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),id);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Linea_Tipo_Ins]"

	public class spType_TDoc_Linea_Tipo_Ins_Entrada
	{
		public String descripcion  { get; set; }
		public System.Nullable<Int64> idTipoDoc  { get; set; }
	}
	public class spType_TDoc_Linea_Tipo_Ins_Salida_Vacia
	{
	}
	public class spType_TDoc_Linea_Tipo_Ins_Salida
	{
	}
	public IMultipleResults TDoc_Linea_Tipo_Ins_2(spType_TDoc_Linea_Tipo_Ins_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Linea_Tipo_Ins( ent.descripcion,ent.idTipoDoc);
		return resultados;
	}
	[Function(Name = "[Doc].[Linea_Tipo_Ins]")]
	[ResultType(typeof(spType_TDoc_Linea_Tipo_Ins_Salida_Vacia))]
	public IMultipleResults TDoc_Linea_Tipo_Ins(
				 [Parameter(Name = "descripcion")] String descripcion
				,[Parameter(Name = "idTipoDoc")] System.Nullable<Int64> idTipoDoc
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),descripcion,idTipoDoc);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Linea_Tipo_Seek]"

	public class spType_TDoc_Linea_Tipo_Seek_Entrada
	{
		public String descripcion  { get; set; }
		public System.Nullable<Int64> idSesion  { get; set; }
		public System.Nullable<Int64> idTipoDoc  { get; set; }
	}
	public class spType_TDoc_Linea_Tipo_Seek_Salida_Vacia
	{
	}
	public class spType_TDoc_Linea_Tipo_Seek_Salida
	{
	}
	public IMultipleResults TDoc_Linea_Tipo_Seek_3(spType_TDoc_Linea_Tipo_Seek_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Linea_Tipo_Seek( ent.descripcion,ent.idSesion,ent.idTipoDoc);
		return resultados;
	}
	[Function(Name = "[Doc].[Linea_Tipo_Seek]")]
	[ResultType(typeof(spType_TDoc_Linea_Tipo_Seek_Salida_Vacia))]
	public IMultipleResults TDoc_Linea_Tipo_Seek(
				 [Parameter(Name = "descripcion")] String descripcion
				,[Parameter(Name = "idSesion")] System.Nullable<Int64> idSesion
				,[Parameter(Name = "idTipoDoc")] System.Nullable<Int64> idTipoDoc
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),descripcion,idSesion,idTipoDoc);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Linea_Tipo_Seek_Combo]"

	public class spType_TDoc_Linea_Tipo_Seek_Combo_Entrada
	{
		public System.Nullable<Int64> idSesion  { get; set; }
		public System.Nullable<Int64> idTipoDoc  { get; set; }
		public String PRIMARY  { get; set; }
	}
	public class spType_TDoc_Linea_Tipo_Seek_Combo_Salida_Vacia
	{
	}
	public class spType_TDoc_Linea_Tipo_Seek_Combo_Salida
	{
	}
	public IMultipleResults TDoc_Linea_Tipo_Seek_Combo_3(spType_TDoc_Linea_Tipo_Seek_Combo_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Linea_Tipo_Seek_Combo( ent.idSesion,ent.idTipoDoc,ent.PRIMARY);
		return resultados;
	}
	[Function(Name = "[Doc].[Linea_Tipo_Seek_Combo]")]
	[ResultType(typeof(spType_TDoc_Linea_Tipo_Seek_Combo_Salida_Vacia))]
	public IMultipleResults TDoc_Linea_Tipo_Seek_Combo(
				 [Parameter(Name = "idSesion")] System.Nullable<Int64> idSesion
				,[Parameter(Name = "idTipoDoc")] System.Nullable<Int64> idTipoDoc
				,[Parameter(Name = "PRIMARY")] String PRIMARY
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),idSesion,idTipoDoc,PRIMARY);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Linea_Tipo_View]"

	public class spType_TDoc_Linea_Tipo_View_Entrada
	{
		public System.Nullable<Int64> idLista  { get; set; }
	}
	public class spType_TDoc_Linea_Tipo_View_Salida_Vacia
	{
	}
	public class spType_TDoc_Linea_Tipo_View_Salida
	{
	}
	public IMultipleResults TDoc_Linea_Tipo_View_1(spType_TDoc_Linea_Tipo_View_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Linea_Tipo_View( ent.idLista);
		return resultados;
	}
	[Function(Name = "[Doc].[Linea_Tipo_View]")]
	[ResultType(typeof(spType_TDoc_Linea_Tipo_View_Salida_Vacia))]
	public IMultipleResults TDoc_Linea_Tipo_View(
				 [Parameter(Name = "idLista")] System.Nullable<Int64> idLista
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),idLista);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Linea_Tipo_View_Combo]"

	public class spType_TDoc_Linea_Tipo_View_Combo_Entrada
	{
		public System.Nullable<Int64> idLista  { get; set; }
	}
	public class spType_TDoc_Linea_Tipo_View_Combo_Salida_Vacia
	{
	}
	public class spType_TDoc_Linea_Tipo_View_Combo_Salida
	{
	}
	public IMultipleResults TDoc_Linea_Tipo_View_Combo_1(spType_TDoc_Linea_Tipo_View_Combo_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Linea_Tipo_View_Combo( ent.idLista);
		return resultados;
	}
	[Function(Name = "[Doc].[Linea_Tipo_View_Combo]")]
	[ResultType(typeof(spType_TDoc_Linea_Tipo_View_Combo_Salida_Vacia))]
	public IMultipleResults TDoc_Linea_Tipo_View_Combo(
				 [Parameter(Name = "idLista")] System.Nullable<Int64> idLista
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),idLista);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Linea_Tipo_View1]"

	public class spType_TDoc_Linea_Tipo_View1_Entrada
	{
		public System.Nullable<Int16> id  { get; set; }
	}
	public class spType_TDoc_Linea_Tipo_View1_Salida_Datos
	{
		public String codTipoDoc  { get; set; }
		public String descripcion  { get; set; }
		public System.Nullable<Int64> idTipoDoc  { get; set; }
		public String TipoDoc  { get; set; }
	}
	public class spType_TDoc_Linea_Tipo_View1_Salida
	{
		public List<spType_TDoc_Linea_Tipo_View1_Salida_Datos> Datos;
	}
	public IMultipleResults TDoc_Linea_Tipo_View1_1(spType_TDoc_Linea_Tipo_View1_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Linea_Tipo_View1( ent.id);
		return resultados;
	}
	[Function(Name = "[Doc].[Linea_Tipo_View1]")]
	[ResultType(typeof(spType_TDoc_Linea_Tipo_View1_Salida_Datos))]
	public IMultipleResults TDoc_Linea_Tipo_View1(
				 [Parameter(Name = "id")] System.Nullable<Int16> id
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),id);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Plantilla_Lineas_Actu]"

	public class spType_TDoc_Plantilla_Lineas_Actu_Entrada
	{
		public System.Nullable<Boolean> datoMinimo  { get; set; }
		public System.Nullable<Boolean> editableAlta  { get; set; }
		public System.Nullable<Boolean> editableEdicion  { get; set; }
		public System.Nullable<Boolean> hayDefecto  { get; set; }
		public System.Nullable<Int32> id  { get; set; }
		public System.Nullable<Boolean> valorDef_Bit  { get; set; }
		public System.Nullable<DateTime> valorDef_Fecha  { get; set; }
		public System.Nullable<Int16> valorDef_Int16  { get; set; }
		public System.Nullable<Int32> valorDef_Int32  { get; set; }
		public System.Nullable<Int64> valorDef_Int64  { get; set; }
		public String valorDef_String  { get; set; }
	}
	public class spType_TDoc_Plantilla_Lineas_Actu_Salida_Vacia
	{
	}
	public class spType_TDoc_Plantilla_Lineas_Actu_Salida
	{
	}
	public IMultipleResults TDoc_Plantilla_Lineas_Actu_11(spType_TDoc_Plantilla_Lineas_Actu_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Plantilla_Lineas_Actu( ent.datoMinimo,ent.editableAlta,ent.editableEdicion,ent.hayDefecto,ent.id,ent.valorDef_Bit,ent.valorDef_Fecha,ent.valorDef_Int16,ent.valorDef_Int32,ent.valorDef_Int64,ent.valorDef_String);
		return resultados;
	}
	[Function(Name = "[Doc].[Plantilla_Lineas_Actu]")]
	[ResultType(typeof(spType_TDoc_Plantilla_Lineas_Actu_Salida_Vacia))]
	public IMultipleResults TDoc_Plantilla_Lineas_Actu(
				 [Parameter(Name = "datoMinimo")] System.Nullable<Boolean> datoMinimo
				,[Parameter(Name = "editableAlta")] System.Nullable<Boolean> editableAlta
				,[Parameter(Name = "editableEdicion")] System.Nullable<Boolean> editableEdicion
				,[Parameter(Name = "hayDefecto")] System.Nullable<Boolean> hayDefecto
				,[Parameter(Name = "id")] System.Nullable<Int32> id
				,[Parameter(Name = "valorDef_Bit")] System.Nullable<Boolean> valorDef_Bit
				,[Parameter(Name = "valorDef_Fecha")] System.Nullable<DateTime> valorDef_Fecha
				,[Parameter(Name = "valorDef_Int16")] System.Nullable<Int16> valorDef_Int16
				,[Parameter(Name = "valorDef_Int32")] System.Nullable<Int32> valorDef_Int32
				,[Parameter(Name = "valorDef_Int64")] System.Nullable<Int64> valorDef_Int64
				,[Parameter(Name = "valorDef_String")] String valorDef_String
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),datoMinimo,editableAlta,editableEdicion,hayDefecto,id,valorDef_Bit,valorDef_Fecha,valorDef_Int16,valorDef_Int32,valorDef_Int64,valorDef_String);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Plantilla_Lineas_View1]"

	public class spType_TDoc_Plantilla_Lineas_View1_Entrada
	{
		public System.Nullable<Int32> id  { get; set; }
	}
	public class spType_TDoc_Plantilla_Lineas_View1_Salida_Datos
	{
		public String campo  { get; set; }
		public System.Nullable<Boolean> datoMinimo  { get; set; }
		public System.Nullable<Boolean> editableAlta  { get; set; }
		public System.Nullable<Boolean> editableEdicion  { get; set; }
		public System.Nullable<Boolean> hayDefecto  { get; set; }
		public System.Nullable<Int32> idCampo  { get; set; }
		public System.Nullable<Int32> idPlantilla  { get; set; }
		public String Plantilla  { get; set; }
		public System.Nullable<Int16> tipo  { get; set; }
		public System.Nullable<Boolean> valorDef_Bit  { get; set; }
		public System.Nullable<DateTime> valorDef_Fecha  { get; set; }
		public System.Nullable<Int16> valorDef_Int16  { get; set; }
		public System.Nullable<Int32> valorDef_Int32  { get; set; }
		public System.Nullable<Int64> valorDef_Int64  { get; set; }
		public String valorDef_String  { get; set; }
	}
	public class spType_TDoc_Plantilla_Lineas_View1_Salida
	{
		public List<spType_TDoc_Plantilla_Lineas_View1_Salida_Datos> Datos;
	}
	public IMultipleResults TDoc_Plantilla_Lineas_View1_1(spType_TDoc_Plantilla_Lineas_View1_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Plantilla_Lineas_View1( ent.id);
		return resultados;
	}
	[Function(Name = "[Doc].[Plantilla_Lineas_View1]")]
	[ResultType(typeof(spType_TDoc_Plantilla_Lineas_View1_Salida_Datos))]
	public IMultipleResults TDoc_Plantilla_Lineas_View1(
				 [Parameter(Name = "id")] System.Nullable<Int32> id
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),id);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Plantillas_Actu]"

	public class spType_TDoc_Plantillas_Actu_Entrada
	{
		public String descripcion  { get; set; }
		public System.Nullable<Int32> id  { get; set; }
	}
	public class spType_TDoc_Plantillas_Actu_Salida_Vacia
	{
	}
	public class spType_TDoc_Plantillas_Actu_Salida
	{
	}
	public IMultipleResults TDoc_Plantillas_Actu_2(spType_TDoc_Plantillas_Actu_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Plantillas_Actu( ent.descripcion,ent.id);
		return resultados;
	}
	[Function(Name = "[Doc].[Plantillas_Actu]")]
	[ResultType(typeof(spType_TDoc_Plantillas_Actu_Salida_Vacia))]
	public IMultipleResults TDoc_Plantillas_Actu(
				 [Parameter(Name = "descripcion")] String descripcion
				,[Parameter(Name = "id")] System.Nullable<Int32> id
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),descripcion,id);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Plantillas_Del]"

	public class spType_TDoc_Plantillas_Del_Entrada
	{
		public System.Nullable<Int64> id  { get; set; }
	}
	public class spType_TDoc_Plantillas_Del_Salida_Vacia
	{
	}
	public class spType_TDoc_Plantillas_Del_Salida
	{
	}
	public IMultipleResults TDoc_Plantillas_Del_1(spType_TDoc_Plantillas_Del_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Plantillas_Del( ent.id);
		return resultados;
	}
	[Function(Name = "[Doc].[Plantillas_Del]")]
	[ResultType(typeof(spType_TDoc_Plantillas_Del_Salida_Vacia))]
	public IMultipleResults TDoc_Plantillas_Del(
				 [Parameter(Name = "id")] System.Nullable<Int64> id
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),id);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Plantillas_Ins]"

	public class spType_TDoc_Plantillas_Ins_Entrada
	{
		public String descripcion  { get; set; }
		public System.Nullable<Int64> idTipoDoc  { get; set; }
	}
	public class spType_TDoc_Plantillas_Ins_Salida_Vacia
	{
	}
	public class spType_TDoc_Plantillas_Ins_Salida
	{
	}
	public IMultipleResults TDoc_Plantillas_Ins_2(spType_TDoc_Plantillas_Ins_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Plantillas_Ins( ent.descripcion,ent.idTipoDoc);
		return resultados;
	}
	[Function(Name = "[Doc].[Plantillas_Ins]")]
	[ResultType(typeof(spType_TDoc_Plantillas_Ins_Salida_Vacia))]
	public IMultipleResults TDoc_Plantillas_Ins(
				 [Parameter(Name = "descripcion")] String descripcion
				,[Parameter(Name = "idTipoDoc")] System.Nullable<Int64> idTipoDoc
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),descripcion,idTipoDoc);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Plantillas_Lineas_ViewAll]"

	public class spType_TDoc_Plantillas_Lineas_ViewAll_Entrada
	{
		public System.Nullable<Int32> idPlantilla  { get; set; }
	}
	public class spType_TDoc_Plantillas_Lineas_ViewAll_Salida_Lineas
	{
		public String campo  { get; set; }
		public System.Nullable<Boolean> datoMinimo  { get; set; }
		public System.Nullable<Boolean> editableAlta  { get; set; }
		public System.Nullable<Boolean> editableEdicion  { get; set; }
		public System.Nullable<Int32> id  { get; set; }
		public String valorDefecto  { get; set; }
	}
	public class spType_TDoc_Plantillas_Lineas_ViewAll_Salida
	{
		public List<spType_TDoc_Plantillas_Lineas_ViewAll_Salida_Lineas> Lineas;
	}
	public IMultipleResults TDoc_Plantillas_Lineas_ViewAll_1(spType_TDoc_Plantillas_Lineas_ViewAll_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Plantillas_Lineas_ViewAll( ent.idPlantilla);
		return resultados;
	}
	[Function(Name = "[Doc].[Plantillas_Lineas_ViewAll]")]
	[ResultType(typeof(spType_TDoc_Plantillas_Lineas_ViewAll_Salida_Lineas))]
	public IMultipleResults TDoc_Plantillas_Lineas_ViewAll(
				 [Parameter(Name = "idPlantilla")] System.Nullable<Int32> idPlantilla
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),idPlantilla);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Plantillas_Seek]"

	public class spType_TDoc_Plantillas_Seek_Entrada
	{
		public String descripcion  { get; set; }
		public System.Nullable<Int64> idGrupoDoc  { get; set; }
		public System.Nullable<Int64> idSesion  { get; set; }
		public System.Nullable<Int64> idTipoDoc  { get; set; }
	}
	public class spType_TDoc_Plantillas_Seek_Salida_Vacia
	{
	}
	public class spType_TDoc_Plantillas_Seek_Salida
	{
	}
	public IMultipleResults TDoc_Plantillas_Seek_4(spType_TDoc_Plantillas_Seek_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Plantillas_Seek( ent.descripcion,ent.idGrupoDoc,ent.idSesion,ent.idTipoDoc);
		return resultados;
	}
	[Function(Name = "[Doc].[Plantillas_Seek]")]
	[ResultType(typeof(spType_TDoc_Plantillas_Seek_Salida_Vacia))]
	public IMultipleResults TDoc_Plantillas_Seek(
				 [Parameter(Name = "descripcion")] String descripcion
				,[Parameter(Name = "idGrupoDoc")] System.Nullable<Int64> idGrupoDoc
				,[Parameter(Name = "idSesion")] System.Nullable<Int64> idSesion
				,[Parameter(Name = "idTipoDoc")] System.Nullable<Int64> idTipoDoc
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),descripcion,idGrupoDoc,idSesion,idTipoDoc);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Plantillas_View]"

	public class spType_TDoc_Plantillas_View_Entrada
	{
		public System.Nullable<Int64> idLista  { get; set; }
	}
	public class spType_TDoc_Plantillas_View_Salida_Vacia
	{
	}
	public class spType_TDoc_Plantillas_View_Salida
	{
	}
	public IMultipleResults TDoc_Plantillas_View_1(spType_TDoc_Plantillas_View_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Plantillas_View( ent.idLista);
		return resultados;
	}
	[Function(Name = "[Doc].[Plantillas_View]")]
	[ResultType(typeof(spType_TDoc_Plantillas_View_Salida_Vacia))]
	public IMultipleResults TDoc_Plantillas_View(
				 [Parameter(Name = "idLista")] System.Nullable<Int64> idLista
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),idLista);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	#region "[Doc].[Plantillas_View1]"

	public class spType_TDoc_Plantillas_View1_Entrada
	{
		public System.Nullable<Int32> id  { get; set; }
	}
	public class spType_TDoc_Plantillas_View1_Salida_Datos
	{
		public String descripcion  { get; set; }
		public System.Nullable<Int64> idTipoDoc  { get; set; }
		public String TipoDocumento  { get; set; }
	}
	public class spType_TDoc_Plantillas_View1_Salida
	{
		public List<spType_TDoc_Plantillas_View1_Salida_Datos> Datos;
	}
	public IMultipleResults TDoc_Plantillas_View1_1(spType_TDoc_Plantillas_View1_Entrada ent)
	{
		IMultipleResults resultados = TDoc_Plantillas_View1( ent.id);
		return resultados;
	}
	[Function(Name = "[Doc].[Plantillas_View1]")]
	[ResultType(typeof(spType_TDoc_Plantillas_View1_Salida_Datos))]
	public IMultipleResults TDoc_Plantillas_View1(
				 [Parameter(Name = "id")] System.Nullable<Int32> id
						)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),id);
		return (IMultipleResults)result.ReturnValue;
	}

	#endregion
	}
}
