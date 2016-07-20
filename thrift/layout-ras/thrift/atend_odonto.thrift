include "common/common.thrift"

namespace java br.gov.saude.esus.cds.transport.generated.thrift.atendimentoodontologico
namespace php br.gov.saude.esus.cds.transport.generated.thrift.atendimentoodontologico
namespace delphi br.gov.saude.esus.cds.transport.generated.thrift.atendimentoodontologico
namespace csharp br.gov.saude.esus.cds.transport.generated.thrift.atendimentoodontologico
namespace rb br.gov.saude.esus.cds.transport.generated.thrift.atendimentoodontologico


struct ProcedimentoQuantidadeThrift {
	1:optional string coMsProcedimento;
	2:optional i32 quantidade;
}

struct FichaAtendimentoOdontologicoChildThrift {
	1:optional i64 dtNascimento;
	2:optional string numCartaoSus;
	3:optional string numProntuario;
	4:optional bool gestante;
	5:optional bool necessidadesEspeciais;
	6:optional i64 localAtendimento;
	7:optional i64 tipoAtendimento;
	8:optional list<i64> tiposEncamOdonto;
	9:optional list<i64> tiposFornecimOdonto;
	10:optional list<i64> tiposVigilanciaSaudeBucal;
	11:optional list<i64> tiposConsultaOdonto;
	12:optional list<ProcedimentoQuantidadeThrift> procedimentosRealizados;
	13:optional list<ProcedimentoQuantidadeThrift> outrosSiaProcedimentos;
	14:optional i64 sexo;
	15:optional i64 turno;
}

struct FichaAtendimentoOdontologicoMasterThrift {
	1:required string uuidFicha;
	
	2:required common.VariasLotacoesHeaderThrift headerTransport;
	3:optional list<FichaAtendimentoOdontologicoChildThrift> atendimentosOdontologicos;
	4:optional i32 tpCdsOrigem;
}