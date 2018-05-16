namespace Api.Engines.Venda.Infra.WcfProxies
{


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EstruturaRetorno", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class EstruturaRetorno : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoErroField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RetornoField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoErro
        {
            get
            {
                return this.DescricaoErroField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoErroField, value) != true))
                {
                    this.DescricaoErroField = value;
                    this.RaisePropertyChanged("DescricaoErro");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Retorno
        {
            get
            {
                return this.RetornoField;
            }
            set
            {
                if ((this.RetornoField.Equals(value) != true))
                {
                    this.RetornoField = value;
                    this.RaisePropertyChanged("Retorno");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
    [System.SerializableAttribute()]
    public partial class ValidacaoException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo
        {
            get
            {
                return this.CodigoField;
            }
            set
            {
                if ((this.CodigoField.Equals(value) != true))
                {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensagem
        {
            get
            {
                return this.MensagemField;
            }
            set
            {
                if ((object.ReferenceEquals(this.MensagemField, value) != true))
                {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StatusPergunta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    public enum StatusPergunta : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        RESOLVIDO = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        PENDENTE = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        TODOS = 3,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "PendenciaResposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class PendenciaResposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AlcadaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AnalistaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AnalistaNomeField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CPFSeguradoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoAntigoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataPerguntaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataRespostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescrCriticaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescrGrupoCriticaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DestinoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCriticaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdHistCriticaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdPendenciaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdSchemaVersaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MatriculaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModeloPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NumPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PendenciaLidaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResponsavelRespostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResponsavelRespostaNomeField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RespostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool RespostaAutomaticaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RespostaLidaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Alcada
        {
            get
            {
                return this.AlcadaField;
            }
            set
            {
                if ((this.AlcadaField.Equals(value) != true))
                {
                    this.AlcadaField = value;
                    this.RaisePropertyChanged("Alcada");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Analista
        {
            get
            {
                return this.AnalistaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.AnalistaField, value) != true))
                {
                    this.AnalistaField = value;
                    this.RaisePropertyChanged("Analista");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AnalistaNome
        {
            get
            {
                return this.AnalistaNomeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.AnalistaNomeField, value) != true))
                {
                    this.AnalistaNomeField = value;
                    this.RaisePropertyChanged("AnalistaNome");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CPFSegurado
        {
            get
            {
                return this.CPFSeguradoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.CPFSeguradoField, value) != true))
                {
                    this.CPFSeguradoField = value;
                    this.RaisePropertyChanged("CPFSegurado");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodigoAntigo
        {
            get
            {
                return this.CodigoAntigoField;
            }
            set
            {
                if ((this.CodigoAntigoField.Equals(value) != true))
                {
                    this.CodigoAntigoField = value;
                    this.RaisePropertyChanged("CodigoAntigo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataPergunta
        {
            get
            {
                return this.DataPerguntaField;
            }
            set
            {
                if ((this.DataPerguntaField.Equals(value) != true))
                {
                    this.DataPerguntaField = value;
                    this.RaisePropertyChanged("DataPergunta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataResposta
        {
            get
            {
                return this.DataRespostaField;
            }
            set
            {
                if ((this.DataRespostaField.Equals(value) != true))
                {
                    this.DataRespostaField = value;
                    this.RaisePropertyChanged("DataResposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescrCritica
        {
            get
            {
                return this.DescrCriticaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescrCriticaField, value) != true))
                {
                    this.DescrCriticaField = value;
                    this.RaisePropertyChanged("DescrCritica");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescrGrupoCritica
        {
            get
            {
                return this.DescrGrupoCriticaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescrGrupoCriticaField, value) != true))
                {
                    this.DescrGrupoCriticaField = value;
                    this.RaisePropertyChanged("DescrGrupoCritica");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao
        {
            get
            {
                return this.DescricaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true))
                {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Destino
        {
            get
            {
                return this.DestinoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DestinoField, value) != true))
                {
                    this.DestinoField = value;
                    this.RaisePropertyChanged("Destino");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCritica
        {
            get
            {
                return this.IdCriticaField;
            }
            set
            {
                if ((this.IdCriticaField.Equals(value) != true))
                {
                    this.IdCriticaField = value;
                    this.RaisePropertyChanged("IdCritica");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IdHistCritica
        {
            get
            {
                return this.IdHistCriticaField;
            }
            set
            {
                if ((this.IdHistCriticaField.Equals(value) != true))
                {
                    this.IdHistCriticaField = value;
                    this.RaisePropertyChanged("IdHistCritica");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPendencia
        {
            get
            {
                return this.IdPendenciaField;
            }
            set
            {
                if ((this.IdPendenciaField.Equals(value) != true))
                {
                    this.IdPendenciaField = value;
                    this.RaisePropertyChanged("IdPendencia");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdSchemaVersao
        {
            get
            {
                return this.IdSchemaVersaoField;
            }
            set
            {
                if ((this.IdSchemaVersaoField.Equals(value) != true))
                {
                    this.IdSchemaVersaoField = value;
                    this.RaisePropertyChanged("IdSchemaVersao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Matricula
        {
            get
            {
                return this.MatriculaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.MatriculaField, value) != true))
                {
                    this.MatriculaField = value;
                    this.RaisePropertyChanged("Matricula");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModeloProposta
        {
            get
            {
                return this.ModeloPropostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ModeloPropostaField, value) != true))
                {
                    this.ModeloPropostaField = value;
                    this.RaisePropertyChanged("ModeloProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NumProposta
        {
            get
            {
                return this.NumPropostaField;
            }
            set
            {
                if ((this.NumPropostaField.Equals(value) != true))
                {
                    this.NumPropostaField = value;
                    this.RaisePropertyChanged("NumProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PendenciaLida
        {
            get
            {
                return this.PendenciaLidaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.PendenciaLidaField, value) != true))
                {
                    this.PendenciaLidaField = value;
                    this.RaisePropertyChanged("PendenciaLida");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResponsavelResposta
        {
            get
            {
                return this.ResponsavelRespostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ResponsavelRespostaField, value) != true))
                {
                    this.ResponsavelRespostaField = value;
                    this.RaisePropertyChanged("ResponsavelResposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ResponsavelRespostaNome
        {
            get
            {
                return this.ResponsavelRespostaNomeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ResponsavelRespostaNomeField, value) != true))
                {
                    this.ResponsavelRespostaNomeField = value;
                    this.RaisePropertyChanged("ResponsavelRespostaNome");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Resposta
        {
            get
            {
                return this.RespostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.RespostaField, value) != true))
                {
                    this.RespostaField = value;
                    this.RaisePropertyChanged("Resposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool RespostaAutomatica
        {
            get
            {
                return this.RespostaAutomaticaField;
            }
            set
            {
                if ((this.RespostaAutomaticaField.Equals(value) != true))
                {
                    this.RespostaAutomaticaField = value;
                    this.RaisePropertyChanged("RespostaAutomatica");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RespostaLida
        {
            get
            {
                return this.RespostaLidaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.RespostaLidaField, value) != true))
                {
                    this.RespostaLidaField = value;
                    this.RaisePropertyChanged("RespostaLida");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                if ((object.ReferenceEquals(this.StatusField, value) != true))
                {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CriticaXML", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Contract")]
    [System.SerializableAttribute()]
    public partial class CriticaXML : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CriticaSistema[] CriticaField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public CriticaSistema[] Critica
        {
            get
            {
                return this.CriticaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.CriticaField, value) != true))
                {
                    this.CriticaField = value;
                    this.RaisePropertyChanged("Critica");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CriticaSistema", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Contract")]
    [System.SerializableAttribute()]
    public partial class CriticaSistema : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ObsField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao
        {
            get
            {
                return this.DescricaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true))
                {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                if ((this.IdField.Equals(value) != true))
                {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Obs
        {
            get
            {
                return this.ObsField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ObsField, value) != true))
                {
                    this.ObsField = value;
                    this.RaisePropertyChanged("Obs");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "VersaoSchema", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class VersaoSchema : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescrPlanoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdSchemaPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdSchemaVersaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamespaceField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomePlanoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SchemaXsdField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VersaoField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescrPlano
        {
            get
            {
                return this.DescrPlanoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescrPlanoField, value) != true))
                {
                    this.DescrPlanoField = value;
                    this.RaisePropertyChanged("DescrPlano");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao
        {
            get
            {
                return this.DescricaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true))
                {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdSchemaProposta
        {
            get
            {
                return this.IdSchemaPropostaField;
            }
            set
            {
                if ((this.IdSchemaPropostaField.Equals(value) != true))
                {
                    this.IdSchemaPropostaField = value;
                    this.RaisePropertyChanged("IdSchemaProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdSchemaVersao
        {
            get
            {
                return this.IdSchemaVersaoField;
            }
            set
            {
                if ((this.IdSchemaVersaoField.Equals(value) != true))
                {
                    this.IdSchemaVersaoField = value;
                    this.RaisePropertyChanged("IdSchemaVersao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Namespace
        {
            get
            {
                return this.NamespaceField;
            }
            set
            {
                if ((object.ReferenceEquals(this.NamespaceField, value) != true))
                {
                    this.NamespaceField = value;
                    this.RaisePropertyChanged("Namespace");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomePlano
        {
            get
            {
                return this.NomePlanoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.NomePlanoField, value) != true))
                {
                    this.NomePlanoField = value;
                    this.RaisePropertyChanged("NomePlano");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SchemaXsd
        {
            get
            {
                return this.SchemaXsdField;
            }
            set
            {
                if ((object.ReferenceEquals(this.SchemaXsdField, value) != true))
                {
                    this.SchemaXsdField = value;
                    this.RaisePropertyChanged("SchemaXsd");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Versao
        {
            get
            {
                return this.VersaoField;
            }
            set
            {
                if ((this.VersaoField.Equals(value) != true))
                {
                    this.VersaoField = value;
                    this.RaisePropertyChanged("Versao");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CriticaPendencia", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class CriticaPendencia : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CheckResolvidoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCriticaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdHistoricoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdPendenciaField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CheckResolvido
        {
            get
            {
                return this.CheckResolvidoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.CheckResolvidoField, value) != true))
                {
                    this.CheckResolvidoField = value;
                    this.RaisePropertyChanged("CheckResolvido");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCritica
        {
            get
            {
                return this.IdCriticaField;
            }
            set
            {
                if ((this.IdCriticaField.Equals(value) != true))
                {
                    this.IdCriticaField = value;
                    this.RaisePropertyChanged("IdCritica");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IdHistorico
        {
            get
            {
                return this.IdHistoricoField;
            }
            set
            {
                if ((this.IdHistoricoField.Equals(value) != true))
                {
                    this.IdHistoricoField = value;
                    this.RaisePropertyChanged("IdHistorico");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPendencia
        {
            get
            {
                return this.IdPendenciaField;
            }
            set
            {
                if ((this.IdPendenciaField.Equals(value) != true))
                {
                    this.IdPendenciaField = value;
                    this.RaisePropertyChanged("IdPendencia");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Criticas", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class Criticas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AlcadaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AtivoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoAntigoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DestinoPendenciaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdGrupoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> IdMotivoRecusaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PendenciaNaturalField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Alcada
        {
            get
            {
                return this.AlcadaField;
            }
            set
            {
                if ((this.AlcadaField.Equals(value) != true))
                {
                    this.AlcadaField = value;
                    this.RaisePropertyChanged("Alcada");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ativo
        {
            get
            {
                return this.AtivoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.AtivoField, value) != true))
                {
                    this.AtivoField = value;
                    this.RaisePropertyChanged("Ativo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodigoAntigo
        {
            get
            {
                return this.CodigoAntigoField;
            }
            set
            {
                if ((this.CodigoAntigoField.Equals(value) != true))
                {
                    this.CodigoAntigoField = value;
                    this.RaisePropertyChanged("CodigoAntigo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao
        {
            get
            {
                return this.DescricaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true))
                {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DestinoPendencia
        {
            get
            {
                return this.DestinoPendenciaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DestinoPendenciaField, value) != true))
                {
                    this.DestinoPendenciaField = value;
                    this.RaisePropertyChanged("DestinoPendencia");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                if ((this.IdField.Equals(value) != true))
                {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdGrupo
        {
            get
            {
                return this.IdGrupoField;
            }
            set
            {
                if ((this.IdGrupoField.Equals(value) != true))
                {
                    this.IdGrupoField = value;
                    this.RaisePropertyChanged("IdGrupo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> IdMotivoRecusa
        {
            get
            {
                return this.IdMotivoRecusaField;
            }
            set
            {
                if ((this.IdMotivoRecusaField.Equals(value) != true))
                {
                    this.IdMotivoRecusaField = value;
                    this.RaisePropertyChanged("IdMotivoRecusa");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PendenciaNatural
        {
            get
            {
                return this.PendenciaNaturalField;
            }
            set
            {
                if ((object.ReferenceEquals(this.PendenciaNaturalField, value) != true))
                {
                    this.PendenciaNaturalField = value;
                    this.RaisePropertyChanged("PendenciaNatural");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Metadado", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class Metadado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdVersaoSchemaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValorMetaDadoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XpathField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdVersaoSchema
        {
            get
            {
                return this.IdVersaoSchemaField;
            }
            set
            {
                if ((this.IdVersaoSchemaField.Equals(value) != true))
                {
                    this.IdVersaoSchemaField = value;
                    this.RaisePropertyChanged("IdVersaoSchema");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ValorMetaDado
        {
            get
            {
                return this.ValorMetaDadoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ValorMetaDadoField, value) != true))
                {
                    this.ValorMetaDadoField = value;
                    this.RaisePropertyChanged("ValorMetaDado");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Xpath
        {
            get
            {
                return this.XpathField;
            }
            set
            {
                if ((object.ReferenceEquals(this.XpathField, value) != true))
                {
                    this.XpathField = value;
                    this.RaisePropertyChanged("Xpath");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EnumTipoPolitica", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Model")]
    public enum EnumTipoPolitica : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        VALIDACAO = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        TRANSFORMACAO = 1,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EnumStatusProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Model")]
    public enum EnumStatusProposta : short
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Todos = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Distribuida = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Digitalizada = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Indexada = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Digitada = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Em_Análise = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Aceita = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Recusada = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Implantada = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Aguardando_Indexação = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Almoxarifado = 10,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Digitalização_Inválida = 11,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Aguardando_Digitação = 12,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Exceção = 13,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Em_Processamento = 14,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pendente = 15,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Em_Conferência = 16,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Elegível_para_Recusa = 17,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Extraviada = 18,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Aceite_Automático = 19,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Rasurada = 20,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inutilizada = 21,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Bloqueada = 22,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Desativada = 23,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Aguardando_Processamento = 24,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Em_Análise_Sysprev = 25,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Nenhum = 26,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inicializada = 28,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Apta_para_Digitação = 29,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Estrutura_Inválida = 30,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Cancelada = 31,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Em_Análise_VG = 32,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Suspensa = 33,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EstruturaRetornoProtocolo", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Contract")]
    [System.SerializableAttribute()]
    public partial class EstruturaRetornoProtocolo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProtocoloField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RetornoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SucessoField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensagem
        {
            get
            {
                return this.MensagemField;
            }
            set
            {
                if ((object.ReferenceEquals(this.MensagemField, value) != true))
                {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Protocolo
        {
            get
            {
                return this.ProtocoloField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ProtocoloField, value) != true))
                {
                    this.ProtocoloField = value;
                    this.RaisePropertyChanged("Protocolo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Retorno
        {
            get
            {
                return this.RetornoField;
            }
            set
            {
                if ((this.RetornoField.Equals(value) != true))
                {
                    this.RetornoField = value;
                    this.RaisePropertyChanged("Retorno");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Sucesso
        {
            get
            {
                return this.SucessoField;
            }
            set
            {
                if ((this.SucessoField.Equals(value) != true))
                {
                    this.SucessoField = value;
                    this.RaisePropertyChanged("Sucesso");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EnumDominioMetadado", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Model")]
    public enum EnumDominioMetadado : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        TODOS = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        NUMERO = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        MODELO = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        DATA_VIGENCIA = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        SUCURSAL = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        NOME_PROPONENTE = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        MATRICULA = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        ORIGEM = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        VALOR_CONTRIBUICAO = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        CPF_PROPONENTE = 10,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        MODELO_ANTIGO = 11,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        NR_BANCO = 12,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        NR_AGENCIA = 13,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        CONTA_CORRENTE = 14,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        EMISSAO_KIT = 15,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        VALOR_RISCO = 16,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        TREINANDO = 17,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        PLANO = 18,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        CODIGO_PLANO = 19,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        NOME_PLANO = 20,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        COBERTURA = 21,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        CODIGO_COBERTURA = 22,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        EMAIL_PROPONENTE = 23,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        FORMA_PAGAMENTO = 24,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        DATA_PROTOCOLO = 25,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        CORRETOR1 = 26,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        CORRETOR2 = 27,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        NOME_BENEFICIARIO = 31,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        VALOR_COBERTURA = 32,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        IDEXTERNO1 = 33,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        IDEXTERNO2 = 34,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        SUSEP = 35,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        TIPOLOGRADOURO = 36,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        ENDERECO = 37,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        COMPLEMENTO = 38,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        BAIRRO = 39,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        CIDADE = 40,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        UF = 41,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        CEP = 42,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        CNPJ_PROPONENTE = 43,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        RAZAO_SOCIAL = 44,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        MODULO = 45,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        CODIGO_MODULO = 46,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ModeloProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class ModeloProposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataCriacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoVersaoSchemaAtualField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DtPrimeiroRangeField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long EstoqueAtualField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long EstoqueMinimoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EnumGrupoModeloProposta GrupoModeloPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdGrupoModeloPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> IdParceiroField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdVersaoSchemaAtualField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeGrupoModeloPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ObservacoesField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StatusModeloPropostaEnum StatusModeloPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EnumTipoModeloProposta TipoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UltimoRangeField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataCriacao
        {
            get
            {
                return this.DataCriacaoField;
            }
            set
            {
                if ((this.DataCriacaoField.Equals(value) != true))
                {
                    this.DataCriacaoField = value;
                    this.RaisePropertyChanged("DataCriacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoVersaoSchemaAtual
        {
            get
            {
                return this.DescricaoVersaoSchemaAtualField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoVersaoSchemaAtualField, value) != true))
                {
                    this.DescricaoVersaoSchemaAtualField = value;
                    this.RaisePropertyChanged("DescricaoVersaoSchemaAtual");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DtPrimeiroRange
        {
            get
            {
                return this.DtPrimeiroRangeField;
            }
            set
            {
                if ((this.DtPrimeiroRangeField.Equals(value) != true))
                {
                    this.DtPrimeiroRangeField = value;
                    this.RaisePropertyChanged("DtPrimeiroRange");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long EstoqueAtual
        {
            get
            {
                return this.EstoqueAtualField;
            }
            set
            {
                if ((this.EstoqueAtualField.Equals(value) != true))
                {
                    this.EstoqueAtualField = value;
                    this.RaisePropertyChanged("EstoqueAtual");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long EstoqueMinimo
        {
            get
            {
                return this.EstoqueMinimoField;
            }
            set
            {
                if ((this.EstoqueMinimoField.Equals(value) != true))
                {
                    this.EstoqueMinimoField = value;
                    this.RaisePropertyChanged("EstoqueMinimo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public EnumGrupoModeloProposta GrupoModeloProposta
        {
            get
            {
                return this.GrupoModeloPropostaField;
            }
            set
            {
                if ((this.GrupoModeloPropostaField.Equals(value) != true))
                {
                    this.GrupoModeloPropostaField = value;
                    this.RaisePropertyChanged("GrupoModeloProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                if ((object.ReferenceEquals(this.IdField, value) != true))
                {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdGrupoModeloProposta
        {
            get
            {
                return this.IdGrupoModeloPropostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.IdGrupoModeloPropostaField, value) != true))
                {
                    this.IdGrupoModeloPropostaField = value;
                    this.RaisePropertyChanged("IdGrupoModeloProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> IdParceiro
        {
            get
            {
                return this.IdParceiroField;
            }
            set
            {
                if ((this.IdParceiroField.Equals(value) != true))
                {
                    this.IdParceiroField = value;
                    this.RaisePropertyChanged("IdParceiro");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IdVersaoSchemaAtual
        {
            get
            {
                return this.IdVersaoSchemaAtualField;
            }
            set
            {
                if ((this.IdVersaoSchemaAtualField.Equals(value) != true))
                {
                    this.IdVersaoSchemaAtualField = value;
                    this.RaisePropertyChanged("IdVersaoSchemaAtual");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome
        {
            get
            {
                return this.NomeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.NomeField, value) != true))
                {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeGrupoModeloProposta
        {
            get
            {
                return this.NomeGrupoModeloPropostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.NomeGrupoModeloPropostaField, value) != true))
                {
                    this.NomeGrupoModeloPropostaField = value;
                    this.RaisePropertyChanged("NomeGrupoModeloProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Observacoes
        {
            get
            {
                return this.ObservacoesField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ObservacoesField, value) != true))
                {
                    this.ObservacoesField = value;
                    this.RaisePropertyChanged("Observacoes");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StatusModeloPropostaEnum StatusModeloProposta
        {
            get
            {
                return this.StatusModeloPropostaField;
            }
            set
            {
                if ((this.StatusModeloPropostaField.Equals(value) != true))
                {
                    this.StatusModeloPropostaField = value;
                    this.RaisePropertyChanged("StatusModeloProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public EnumTipoModeloProposta Tipo
        {
            get
            {
                return this.TipoField;
            }
            set
            {
                if ((this.TipoField.Equals(value) != true))
                {
                    this.TipoField = value;
                    this.RaisePropertyChanged("Tipo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UltimoRange
        {
            get
            {
                return this.UltimoRangeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.UltimoRangeField, value) != true))
                {
                    this.UltimoRangeField = value;
                    this.RaisePropertyChanged("UltimoRange");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EnumGrupoModeloProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Model")]
    public enum EnumGrupoModeloProposta : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        AgoraSim = 65,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        MinhaFamilia = 70,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        VidaEmGrupo = 71,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Mongeral = 77,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        PrivateSolutions = 80,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        VidaToda = 86,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StatusModeloPropostaEnum", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.eSim.Implantacao.PropostaSubscri" +
        "taDomain.Enums")]
    public enum StatusModeloPropostaEnum : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Comercializado = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        NaoComercializado = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        EmDesenvolvimento = 3,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EnumTipoModeloProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Model")]
    public enum EnumTipoModeloProposta : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Nenhum = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Proposta_Papel = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Proposta_Web = 2,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EnumTipoParecer", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Model")]
    public enum EnumTipoParecer : short
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Todos = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Parecer_Aceite = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Parecer_Retirar_Aceite = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Parecer_Retirar_Recusa = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Parecer_Eleger_Recusa = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Parecer_Recusa = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Parecer_Suspensao = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Parecer_Retirar_Suspensao = 7,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EnumStatusExcecao", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Model")]
    public enum EnumStatusExcecao : short
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Pendente_De_Analise = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Resolvida = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Ignorada = 3,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "PoliticaAceitacao", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class PoliticaAceitacao : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DtFimField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DtInicioField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdModeloPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeModeloField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PoliticaTransfField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PoliticaValField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VersaoTransfField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VersaoValField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DtFim
        {
            get
            {
                return this.DtFimField;
            }
            set
            {
                if ((this.DtFimField.Equals(value) != true))
                {
                    this.DtFimField = value;
                    this.RaisePropertyChanged("DtFim");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DtInicio
        {
            get
            {
                return this.DtInicioField;
            }
            set
            {
                if ((this.DtInicioField.Equals(value) != true))
                {
                    this.DtInicioField = value;
                    this.RaisePropertyChanged("DtInicio");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                if ((this.IdField.Equals(value) != true))
                {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdModeloProposta
        {
            get
            {
                return this.IdModeloPropostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.IdModeloPropostaField, value) != true))
                {
                    this.IdModeloPropostaField = value;
                    this.RaisePropertyChanged("IdModeloProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeModelo
        {
            get
            {
                return this.NomeModeloField;
            }
            set
            {
                if ((object.ReferenceEquals(this.NomeModeloField, value) != true))
                {
                    this.NomeModeloField = value;
                    this.RaisePropertyChanged("NomeModelo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PoliticaTransf
        {
            get
            {
                return this.PoliticaTransfField;
            }
            set
            {
                if ((object.ReferenceEquals(this.PoliticaTransfField, value) != true))
                {
                    this.PoliticaTransfField = value;
                    this.RaisePropertyChanged("PoliticaTransf");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PoliticaVal
        {
            get
            {
                return this.PoliticaValField;
            }
            set
            {
                if ((object.ReferenceEquals(this.PoliticaValField, value) != true))
                {
                    this.PoliticaValField = value;
                    this.RaisePropertyChanged("PoliticaVal");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int VersaoTransf
        {
            get
            {
                return this.VersaoTransfField;
            }
            set
            {
                if ((this.VersaoTransfField.Equals(value) != true))
                {
                    this.VersaoTransfField = value;
                    this.RaisePropertyChanged("VersaoTransf");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int VersaoVal
        {
            get
            {
                return this.VersaoValField;
            }
            set
            {
                if ((this.VersaoValField.Equals(value) != true))
                {
                    this.VersaoValField = value;
                    this.RaisePropertyChanged("VersaoVal");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SistemaProduto", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class SistemaProduto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AtivoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EndpointInterfaceField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SistemaField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ativo
        {
            get
            {
                return this.AtivoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.AtivoField, value) != true))
                {
                    this.AtivoField = value;
                    this.RaisePropertyChanged("Ativo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EndpointInterface
        {
            get
            {
                return this.EndpointInterfaceField;
            }
            set
            {
                if ((object.ReferenceEquals(this.EndpointInterfaceField, value) != true))
                {
                    this.EndpointInterfaceField = value;
                    this.RaisePropertyChanged("EndpointInterface");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                if ((this.IdField.Equals(value) != true))
                {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sistema
        {
            get
            {
                return this.SistemaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.SistemaField, value) != true))
                {
                    this.SistemaField = value;
                    this.RaisePropertyChanged("Sistema");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "GrupoModeloProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class GrupoModeloProposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AtivoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeGrupoField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ativo
        {
            get
            {
                return this.AtivoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.AtivoField, value) != true))
                {
                    this.AtivoField = value;
                    this.RaisePropertyChanged("Ativo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao
        {
            get
            {
                return this.DescricaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true))
                {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                if ((object.ReferenceEquals(this.IdField, value) != true))
                {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeGrupo
        {
            get
            {
                return this.NomeGrupoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.NomeGrupoField, value) != true))
                {
                    this.NomeGrupoField = value;
                    this.RaisePropertyChanged("NomeGrupo");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "DetalheExcecao", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class DetalheExcecao : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataAlteracaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdExcecaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ObservacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EnumStatusExcecao StatusField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataAlteracao
        {
            get
            {
                return this.DataAlteracaoField;
            }
            set
            {
                if ((this.DataAlteracaoField.Equals(value) != true))
                {
                    this.DataAlteracaoField = value;
                    this.RaisePropertyChanged("DataAlteracao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IdExcecao
        {
            get
            {
                return this.IdExcecaoField;
            }
            set
            {
                if ((this.IdExcecaoField.Equals(value) != true))
                {
                    this.IdExcecaoField = value;
                    this.RaisePropertyChanged("IdExcecao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Observacao
        {
            get
            {
                return this.ObservacaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ObservacaoField, value) != true))
                {
                    this.ObservacaoField = value;
                    this.RaisePropertyChanged("Observacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EnumStatusExcecao Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                if ((this.StatusField.Equals(value) != true))
                {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usuario
        {
            get
            {
                return this.UsuarioField;
            }
            set
            {
                if ((object.ReferenceEquals(this.UsuarioField, value) != true))
                {
                    this.UsuarioField = value;
                    this.RaisePropertyChanged("Usuario");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ResumoProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class ResumoProposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataAlteracaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataCriacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModeloField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NumeroField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrigemField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SucursalField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataAlteracao
        {
            get
            {
                return this.DataAlteracaoField;
            }
            set
            {
                if ((this.DataAlteracaoField.Equals(value) != true))
                {
                    this.DataAlteracaoField = value;
                    this.RaisePropertyChanged("DataAlteracao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataCriacao
        {
            get
            {
                return this.DataCriacaoField;
            }
            set
            {
                if ((this.DataCriacaoField.Equals(value) != true))
                {
                    this.DataCriacaoField = value;
                    this.RaisePropertyChanged("DataCriacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao
        {
            get
            {
                return this.DescricaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true))
                {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modelo
        {
            get
            {
                return this.ModeloField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ModeloField, value) != true))
                {
                    this.ModeloField = value;
                    this.RaisePropertyChanged("Modelo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Numero
        {
            get
            {
                return this.NumeroField;
            }
            set
            {
                if ((this.NumeroField.Equals(value) != true))
                {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Origem
        {
            get
            {
                return this.OrigemField;
            }
            set
            {
                if ((object.ReferenceEquals(this.OrigemField, value) != true))
                {
                    this.OrigemField = value;
                    this.RaisePropertyChanged("Origem");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                if ((object.ReferenceEquals(this.StatusField, value) != true))
                {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sucursal
        {
            get
            {
                return this.SucursalField;
            }
            set
            {
                if ((object.ReferenceEquals(this.SucursalField, value) != true))
                {
                    this.SucursalField = value;
                    this.RaisePropertyChanged("Sucursal");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "PropostasCriadas", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class PropostasCriadas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long PropostaFinalField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long PropostaInicialField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SucessoField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensagem
        {
            get
            {
                return this.MensagemField;
            }
            set
            {
                if ((object.ReferenceEquals(this.MensagemField, value) != true))
                {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long PropostaFinal
        {
            get
            {
                return this.PropostaFinalField;
            }
            set
            {
                if ((this.PropostaFinalField.Equals(value) != true))
                {
                    this.PropostaFinalField = value;
                    this.RaisePropertyChanged("PropostaFinal");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long PropostaInicial
        {
            get
            {
                return this.PropostaInicialField;
            }
            set
            {
                if ((this.PropostaInicialField.Equals(value) != true))
                {
                    this.PropostaInicialField = value;
                    this.RaisePropertyChanged("PropostaInicial");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Sucesso
        {
            get
            {
                return this.SucessoField;
            }
            set
            {
                if ((this.SucessoField.Equals(value) != true))
                {
                    this.SucessoField = value;
                    this.RaisePropertyChanged("Sucesso");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "PropostaErro", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class PropostaErro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                if ((this.IdField.Equals(value) != true))
                {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensagem
        {
            get
            {
                return this.MensagemField;
            }
            set
            {
                if ((object.ReferenceEquals(this.MensagemField, value) != true))
                {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "InfoProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class InfoProposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AnalistaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<EnumDominioAtributo, string> AtributosField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CPFSeguradoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataCriacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DataDigitalizacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DataPrimeiraAnaliseField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DataProtocoloField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescrStatusField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdSchemaVersaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MatriculaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModeloField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeSeguradoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumPendenciaNaoResolvidaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumPendenciaRespondidaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NumPropField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrigemField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StatusProposta StatusField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EnumStatusEmissaoKit StatusEmissaoKitField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SucursalField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TempoRegularizacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TempoTranscorridoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ValorTotalAcumulacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ValorTotalContribuicaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ValorTotalRiscoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VersaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XmlPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _CPFSeguradoField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Analista
        {
            get
            {
                return this.AnalistaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.AnalistaField, value) != true))
                {
                    this.AnalistaField = value;
                    this.RaisePropertyChanged("Analista");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<EnumDominioAtributo, string> Atributos
        {
            get
            {
                return this.AtributosField;
            }
            set
            {
                if ((object.ReferenceEquals(this.AtributosField, value) != true))
                {
                    this.AtributosField = value;
                    this.RaisePropertyChanged("Atributos");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CPFSegurado
        {
            get
            {
                return this.CPFSeguradoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.CPFSeguradoField, value) != true))
                {
                    this.CPFSeguradoField = value;
                    this.RaisePropertyChanged("CPFSegurado");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataCriacao
        {
            get
            {
                return this.DataCriacaoField;
            }
            set
            {
                if ((this.DataCriacaoField.Equals(value) != true))
                {
                    this.DataCriacaoField = value;
                    this.RaisePropertyChanged("DataCriacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DataDigitalizacao
        {
            get
            {
                return this.DataDigitalizacaoField;
            }
            set
            {
                if ((this.DataDigitalizacaoField.Equals(value) != true))
                {
                    this.DataDigitalizacaoField = value;
                    this.RaisePropertyChanged("DataDigitalizacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DataPrimeiraAnalise
        {
            get
            {
                return this.DataPrimeiraAnaliseField;
            }
            set
            {
                if ((this.DataPrimeiraAnaliseField.Equals(value) != true))
                {
                    this.DataPrimeiraAnaliseField = value;
                    this.RaisePropertyChanged("DataPrimeiraAnalise");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DataProtocolo
        {
            get
            {
                return this.DataProtocoloField;
            }
            set
            {
                if ((this.DataProtocoloField.Equals(value) != true))
                {
                    this.DataProtocoloField = value;
                    this.RaisePropertyChanged("DataProtocolo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescrStatus
        {
            get
            {
                return this.DescrStatusField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescrStatusField, value) != true))
                {
                    this.DescrStatusField = value;
                    this.RaisePropertyChanged("DescrStatus");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdSchemaVersao
        {
            get
            {
                return this.IdSchemaVersaoField;
            }
            set
            {
                if ((this.IdSchemaVersaoField.Equals(value) != true))
                {
                    this.IdSchemaVersaoField = value;
                    this.RaisePropertyChanged("IdSchemaVersao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Matricula
        {
            get
            {
                return this.MatriculaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.MatriculaField, value) != true))
                {
                    this.MatriculaField = value;
                    this.RaisePropertyChanged("Matricula");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modelo
        {
            get
            {
                return this.ModeloField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ModeloField, value) != true))
                {
                    this.ModeloField = value;
                    this.RaisePropertyChanged("Modelo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeSegurado
        {
            get
            {
                return this.NomeSeguradoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.NomeSeguradoField, value) != true))
                {
                    this.NomeSeguradoField = value;
                    this.RaisePropertyChanged("NomeSegurado");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumPendenciaNaoResolvida
        {
            get
            {
                return this.NumPendenciaNaoResolvidaField;
            }
            set
            {
                if ((this.NumPendenciaNaoResolvidaField.Equals(value) != true))
                {
                    this.NumPendenciaNaoResolvidaField = value;
                    this.RaisePropertyChanged("NumPendenciaNaoResolvida");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumPendenciaRespondida
        {
            get
            {
                return this.NumPendenciaRespondidaField;
            }
            set
            {
                if ((this.NumPendenciaRespondidaField.Equals(value) != true))
                {
                    this.NumPendenciaRespondidaField = value;
                    this.RaisePropertyChanged("NumPendenciaRespondida");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NumProp
        {
            get
            {
                return this.NumPropField;
            }
            set
            {
                if ((this.NumPropField.Equals(value) != true))
                {
                    this.NumPropField = value;
                    this.RaisePropertyChanged("NumProp");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Origem
        {
            get
            {
                return this.OrigemField;
            }
            set
            {
                if ((object.ReferenceEquals(this.OrigemField, value) != true))
                {
                    this.OrigemField = value;
                    this.RaisePropertyChanged("Origem");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public StatusProposta Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                if ((object.ReferenceEquals(this.StatusField, value) != true))
                {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public EnumStatusEmissaoKit StatusEmissaoKit
        {
            get
            {
                return this.StatusEmissaoKitField;
            }
            set
            {
                if ((this.StatusEmissaoKitField.Equals(value) != true))
                {
                    this.StatusEmissaoKitField = value;
                    this.RaisePropertyChanged("StatusEmissaoKit");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sucursal
        {
            get
            {
                return this.SucursalField;
            }
            set
            {
                if ((object.ReferenceEquals(this.SucursalField, value) != true))
                {
                    this.SucursalField = value;
                    this.RaisePropertyChanged("Sucursal");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TempoRegularizacao
        {
            get
            {
                return this.TempoRegularizacaoField;
            }
            set
            {
                if ((this.TempoRegularizacaoField.Equals(value) != true))
                {
                    this.TempoRegularizacaoField = value;
                    this.RaisePropertyChanged("TempoRegularizacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TempoTranscorrido
        {
            get
            {
                return this.TempoTranscorridoField;
            }
            set
            {
                if ((this.TempoTranscorridoField.Equals(value) != true))
                {
                    this.TempoTranscorridoField = value;
                    this.RaisePropertyChanged("TempoTranscorrido");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ValorTotalAcumulacao
        {
            get
            {
                return this.ValorTotalAcumulacaoField;
            }
            set
            {
                if ((this.ValorTotalAcumulacaoField.Equals(value) != true))
                {
                    this.ValorTotalAcumulacaoField = value;
                    this.RaisePropertyChanged("ValorTotalAcumulacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ValorTotalContribuicao
        {
            get
            {
                return this.ValorTotalContribuicaoField;
            }
            set
            {
                if ((this.ValorTotalContribuicaoField.Equals(value) != true))
                {
                    this.ValorTotalContribuicaoField = value;
                    this.RaisePropertyChanged("ValorTotalContribuicao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ValorTotalRisco
        {
            get
            {
                return this.ValorTotalRiscoField;
            }
            set
            {
                if ((this.ValorTotalRiscoField.Equals(value) != true))
                {
                    this.ValorTotalRiscoField = value;
                    this.RaisePropertyChanged("ValorTotalRisco");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Versao
        {
            get
            {
                return this.VersaoField;
            }
            set
            {
                if ((this.VersaoField.Equals(value) != true))
                {
                    this.VersaoField = value;
                    this.RaisePropertyChanged("Versao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlProposta
        {
            get
            {
                return this.XmlPropostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.XmlPropostaField, value) != true))
                {
                    this.XmlPropostaField = value;
                    this.RaisePropertyChanged("XmlProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _CPFSegurado
        {
            get
            {
                return this._CPFSeguradoField;
            }
            set
            {
                if ((object.ReferenceEquals(this._CPFSeguradoField, value) != true))
                {
                    this._CPFSeguradoField = value;
                    this.RaisePropertyChanged("_CPFSegurado");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "StatusProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class StatusProposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataAlteracaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NumPropsField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NumTotalPropsField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrdenacaoCicloField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SolicitanteField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SolicitanteNomeField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EnumStatusProposta StatusField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataAlteracao
        {
            get
            {
                return this.DataAlteracaoField;
            }
            set
            {
                if ((this.DataAlteracaoField.Equals(value) != true))
                {
                    this.DataAlteracaoField = value;
                    this.RaisePropertyChanged("DataAlteracao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NumProps
        {
            get
            {
                return this.NumPropsField;
            }
            set
            {
                if ((this.NumPropsField.Equals(value) != true))
                {
                    this.NumPropsField = value;
                    this.RaisePropertyChanged("NumProps");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NumTotalProps
        {
            get
            {
                return this.NumTotalPropsField;
            }
            set
            {
                if ((this.NumTotalPropsField.Equals(value) != true))
                {
                    this.NumTotalPropsField = value;
                    this.RaisePropertyChanged("NumTotalProps");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Operacao
        {
            get
            {
                return this.OperacaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.OperacaoField, value) != true))
                {
                    this.OperacaoField = value;
                    this.RaisePropertyChanged("Operacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrdenacaoCiclo
        {
            get
            {
                return this.OrdenacaoCicloField;
            }
            set
            {
                if ((this.OrdenacaoCicloField.Equals(value) != true))
                {
                    this.OrdenacaoCicloField = value;
                    this.RaisePropertyChanged("OrdenacaoCiclo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Solicitante
        {
            get
            {
                return this.SolicitanteField;
            }
            set
            {
                if ((object.ReferenceEquals(this.SolicitanteField, value) != true))
                {
                    this.SolicitanteField = value;
                    this.RaisePropertyChanged("Solicitante");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SolicitanteNome
        {
            get
            {
                return this.SolicitanteNomeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.SolicitanteNomeField, value) != true))
                {
                    this.SolicitanteNomeField = value;
                    this.RaisePropertyChanged("SolicitanteNome");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EnumStatusProposta Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                if ((this.StatusField.Equals(value) != true))
                {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EnumDominioAtributo", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Model")]
    public enum EnumDominioAtributo : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Reanalise = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Em_Edicao = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Analise_Pos_Recusa = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Id_PreAutorizacao_Cartao = 4,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EnumStatusEmissaoKit", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Model")]
    public enum EnumStatusEmissaoKit : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Sem_Informacoes = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Recusado = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Emitido = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Sem_Kit = 3,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "CriticaProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class CriticaProposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AlcadaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodCriticaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private CriticaPendencia[] CriticaPendenciaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataCriticaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdCriticaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdHistoricoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NumPropField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ObservacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrigemField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResolvidoField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Alcada
        {
            get
            {
                return this.AlcadaField;
            }
            set
            {
                if ((this.AlcadaField.Equals(value) != true))
                {
                    this.AlcadaField = value;
                    this.RaisePropertyChanged("Alcada");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodCritica
        {
            get
            {
                return this.CodCriticaField;
            }
            set
            {
                if ((this.CodCriticaField.Equals(value) != true))
                {
                    this.CodCriticaField = value;
                    this.RaisePropertyChanged("CodCritica");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public CriticaPendencia[] CriticaPendencia
        {
            get
            {
                return this.CriticaPendenciaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.CriticaPendenciaField, value) != true))
                {
                    this.CriticaPendenciaField = value;
                    this.RaisePropertyChanged("CriticaPendencia");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataCritica
        {
            get
            {
                return this.DataCriticaField;
            }
            set
            {
                if ((this.DataCriticaField.Equals(value) != true))
                {
                    this.DataCriticaField = value;
                    this.RaisePropertyChanged("DataCritica");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao
        {
            get
            {
                return this.DescricaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true))
                {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCritica
        {
            get
            {
                return this.IdCriticaField;
            }
            set
            {
                if ((this.IdCriticaField.Equals(value) != true))
                {
                    this.IdCriticaField = value;
                    this.RaisePropertyChanged("IdCritica");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IdHistorico
        {
            get
            {
                return this.IdHistoricoField;
            }
            set
            {
                if ((this.IdHistoricoField.Equals(value) != true))
                {
                    this.IdHistoricoField = value;
                    this.RaisePropertyChanged("IdHistorico");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NumProp
        {
            get
            {
                return this.NumPropField;
            }
            set
            {
                if ((this.NumPropField.Equals(value) != true))
                {
                    this.NumPropField = value;
                    this.RaisePropertyChanged("NumProp");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Observacao
        {
            get
            {
                return this.ObservacaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ObservacaoField, value) != true))
                {
                    this.ObservacaoField = value;
                    this.RaisePropertyChanged("Observacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Origem
        {
            get
            {
                return this.OrigemField;
            }
            set
            {
                if ((object.ReferenceEquals(this.OrigemField, value) != true))
                {
                    this.OrigemField = value;
                    this.RaisePropertyChanged("Origem");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Resolvido
        {
            get
            {
                return this.ResolvidoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ResolvidoField, value) != true))
                {
                    this.ResolvidoField = value;
                    this.RaisePropertyChanged("Resolvido");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "HistoricoProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class HistoricoProposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DtAlteracaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdHistoricoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MinutosTranscorridosField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NumPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EnumOperacaoHistorico OperacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SolicitanteField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XmlPropostaField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DtAlteracao
        {
            get
            {
                return this.DtAlteracaoField;
            }
            set
            {
                if ((this.DtAlteracaoField.Equals(value) != true))
                {
                    this.DtAlteracaoField = value;
                    this.RaisePropertyChanged("DtAlteracao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IdHistorico
        {
            get
            {
                return this.IdHistoricoField;
            }
            set
            {
                if ((this.IdHistoricoField.Equals(value) != true))
                {
                    this.IdHistoricoField = value;
                    this.RaisePropertyChanged("IdHistorico");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MinutosTranscorridos
        {
            get
            {
                return this.MinutosTranscorridosField;
            }
            set
            {
                if ((this.MinutosTranscorridosField.Equals(value) != true))
                {
                    this.MinutosTranscorridosField = value;
                    this.RaisePropertyChanged("MinutosTranscorridos");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NumProposta
        {
            get
            {
                return this.NumPropostaField;
            }
            set
            {
                if ((this.NumPropostaField.Equals(value) != true))
                {
                    this.NumPropostaField = value;
                    this.RaisePropertyChanged("NumProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EnumOperacaoHistorico Operacao
        {
            get
            {
                return this.OperacaoField;
            }
            set
            {
                if ((this.OperacaoField.Equals(value) != true))
                {
                    this.OperacaoField = value;
                    this.RaisePropertyChanged("Operacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Solicitante
        {
            get
            {
                return this.SolicitanteField;
            }
            set
            {
                if ((object.ReferenceEquals(this.SolicitanteField, value) != true))
                {
                    this.SolicitanteField = value;
                    this.RaisePropertyChanged("Solicitante");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatusProposta
        {
            get
            {
                return this.StatusPropostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.StatusPropostaField, value) != true))
                {
                    this.StatusPropostaField = value;
                    this.RaisePropertyChanged("StatusProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlProposta
        {
            get
            {
                return this.XmlPropostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.XmlPropostaField, value) != true))
                {
                    this.XmlPropostaField = value;
                    this.RaisePropertyChanged("XmlProposta");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EnumOperacaoHistorico", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Model")]
    public enum EnumOperacaoHistorico : short
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inclusão = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fila = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Alteração_Dados = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Alteração_Status = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inclusão_Críticas_Sistema = 5,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Alteração_Analista = 6,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inclusão_Crítica_Deari = 7,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Retirar_Recusa = 8,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Retirar_Aceite = 9,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inserir_Atributo = 10,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "HistoricoDataProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class HistoricoDataProposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DtAlteracaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdHistoricoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdStatusPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal MinutosTranscorridosField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NumPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EnumOperacaoHistorico OperacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SolicitanteField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XmlPropostaField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DtAlteracao
        {
            get
            {
                return this.DtAlteracaoField;
            }
            set
            {
                if ((this.DtAlteracaoField.Equals(value) != true))
                {
                    this.DtAlteracaoField = value;
                    this.RaisePropertyChanged("DtAlteracao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IdHistorico
        {
            get
            {
                return this.IdHistoricoField;
            }
            set
            {
                if ((this.IdHistoricoField.Equals(value) != true))
                {
                    this.IdHistoricoField = value;
                    this.RaisePropertyChanged("IdHistorico");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdStatusProposta
        {
            get
            {
                return this.IdStatusPropostaField;
            }
            set
            {
                if ((this.IdStatusPropostaField.Equals(value) != true))
                {
                    this.IdStatusPropostaField = value;
                    this.RaisePropertyChanged("IdStatusProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal MinutosTranscorridos
        {
            get
            {
                return this.MinutosTranscorridosField;
            }
            set
            {
                if ((this.MinutosTranscorridosField.Equals(value) != true))
                {
                    this.MinutosTranscorridosField = value;
                    this.RaisePropertyChanged("MinutosTranscorridos");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NumProposta
        {
            get
            {
                return this.NumPropostaField;
            }
            set
            {
                if ((this.NumPropostaField.Equals(value) != true))
                {
                    this.NumPropostaField = value;
                    this.RaisePropertyChanged("NumProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EnumOperacaoHistorico Operacao
        {
            get
            {
                return this.OperacaoField;
            }
            set
            {
                if ((this.OperacaoField.Equals(value) != true))
                {
                    this.OperacaoField = value;
                    this.RaisePropertyChanged("Operacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Solicitante
        {
            get
            {
                return this.SolicitanteField;
            }
            set
            {
                if ((object.ReferenceEquals(this.SolicitanteField, value) != true))
                {
                    this.SolicitanteField = value;
                    this.RaisePropertyChanged("Solicitante");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatusProposta
        {
            get
            {
                return this.StatusPropostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.StatusPropostaField, value) != true))
                {
                    this.StatusPropostaField = value;
                    this.RaisePropertyChanged("StatusProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlProposta
        {
            get
            {
                return this.XmlPropostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.XmlPropostaField, value) != true))
                {
                    this.XmlPropostaField = value;
                    this.RaisePropertyChanged("XmlProposta");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Parecer", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class Parecer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AnalistaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataCriacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdSchemaVersaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EnumTipoParecer IdTipoParecerField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NumPropostaField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Analista
        {
            get
            {
                return this.AnalistaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.AnalistaField, value) != true))
                {
                    this.AnalistaField = value;
                    this.RaisePropertyChanged("Analista");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataCriacao
        {
            get
            {
                return this.DataCriacaoField;
            }
            set
            {
                if ((this.DataCriacaoField.Equals(value) != true))
                {
                    this.DataCriacaoField = value;
                    this.RaisePropertyChanged("DataCriacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao
        {
            get
            {
                return this.DescricaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true))
                {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                if ((this.IdField.Equals(value) != true))
                {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdSchemaVersao
        {
            get
            {
                return this.IdSchemaVersaoField;
            }
            set
            {
                if ((this.IdSchemaVersaoField.Equals(value) != true))
                {
                    this.IdSchemaVersaoField = value;
                    this.RaisePropertyChanged("IdSchemaVersao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EnumTipoParecer IdTipoParecer
        {
            get
            {
                return this.IdTipoParecerField;
            }
            set
            {
                if ((this.IdTipoParecerField.Equals(value) != true))
                {
                    this.IdTipoParecerField = value;
                    this.RaisePropertyChanged("IdTipoParecer");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NumProposta
        {
            get
            {
                return this.NumPropostaField;
            }
            set
            {
                if ((this.NumPropostaField.Equals(value) != true))
                {
                    this.NumPropostaField = value;
                    this.RaisePropertyChanged("NumProposta");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "EnumTipoProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Model")]
    public enum EnumTipoProposta : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        TODOS = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        INDIVIDUAL = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        VG = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        ESIM = 3,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        PRIVATE = 4,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        ESIM_INDIVIDUAL = 7,
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "InfoPropostaAnalise", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class InfoPropostaAnalise : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AlcadaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AnalistaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataCriacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DataDigitalizacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescStatusField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DtProtocoloField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdSchemaVersaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModeloField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumPendenciaNaoResolvidaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumPendenciaRespondidaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NumPropField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumRespNLidasField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EnumStatusProposta StatusField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SucursalField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TempoTranscorridoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EnumTipoProposta TipoPropostaField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Alcada
        {
            get
            {
                return this.AlcadaField;
            }
            set
            {
                if ((this.AlcadaField.Equals(value) != true))
                {
                    this.AlcadaField = value;
                    this.RaisePropertyChanged("Alcada");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Analista
        {
            get
            {
                return this.AnalistaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.AnalistaField, value) != true))
                {
                    this.AnalistaField = value;
                    this.RaisePropertyChanged("Analista");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataCriacao
        {
            get
            {
                return this.DataCriacaoField;
            }
            set
            {
                if ((this.DataCriacaoField.Equals(value) != true))
                {
                    this.DataCriacaoField = value;
                    this.RaisePropertyChanged("DataCriacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DataDigitalizacao
        {
            get
            {
                return this.DataDigitalizacaoField;
            }
            set
            {
                if ((this.DataDigitalizacaoField.Equals(value) != true))
                {
                    this.DataDigitalizacaoField = value;
                    this.RaisePropertyChanged("DataDigitalizacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescStatus
        {
            get
            {
                return this.DescStatusField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescStatusField, value) != true))
                {
                    this.DescStatusField = value;
                    this.RaisePropertyChanged("DescStatus");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DtProtocolo
        {
            get
            {
                return this.DtProtocoloField;
            }
            set
            {
                if ((this.DtProtocoloField.Equals(value) != true))
                {
                    this.DtProtocoloField = value;
                    this.RaisePropertyChanged("DtProtocolo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdSchemaVersao
        {
            get
            {
                return this.IdSchemaVersaoField;
            }
            set
            {
                if ((this.IdSchemaVersaoField.Equals(value) != true))
                {
                    this.IdSchemaVersaoField = value;
                    this.RaisePropertyChanged("IdSchemaVersao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modelo
        {
            get
            {
                return this.ModeloField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ModeloField, value) != true))
                {
                    this.ModeloField = value;
                    this.RaisePropertyChanged("Modelo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumPendenciaNaoResolvida
        {
            get
            {
                return this.NumPendenciaNaoResolvidaField;
            }
            set
            {
                if ((this.NumPendenciaNaoResolvidaField.Equals(value) != true))
                {
                    this.NumPendenciaNaoResolvidaField = value;
                    this.RaisePropertyChanged("NumPendenciaNaoResolvida");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumPendenciaRespondida
        {
            get
            {
                return this.NumPendenciaRespondidaField;
            }
            set
            {
                if ((this.NumPendenciaRespondidaField.Equals(value) != true))
                {
                    this.NumPendenciaRespondidaField = value;
                    this.RaisePropertyChanged("NumPendenciaRespondida");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NumProp
        {
            get
            {
                return this.NumPropField;
            }
            set
            {
                if ((this.NumPropField.Equals(value) != true))
                {
                    this.NumPropField = value;
                    this.RaisePropertyChanged("NumProp");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumRespNLidas
        {
            get
            {
                return this.NumRespNLidasField;
            }
            set
            {
                if ((this.NumRespNLidasField.Equals(value) != true))
                {
                    this.NumRespNLidasField = value;
                    this.RaisePropertyChanged("NumRespNLidas");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EnumStatusProposta Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                if ((this.StatusField.Equals(value) != true))
                {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sucursal
        {
            get
            {
                return this.SucursalField;
            }
            set
            {
                if ((object.ReferenceEquals(this.SucursalField, value) != true))
                {
                    this.SucursalField = value;
                    this.RaisePropertyChanged("Sucursal");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double TempoTranscorrido
        {
            get
            {
                return this.TempoTranscorridoField;
            }
            set
            {
                if ((this.TempoTranscorridoField.Equals(value) != true))
                {
                    this.TempoTranscorridoField = value;
                    this.RaisePropertyChanged("TempoTranscorrido");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EnumTipoProposta TipoProposta
        {
            get
            {
                return this.TipoPropostaField;
            }
            set
            {
                if ((this.TipoPropostaField.Equals(value) != true))
                {
                    this.TipoPropostaField = value;
                    this.RaisePropertyChanged("TipoProposta");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "InfoPropostaResumo", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class InfoPropostaResumo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataDigitalizaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModeloField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NumPropField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UnidadeField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataDigitaliza
        {
            get
            {
                return this.DataDigitalizaField;
            }
            set
            {
                if ((this.DataDigitalizaField.Equals(value) != true))
                {
                    this.DataDigitalizaField = value;
                    this.RaisePropertyChanged("DataDigitaliza");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modelo
        {
            get
            {
                return this.ModeloField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ModeloField, value) != true))
                {
                    this.ModeloField = value;
                    this.RaisePropertyChanged("Modelo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NumProp
        {
            get
            {
                return this.NumPropField;
            }
            set
            {
                if ((this.NumPropField.Equals(value) != true))
                {
                    this.NumPropField = value;
                    this.RaisePropertyChanged("NumProp");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Unidade
        {
            get
            {
                return this.UnidadeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.UnidadeField, value) != true))
                {
                    this.UnidadeField = value;
                    this.RaisePropertyChanged("Unidade");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "InfoIndiceProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class InfoIndiceProposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CPFSeguradoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MatriculaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeSeguradoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VigenciaField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CPFSegurado
        {
            get
            {
                return this.CPFSeguradoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.CPFSeguradoField, value) != true))
                {
                    this.CPFSeguradoField = value;
                    this.RaisePropertyChanged("CPFSegurado");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Matricula
        {
            get
            {
                return this.MatriculaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.MatriculaField, value) != true))
                {
                    this.MatriculaField = value;
                    this.RaisePropertyChanged("Matricula");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeSegurado
        {
            get
            {
                return this.NomeSeguradoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.NomeSeguradoField, value) != true))
                {
                    this.NomeSeguradoField = value;
                    this.RaisePropertyChanged("NomeSegurado");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Vigencia
        {
            get
            {
                return this.VigenciaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.VigenciaField, value) != true))
                {
                    this.VigenciaField = value;
                    this.RaisePropertyChanged("Vigencia");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SchemaProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class SchemaProposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descricao
        {
            get
            {
                return this.DescricaoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true))
                {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                if ((this.IdField.Equals(value) != true))
                {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome
        {
            get
            {
                return this.NomeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.NomeField, value) != true))
                {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "FiltrosProponente", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class FiltrosProponente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CPFField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<int, string> FiltrosChaveValorField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long MatriculaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long CPF
        {
            get
            {
                return this.CPFField;
            }
            set
            {
                if ((this.CPFField.Equals(value) != true))
                {
                    this.CPFField = value;
                    this.RaisePropertyChanged("CPF");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<int, string> FiltrosChaveValor
        {
            get
            {
                return this.FiltrosChaveValorField;
            }
            set
            {
                if ((object.ReferenceEquals(this.FiltrosChaveValorField, value) != true))
                {
                    this.FiltrosChaveValorField = value;
                    this.RaisePropertyChanged("FiltrosChaveValor");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Matricula
        {
            get
            {
                return this.MatriculaField;
            }
            set
            {
                if ((this.MatriculaField.Equals(value) != true))
                {
                    this.MatriculaField = value;
                    this.RaisePropertyChanged("Matricula");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome
        {
            get
            {
                return this.NomeField;
            }
            set
            {
                if ((object.ReferenceEquals(this.NomeField, value) != true))
                {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "FiltrosDadosProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class FiltrosDadosProposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataFinalField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataInicialField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<int, string> FiltrosChaveValorField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModeloPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> NumeroPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long OrigemVendaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EnumStatusProposta[] StatusField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataFinal
        {
            get
            {
                return this.DataFinalField;
            }
            set
            {
                if ((this.DataFinalField.Equals(value) != true))
                {
                    this.DataFinalField = value;
                    this.RaisePropertyChanged("DataFinal");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataInicial
        {
            get
            {
                return this.DataInicialField;
            }
            set
            {
                if ((this.DataInicialField.Equals(value) != true))
                {
                    this.DataInicialField = value;
                    this.RaisePropertyChanged("DataInicial");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<int, string> FiltrosChaveValor
        {
            get
            {
                return this.FiltrosChaveValorField;
            }
            set
            {
                if ((object.ReferenceEquals(this.FiltrosChaveValorField, value) != true))
                {
                    this.FiltrosChaveValorField = value;
                    this.RaisePropertyChanged("FiltrosChaveValor");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModeloProposta
        {
            get
            {
                return this.ModeloPropostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ModeloPropostaField, value) != true))
                {
                    this.ModeloPropostaField = value;
                    this.RaisePropertyChanged("ModeloProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> NumeroProposta
        {
            get
            {
                return this.NumeroPropostaField;
            }
            set
            {
                if ((this.NumeroPropostaField.Equals(value) != true))
                {
                    this.NumeroPropostaField = value;
                    this.RaisePropertyChanged("NumeroProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long OrigemVenda
        {
            get
            {
                return this.OrigemVendaField;
            }
            set
            {
                if ((this.OrigemVendaField.Equals(value) != true))
                {
                    this.OrigemVendaField = value;
                    this.RaisePropertyChanged("OrigemVenda");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EnumStatusProposta[] Status
        {
            get
            {
                return this.StatusField;
            }
            set
            {
                if ((object.ReferenceEquals(this.StatusField, value) != true))
                {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "InfoPropostaCorretor", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class InfoPropostaCorretor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CPFProponenteField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataProtocoloField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long MatriculaProponenteField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModeloPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeProponenteField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NumeroPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PendenciaProposta[] PendenciasField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EnumStatusProposta StatusPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SucursalField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ValorTotalAcumulacaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ValorTotalContribuicaoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ValorTotalRiscoField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long CPFProponente
        {
            get
            {
                return this.CPFProponenteField;
            }
            set
            {
                if ((this.CPFProponenteField.Equals(value) != true))
                {
                    this.CPFProponenteField = value;
                    this.RaisePropertyChanged("CPFProponente");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DataProtocolo
        {
            get
            {
                return this.DataProtocoloField;
            }
            set
            {
                if ((this.DataProtocoloField.Equals(value) != true))
                {
                    this.DataProtocoloField = value;
                    this.RaisePropertyChanged("DataProtocolo");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long MatriculaProponente
        {
            get
            {
                return this.MatriculaProponenteField;
            }
            set
            {
                if ((this.MatriculaProponenteField.Equals(value) != true))
                {
                    this.MatriculaProponenteField = value;
                    this.RaisePropertyChanged("MatriculaProponente");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModeloProposta
        {
            get
            {
                return this.ModeloPropostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ModeloPropostaField, value) != true))
                {
                    this.ModeloPropostaField = value;
                    this.RaisePropertyChanged("ModeloProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProponente
        {
            get
            {
                return this.NomeProponenteField;
            }
            set
            {
                if ((object.ReferenceEquals(this.NomeProponenteField, value) != true))
                {
                    this.NomeProponenteField = value;
                    this.RaisePropertyChanged("NomeProponente");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NumeroProposta
        {
            get
            {
                return this.NumeroPropostaField;
            }
            set
            {
                if ((this.NumeroPropostaField.Equals(value) != true))
                {
                    this.NumeroPropostaField = value;
                    this.RaisePropertyChanged("NumeroProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public PendenciaProposta[] Pendencias
        {
            get
            {
                return this.PendenciasField;
            }
            set
            {
                if ((object.ReferenceEquals(this.PendenciasField, value) != true))
                {
                    this.PendenciasField = value;
                    this.RaisePropertyChanged("Pendencias");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EnumStatusProposta StatusProposta
        {
            get
            {
                return this.StatusPropostaField;
            }
            set
            {
                if ((this.StatusPropostaField.Equals(value) != true))
                {
                    this.StatusPropostaField = value;
                    this.RaisePropertyChanged("StatusProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sucursal
        {
            get
            {
                return this.SucursalField;
            }
            set
            {
                if ((object.ReferenceEquals(this.SucursalField, value) != true))
                {
                    this.SucursalField = value;
                    this.RaisePropertyChanged("Sucursal");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ValorTotalAcumulacao
        {
            get
            {
                return this.ValorTotalAcumulacaoField;
            }
            set
            {
                if ((this.ValorTotalAcumulacaoField.Equals(value) != true))
                {
                    this.ValorTotalAcumulacaoField = value;
                    this.RaisePropertyChanged("ValorTotalAcumulacao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ValorTotalContribuicao
        {
            get
            {
                return this.ValorTotalContribuicaoField;
            }
            set
            {
                if ((this.ValorTotalContribuicaoField.Equals(value) != true))
                {
                    this.ValorTotalContribuicaoField = value;
                    this.RaisePropertyChanged("ValorTotalContribuicao");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ValorTotalRisco
        {
            get
            {
                return this.ValorTotalRiscoField;
            }
            set
            {
                if ((this.ValorTotalRiscoField.Equals(value) != true))
                {
                    this.ValorTotalRiscoField = value;
                    this.RaisePropertyChanged("ValorTotalRisco");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "PendenciaProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class PendenciaProposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoPendenciaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DestinoField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IDPendenciaField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DescricaoPendencia
        {
            get
            {
                return this.DescricaoPendenciaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DescricaoPendenciaField, value) != true))
                {
                    this.DescricaoPendenciaField = value;
                    this.RaisePropertyChanged("DescricaoPendencia");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Destino
        {
            get
            {
                return this.DestinoField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DestinoField, value) != true))
                {
                    this.DestinoField = value;
                    this.RaisePropertyChanged("Destino");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IDPendencia
        {
            get
            {
                return this.IDPendenciaField;
            }
            set
            {
                if ((this.IDPendenciaField.Equals(value) != true))
                {
                    this.IDPendenciaField = value;
                    this.RaisePropertyChanged("IDPendencia");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "ListaIntervaloPropostas", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class ListaIntervaloPropostas : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IntervaloProposta[] ListaIntervalosPropostaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long QuantidadeRetornadaField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool TotalmenteAtendidoField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public IntervaloProposta[] ListaIntervalosProposta
        {
            get
            {
                return this.ListaIntervalosPropostaField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ListaIntervalosPropostaField, value) != true))
                {
                    this.ListaIntervalosPropostaField = value;
                    this.RaisePropertyChanged("ListaIntervalosProposta");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensagem
        {
            get
            {
                return this.MensagemField;
            }
            set
            {
                if ((object.ReferenceEquals(this.MensagemField, value) != true))
                {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long QuantidadeRetornada
        {
            get
            {
                return this.QuantidadeRetornadaField;
            }
            set
            {
                if ((this.QuantidadeRetornadaField.Equals(value) != true))
                {
                    this.QuantidadeRetornadaField = value;
                    this.RaisePropertyChanged("QuantidadeRetornada");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool TotalmenteAtendido
        {
            get
            {
                return this.TotalmenteAtendidoField;
            }
            set
            {
                if ((this.TotalmenteAtendidoField.Equals(value) != true))
                {
                    this.TotalmenteAtendidoField = value;
                    this.RaisePropertyChanged("TotalmenteAtendido");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IntervaloProposta", Namespace = "http://schemas.datacontract.org/2004/07/Mongeral.Propostas.Gerenciador.DAL.Contra" +
        "ct")]
    [System.SerializableAttribute()]
    public partial class IntervaloProposta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long PropostaFinalField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long PropostaInicialField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long PropostaFinal
        {
            get
            {
                return this.PropostaFinalField;
            }
            set
            {
                if ((this.PropostaFinalField.Equals(value) != true))
                {
                    this.PropostaFinalField = value;
                    this.RaisePropertyChanged("PropostaFinal");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public long PropostaInicial
        {
            get
            {
                return this.PropostaInicialField;
            }
            set
            {
                if ((this.PropostaInicialField.Equals(value) != true))
                {
                    this.PropostaInicialField = value;
                    this.RaisePropertyChanged("PropostaInicial");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://ESB.Mongeral/GerirProposta", ConfigurationName = "ESB.GerirProposta.IGerirProposta")]
    public interface IGerirProposta
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/SalvarVersaoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/SalvarVersaoPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/SalvarVersaoPropostaValidacaoExc" +
            "eptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno SalvarVersaoProposta(long numprop, string xml, string user, int idSchemaVersao, string analista);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/SalvarVersaoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/SalvarVersaoPropostaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> SalvarVersaoPropostaAsync(long numprop, string xml, string user, int idSchemaVersao, string analista);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPendencia", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPendenciaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPendenciaValidacaoExceptio" +
            "nFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        PendenciaResposta[] ListarPendencia(StatusPergunta status, long proposta, string destino, int idSchemaVersao, System.DateTime dtInicio, System.DateTime dtFim);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPendencia", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPendenciaResponse")]
        System.Threading.Tasks.Task<PendenciaResposta[]> ListarPendenciaAsync(StatusPergunta status, long proposta, string destino, int idSchemaVersao, System.DateTime dtInicio, System.DateTime dtFim);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarResposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarRespostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarRespostaValidacaoExcept" +
            "ionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno RegistrarResposta(long pendencia, long proposta, string resposta, string usuario, int IdSchemaVersao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarResposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarRespostaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> RegistrarRespostaAsync(long pendencia, long proposta, string resposta, string usuario, int IdSchemaVersao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarRecusa", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarRecusaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarRecusaValidacaoExceptio" +
            "nFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno RegistrarRecusa(long proposta, long idMotivo, string texto, string user);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarRecusa", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarRecusaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> RegistrarRecusaAsync(long proposta, long idMotivo, string texto, string user);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarCritica", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarCriticaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarCriticaValidacaoExcepti" +
            "onFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno RegistrarCritica(long proposta, CriticaXML xml, string solicitante, int IdSchemaVersao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarCritica", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarCriticaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> RegistrarCriticaAsync(long proposta, CriticaXML xml, string solicitante, int IdSchemaVersao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarPropostaValidacaoExcept" +
            "ionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno RegistrarProposta(long proposta, string xml, string strNamespace);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarPropostaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> RegistrarPropostaAsync(long proposta, string xml, string strNamespace);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarPropostaTmp", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarPropostaTmpResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarPropostaTmpValidacaoExc" +
            "eptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno RegistrarPropostaTmp(long proposta, string xml, string strNamespace);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarPropostaTmp", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarPropostaTmpResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> RegistrarPropostaTmpAsync(long proposta, string xml, string strNamespace);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarVersaoSchema", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarVersaoSchemaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarVersaoSchemaValidacaoExcep" +
            "tionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        VersaoSchema[] BuscarVersaoSchema(int versao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarVersaoSchema", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarVersaoSchemaResponse")]
        System.Threading.Tasks.Task<VersaoSchema[]> BuscarVersaoSchemaAsync(int versao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPendenciaRelacionada", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPendenciaRelacionadaRespon" +
            "se")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPendenciaRelacionadaValida" +
            "caoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        CriticaPendencia[] BuscarPendenciaRelacionada(long idHistorico, int idCritica);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPendenciaRelacionada", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPendenciaRelacionadaRespon" +
            "se")]
        System.Threading.Tasks.Task<CriticaPendencia[]> BuscarPendenciaRelacionadaAsync(long idHistorico, int idCritica);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPendenciaPorGrupo", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPendenciaPorGrupoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPendenciaPorGrupoValidacao" +
            "ExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        Criticas[] ListarPendenciaPorGrupo(int codGrupo, int codCritica);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPendenciaPorGrupo", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPendenciaPorGrupoResponse")]
        System.Threading.Tasks.Task<Criticas[]> ListarPendenciaPorGrupoAsync(int codGrupo, int codCritica);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoInfo", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoInfoValidacaoExcep" +
            "tionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        Metadado[] BuscarMetadadoInfo(string nmspace);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoInfo", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoInfoResponse")]
        System.Threading.Tasks.Task<Metadado[]> BuscarMetadadoInfoAsync(string nmspace);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPolitica", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPoliticaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPoliticaValidacaoException" +
            "Fault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        System.Collections.Generic.KeyValuePair<int, string> BuscarPolitica(string modelo, System.DateTime data, EnumTipoPolitica tipo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPolitica", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPoliticaResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> BuscarPoliticaAsync(string modelo, System.DateTime data, EnumTipoPolitica tipo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarStatusProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarStatusPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarStatusPropostaValidacaoEx" +
            "ceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno AlterarStatusProposta(long numProposta, int idSchemaVersao, string strNamespace, EnumStatusProposta statusPropostaDestino, string solicitante);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarStatusProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarStatusPropostaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> AlterarStatusPropostaAsync(long numProposta, int idSchemaVersao, string strNamespace, EnumStatusProposta statusPropostaDestino, string solicitante);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/EnviarParaConferencia", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/EnviarParaConferenciaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/EnviarParaConferenciaValidacaoEx" +
            "ceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno EnviarParaConferencia(long numProposta, int idSchemaVersao, string strNamespace, string solicitante);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/EnviarParaConferencia", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/EnviarParaConferenciaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> EnviarParaConferenciaAsync(long numProposta, int idSchemaVersao, string strNamespace, string solicitante);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarDescricaoPendencia", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarDescricaoPendenciaRespons" +
            "e")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarDescricaoPendenciaValidac" +
            "aoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno AlterarDescricaoPendencia(long pendencia, string descricao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarDescricaoPendencia", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarDescricaoPendenciaRespons" +
            "e")]
        System.Threading.Tasks.Task<EstruturaRetorno> AlterarDescricaoPendenciaAsync(long pendencia, string descricao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AceitarProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AceitarPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AceitarPropostaValidacaoExceptio" +
            "nFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetornoProtocolo AceitarProposta(string xmlProposta, long proposta, int idSchemaVersao, string solicitante, string descrParecer, bool aceiteAutomatico);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AceitarProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AceitarPropostaResponse")]
        System.Threading.Tasks.Task<EstruturaRetornoProtocolo> AceitarPropostaAsync(string xmlProposta, long proposta, int idSchemaVersao, string solicitante, string descrParecer, bool aceiteAutomatico);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RecusarProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RecusarPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RecusarPropostaValidacaoExceptio" +
            "nFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetornoProtocolo RecusarProposta(string xmlProposta, long proposta, int idSchemaVersao, string solicitante, string parceiro, string motivo, string[] emails);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RecusarProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RecusarPropostaResponse")]
        System.Threading.Tasks.Task<EstruturaRetornoProtocolo> RecusarPropostaAsync(string xmlProposta, long proposta, int idSchemaVersao, string solicitante, string parceiro, string motivo, string[] emails);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarDetalhePendencia", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarDetalhePendenciaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarDetalhePendenciaValidacaoE" +
            "xceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        PendenciaResposta BuscarDetalhePendencia(int idPendencia);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarDetalhePendencia", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarDetalhePendenciaResponse")]
        System.Threading.Tasks.Task<PendenciaResposta> BuscarDetalhePendenciaAsync(int idPendencia);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarStatusProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarStatusPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarStatusPropostaValidacao" +
            "ExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EnumStatusProposta VerificarStatusProposta(long numProposta, int idSchemaVersao, string strNamespace);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarStatusProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarStatusPropostaResponse")]
        System.Threading.Tasks.Task<EnumStatusProposta> VerificarStatusPropostaAsync(long numProposta, int idSchemaVersao, string strNamespace);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ExcluirResposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ExcluirRespostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ExcluirRespostaValidacaoExceptio" +
            "nFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno ExcluirResposta(int idPendencia);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ExcluirResposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ExcluirRespostaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> ExcluirRespostaAsync(int idPendencia);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoIdSchemaVersao", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoIdSchemaVersaoResp" +
            "onse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoIdSchemaVersaoVali" +
            "dacaoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        Metadado BuscarMetadadoIdSchemaVersao(long idSchemaVersao, EnumDominioMetadado metadado);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoIdSchemaVersao", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoIdSchemaVersaoResp" +
            "onse")]
        System.Threading.Tasks.Task<Metadado> BuscarMetadadoIdSchemaVersaoAsync(long idSchemaVersao, EnumDominioMetadado metadado);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoNamespace", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoNamespaceResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoNamespaceValidacao" +
            "ExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        Metadado BuscarMetadadoNamespace(string nmspace, EnumDominioMetadado metadado);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoNamespace", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarMetadadoNamespaceResponse")]
        System.Threading.Tasks.Task<Metadado> BuscarMetadadoNamespaceAsync(string nmspace, EnumDominioMetadado metadado);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/CriarExcecaoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/CriarExcecaoPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/CriarExcecaoPropostaValidacaoExc" +
            "eptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno CriarExcecaoProposta(long numProposta, int idSchemaVersao, string excecao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/CriarExcecaoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/CriarExcecaoPropostaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> CriarExcecaoPropostaAsync(long numProposta, int idSchemaVersao, string excecao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarSchemaProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarSchemaPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarSchemaPropostaValidacao" +
            "ExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno VerificarSchemaProposta(long idSchemaVersao, string xmlProp);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarSchemaProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarSchemaPropostaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> VerificarSchemaPropostaAsync(long idSchemaVersao, string xmlProp);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarModeloProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarModeloPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarModeloPropostaValidacaoExc" +
            "eptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        ModeloProposta[] ListarModeloProposta(string modelo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarModeloProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarModeloPropostaResponse")]
        System.Threading.Tasks.Task<ModeloProposta[]> ListarModeloPropostaAsync(string modelo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarOrigemProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarOrigemPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarOrigemPropostaValidacaoExc" +
            "eptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        string[] ListarOrigemProposta(System.Nullable<long> numeroProposta, System.Nullable<int> idSchema);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarOrigemProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarOrigemPropostaResponse")]
        System.Threading.Tasks.Task<string[]> ListarOrigemPropostaAsync(System.Nullable<long> numeroProposta, System.Nullable<int> idSchema);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ExisteProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ExistePropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ExistePropostaValidacaoException" +
            "Fault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        bool ExisteProposta(int idSchemaVersao, long numProposta);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ExisteProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ExistePropostaResponse")]
        System.Threading.Tasks.Task<bool> ExistePropostaAsync(int idSchemaVersao, long numProposta);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarSchemaNamespacePorModelo", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarSchemaNamespacePorModeloRe" +
            "sponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarSchemaNamespacePorModeloVa" +
            "lidacaoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        System.Collections.Generic.KeyValuePair<int, string> BuscarSchemaNamespacePorModelo(string modelo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarSchemaNamespacePorModelo", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarSchemaNamespacePorModeloRe" +
            "sponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> BuscarSchemaNamespacePorModeloAsync(string modelo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObtemElementosPorModelo", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObtemElementosPorModeloResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObtemElementosPorModeloValidacao" +
            "ExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        string[] ObtemElementosPorModelo(string modeloProposta, int versao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObtemElementosPorModelo", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObtemElementosPorModeloResponse")]
        System.Threading.Tasks.Task<string[]> ObtemElementosPorModeloAsync(string modeloProposta, int versao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarRespostaAutomatica", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarRespostaAutomaticaRespo" +
            "nse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarRespostaAutomaticaValid" +
            "acaoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno RegistrarRespostaAutomatica(long proposta, string resposta, string usuario, int idSchemaVersao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarRespostaAutomatica", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarRespostaAutomaticaRespo" +
            "nse")]
        System.Threading.Tasks.Task<EstruturaRetorno> RegistrarRespostaAutomaticaAsync(long proposta, string resposta, string usuario, int idSchemaVersao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarPropostaDigitada", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarPropostaDigitadaRespons" +
            "e")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarPropostaDigitadaValidac" +
            "aoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno RegistrarPropostaDigitada(long proposta, string xml, string strNamespace, string user);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarPropostaDigitada", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RegistrarPropostaDigitadaRespons" +
            "e")]
        System.Threading.Tasks.Task<EstruturaRetorno> RegistrarPropostaDigitadaAsync(long proposta, string xml, string strNamespace, string user);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RetirarAceite", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RetirarAceiteResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RetirarAceiteValidacaoExceptionF" +
            "ault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno RetirarAceite(long numeroProposta, int idSchemaVersao, string solicitante, string parecer);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RetirarAceite", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RetirarAceiteResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> RetirarAceiteAsync(long numeroProposta, int idSchemaVersao, string solicitante, string parecer);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RetirarRecusa", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RetirarRecusaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RetirarRecusaValidacaoExceptionF" +
            "ault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno RetirarRecusa(long numeroProposta, int idSchemaVersao, string solicitante, string parecer);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RetirarRecusa", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/RetirarRecusaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> RetirarRecusaAsync(long numeroProposta, int idSchemaVersao, string solicitante, string parecer);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirParecer", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirParecerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirParecerValidacaoException" +
            "Fault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno IncluirParecer(long proposta, int IdSchemaVersao, string descrParecer, string analista, EnumTipoParecer tipoParecer);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirParecer", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirParecerResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> IncluirParecerAsync(long proposta, int IdSchemaVersao, string descrParecer, string analista, EnumTipoParecer tipoParecer);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarSchemaNamespace", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarSchemaNamespaceResponse" +
            "")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarSchemaNamespaceValidaca" +
            "oExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno VerificarSchemaNamespace(string nmspace, string xmlProp);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarSchemaNamespace", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/VerificarSchemaNamespaceResponse" +
            "")]
        System.Threading.Tasks.Task<EstruturaRetorno> VerificarSchemaNamespaceAsync(string nmspace, string xmlProp);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirExcecao", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirExcecaoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirExcecaoValidacaoException" +
            "Fault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno IncluirExcecao(string xml, string mensagem, string xmlNamespace, string usuario, EnumStatusExcecao status, string observacao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirExcecao", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirExcecaoResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> IncluirExcecaoAsync(string xml, string mensagem, string xmlNamespace, string usuario, EnumStatusExcecao status, string observacao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ResolverExcecao", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ResolverExcecaoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ResolverExcecaoValidacaoExceptio" +
            "nFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno ResolverExcecao(long idExcecao, string usuario, string observacao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ResolverExcecao", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ResolverExcecaoResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> ResolverExcecaoAsync(long idExcecao, string usuario, string observacao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPoliticas", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPoliticasResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPoliticasValidacaoExceptio" +
            "nFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        PoliticaAceitacao[] ListarPoliticas(string modelo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPoliticas", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPoliticasResponse")]
        System.Threading.Tasks.Task<PoliticaAceitacao[]> ListarPoliticasAsync(string modelo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarSistemaProduto", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarSistemaProdutoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarSistemaProdutoValidacaoExc" +
            "eptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        SistemaProduto[] ListarSistemaProduto(string nomeSistema);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarSistemaProduto", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarSistemaProdutoResponse")]
        System.Threading.Tasks.Task<SistemaProduto[]> ListarSistemaProdutoAsync(string nomeSistema);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarGrupoModeloProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarGrupoModeloPropostaRespons" +
            "e")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarGrupoModeloPropostaValidac" +
            "aoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        GrupoModeloProposta[] ListarGrupoModeloProposta(string nomeGrupo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarGrupoModeloProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarGrupoModeloPropostaRespons" +
            "e")]
        System.Threading.Tasks.Task<GrupoModeloProposta[]> ListarGrupoModeloPropostaAsync(string nomeGrupo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObterDetalheExcecao", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObterDetalheExcecaoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObterDetalheExcecaoValidacaoExce" +
            "ptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        DetalheExcecao ObterDetalheExcecao(long idExcecao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObterDetalheExcecao", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObterDetalheExcecaoResponse")]
        System.Threading.Tasks.Task<DetalheExcecao> ObterDetalheExcecaoAsync(long idExcecao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarUltimoStatus", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarUltimoStatusResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarUltimoStatusValidacaoExcep" +
            "tionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EnumStatusProposta BuscarUltimoStatus(int idSchemaVersao, long idProposta);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarUltimoStatus", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarUltimoStatusResponse")]
        System.Threading.Tasks.Task<EnumStatusProposta> BuscarUltimoStatusAsync(int idSchemaVersao, long idProposta);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarResumoPropostaPorMetadado", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarResumoPropostaPorMetadadoR" +
            "esponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarResumoPropostaPorMetadadoV" +
            "alidacaoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        ResumoProposta BuscarResumoPropostaPorMetadado(EnumDominioMetadado tipoMetadado, string valor);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarResumoPropostaPorMetadado", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarResumoPropostaPorMetadadoR" +
            "esponse")]
        System.Threading.Tasks.Task<ResumoProposta> BuscarResumoPropostaPorMetadadoAsync(EnumDominioMetadado tipoMetadado, string valor);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/CriarPropostas", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/CriarPropostasResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/CriarPropostasValidacaoException" +
            "Fault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        PropostasCriadas CriarPropostas(int quantidade, string modelo, string solicitante);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/CriarPropostas", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/CriarPropostasResponse")]
        System.Threading.Tasks.Task<PropostasCriadas> CriarPropostasAsync(int quantidade, string modelo, string solicitante);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ArmazenarPropostas", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ArmazenarPropostasResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ArmazenarPropostasValidacaoExcep" +
            "tionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno ArmazenarPropostas(long propInicial, long propFinal, string modelo, string solicitante);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ArmazenarPropostas", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ArmazenarPropostasResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> ArmazenarPropostasAsync(long propInicial, long propFinal, string modelo, string solicitante);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/DistribuirPropostas", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/DistribuirPropostasResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/DistribuirPropostasValidacaoExce" +
            "ptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        PropostaErro DistribuirPropostas(long proposta, int keySchemaNamespace, string schemaNamespace, string modelo, string sucursal, string solicitante, long codigoProdutorPrincipal, long codigoProdutor);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/DistribuirPropostas", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/DistribuirPropostasResponse")]
        System.Threading.Tasks.Task<PropostaErro> DistribuirPropostasAsync(long proposta, int keySchemaNamespace, string schemaNamespace, string modelo, string sucursal, string solicitante, long codigoProdutorPrincipal, long codigoProdutor);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscaPropostaInicializada", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscaPropostaInicializadaRespons" +
            "e")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscaPropostaInicializadaValidac" +
            "aoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        PropostasCriadas BuscaPropostaInicializada(string modelo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscaPropostaInicializada", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscaPropostaInicializadaRespons" +
            "e")]
        System.Threading.Tasks.Task<PropostasCriadas> BuscaPropostaInicializadaAsync(string modelo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarInfoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarInfoPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarInfoPropostaValidacaoExcep" +
            "tionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        InfoProposta BuscarInfoProposta(long numProp);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarInfoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarInfoPropostaResponse")]
        System.Threading.Tasks.Task<InfoProposta> BuscarInfoPropostaAsync(long numProp);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/DistribuirRangePropostas", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/DistribuirRangePropostasResponse" +
            "")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/DistribuirRangePropostasValidaca" +
            "oExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno DistribuirRangePropostas(long propInicial, long propFinal, string modelo, string solicitante, string sucursal, long codigoProdutorPrincipal, long codigoProdutor);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/DistribuirRangePropostas", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/DistribuirRangePropostasResponse" +
            "")]
        System.Threading.Tasks.Task<EstruturaRetorno> DistribuirRangePropostasAsync(long propInicial, long propFinal, string modelo, string solicitante, string sucursal, long codigoProdutorPrincipal, long codigoProdutor);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarOrdenacaoStatusProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarOrdenacaoStatusPropostaRes" +
            "ponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarOrdenacaoStatusPropostaVal" +
            "idacaoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        System.Collections.Generic.Dictionary<EnumStatusProposta, int> ListarOrdenacaoStatusProposta();

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarOrdenacaoStatusProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarOrdenacaoStatusPropostaRes" +
            "ponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<EnumStatusProposta, int>> ListarOrdenacaoStatusPropostaAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarObservacoesProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarObservacoesPropostaRespons" +
            "e")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarObservacoesPropostaValidac" +
            "aoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        CriticaProposta[] ListarObservacoesProposta(long numprop, int IdSchemaVersao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarObservacoesProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarObservacoesPropostaRespons" +
            "e")]
        System.Threading.Tasks.Task<CriticaProposta[]> ListarObservacoesPropostaAsync(long numprop, int IdSchemaVersao);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarHistoricoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarHistoricoPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarHistoricoPropostaValidacao" +
            "ExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        HistoricoProposta[] ListarHistoricoProposta(long proposta, int IdSchemaVersao, bool carregaXml);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarHistoricoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarHistoricoPropostaResponse")]
        System.Threading.Tasks.Task<HistoricoProposta[]> ListarHistoricoPropostaAsync(long proposta, int IdSchemaVersao, bool carregaXml);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarDataHistoricoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarDataHistoricoPropostaRespo" +
            "nse")]
        HistoricoDataProposta[] ListarDataHistoricoProposta(long proposta, EnumStatusProposta[] status, bool obtemXml);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarDataHistoricoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarDataHistoricoPropostaRespo" +
            "nse")]
        System.Threading.Tasks.Task<HistoricoDataProposta[]> ListarDataHistoricoPropostaAsync(long proposta, EnumStatusProposta[] status, bool obtemXml);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPareceres", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPareceresResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPareceresValidacaoExceptio" +
            "nFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        Parecer[] ListarPareceres(long proposta, int idSchemaVersao, EnumTipoParecer tipoParecer);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPareceres", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPareceresResponse")]
        System.Threading.Tasks.Task<Parecer[]> ListarPareceresAsync(long proposta, int idSchemaVersao, EnumTipoParecer tipoParecer);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasAnalise", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasAnaliseResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasAnaliseValidacaoE" +
            "xceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        InfoPropostaAnalise[] ListarPropostasAnalise(EnumTipoProposta tipoProposta, string analistas, long numProposta);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasAnalise", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasAnaliseResponse")]
        System.Threading.Tasks.Task<InfoPropostaAnalise[]> ListarPropostasAnaliseAsync(EnumTipoProposta tipoProposta, string analistas, long numProposta);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasPorTipo", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasPorTipoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasPorTipoValidacaoE" +
            "xceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        InfoPropostaResumo[] ListarPropostasPorTipo(EnumTipoProposta tipo, EnumStatusProposta[] status);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasPorTipo", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasPorTipoResponse")]
        System.Threading.Tasks.Task<InfoPropostaResumo[]> ListarPropostasPorTipoAsync(EnumTipoProposta tipo, EnumStatusProposta[] status);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarIndiceProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarIndicePropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarIndicePropostaValidacaoExc" +
            "eptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        InfoIndiceProposta ListarIndiceProposta(int numProposta);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarIndiceProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarIndicePropostaResponse")]
        System.Threading.Tasks.Task<InfoIndiceProposta> ListarIndicePropostaAsync(int numProposta);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AtualizarSucursalProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AtualizarSucursalPropostaRespons" +
            "e")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AtualizarSucursalPropostaValidac" +
            "aoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno AtualizarSucursalProposta(long proposta, string sucursal);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AtualizarSucursalProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AtualizarSucursalPropostaRespons" +
            "e")]
        System.Threading.Tasks.Task<EstruturaRetorno> AtualizarSucursalPropostaAsync(long proposta, string sucursal);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirModeloProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirModeloPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirModeloPropostaValidacaoEx" +
            "ceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno IncluirModeloProposta(string id, string nome, System.DateTime dataCriacao, long estoqueMinimo, long estoqueAtual, StatusModeloPropostaEnum statusModeloProposta, int idVersaoSchemaAtual, EnumTipoModeloProposta idTipoModeloProposta, string idGrupoModeloProposta, string observacoes, System.Nullable<long> idParceiro);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirModeloProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/IncluirModeloPropostaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> IncluirModeloPropostaAsync(string id, string nome, System.DateTime dataCriacao, long estoqueMinimo, long estoqueAtual, StatusModeloPropostaEnum statusModeloProposta, int idVersaoSchemaAtual, EnumTipoModeloProposta idTipoModeloProposta, string idGrupoModeloProposta, string observacoes, System.Nullable<long> idParceiro);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarModeloProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarModeloPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarModeloPropostaValidacaoEx" +
            "ceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno AlterarModeloProposta(string id, string nome, long estoqueMinimo, long estoqueAtual, StatusModeloPropostaEnum statusModeloProposta, int idVersaoSchemaAtual, EnumTipoModeloProposta idTipoModeloProposta, string idGrupoModeloProposta, string observacoes, System.Nullable<long> idParceiro);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarModeloProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/AlterarModeloPropostaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> AlterarModeloPropostaAsync(string id, string nome, long estoqueMinimo, long estoqueAtual, StatusModeloPropostaEnum statusModeloProposta, int idVersaoSchemaAtual, EnumTipoModeloProposta idTipoModeloProposta, string idGrupoModeloProposta, string observacoes, System.Nullable<long> idParceiro);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarTiposProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarTiposPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarTiposPropostaValidacaoExce" +
            "ptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        SchemaProposta[] BuscarTiposProposta();

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarTiposProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarTiposPropostaResponse")]
        System.Threading.Tasks.Task<SchemaProposta[]> BuscarTiposPropostaAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasPorCorretor", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasPorCorretorRespon" +
            "se")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasPorCorretorValida" +
            "caoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        InfoPropostaCorretor[] ListarPropostasPorCorretor(long CodigoCorretor, FiltrosProponente filtrosProponente, FiltrosDadosProposta filtrosProposta);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasPorCorretor", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ListarPropostasPorCorretorRespon" +
            "se")]
        System.Threading.Tasks.Task<InfoPropostaCorretor[]> ListarPropostasPorCorretorAsync(long CodigoCorretor, FiltrosProponente filtrosProponente, FiltrosDadosProposta filtrosProposta);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/InserirAtributoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/InserirAtributoPropostaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/InserirAtributoPropostaValidacao" +
            "ExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        EstruturaRetorno InserirAtributoProposta(long numProposta, int idSchemaVersao, EnumDominioAtributo dominioAtributo, string valor, string solicitante);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/InserirAtributoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/InserirAtributoPropostaResponse")]
        System.Threading.Tasks.Task<EstruturaRetorno> InserirAtributoPropostaAsync(long numProposta, int idSchemaVersao, EnumDominioAtributo dominioAtributo, string valor, string solicitante);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObterValorAtributoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObterValorAtributoPropostaRespon" +
            "se")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObterValorAtributoPropostaValida" +
            "caoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        string ObterValorAtributoProposta(long numProposta, int idSchemaVersao, EnumDominioAtributo dominioAtributo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObterValorAtributoProposta", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/ObterValorAtributoPropostaRespon" +
            "se")]
        System.Threading.Tasks.Task<string> ObterValorAtributoPropostaAsync(long numProposta, int idSchemaVersao, EnumDominioAtributo dominioAtributo);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPropostasParaDistribuicao", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPropostasParaDistribuicaoR" +
            "esponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ValidacaoException), Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPropostasParaDistribuicaoV" +
            "alidacaoExceptionFault", Name = "ValidacaoException", Namespace = "http://schemas.datacontract.org/2004/07/ESB.GerirProposta.Model")]
        ListaIntervaloPropostas BuscarPropostasParaDistribuicao(string modelo, long quantidade);

        [System.ServiceModel.OperationContractAttribute(Action = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPropostasParaDistribuicao", ReplyAction = "http://ESB.Mongeral/GerirProposta/IGerirProposta/BuscarPropostasParaDistribuicaoR" +
            "esponse")]
        System.Threading.Tasks.Task<ListaIntervaloPropostas> BuscarPropostasParaDistribuicaoAsync(string modelo, long quantidade);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGerirPropostaChannel : IGerirProposta, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GerirPropostaClient : System.ServiceModel.ClientBase<IGerirProposta>, IGerirProposta
    {

        public GerirPropostaClient()
        {
        }

        public GerirPropostaClient(string endpointConfigurationName) :
                base(endpointConfigurationName)
        {
        }

        public GerirPropostaClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public GerirPropostaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress)
        {
        }

        public GerirPropostaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public EstruturaRetorno SalvarVersaoProposta(long numprop, string xml, string user, int idSchemaVersao, string analista)
        {
            return base.Channel.SalvarVersaoProposta(numprop, xml, user, idSchemaVersao, analista);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> SalvarVersaoPropostaAsync(long numprop, string xml, string user, int idSchemaVersao, string analista)
        {
            return base.Channel.SalvarVersaoPropostaAsync(numprop, xml, user, idSchemaVersao, analista);
        }

        public PendenciaResposta[] ListarPendencia(StatusPergunta status, long proposta, string destino, int idSchemaVersao, System.DateTime dtInicio, System.DateTime dtFim)
        {
            return base.Channel.ListarPendencia(status, proposta, destino, idSchemaVersao, dtInicio, dtFim);
        }

        public System.Threading.Tasks.Task<PendenciaResposta[]> ListarPendenciaAsync(StatusPergunta status, long proposta, string destino, int idSchemaVersao, System.DateTime dtInicio, System.DateTime dtFim)
        {
            return base.Channel.ListarPendenciaAsync(status, proposta, destino, idSchemaVersao, dtInicio, dtFim);
        }

        public EstruturaRetorno RegistrarResposta(long pendencia, long proposta, string resposta, string usuario, int IdSchemaVersao)
        {
            return base.Channel.RegistrarResposta(pendencia, proposta, resposta, usuario, IdSchemaVersao);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> RegistrarRespostaAsync(long pendencia, long proposta, string resposta, string usuario, int IdSchemaVersao)
        {
            return base.Channel.RegistrarRespostaAsync(pendencia, proposta, resposta, usuario, IdSchemaVersao);
        }

        public EstruturaRetorno RegistrarRecusa(long proposta, long idMotivo, string texto, string user)
        {
            return base.Channel.RegistrarRecusa(proposta, idMotivo, texto, user);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> RegistrarRecusaAsync(long proposta, long idMotivo, string texto, string user)
        {
            return base.Channel.RegistrarRecusaAsync(proposta, idMotivo, texto, user);
        }

        public EstruturaRetorno RegistrarCritica(long proposta, CriticaXML xml, string solicitante, int IdSchemaVersao)
        {
            return base.Channel.RegistrarCritica(proposta, xml, solicitante, IdSchemaVersao);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> RegistrarCriticaAsync(long proposta, CriticaXML xml, string solicitante, int IdSchemaVersao)
        {
            return base.Channel.RegistrarCriticaAsync(proposta, xml, solicitante, IdSchemaVersao);
        }

        public EstruturaRetorno RegistrarProposta(long proposta, string xml, string strNamespace)
        {
            return base.Channel.RegistrarProposta(proposta, xml, strNamespace);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> RegistrarPropostaAsync(long proposta, string xml, string strNamespace)
        {
            return base.Channel.RegistrarPropostaAsync(proposta, xml, strNamespace);
        }

        public EstruturaRetorno RegistrarPropostaTmp(long proposta, string xml, string strNamespace)
        {
            return base.Channel.RegistrarPropostaTmp(proposta, xml, strNamespace);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> RegistrarPropostaTmpAsync(long proposta, string xml, string strNamespace)
        {
            return base.Channel.RegistrarPropostaTmpAsync(proposta, xml, strNamespace);
        }

        public VersaoSchema[] BuscarVersaoSchema(int versao)
        {
            return base.Channel.BuscarVersaoSchema(versao);
        }

        public System.Threading.Tasks.Task<VersaoSchema[]> BuscarVersaoSchemaAsync(int versao)
        {
            return base.Channel.BuscarVersaoSchemaAsync(versao);
        }

        public CriticaPendencia[] BuscarPendenciaRelacionada(long idHistorico, int idCritica)
        {
            return base.Channel.BuscarPendenciaRelacionada(idHistorico, idCritica);
        }

        public System.Threading.Tasks.Task<CriticaPendencia[]> BuscarPendenciaRelacionadaAsync(long idHistorico, int idCritica)
        {
            return base.Channel.BuscarPendenciaRelacionadaAsync(idHistorico, idCritica);
        }

        public Criticas[] ListarPendenciaPorGrupo(int codGrupo, int codCritica)
        {
            return base.Channel.ListarPendenciaPorGrupo(codGrupo, codCritica);
        }

        public System.Threading.Tasks.Task<Criticas[]> ListarPendenciaPorGrupoAsync(int codGrupo, int codCritica)
        {
            return base.Channel.ListarPendenciaPorGrupoAsync(codGrupo, codCritica);
        }

        public Metadado[] BuscarMetadadoInfo(string nmspace)
        {
            return base.Channel.BuscarMetadadoInfo(nmspace);
        }

        public System.Threading.Tasks.Task<Metadado[]> BuscarMetadadoInfoAsync(string nmspace)
        {
            return base.Channel.BuscarMetadadoInfoAsync(nmspace);
        }

        public System.Collections.Generic.KeyValuePair<int, string> BuscarPolitica(string modelo, System.DateTime data, EnumTipoPolitica tipo)
        {
            return base.Channel.BuscarPolitica(modelo, data, tipo);
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> BuscarPoliticaAsync(string modelo, System.DateTime data, EnumTipoPolitica tipo)
        {
            return base.Channel.BuscarPoliticaAsync(modelo, data, tipo);
        }

        public EstruturaRetorno AlterarStatusProposta(long numProposta, int idSchemaVersao, string strNamespace, EnumStatusProposta statusPropostaDestino, string solicitante)
        {
            return base.Channel.AlterarStatusProposta(numProposta, idSchemaVersao, strNamespace, statusPropostaDestino, solicitante);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> AlterarStatusPropostaAsync(long numProposta, int idSchemaVersao, string strNamespace, EnumStatusProposta statusPropostaDestino, string solicitante)
        {
            return base.Channel.AlterarStatusPropostaAsync(numProposta, idSchemaVersao, strNamespace, statusPropostaDestino, solicitante);
        }

        public EstruturaRetorno EnviarParaConferencia(long numProposta, int idSchemaVersao, string strNamespace, string solicitante)
        {
            return base.Channel.EnviarParaConferencia(numProposta, idSchemaVersao, strNamespace, solicitante);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> EnviarParaConferenciaAsync(long numProposta, int idSchemaVersao, string strNamespace, string solicitante)
        {
            return base.Channel.EnviarParaConferenciaAsync(numProposta, idSchemaVersao, strNamespace, solicitante);
        }

        public EstruturaRetorno AlterarDescricaoPendencia(long pendencia, string descricao)
        {
            return base.Channel.AlterarDescricaoPendencia(pendencia, descricao);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> AlterarDescricaoPendenciaAsync(long pendencia, string descricao)
        {
            return base.Channel.AlterarDescricaoPendenciaAsync(pendencia, descricao);
        }

        public EstruturaRetornoProtocolo AceitarProposta(string xmlProposta, long proposta, int idSchemaVersao, string solicitante, string descrParecer, bool aceiteAutomatico)
        {
            return base.Channel.AceitarProposta(xmlProposta, proposta, idSchemaVersao, solicitante, descrParecer, aceiteAutomatico);
        }

        public System.Threading.Tasks.Task<EstruturaRetornoProtocolo> AceitarPropostaAsync(string xmlProposta, long proposta, int idSchemaVersao, string solicitante, string descrParecer, bool aceiteAutomatico)
        {
            return base.Channel.AceitarPropostaAsync(xmlProposta, proposta, idSchemaVersao, solicitante, descrParecer, aceiteAutomatico);
        }

        public EstruturaRetornoProtocolo RecusarProposta(string xmlProposta, long proposta, int idSchemaVersao, string solicitante, string parceiro, string motivo, string[] emails)
        {
            return base.Channel.RecusarProposta(xmlProposta, proposta, idSchemaVersao, solicitante, parceiro, motivo, emails);
        }

        public System.Threading.Tasks.Task<EstruturaRetornoProtocolo> RecusarPropostaAsync(string xmlProposta, long proposta, int idSchemaVersao, string solicitante, string parceiro, string motivo, string[] emails)
        {
            return base.Channel.RecusarPropostaAsync(xmlProposta, proposta, idSchemaVersao, solicitante, parceiro, motivo, emails);
        }

        public PendenciaResposta BuscarDetalhePendencia(int idPendencia)
        {
            return base.Channel.BuscarDetalhePendencia(idPendencia);
        }

        public System.Threading.Tasks.Task<PendenciaResposta> BuscarDetalhePendenciaAsync(int idPendencia)
        {
            return base.Channel.BuscarDetalhePendenciaAsync(idPendencia);
        }

        public EnumStatusProposta VerificarStatusProposta(long numProposta, int idSchemaVersao, string strNamespace)
        {
            return base.Channel.VerificarStatusProposta(numProposta, idSchemaVersao, strNamespace);
        }

        public System.Threading.Tasks.Task<EnumStatusProposta> VerificarStatusPropostaAsync(long numProposta, int idSchemaVersao, string strNamespace)
        {
            return base.Channel.VerificarStatusPropostaAsync(numProposta, idSchemaVersao, strNamespace);
        }

        public EstruturaRetorno ExcluirResposta(int idPendencia)
        {
            return base.Channel.ExcluirResposta(idPendencia);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> ExcluirRespostaAsync(int idPendencia)
        {
            return base.Channel.ExcluirRespostaAsync(idPendencia);
        }

        public Metadado BuscarMetadadoIdSchemaVersao(long idSchemaVersao, EnumDominioMetadado metadado)
        {
            return base.Channel.BuscarMetadadoIdSchemaVersao(idSchemaVersao, metadado);
        }

        public System.Threading.Tasks.Task<Metadado> BuscarMetadadoIdSchemaVersaoAsync(long idSchemaVersao, EnumDominioMetadado metadado)
        {
            return base.Channel.BuscarMetadadoIdSchemaVersaoAsync(idSchemaVersao, metadado);
        }

        public Metadado BuscarMetadadoNamespace(string nmspace, EnumDominioMetadado metadado)
        {
            return base.Channel.BuscarMetadadoNamespace(nmspace, metadado);
        }

        public System.Threading.Tasks.Task<Metadado> BuscarMetadadoNamespaceAsync(string nmspace, EnumDominioMetadado metadado)
        {
            return base.Channel.BuscarMetadadoNamespaceAsync(nmspace, metadado);
        }

        public EstruturaRetorno CriarExcecaoProposta(long numProposta, int idSchemaVersao, string excecao)
        {
            return base.Channel.CriarExcecaoProposta(numProposta, idSchemaVersao, excecao);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> CriarExcecaoPropostaAsync(long numProposta, int idSchemaVersao, string excecao)
        {
            return base.Channel.CriarExcecaoPropostaAsync(numProposta, idSchemaVersao, excecao);
        }

        public EstruturaRetorno VerificarSchemaProposta(long idSchemaVersao, string xmlProp)
        {
            return base.Channel.VerificarSchemaProposta(idSchemaVersao, xmlProp);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> VerificarSchemaPropostaAsync(long idSchemaVersao, string xmlProp)
        {
            return base.Channel.VerificarSchemaPropostaAsync(idSchemaVersao, xmlProp);
        }

        public ModeloProposta[] ListarModeloProposta(string modelo)
        {
            return base.Channel.ListarModeloProposta(modelo);
        }

        public System.Threading.Tasks.Task<ModeloProposta[]> ListarModeloPropostaAsync(string modelo)
        {
            return base.Channel.ListarModeloPropostaAsync(modelo);
        }

        public string[] ListarOrigemProposta(System.Nullable<long> numeroProposta, System.Nullable<int> idSchema)
        {
            return base.Channel.ListarOrigemProposta(numeroProposta, idSchema);
        }

        public System.Threading.Tasks.Task<string[]> ListarOrigemPropostaAsync(System.Nullable<long> numeroProposta, System.Nullable<int> idSchema)
        {
            return base.Channel.ListarOrigemPropostaAsync(numeroProposta, idSchema);
        }

        public bool ExisteProposta(int idSchemaVersao, long numProposta)
        {
            return base.Channel.ExisteProposta(idSchemaVersao, numProposta);
        }

        public System.Threading.Tasks.Task<bool> ExistePropostaAsync(int idSchemaVersao, long numProposta)
        {
            return base.Channel.ExistePropostaAsync(idSchemaVersao, numProposta);
        }

        public System.Collections.Generic.KeyValuePair<int, string> BuscarSchemaNamespacePorModelo(string modelo)
        {
            return base.Channel.BuscarSchemaNamespacePorModelo(modelo);
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.KeyValuePair<int, string>> BuscarSchemaNamespacePorModeloAsync(string modelo)
        {
            return base.Channel.BuscarSchemaNamespacePorModeloAsync(modelo);
        }

        public string[] ObtemElementosPorModelo(string modeloProposta, int versao)
        {
            return base.Channel.ObtemElementosPorModelo(modeloProposta, versao);
        }

        public System.Threading.Tasks.Task<string[]> ObtemElementosPorModeloAsync(string modeloProposta, int versao)
        {
            return base.Channel.ObtemElementosPorModeloAsync(modeloProposta, versao);
        }

        public EstruturaRetorno RegistrarRespostaAutomatica(long proposta, string resposta, string usuario, int idSchemaVersao)
        {
            return base.Channel.RegistrarRespostaAutomatica(proposta, resposta, usuario, idSchemaVersao);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> RegistrarRespostaAutomaticaAsync(long proposta, string resposta, string usuario, int idSchemaVersao)
        {
            return base.Channel.RegistrarRespostaAutomaticaAsync(proposta, resposta, usuario, idSchemaVersao);
        }

        public EstruturaRetorno RegistrarPropostaDigitada(long proposta, string xml, string strNamespace, string user)
        {
            return base.Channel.RegistrarPropostaDigitada(proposta, xml, strNamespace, user);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> RegistrarPropostaDigitadaAsync(long proposta, string xml, string strNamespace, string user)
        {
            return base.Channel.RegistrarPropostaDigitadaAsync(proposta, xml, strNamespace, user);
        }

        public EstruturaRetorno RetirarAceite(long numeroProposta, int idSchemaVersao, string solicitante, string parecer)
        {
            return base.Channel.RetirarAceite(numeroProposta, idSchemaVersao, solicitante, parecer);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> RetirarAceiteAsync(long numeroProposta, int idSchemaVersao, string solicitante, string parecer)
        {
            return base.Channel.RetirarAceiteAsync(numeroProposta, idSchemaVersao, solicitante, parecer);
        }

        public EstruturaRetorno RetirarRecusa(long numeroProposta, int idSchemaVersao, string solicitante, string parecer)
        {
            return base.Channel.RetirarRecusa(numeroProposta, idSchemaVersao, solicitante, parecer);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> RetirarRecusaAsync(long numeroProposta, int idSchemaVersao, string solicitante, string parecer)
        {
            return base.Channel.RetirarRecusaAsync(numeroProposta, idSchemaVersao, solicitante, parecer);
        }

        public EstruturaRetorno IncluirParecer(long proposta, int IdSchemaVersao, string descrParecer, string analista, EnumTipoParecer tipoParecer)
        {
            return base.Channel.IncluirParecer(proposta, IdSchemaVersao, descrParecer, analista, tipoParecer);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> IncluirParecerAsync(long proposta, int IdSchemaVersao, string descrParecer, string analista, EnumTipoParecer tipoParecer)
        {
            return base.Channel.IncluirParecerAsync(proposta, IdSchemaVersao, descrParecer, analista, tipoParecer);
        }

        public EstruturaRetorno VerificarSchemaNamespace(string nmspace, string xmlProp)
        {
            return base.Channel.VerificarSchemaNamespace(nmspace, xmlProp);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> VerificarSchemaNamespaceAsync(string nmspace, string xmlProp)
        {
            return base.Channel.VerificarSchemaNamespaceAsync(nmspace, xmlProp);
        }

        public EstruturaRetorno IncluirExcecao(string xml, string mensagem, string xmlNamespace, string usuario, EnumStatusExcecao status, string observacao)
        {
            return base.Channel.IncluirExcecao(xml, mensagem, xmlNamespace, usuario, status, observacao);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> IncluirExcecaoAsync(string xml, string mensagem, string xmlNamespace, string usuario, EnumStatusExcecao status, string observacao)
        {
            return base.Channel.IncluirExcecaoAsync(xml, mensagem, xmlNamespace, usuario, status, observacao);
        }

        public EstruturaRetorno ResolverExcecao(long idExcecao, string usuario, string observacao)
        {
            return base.Channel.ResolverExcecao(idExcecao, usuario, observacao);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> ResolverExcecaoAsync(long idExcecao, string usuario, string observacao)
        {
            return base.Channel.ResolverExcecaoAsync(idExcecao, usuario, observacao);
        }

        public PoliticaAceitacao[] ListarPoliticas(string modelo)
        {
            return base.Channel.ListarPoliticas(modelo);
        }

        public System.Threading.Tasks.Task<PoliticaAceitacao[]> ListarPoliticasAsync(string modelo)
        {
            return base.Channel.ListarPoliticasAsync(modelo);
        }

        public SistemaProduto[] ListarSistemaProduto(string nomeSistema)
        {
            return base.Channel.ListarSistemaProduto(nomeSistema);
        }

        public System.Threading.Tasks.Task<SistemaProduto[]> ListarSistemaProdutoAsync(string nomeSistema)
        {
            return base.Channel.ListarSistemaProdutoAsync(nomeSistema);
        }

        public GrupoModeloProposta[] ListarGrupoModeloProposta(string nomeGrupo)
        {
            return base.Channel.ListarGrupoModeloProposta(nomeGrupo);
        }

        public System.Threading.Tasks.Task<GrupoModeloProposta[]> ListarGrupoModeloPropostaAsync(string nomeGrupo)
        {
            return base.Channel.ListarGrupoModeloPropostaAsync(nomeGrupo);
        }

        public DetalheExcecao ObterDetalheExcecao(long idExcecao)
        {
            return base.Channel.ObterDetalheExcecao(idExcecao);
        }

        public System.Threading.Tasks.Task<DetalheExcecao> ObterDetalheExcecaoAsync(long idExcecao)
        {
            return base.Channel.ObterDetalheExcecaoAsync(idExcecao);
        }

        public EnumStatusProposta BuscarUltimoStatus(int idSchemaVersao, long idProposta)
        {
            return base.Channel.BuscarUltimoStatus(idSchemaVersao, idProposta);
        }

        public System.Threading.Tasks.Task<EnumStatusProposta> BuscarUltimoStatusAsync(int idSchemaVersao, long idProposta)
        {
            return base.Channel.BuscarUltimoStatusAsync(idSchemaVersao, idProposta);
        }

        public ResumoProposta BuscarResumoPropostaPorMetadado(EnumDominioMetadado tipoMetadado, string valor)
        {
            return base.Channel.BuscarResumoPropostaPorMetadado(tipoMetadado, valor);
        }

        public System.Threading.Tasks.Task<ResumoProposta> BuscarResumoPropostaPorMetadadoAsync(EnumDominioMetadado tipoMetadado, string valor)
        {
            return base.Channel.BuscarResumoPropostaPorMetadadoAsync(tipoMetadado, valor);
        }

        public PropostasCriadas CriarPropostas(int quantidade, string modelo, string solicitante)
        {
            return base.Channel.CriarPropostas(quantidade, modelo, solicitante);
        }

        public System.Threading.Tasks.Task<PropostasCriadas> CriarPropostasAsync(int quantidade, string modelo, string solicitante)
        {
            return base.Channel.CriarPropostasAsync(quantidade, modelo, solicitante);
        }

        public EstruturaRetorno ArmazenarPropostas(long propInicial, long propFinal, string modelo, string solicitante)
        {
            return base.Channel.ArmazenarPropostas(propInicial, propFinal, modelo, solicitante);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> ArmazenarPropostasAsync(long propInicial, long propFinal, string modelo, string solicitante)
        {
            return base.Channel.ArmazenarPropostasAsync(propInicial, propFinal, modelo, solicitante);
        }

        public PropostaErro DistribuirPropostas(long proposta, int keySchemaNamespace, string schemaNamespace, string modelo, string sucursal, string solicitante, long codigoProdutorPrincipal, long codigoProdutor)
        {
            return base.Channel.DistribuirPropostas(proposta, keySchemaNamespace, schemaNamespace, modelo, sucursal, solicitante, codigoProdutorPrincipal, codigoProdutor);
        }

        public System.Threading.Tasks.Task<PropostaErro> DistribuirPropostasAsync(long proposta, int keySchemaNamespace, string schemaNamespace, string modelo, string sucursal, string solicitante, long codigoProdutorPrincipal, long codigoProdutor)
        {
            return base.Channel.DistribuirPropostasAsync(proposta, keySchemaNamespace, schemaNamespace, modelo, sucursal, solicitante, codigoProdutorPrincipal, codigoProdutor);
        }

        public PropostasCriadas BuscaPropostaInicializada(string modelo)
        {
            return base.Channel.BuscaPropostaInicializada(modelo);
        }

        public System.Threading.Tasks.Task<PropostasCriadas> BuscaPropostaInicializadaAsync(string modelo)
        {
            return base.Channel.BuscaPropostaInicializadaAsync(modelo);
        }

        public InfoProposta BuscarInfoProposta(long numProp)
        {
            return base.Channel.BuscarInfoProposta(numProp);
        }

        public System.Threading.Tasks.Task<InfoProposta> BuscarInfoPropostaAsync(long numProp)
        {
            return base.Channel.BuscarInfoPropostaAsync(numProp);
        }

        public EstruturaRetorno DistribuirRangePropostas(long propInicial, long propFinal, string modelo, string solicitante, string sucursal, long codigoProdutorPrincipal, long codigoProdutor)
        {
            return base.Channel.DistribuirRangePropostas(propInicial, propFinal, modelo, solicitante, sucursal, codigoProdutorPrincipal, codigoProdutor);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> DistribuirRangePropostasAsync(long propInicial, long propFinal, string modelo, string solicitante, string sucursal, long codigoProdutorPrincipal, long codigoProdutor)
        {
            return base.Channel.DistribuirRangePropostasAsync(propInicial, propFinal, modelo, solicitante, sucursal, codigoProdutorPrincipal, codigoProdutor);
        }

        public System.Collections.Generic.Dictionary<EnumStatusProposta, int> ListarOrdenacaoStatusProposta()
        {
            return base.Channel.ListarOrdenacaoStatusProposta();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<EnumStatusProposta, int>> ListarOrdenacaoStatusPropostaAsync()
        {
            return base.Channel.ListarOrdenacaoStatusPropostaAsync();
        }

        public CriticaProposta[] ListarObservacoesProposta(long numprop, int IdSchemaVersao)
        {
            return base.Channel.ListarObservacoesProposta(numprop, IdSchemaVersao);
        }

        public System.Threading.Tasks.Task<CriticaProposta[]> ListarObservacoesPropostaAsync(long numprop, int IdSchemaVersao)
        {
            return base.Channel.ListarObservacoesPropostaAsync(numprop, IdSchemaVersao);
        }

        public HistoricoProposta[] ListarHistoricoProposta(long proposta, int IdSchemaVersao, bool carregaXml)
        {
            return base.Channel.ListarHistoricoProposta(proposta, IdSchemaVersao, carregaXml);
        }

        public System.Threading.Tasks.Task<HistoricoProposta[]> ListarHistoricoPropostaAsync(long proposta, int IdSchemaVersao, bool carregaXml)
        {
            return base.Channel.ListarHistoricoPropostaAsync(proposta, IdSchemaVersao, carregaXml);
        }

        public HistoricoDataProposta[] ListarDataHistoricoProposta(long proposta, EnumStatusProposta[] status, bool obtemXml)
        {
            return base.Channel.ListarDataHistoricoProposta(proposta, status, obtemXml);
        }

        public System.Threading.Tasks.Task<HistoricoDataProposta[]> ListarDataHistoricoPropostaAsync(long proposta, EnumStatusProposta[] status, bool obtemXml)
        {
            return base.Channel.ListarDataHistoricoPropostaAsync(proposta, status, obtemXml);
        }

        public Parecer[] ListarPareceres(long proposta, int idSchemaVersao, EnumTipoParecer tipoParecer)
        {
            return base.Channel.ListarPareceres(proposta, idSchemaVersao, tipoParecer);
        }

        public System.Threading.Tasks.Task<Parecer[]> ListarPareceresAsync(long proposta, int idSchemaVersao, EnumTipoParecer tipoParecer)
        {
            return base.Channel.ListarPareceresAsync(proposta, idSchemaVersao, tipoParecer);
        }

        public InfoPropostaAnalise[] ListarPropostasAnalise(EnumTipoProposta tipoProposta, string analistas, long numProposta)
        {
            return base.Channel.ListarPropostasAnalise(tipoProposta, analistas, numProposta);
        }

        public System.Threading.Tasks.Task<InfoPropostaAnalise[]> ListarPropostasAnaliseAsync(EnumTipoProposta tipoProposta, string analistas, long numProposta)
        {
            return base.Channel.ListarPropostasAnaliseAsync(tipoProposta, analistas, numProposta);
        }

        public InfoPropostaResumo[] ListarPropostasPorTipo(EnumTipoProposta tipo, EnumStatusProposta[] status)
        {
            return base.Channel.ListarPropostasPorTipo(tipo, status);
        }

        public System.Threading.Tasks.Task<InfoPropostaResumo[]> ListarPropostasPorTipoAsync(EnumTipoProposta tipo, EnumStatusProposta[] status)
        {
            return base.Channel.ListarPropostasPorTipoAsync(tipo, status);
        }

        public InfoIndiceProposta ListarIndiceProposta(int numProposta)
        {
            return base.Channel.ListarIndiceProposta(numProposta);
        }

        public System.Threading.Tasks.Task<InfoIndiceProposta> ListarIndicePropostaAsync(int numProposta)
        {
            return base.Channel.ListarIndicePropostaAsync(numProposta);
        }

        public EstruturaRetorno AtualizarSucursalProposta(long proposta, string sucursal)
        {
            return base.Channel.AtualizarSucursalProposta(proposta, sucursal);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> AtualizarSucursalPropostaAsync(long proposta, string sucursal)
        {
            return base.Channel.AtualizarSucursalPropostaAsync(proposta, sucursal);
        }

        public EstruturaRetorno IncluirModeloProposta(string id, string nome, System.DateTime dataCriacao, long estoqueMinimo, long estoqueAtual, StatusModeloPropostaEnum statusModeloProposta, int idVersaoSchemaAtual, EnumTipoModeloProposta idTipoModeloProposta, string idGrupoModeloProposta, string observacoes, System.Nullable<long> idParceiro)
        {
            return base.Channel.IncluirModeloProposta(id, nome, dataCriacao, estoqueMinimo, estoqueAtual, statusModeloProposta, idVersaoSchemaAtual, idTipoModeloProposta, idGrupoModeloProposta, observacoes, idParceiro);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> IncluirModeloPropostaAsync(string id, string nome, System.DateTime dataCriacao, long estoqueMinimo, long estoqueAtual, StatusModeloPropostaEnum statusModeloProposta, int idVersaoSchemaAtual, EnumTipoModeloProposta idTipoModeloProposta, string idGrupoModeloProposta, string observacoes, System.Nullable<long> idParceiro)
        {
            return base.Channel.IncluirModeloPropostaAsync(id, nome, dataCriacao, estoqueMinimo, estoqueAtual, statusModeloProposta, idVersaoSchemaAtual, idTipoModeloProposta, idGrupoModeloProposta, observacoes, idParceiro);
        }

        public EstruturaRetorno AlterarModeloProposta(string id, string nome, long estoqueMinimo, long estoqueAtual, StatusModeloPropostaEnum statusModeloProposta, int idVersaoSchemaAtual, EnumTipoModeloProposta idTipoModeloProposta, string idGrupoModeloProposta, string observacoes, System.Nullable<long> idParceiro)
        {
            return base.Channel.AlterarModeloProposta(id, nome, estoqueMinimo, estoqueAtual, statusModeloProposta, idVersaoSchemaAtual, idTipoModeloProposta, idGrupoModeloProposta, observacoes, idParceiro);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> AlterarModeloPropostaAsync(string id, string nome, long estoqueMinimo, long estoqueAtual, StatusModeloPropostaEnum statusModeloProposta, int idVersaoSchemaAtual, EnumTipoModeloProposta idTipoModeloProposta, string idGrupoModeloProposta, string observacoes, System.Nullable<long> idParceiro)
        {
            return base.Channel.AlterarModeloPropostaAsync(id, nome, estoqueMinimo, estoqueAtual, statusModeloProposta, idVersaoSchemaAtual, idTipoModeloProposta, idGrupoModeloProposta, observacoes, idParceiro);
        }

        public SchemaProposta[] BuscarTiposProposta()
        {
            return base.Channel.BuscarTiposProposta();
        }

        public System.Threading.Tasks.Task<SchemaProposta[]> BuscarTiposPropostaAsync()
        {
            return base.Channel.BuscarTiposPropostaAsync();
        }

        public InfoPropostaCorretor[] ListarPropostasPorCorretor(long CodigoCorretor, FiltrosProponente filtrosProponente, FiltrosDadosProposta filtrosProposta)
        {
            return base.Channel.ListarPropostasPorCorretor(CodigoCorretor, filtrosProponente, filtrosProposta);
        }

        public System.Threading.Tasks.Task<InfoPropostaCorretor[]> ListarPropostasPorCorretorAsync(long CodigoCorretor, FiltrosProponente filtrosProponente, FiltrosDadosProposta filtrosProposta)
        {
            return base.Channel.ListarPropostasPorCorretorAsync(CodigoCorretor, filtrosProponente, filtrosProposta);
        }

        public EstruturaRetorno InserirAtributoProposta(long numProposta, int idSchemaVersao, EnumDominioAtributo dominioAtributo, string valor, string solicitante)
        {
            return base.Channel.InserirAtributoProposta(numProposta, idSchemaVersao, dominioAtributo, valor, solicitante);
        }

        public System.Threading.Tasks.Task<EstruturaRetorno> InserirAtributoPropostaAsync(long numProposta, int idSchemaVersao, EnumDominioAtributo dominioAtributo, string valor, string solicitante)
        {
            return base.Channel.InserirAtributoPropostaAsync(numProposta, idSchemaVersao, dominioAtributo, valor, solicitante);
        }

        public string ObterValorAtributoProposta(long numProposta, int idSchemaVersao, EnumDominioAtributo dominioAtributo)
        {
            return base.Channel.ObterValorAtributoProposta(numProposta, idSchemaVersao, dominioAtributo);
        }

        public System.Threading.Tasks.Task<string> ObterValorAtributoPropostaAsync(long numProposta, int idSchemaVersao, EnumDominioAtributo dominioAtributo)
        {
            return base.Channel.ObterValorAtributoPropostaAsync(numProposta, idSchemaVersao, dominioAtributo);
        }

        public ListaIntervaloPropostas BuscarPropostasParaDistribuicao(string modelo, long quantidade)
        {
            return base.Channel.BuscarPropostasParaDistribuicao(modelo, quantidade);
        }

        public System.Threading.Tasks.Task<ListaIntervaloPropostas> BuscarPropostasParaDistribuicaoAsync(string modelo, long quantidade)
        {
            return base.Channel.BuscarPropostasParaDistribuicaoAsync(modelo, quantidade);
        }
    }
}
