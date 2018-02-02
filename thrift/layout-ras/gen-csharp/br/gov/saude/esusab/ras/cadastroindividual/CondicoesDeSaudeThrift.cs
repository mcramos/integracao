/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace br.gov.saude.esusab.ras.cadastroindividual
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class CondicoesDeSaudeThrift : TBase
  {
    private string _descricaoCausaInternacaoEm12Meses;
    private string _descricaoOutraCondicao1;
    private string _descricaoOutraCondicao2;
    private string _descricaoOutraCondicao3;
    private string _descricaoPlantasMedicinaisUsadas;
    private List<long> _doencaCardiaca;
    private List<long> _doencaRespiratoria;
    private List<long> _doencaRins;
    private string _maternidadeDeReferencia;
    private long _situacaoPeso;
    private bool _statusEhDependenteAlcool;
    private bool _statusEhDependenteOutrasDrogas;
    private bool _statusEhFumante;
    private bool _statusEhGestante;
    private bool _statusEstaAcamado;
    private bool _statusEstaDomiciliado;
    private bool _statusTemDiabetes;
    private bool _statusTemDoencaRespiratoria;
    private bool _statusTemHanseniase;
    private bool _statusTemHipertensaoArterial;
    private bool _statusTemTeveCancer;
    private bool _statusTemTeveDoencasRins;
    private bool _statusTemTuberculose;
    private bool _statusTeveAvcDerrame;
    private bool _statusTeveDoencaCardiaca;
    private bool _statusTeveInfarto;
    private bool _statusTeveInternadoEm12Meses;
    private bool _statusUsaOutrasPraticasIntegrativasOuComplementares;
    private bool _statusUsaPlantaMedicinais;
    private bool _statusDiagnosticoMental;

    public string DescricaoCausaInternacaoEm12Meses
    {
      get
      {
        return _descricaoCausaInternacaoEm12Meses;
      }
      set
      {
        __isset.descricaoCausaInternacaoEm12Meses = true;
        this._descricaoCausaInternacaoEm12Meses = value;
      }
    }

    public string DescricaoOutraCondicao1
    {
      get
      {
        return _descricaoOutraCondicao1;
      }
      set
      {
        __isset.descricaoOutraCondicao1 = true;
        this._descricaoOutraCondicao1 = value;
      }
    }

    public string DescricaoOutraCondicao2
    {
      get
      {
        return _descricaoOutraCondicao2;
      }
      set
      {
        __isset.descricaoOutraCondicao2 = true;
        this._descricaoOutraCondicao2 = value;
      }
    }

    public string DescricaoOutraCondicao3
    {
      get
      {
        return _descricaoOutraCondicao3;
      }
      set
      {
        __isset.descricaoOutraCondicao3 = true;
        this._descricaoOutraCondicao3 = value;
      }
    }

    public string DescricaoPlantasMedicinaisUsadas
    {
      get
      {
        return _descricaoPlantasMedicinaisUsadas;
      }
      set
      {
        __isset.descricaoPlantasMedicinaisUsadas = true;
        this._descricaoPlantasMedicinaisUsadas = value;
      }
    }

    public List<long> DoencaCardiaca
    {
      get
      {
        return _doencaCardiaca;
      }
      set
      {
        __isset.doencaCardiaca = true;
        this._doencaCardiaca = value;
      }
    }

    public List<long> DoencaRespiratoria
    {
      get
      {
        return _doencaRespiratoria;
      }
      set
      {
        __isset.doencaRespiratoria = true;
        this._doencaRespiratoria = value;
      }
    }

    public List<long> DoencaRins
    {
      get
      {
        return _doencaRins;
      }
      set
      {
        __isset.doencaRins = true;
        this._doencaRins = value;
      }
    }

    public string MaternidadeDeReferencia
    {
      get
      {
        return _maternidadeDeReferencia;
      }
      set
      {
        __isset.maternidadeDeReferencia = true;
        this._maternidadeDeReferencia = value;
      }
    }

    public long SituacaoPeso
    {
      get
      {
        return _situacaoPeso;
      }
      set
      {
        __isset.situacaoPeso = true;
        this._situacaoPeso = value;
      }
    }

    public bool StatusEhDependenteAlcool
    {
      get
      {
        return _statusEhDependenteAlcool;
      }
      set
      {
        __isset.statusEhDependenteAlcool = true;
        this._statusEhDependenteAlcool = value;
      }
    }

    public bool StatusEhDependenteOutrasDrogas
    {
      get
      {
        return _statusEhDependenteOutrasDrogas;
      }
      set
      {
        __isset.statusEhDependenteOutrasDrogas = true;
        this._statusEhDependenteOutrasDrogas = value;
      }
    }

    public bool StatusEhFumante
    {
      get
      {
        return _statusEhFumante;
      }
      set
      {
        __isset.statusEhFumante = true;
        this._statusEhFumante = value;
      }
    }

    public bool StatusEhGestante
    {
      get
      {
        return _statusEhGestante;
      }
      set
      {
        __isset.statusEhGestante = true;
        this._statusEhGestante = value;
      }
    }

    public bool StatusEstaAcamado
    {
      get
      {
        return _statusEstaAcamado;
      }
      set
      {
        __isset.statusEstaAcamado = true;
        this._statusEstaAcamado = value;
      }
    }

    public bool StatusEstaDomiciliado
    {
      get
      {
        return _statusEstaDomiciliado;
      }
      set
      {
        __isset.statusEstaDomiciliado = true;
        this._statusEstaDomiciliado = value;
      }
    }

    public bool StatusTemDiabetes
    {
      get
      {
        return _statusTemDiabetes;
      }
      set
      {
        __isset.statusTemDiabetes = true;
        this._statusTemDiabetes = value;
      }
    }

    public bool StatusTemDoencaRespiratoria
    {
      get
      {
        return _statusTemDoencaRespiratoria;
      }
      set
      {
        __isset.statusTemDoencaRespiratoria = true;
        this._statusTemDoencaRespiratoria = value;
      }
    }

    public bool StatusTemHanseniase
    {
      get
      {
        return _statusTemHanseniase;
      }
      set
      {
        __isset.statusTemHanseniase = true;
        this._statusTemHanseniase = value;
      }
    }

    public bool StatusTemHipertensaoArterial
    {
      get
      {
        return _statusTemHipertensaoArterial;
      }
      set
      {
        __isset.statusTemHipertensaoArterial = true;
        this._statusTemHipertensaoArterial = value;
      }
    }

    public bool StatusTemTeveCancer
    {
      get
      {
        return _statusTemTeveCancer;
      }
      set
      {
        __isset.statusTemTeveCancer = true;
        this._statusTemTeveCancer = value;
      }
    }

    public bool StatusTemTeveDoencasRins
    {
      get
      {
        return _statusTemTeveDoencasRins;
      }
      set
      {
        __isset.statusTemTeveDoencasRins = true;
        this._statusTemTeveDoencasRins = value;
      }
    }

    public bool StatusTemTuberculose
    {
      get
      {
        return _statusTemTuberculose;
      }
      set
      {
        __isset.statusTemTuberculose = true;
        this._statusTemTuberculose = value;
      }
    }

    public bool StatusTeveAvcDerrame
    {
      get
      {
        return _statusTeveAvcDerrame;
      }
      set
      {
        __isset.statusTeveAvcDerrame = true;
        this._statusTeveAvcDerrame = value;
      }
    }

    public bool StatusTeveDoencaCardiaca
    {
      get
      {
        return _statusTeveDoencaCardiaca;
      }
      set
      {
        __isset.statusTeveDoencaCardiaca = true;
        this._statusTeveDoencaCardiaca = value;
      }
    }

    public bool StatusTeveInfarto
    {
      get
      {
        return _statusTeveInfarto;
      }
      set
      {
        __isset.statusTeveInfarto = true;
        this._statusTeveInfarto = value;
      }
    }

    public bool StatusTeveInternadoEm12Meses
    {
      get
      {
        return _statusTeveInternadoEm12Meses;
      }
      set
      {
        __isset.statusTeveInternadoEm12Meses = true;
        this._statusTeveInternadoEm12Meses = value;
      }
    }

    public bool StatusUsaOutrasPraticasIntegrativasOuComplementares
    {
      get
      {
        return _statusUsaOutrasPraticasIntegrativasOuComplementares;
      }
      set
      {
        __isset.statusUsaOutrasPraticasIntegrativasOuComplementares = true;
        this._statusUsaOutrasPraticasIntegrativasOuComplementares = value;
      }
    }

    public bool StatusUsaPlantaMedicinais
    {
      get
      {
        return _statusUsaPlantaMedicinais;
      }
      set
      {
        __isset.statusUsaPlantaMedicinais = true;
        this._statusUsaPlantaMedicinais = value;
      }
    }

    public bool StatusDiagnosticoMental
    {
      get
      {
        return _statusDiagnosticoMental;
      }
      set
      {
        __isset.statusDiagnosticoMental = true;
        this._statusDiagnosticoMental = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool descricaoCausaInternacaoEm12Meses;
      public bool descricaoOutraCondicao1;
      public bool descricaoOutraCondicao2;
      public bool descricaoOutraCondicao3;
      public bool descricaoPlantasMedicinaisUsadas;
      public bool doencaCardiaca;
      public bool doencaRespiratoria;
      public bool doencaRins;
      public bool maternidadeDeReferencia;
      public bool situacaoPeso;
      public bool statusEhDependenteAlcool;
      public bool statusEhDependenteOutrasDrogas;
      public bool statusEhFumante;
      public bool statusEhGestante;
      public bool statusEstaAcamado;
      public bool statusEstaDomiciliado;
      public bool statusTemDiabetes;
      public bool statusTemDoencaRespiratoria;
      public bool statusTemHanseniase;
      public bool statusTemHipertensaoArterial;
      public bool statusTemTeveCancer;
      public bool statusTemTeveDoencasRins;
      public bool statusTemTuberculose;
      public bool statusTeveAvcDerrame;
      public bool statusTeveDoencaCardiaca;
      public bool statusTeveInfarto;
      public bool statusTeveInternadoEm12Meses;
      public bool statusUsaOutrasPraticasIntegrativasOuComplementares;
      public bool statusUsaPlantaMedicinais;
      public bool statusDiagnosticoMental;
    }

    public CondicoesDeSaudeThrift() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              DescricaoCausaInternacaoEm12Meses = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              DescricaoOutraCondicao1 = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              DescricaoOutraCondicao2 = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              DescricaoOutraCondicao3 = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              DescricaoPlantasMedicinaisUsadas = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.List) {
              {
                DoencaCardiaca = new List<long>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  long _elem2;
                  _elem2 = iprot.ReadI64();
                  DoencaCardiaca.Add(_elem2);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.List) {
              {
                DoencaRespiratoria = new List<long>();
                TList _list3 = iprot.ReadListBegin();
                for( int _i4 = 0; _i4 < _list3.Count; ++_i4)
                {
                  long _elem5;
                  _elem5 = iprot.ReadI64();
                  DoencaRespiratoria.Add(_elem5);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.List) {
              {
                DoencaRins = new List<long>();
                TList _list6 = iprot.ReadListBegin();
                for( int _i7 = 0; _i7 < _list6.Count; ++_i7)
                {
                  long _elem8;
                  _elem8 = iprot.ReadI64();
                  DoencaRins.Add(_elem8);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.String) {
              MaternidadeDeReferencia = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I64) {
              SituacaoPeso = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.Bool) {
              StatusEhDependenteAlcool = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.Bool) {
              StatusEhDependenteOutrasDrogas = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.Bool) {
              StatusEhFumante = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 14:
            if (field.Type == TType.Bool) {
              StatusEhGestante = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 15:
            if (field.Type == TType.Bool) {
              StatusEstaAcamado = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 16:
            if (field.Type == TType.Bool) {
              StatusEstaDomiciliado = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 17:
            if (field.Type == TType.Bool) {
              StatusTemDiabetes = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 18:
            if (field.Type == TType.Bool) {
              StatusTemDoencaRespiratoria = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 19:
            if (field.Type == TType.Bool) {
              StatusTemHanseniase = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.Bool) {
              StatusTemHipertensaoArterial = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 21:
            if (field.Type == TType.Bool) {
              StatusTemTeveCancer = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 22:
            if (field.Type == TType.Bool) {
              StatusTemTeveDoencasRins = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 23:
            if (field.Type == TType.Bool) {
              StatusTemTuberculose = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 24:
            if (field.Type == TType.Bool) {
              StatusTeveAvcDerrame = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 25:
            if (field.Type == TType.Bool) {
              StatusTeveDoencaCardiaca = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 26:
            if (field.Type == TType.Bool) {
              StatusTeveInfarto = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 27:
            if (field.Type == TType.Bool) {
              StatusTeveInternadoEm12Meses = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 29:
            if (field.Type == TType.Bool) {
              StatusUsaOutrasPraticasIntegrativasOuComplementares = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.Bool) {
              StatusUsaPlantaMedicinais = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 31:
            if (field.Type == TType.Bool) {
              StatusDiagnosticoMental = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("CondicoesDeSaudeThrift");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (DescricaoCausaInternacaoEm12Meses != null && __isset.descricaoCausaInternacaoEm12Meses) {
        field.Name = "descricaoCausaInternacaoEm12Meses";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DescricaoCausaInternacaoEm12Meses);
        oprot.WriteFieldEnd();
      }
      if (DescricaoOutraCondicao1 != null && __isset.descricaoOutraCondicao1) {
        field.Name = "descricaoOutraCondicao1";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DescricaoOutraCondicao1);
        oprot.WriteFieldEnd();
      }
      if (DescricaoOutraCondicao2 != null && __isset.descricaoOutraCondicao2) {
        field.Name = "descricaoOutraCondicao2";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DescricaoOutraCondicao2);
        oprot.WriteFieldEnd();
      }
      if (DescricaoOutraCondicao3 != null && __isset.descricaoOutraCondicao3) {
        field.Name = "descricaoOutraCondicao3";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DescricaoOutraCondicao3);
        oprot.WriteFieldEnd();
      }
      if (DescricaoPlantasMedicinaisUsadas != null && __isset.descricaoPlantasMedicinaisUsadas) {
        field.Name = "descricaoPlantasMedicinaisUsadas";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DescricaoPlantasMedicinaisUsadas);
        oprot.WriteFieldEnd();
      }
      if (DoencaCardiaca != null && __isset.doencaCardiaca) {
        field.Name = "doencaCardiaca";
        field.Type = TType.List;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I64, DoencaCardiaca.Count));
          foreach (long _iter9 in DoencaCardiaca)
          {
            oprot.WriteI64(_iter9);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (DoencaRespiratoria != null && __isset.doencaRespiratoria) {
        field.Name = "doencaRespiratoria";
        field.Type = TType.List;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I64, DoencaRespiratoria.Count));
          foreach (long _iter10 in DoencaRespiratoria)
          {
            oprot.WriteI64(_iter10);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (DoencaRins != null && __isset.doencaRins) {
        field.Name = "doencaRins";
        field.Type = TType.List;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I64, DoencaRins.Count));
          foreach (long _iter11 in DoencaRins)
          {
            oprot.WriteI64(_iter11);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (MaternidadeDeReferencia != null && __isset.maternidadeDeReferencia) {
        field.Name = "maternidadeDeReferencia";
        field.Type = TType.String;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(MaternidadeDeReferencia);
        oprot.WriteFieldEnd();
      }
      if (__isset.situacaoPeso) {
        field.Name = "situacaoPeso";
        field.Type = TType.I64;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(SituacaoPeso);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusEhDependenteAlcool) {
        field.Name = "statusEhDependenteAlcool";
        field.Type = TType.Bool;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusEhDependenteAlcool);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusEhDependenteOutrasDrogas) {
        field.Name = "statusEhDependenteOutrasDrogas";
        field.Type = TType.Bool;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusEhDependenteOutrasDrogas);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusEhFumante) {
        field.Name = "statusEhFumante";
        field.Type = TType.Bool;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusEhFumante);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusEhGestante) {
        field.Name = "statusEhGestante";
        field.Type = TType.Bool;
        field.ID = 14;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusEhGestante);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusEstaAcamado) {
        field.Name = "statusEstaAcamado";
        field.Type = TType.Bool;
        field.ID = 15;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusEstaAcamado);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusEstaDomiciliado) {
        field.Name = "statusEstaDomiciliado";
        field.Type = TType.Bool;
        field.ID = 16;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusEstaDomiciliado);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusTemDiabetes) {
        field.Name = "statusTemDiabetes";
        field.Type = TType.Bool;
        field.ID = 17;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusTemDiabetes);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusTemDoencaRespiratoria) {
        field.Name = "statusTemDoencaRespiratoria";
        field.Type = TType.Bool;
        field.ID = 18;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusTemDoencaRespiratoria);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusTemHanseniase) {
        field.Name = "statusTemHanseniase";
        field.Type = TType.Bool;
        field.ID = 19;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusTemHanseniase);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusTemHipertensaoArterial) {
        field.Name = "statusTemHipertensaoArterial";
        field.Type = TType.Bool;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusTemHipertensaoArterial);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusTemTeveCancer) {
        field.Name = "statusTemTeveCancer";
        field.Type = TType.Bool;
        field.ID = 21;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusTemTeveCancer);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusTemTeveDoencasRins) {
        field.Name = "statusTemTeveDoencasRins";
        field.Type = TType.Bool;
        field.ID = 22;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusTemTeveDoencasRins);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusTemTuberculose) {
        field.Name = "statusTemTuberculose";
        field.Type = TType.Bool;
        field.ID = 23;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusTemTuberculose);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusTeveAvcDerrame) {
        field.Name = "statusTeveAvcDerrame";
        field.Type = TType.Bool;
        field.ID = 24;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusTeveAvcDerrame);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusTeveDoencaCardiaca) {
        field.Name = "statusTeveDoencaCardiaca";
        field.Type = TType.Bool;
        field.ID = 25;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusTeveDoencaCardiaca);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusTeveInfarto) {
        field.Name = "statusTeveInfarto";
        field.Type = TType.Bool;
        field.ID = 26;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusTeveInfarto);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusTeveInternadoEm12Meses) {
        field.Name = "statusTeveInternadoEm12Meses";
        field.Type = TType.Bool;
        field.ID = 27;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusTeveInternadoEm12Meses);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusUsaOutrasPraticasIntegrativasOuComplementares) {
        field.Name = "statusUsaOutrasPraticasIntegrativasOuComplementares";
        field.Type = TType.Bool;
        field.ID = 29;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusUsaOutrasPraticasIntegrativasOuComplementares);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusUsaPlantaMedicinais) {
        field.Name = "statusUsaPlantaMedicinais";
        field.Type = TType.Bool;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusUsaPlantaMedicinais);
        oprot.WriteFieldEnd();
      }
      if (__isset.statusDiagnosticoMental) {
        field.Name = "statusDiagnosticoMental";
        field.Type = TType.Bool;
        field.ID = 31;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(StatusDiagnosticoMental);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("CondicoesDeSaudeThrift(");
      bool __first = true;
      if (DescricaoCausaInternacaoEm12Meses != null && __isset.descricaoCausaInternacaoEm12Meses) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DescricaoCausaInternacaoEm12Meses: ");
        __sb.Append(DescricaoCausaInternacaoEm12Meses);
      }
      if (DescricaoOutraCondicao1 != null && __isset.descricaoOutraCondicao1) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DescricaoOutraCondicao1: ");
        __sb.Append(DescricaoOutraCondicao1);
      }
      if (DescricaoOutraCondicao2 != null && __isset.descricaoOutraCondicao2) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DescricaoOutraCondicao2: ");
        __sb.Append(DescricaoOutraCondicao2);
      }
      if (DescricaoOutraCondicao3 != null && __isset.descricaoOutraCondicao3) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DescricaoOutraCondicao3: ");
        __sb.Append(DescricaoOutraCondicao3);
      }
      if (DescricaoPlantasMedicinaisUsadas != null && __isset.descricaoPlantasMedicinaisUsadas) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DescricaoPlantasMedicinaisUsadas: ");
        __sb.Append(DescricaoPlantasMedicinaisUsadas);
      }
      if (DoencaCardiaca != null && __isset.doencaCardiaca) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DoencaCardiaca: ");
        __sb.Append(DoencaCardiaca);
      }
      if (DoencaRespiratoria != null && __isset.doencaRespiratoria) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DoencaRespiratoria: ");
        __sb.Append(DoencaRespiratoria);
      }
      if (DoencaRins != null && __isset.doencaRins) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DoencaRins: ");
        __sb.Append(DoencaRins);
      }
      if (MaternidadeDeReferencia != null && __isset.maternidadeDeReferencia) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("MaternidadeDeReferencia: ");
        __sb.Append(MaternidadeDeReferencia);
      }
      if (__isset.situacaoPeso) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SituacaoPeso: ");
        __sb.Append(SituacaoPeso);
      }
      if (__isset.statusEhDependenteAlcool) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusEhDependenteAlcool: ");
        __sb.Append(StatusEhDependenteAlcool);
      }
      if (__isset.statusEhDependenteOutrasDrogas) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusEhDependenteOutrasDrogas: ");
        __sb.Append(StatusEhDependenteOutrasDrogas);
      }
      if (__isset.statusEhFumante) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusEhFumante: ");
        __sb.Append(StatusEhFumante);
      }
      if (__isset.statusEhGestante) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusEhGestante: ");
        __sb.Append(StatusEhGestante);
      }
      if (__isset.statusEstaAcamado) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusEstaAcamado: ");
        __sb.Append(StatusEstaAcamado);
      }
      if (__isset.statusEstaDomiciliado) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusEstaDomiciliado: ");
        __sb.Append(StatusEstaDomiciliado);
      }
      if (__isset.statusTemDiabetes) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusTemDiabetes: ");
        __sb.Append(StatusTemDiabetes);
      }
      if (__isset.statusTemDoencaRespiratoria) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusTemDoencaRespiratoria: ");
        __sb.Append(StatusTemDoencaRespiratoria);
      }
      if (__isset.statusTemHanseniase) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusTemHanseniase: ");
        __sb.Append(StatusTemHanseniase);
      }
      if (__isset.statusTemHipertensaoArterial) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusTemHipertensaoArterial: ");
        __sb.Append(StatusTemHipertensaoArterial);
      }
      if (__isset.statusTemTeveCancer) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusTemTeveCancer: ");
        __sb.Append(StatusTemTeveCancer);
      }
      if (__isset.statusTemTeveDoencasRins) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusTemTeveDoencasRins: ");
        __sb.Append(StatusTemTeveDoencasRins);
      }
      if (__isset.statusTemTuberculose) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusTemTuberculose: ");
        __sb.Append(StatusTemTuberculose);
      }
      if (__isset.statusTeveAvcDerrame) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusTeveAvcDerrame: ");
        __sb.Append(StatusTeveAvcDerrame);
      }
      if (__isset.statusTeveDoencaCardiaca) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusTeveDoencaCardiaca: ");
        __sb.Append(StatusTeveDoencaCardiaca);
      }
      if (__isset.statusTeveInfarto) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusTeveInfarto: ");
        __sb.Append(StatusTeveInfarto);
      }
      if (__isset.statusTeveInternadoEm12Meses) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusTeveInternadoEm12Meses: ");
        __sb.Append(StatusTeveInternadoEm12Meses);
      }
      if (__isset.statusUsaOutrasPraticasIntegrativasOuComplementares) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusUsaOutrasPraticasIntegrativasOuComplementares: ");
        __sb.Append(StatusUsaOutrasPraticasIntegrativasOuComplementares);
      }
      if (__isset.statusUsaPlantaMedicinais) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusUsaPlantaMedicinais: ");
        __sb.Append(StatusUsaPlantaMedicinais);
      }
      if (__isset.statusDiagnosticoMental) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StatusDiagnosticoMental: ");
        __sb.Append(StatusDiagnosticoMental);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}