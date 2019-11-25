
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.xmlsoap.org/soap/envelope/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.xmlsoap.org/soap/envelope/", IsNullable=false)]
public partial class Envelope {
    
    private EnvelopeBody bodyField;
    
    /// <remarks/>
    public EnvelopeBody Body {
        get {
            return this.bodyField;
        }
        set {
            this.bodyField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.xmlsoap.org/soap/envelope/")]
public partial class EnvelopeBody {
    
    private EndStrategyResponse endStrategyResponseField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector")]
    public EndStrategyResponse EndStrategyResponse {
        get {
            return this.endStrategyResponseField;
        }
        set {
            this.endStrategyResponseField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector", IsNullable=false)]
public partial class EndStrategyResponse {
    
    private EndStrategyResponseEndStrategyResult endStrategyResultField;
    
    /// <remarks/>
    public EndStrategyResponseEndStrategyResult EndStrategyResult {
        get {
            return this.endStrategyResultField;
        }
        set {
            this.endStrategyResultField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector")]
public partial class EndStrategyResponseEndStrategyResult {
    
    private EndStrategyResponseEndStrategyResultResponse responseField;
    
    /// <remarks/>
    public EndStrategyResponseEndStrategyResultResponse Response {
        get {
            return this.responseField;
        }
        set {
            this.responseField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector")]
public partial class EndStrategyResponseEndStrategyResultResponse {
    
    private response responseField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Messages/Response")]
    public response response {
        get {
            return this.responseField;
        }
        set {
            this.responseField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Messages/Response")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Messages/Response", IsNullable=false)]
public partial class response {
    
    private responseConnector connectorField;
    
    /// <remarks/>
    public responseConnector connector {
        get {
            return this.connectorField;
        }
        set {
            this.connectorField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Messages/Response")]
public partial class responseConnector {
    
    private responseConnectorData dataField;
    
    private string idField;
    
    /// <remarks/>
    public responseConnectorData data {
        get {
            return this.dataField;
        }
        set {
            this.dataField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Messages/Response")]
public partial class responseConnectorData {
    
    private response1 responseField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
        "esponse")]
    public response1 response {
        get {
            return this.responseField;
        }
        set {
            this.responseField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
[System.Xml.Serialization.XmlRootAttribute("response", Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse", IsNullable=false)]
public partial class response1 {
    
    private string statusField;
    
    private string infomsgField;
    
    private string currencyField;
    
    private responseResult resultField;
    
    private responseGeneralInformation generalInformationField;
    
    private responsePersonalInformation personalInformationField;
    
    private responseScoringAnalysis scoringAnalysisField;
    
    private responseInquiriesAnalysis inquiriesAnalysisField;
    
    private responseCurrentContracts currentContractsField;
    
    private responsePastDueInformation pastDueInformationField;
    
    private responseRepaymentInformation repaymentInformationField;
    
    private responseRule[] policyRulesField;
    
    private responseExtract extractField;
    
    private responseStrategy strategyField;
    
    private responseSteps stepsField;
    
    /// <remarks/>
    public string status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    public string infomsg {
        get {
            return this.infomsgField;
        }
        set {
            this.infomsgField = value;
        }
    }
    
    /// <remarks/>
    public string Currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
    
    /// <remarks/>
    public responseResult Result {
        get {
            return this.resultField;
        }
        set {
            this.resultField = value;
        }
    }
    
    /// <remarks/>
    public responseGeneralInformation GeneralInformation {
        get {
            return this.generalInformationField;
        }
        set {
            this.generalInformationField = value;
        }
    }
    
    /// <remarks/>
    public responsePersonalInformation PersonalInformation {
        get {
            return this.personalInformationField;
        }
        set {
            this.personalInformationField = value;
        }
    }
    
    /// <remarks/>
    public responseScoringAnalysis ScoringAnalysis {
        get {
            return this.scoringAnalysisField;
        }
        set {
            this.scoringAnalysisField = value;
        }
    }
    
    /// <remarks/>
    public responseInquiriesAnalysis InquiriesAnalysis {
        get {
            return this.inquiriesAnalysisField;
        }
        set {
            this.inquiriesAnalysisField = value;
        }
    }
    
    /// <remarks/>
    public responseCurrentContracts CurrentContracts {
        get {
            return this.currentContractsField;
        }
        set {
            this.currentContractsField = value;
        }
    }
    
    /// <remarks/>
    public responsePastDueInformation PastDueInformation {
        get {
            return this.pastDueInformationField;
        }
        set {
            this.pastDueInformationField = value;
        }
    }
    
    /// <remarks/>
    public responseRepaymentInformation RepaymentInformation {
        get {
            return this.repaymentInformationField;
        }
        set {
            this.repaymentInformationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Rule", IsNullable=false)]
    public responseRule[] PolicyRules {
        get {
            return this.policyRulesField;
        }
        set {
            this.policyRulesField = value;
        }
    }
    
    /// <remarks/>
    public responseExtract Extract {
        get {
            return this.extractField;
        }
        set {
            this.extractField = value;
        }
    }
    
    /// <remarks/>
    public responseStrategy Strategy {
        get {
            return this.strategyField;
        }
        set {
            this.strategyField = value;
        }
    }
    
    /// <remarks/>
    public responseSteps Steps {
        get {
            return this.stepsField;
        }
        set {
            this.stepsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseResult {
    
    private string recommendedDecisionField;
    
    private byte brokenRulesField;
    
    private ushort creditLimitField;
    
    /// <remarks/>
    public string RecommendedDecision {
        get {
            return this.recommendedDecisionField;
        }
        set {
            this.recommendedDecisionField = value;
        }
    }
    
    /// <remarks/>
    public byte BrokenRules {
        get {
            return this.brokenRulesField;
        }
        set {
            this.brokenRulesField = value;
        }
    }
    
    /// <remarks/>
    public ushort CreditLimit {
        get {
            return this.creditLimitField;
        }
        set {
            this.creditLimitField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseGeneralInformation {
    
    private uint subjectIDNumberField;
    
    private System.DateTime requestDateField;
    
    private string referenceNumberField;
    
    /// <remarks/>
    public uint SubjectIDNumber {
        get {
            return this.subjectIDNumberField;
        }
        set {
            this.subjectIDNumberField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime RequestDate {
        get {
            return this.requestDateField;
        }
        set {
            this.requestDateField = value;
        }
    }
    
    /// <remarks/>
    public string ReferenceNumber {
        get {
            return this.referenceNumberField;
        }
        set {
            this.referenceNumberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responsePersonalInformation {
    
    private string fullNameField;
    
    private System.DateTime dateOfBirthField;
    
    private byte ageField;
    
    private string genderField;
    
    private string maritalStatusField;
    
    private string employmentStatusField;
    
    /// <remarks/>
    public string FullName {
        get {
            return this.fullNameField;
        }
        set {
            this.fullNameField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime DateOfBirth {
        get {
            return this.dateOfBirthField;
        }
        set {
            this.dateOfBirthField = value;
        }
    }
    
    /// <remarks/>
    public byte Age {
        get {
            return this.ageField;
        }
        set {
            this.ageField = value;
        }
    }
    
    /// <remarks/>
    public string Gender {
        get {
            return this.genderField;
        }
        set {
            this.genderField = value;
        }
    }
    
    /// <remarks/>
    public string MaritalStatus {
        get {
            return this.maritalStatusField;
        }
        set {
            this.maritalStatusField = value;
        }
    }
    
    /// <remarks/>
    public string EmploymentStatus {
        get {
            return this.employmentStatusField;
        }
        set {
            this.employmentStatusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseScoringAnalysis {
    
    private ushort cIPScoreField;
    
    private string cIPRiskGradeField;
    
    private ushort mobileScoreField;
    
    private string mobileScoreRiskGradeField;
    
    private object conclusionField;
    
    private responseScoringAnalysisRule[] policyRulesField;
    
    /// <remarks/>
    public ushort CIPScore {
        get {
            return this.cIPScoreField;
        }
        set {
            this.cIPScoreField = value;
        }
    }
    
    /// <remarks/>
    public string CIPRiskGrade {
        get {
            return this.cIPRiskGradeField;
        }
        set {
            this.cIPRiskGradeField = value;
        }
    }
    
    /// <remarks/>
    public ushort MobileScore {
        get {
            return this.mobileScoreField;
        }
        set {
            this.mobileScoreField = value;
        }
    }
    
    /// <remarks/>
    public string MobileScoreRiskGrade {
        get {
            return this.mobileScoreRiskGradeField;
        }
        set {
            this.mobileScoreRiskGradeField = value;
        }
    }
    
    /// <remarks/>
    public object Conclusion {
        get {
            return this.conclusionField;
        }
        set {
            this.conclusionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Rule", IsNullable=false)]
    public responseScoringAnalysisRule[] PolicyRules {
        get {
            return this.policyRulesField;
        }
        set {
            this.policyRulesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseScoringAnalysisRule {
    
    private string resultField;
    
    private string descriptionField;
    
    private string idField;
    
    /// <remarks/>
    public string Result {
        get {
            return this.resultField;
        }
        set {
            this.resultField = value;
        }
    }
    
    /// <remarks/>
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseInquiriesAnalysis {
    
    private byte totalLast7DaysField;
    
    private byte totalLast1MonthField;
    
    private byte nonBankingLast1MonthField;
    
    private responseInquiriesAnalysisRule[] policyRulesField;
    
    private object conclusionField;
    
    /// <remarks/>
    public byte TotalLast7Days {
        get {
            return this.totalLast7DaysField;
        }
        set {
            this.totalLast7DaysField = value;
        }
    }
    
    /// <remarks/>
    public byte TotalLast1Month {
        get {
            return this.totalLast1MonthField;
        }
        set {
            this.totalLast1MonthField = value;
        }
    }
    
    /// <remarks/>
    public byte NonBankingLast1Month {
        get {
            return this.nonBankingLast1MonthField;
        }
        set {
            this.nonBankingLast1MonthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Rule", IsNullable=false)]
    public responseInquiriesAnalysisRule[] PolicyRules {
        get {
            return this.policyRulesField;
        }
        set {
            this.policyRulesField = value;
        }
    }
    
    /// <remarks/>
    public object Conclusion {
        get {
            return this.conclusionField;
        }
        set {
            this.conclusionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseInquiriesAnalysisRule {
    
    private string resultField;
    
    private string descriptionField;
    
    private string idField;
    
    /// <remarks/>
    public string Result {
        get {
            return this.resultField;
        }
        set {
            this.resultField = value;
        }
    }
    
    /// <remarks/>
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseCurrentContracts {
    
    private responseCurrentContractsCurrentBanking currentBankingField;
    
    private responseCurrentContractsCurrentNonBanking currentNonBankingField;
    
    private responseCurrentContractsTotal totalField;
    
    /// <remarks/>
    public responseCurrentContractsCurrentBanking CurrentBanking {
        get {
            return this.currentBankingField;
        }
        set {
            this.currentBankingField = value;
        }
    }
    
    /// <remarks/>
    public responseCurrentContractsCurrentNonBanking CurrentNonBanking {
        get {
            return this.currentNonBankingField;
        }
        set {
            this.currentNonBankingField = value;
        }
    }
    
    /// <remarks/>
    public responseCurrentContractsTotal Total {
        get {
            return this.totalField;
        }
        set {
            this.totalField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseCurrentContractsCurrentBanking {
    
    private byte positiveField;
    
    private byte negativeField;
    
    private byte balanceField;
    
    private byte balanceAtRiskField;
    
    /// <remarks/>
    public byte Positive {
        get {
            return this.positiveField;
        }
        set {
            this.positiveField = value;
        }
    }
    
    /// <remarks/>
    public byte Negative {
        get {
            return this.negativeField;
        }
        set {
            this.negativeField = value;
        }
    }
    
    /// <remarks/>
    public byte Balance {
        get {
            return this.balanceField;
        }
        set {
            this.balanceField = value;
        }
    }
    
    /// <remarks/>
    public byte BalanceAtRisk {
        get {
            return this.balanceAtRiskField;
        }
        set {
            this.balanceAtRiskField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseCurrentContractsCurrentNonBanking {
    
    private byte positiveField;
    
    private byte negativeField;
    
    private byte balanceField;
    
    private byte balanceAtRiskField;
    
    /// <remarks/>
    public byte Positive {
        get {
            return this.positiveField;
        }
        set {
            this.positiveField = value;
        }
    }
    
    /// <remarks/>
    public byte Negative {
        get {
            return this.negativeField;
        }
        set {
            this.negativeField = value;
        }
    }
    
    /// <remarks/>
    public byte Balance {
        get {
            return this.balanceField;
        }
        set {
            this.balanceField = value;
        }
    }
    
    /// <remarks/>
    public byte BalanceAtRisk {
        get {
            return this.balanceAtRiskField;
        }
        set {
            this.balanceAtRiskField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseCurrentContractsTotal {
    
    private byte positiveField;
    
    private byte negativeField;
    
    private byte balanceField;
    
    private byte balanceAtRiskField;
    
    /// <remarks/>
    public byte Positive {
        get {
            return this.positiveField;
        }
        set {
            this.positiveField = value;
        }
    }
    
    /// <remarks/>
    public byte Negative {
        get {
            return this.negativeField;
        }
        set {
            this.negativeField = value;
        }
    }
    
    /// <remarks/>
    public byte Balance {
        get {
            return this.balanceField;
        }
        set {
            this.balanceField = value;
        }
    }
    
    /// <remarks/>
    public byte BalanceAtRisk {
        get {
            return this.balanceAtRiskField;
        }
        set {
            this.balanceAtRiskField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responsePastDueInformation {
    
    private byte totalCurrentPastDueField;
    
    private byte totalCurrentDaysPastDueField;
    
    private byte monthsWithoutArrearsLast12MonthsField;
    
    private byte totalMonthsWithHistoryLast12MonthsField;
    
    private byte percMonthsWithoutArrearsLast12MonthsField;
    
    /// <remarks/>
    public byte TotalCurrentPastDue {
        get {
            return this.totalCurrentPastDueField;
        }
        set {
            this.totalCurrentPastDueField = value;
        }
    }
    
    /// <remarks/>
    public byte TotalCurrentDaysPastDue {
        get {
            return this.totalCurrentDaysPastDueField;
        }
        set {
            this.totalCurrentDaysPastDueField = value;
        }
    }
    
    /// <remarks/>
    public byte MonthsWithoutArrearsLast12Months {
        get {
            return this.monthsWithoutArrearsLast12MonthsField;
        }
        set {
            this.monthsWithoutArrearsLast12MonthsField = value;
        }
    }
    
    /// <remarks/>
    public byte TotalMonthsWithHistoryLast12Months {
        get {
            return this.totalMonthsWithHistoryLast12MonthsField;
        }
        set {
            this.totalMonthsWithHistoryLast12MonthsField = value;
        }
    }
    
    /// <remarks/>
    public byte PercMonthsWithoutArrearsLast12Months {
        get {
            return this.percMonthsWithoutArrearsLast12MonthsField;
        }
        set {
            this.percMonthsWithoutArrearsLast12MonthsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseRepaymentInformation {
    
    private byte totalMonthlyPaymentField;
    
    private byte closedContractsField;
    
    /// <remarks/>
    public byte TotalMonthlyPayment {
        get {
            return this.totalMonthlyPaymentField;
        }
        set {
            this.totalMonthlyPaymentField = value;
        }
    }
    
    /// <remarks/>
    public byte ClosedContracts {
        get {
            return this.closedContractsField;
        }
        set {
            this.closedContractsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseRule {
    
    private string resultField;
    
    private string descriptionField;
    
    private string idField;
    
    /// <remarks/>
    public string Result {
        get {
            return this.resultField;
        }
        set {
            this.resultField = value;
        }
    }
    
    /// <remarks/>
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseExtract {
    
    private uint nationalIdField;
    
    private System.DateTime dateField;
    
    private string decisionField;
    
    private bool foundField;
    
    private byte nbrokenRulesField;
    
    private ushort mobileScoreField;
    
    private string mobileGradeField;
    
    private ushort cIPScoreField;
    
    private string cIPGradeField;
    
    private ulong allContactsField;
    
    private bool limitChangedField;
    
    private bool matchPreviousEligibleField;
    
    private byte nRepaidLoansField;
    
    private string creditRiskField;
    
    private string sCR1ResultField;
    
    private string sCR1ParameterField;
    
    private string sCR1ValueField;
    
    private string sCR3ResultField;
    
    private string sCR3ParameterField;
    
    private string sCR3ValueField;
    
    private string iNQ2ResultField;
    
    private byte iNQ2ParameterField;
    
    private byte iNQ2ValueField;
    
    private string rSK0ResultField;
    
    private string rSK2ResultField;
    
    private byte rSK2ParameterField;
    
    private string rSK3ResultField;
    
    private byte rSK3ParameterField;
    
    private string rSK4ResultField;
    
    private byte rSK4ParameterField;
    
    private string rSK6ResultField;
    
    private byte rSK6ParameterField;
    
    private byte rSK6ValueField;
    
    private string rSK7ResultField;
    
    private byte rSK7ParameterField;
    
    private string rSK8ResultField;
    
    private byte rSK8ParameterField;
    
    private byte rSK8ValueField;
    
    private string rSK11ResultField;
    
    private byte rSK11ParameterField;
    
    private string cST12ResultField;
    
    private string cST1ResultField;
    
    private string cST2ResultField;
    
    private string cST3ResultField;
    
    private string cST4ResultField;
    
    private string cST5ResultField;
    
    private bool existingCustomerField;
    
    private ulong mobilePhoneField;
    
    private byte ageOfBusinessField;
    
    private ushort salesTurnoverField;
    
    private byte nDaysInRolloverField;
    
    private byte nDeclinedApplicationsL3mField;
    
    private byte repaymentScoreField;
    
    private System.DateTime dateOfLastLimitChangeField;
    
    /// <remarks/>
    public uint NationalId {
        get {
            return this.nationalIdField;
        }
        set {
            this.nationalIdField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime Date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    public string Decision {
        get {
            return this.decisionField;
        }
        set {
            this.decisionField = value;
        }
    }
    
    /// <remarks/>
    public bool Found {
        get {
            return this.foundField;
        }
        set {
            this.foundField = value;
        }
    }
    
    /// <remarks/>
    public byte NbrokenRules {
        get {
            return this.nbrokenRulesField;
        }
        set {
            this.nbrokenRulesField = value;
        }
    }
    
    /// <remarks/>
    public ushort MobileScore {
        get {
            return this.mobileScoreField;
        }
        set {
            this.mobileScoreField = value;
        }
    }
    
    /// <remarks/>
    public string MobileGrade {
        get {
            return this.mobileGradeField;
        }
        set {
            this.mobileGradeField = value;
        }
    }
    
    /// <remarks/>
    public ushort CIPScore {
        get {
            return this.cIPScoreField;
        }
        set {
            this.cIPScoreField = value;
        }
    }
    
    /// <remarks/>
    public string CIPGrade {
        get {
            return this.cIPGradeField;
        }
        set {
            this.cIPGradeField = value;
        }
    }
    
    /// <remarks/>
    public ulong AllContacts {
        get {
            return this.allContactsField;
        }
        set {
            this.allContactsField = value;
        }
    }
    
    /// <remarks/>
    public bool LimitChanged {
        get {
            return this.limitChangedField;
        }
        set {
            this.limitChangedField = value;
        }
    }
    
    /// <remarks/>
    public bool MatchPreviousEligible {
        get {
            return this.matchPreviousEligibleField;
        }
        set {
            this.matchPreviousEligibleField = value;
        }
    }
    
    /// <remarks/>
    public byte NRepaidLoans {
        get {
            return this.nRepaidLoansField;
        }
        set {
            this.nRepaidLoansField = value;
        }
    }
    
    /// <remarks/>
    public string CreditRisk {
        get {
            return this.creditRiskField;
        }
        set {
            this.creditRiskField = value;
        }
    }
    
    /// <remarks/>
    public string SCR1Result {
        get {
            return this.sCR1ResultField;
        }
        set {
            this.sCR1ResultField = value;
        }
    }
    
    /// <remarks/>
    public string SCR1Parameter {
        get {
            return this.sCR1ParameterField;
        }
        set {
            this.sCR1ParameterField = value;
        }
    }
    
    /// <remarks/>
    public string SCR1Value {
        get {
            return this.sCR1ValueField;
        }
        set {
            this.sCR1ValueField = value;
        }
    }
    
    /// <remarks/>
    public string SCR3Result {
        get {
            return this.sCR3ResultField;
        }
        set {
            this.sCR3ResultField = value;
        }
    }
    
    /// <remarks/>
    public string SCR3Parameter {
        get {
            return this.sCR3ParameterField;
        }
        set {
            this.sCR3ParameterField = value;
        }
    }
    
    /// <remarks/>
    public string SCR3Value {
        get {
            return this.sCR3ValueField;
        }
        set {
            this.sCR3ValueField = value;
        }
    }
    
    /// <remarks/>
    public string INQ2Result {
        get {
            return this.iNQ2ResultField;
        }
        set {
            this.iNQ2ResultField = value;
        }
    }
    
    /// <remarks/>
    public byte INQ2Parameter {
        get {
            return this.iNQ2ParameterField;
        }
        set {
            this.iNQ2ParameterField = value;
        }
    }
    
    /// <remarks/>
    public byte INQ2Value {
        get {
            return this.iNQ2ValueField;
        }
        set {
            this.iNQ2ValueField = value;
        }
    }
    
    /// <remarks/>
    public string RSK0Result {
        get {
            return this.rSK0ResultField;
        }
        set {
            this.rSK0ResultField = value;
        }
    }
    
    /// <remarks/>
    public string RSK2Result {
        get {
            return this.rSK2ResultField;
        }
        set {
            this.rSK2ResultField = value;
        }
    }
    
    /// <remarks/>
    public byte RSK2Parameter {
        get {
            return this.rSK2ParameterField;
        }
        set {
            this.rSK2ParameterField = value;
        }
    }
    
    /// <remarks/>
    public string RSK3Result {
        get {
            return this.rSK3ResultField;
        }
        set {
            this.rSK3ResultField = value;
        }
    }
    
    /// <remarks/>
    public byte RSK3Parameter {
        get {
            return this.rSK3ParameterField;
        }
        set {
            this.rSK3ParameterField = value;
        }
    }
    
    /// <remarks/>
    public string RSK4Result {
        get {
            return this.rSK4ResultField;
        }
        set {
            this.rSK4ResultField = value;
        }
    }
    
    /// <remarks/>
    public byte RSK4Parameter {
        get {
            return this.rSK4ParameterField;
        }
        set {
            this.rSK4ParameterField = value;
        }
    }
    
    /// <remarks/>
    public string RSK6Result {
        get {
            return this.rSK6ResultField;
        }
        set {
            this.rSK6ResultField = value;
        }
    }
    
    /// <remarks/>
    public byte RSK6Parameter {
        get {
            return this.rSK6ParameterField;
        }
        set {
            this.rSK6ParameterField = value;
        }
    }
    
    /// <remarks/>
    public byte RSK6Value {
        get {
            return this.rSK6ValueField;
        }
        set {
            this.rSK6ValueField = value;
        }
    }
    
    /// <remarks/>
    public string RSK7Result {
        get {
            return this.rSK7ResultField;
        }
        set {
            this.rSK7ResultField = value;
        }
    }
    
    /// <remarks/>
    public byte RSK7Parameter {
        get {
            return this.rSK7ParameterField;
        }
        set {
            this.rSK7ParameterField = value;
        }
    }
    
    /// <remarks/>
    public string RSK8Result {
        get {
            return this.rSK8ResultField;
        }
        set {
            this.rSK8ResultField = value;
        }
    }
    
    /// <remarks/>
    public byte RSK8Parameter {
        get {
            return this.rSK8ParameterField;
        }
        set {
            this.rSK8ParameterField = value;
        }
    }
    
    /// <remarks/>
    public byte RSK8Value {
        get {
            return this.rSK8ValueField;
        }
        set {
            this.rSK8ValueField = value;
        }
    }
    
    /// <remarks/>
    public string RSK11Result {
        get {
            return this.rSK11ResultField;
        }
        set {
            this.rSK11ResultField = value;
        }
    }
    
    /// <remarks/>
    public byte RSK11Parameter {
        get {
            return this.rSK11ParameterField;
        }
        set {
            this.rSK11ParameterField = value;
        }
    }
    
    /// <remarks/>
    public string CST12Result {
        get {
            return this.cST12ResultField;
        }
        set {
            this.cST12ResultField = value;
        }
    }
    
    /// <remarks/>
    public string CST1Result {
        get {
            return this.cST1ResultField;
        }
        set {
            this.cST1ResultField = value;
        }
    }
    
    /// <remarks/>
    public string CST2Result {
        get {
            return this.cST2ResultField;
        }
        set {
            this.cST2ResultField = value;
        }
    }
    
    /// <remarks/>
    public string CST3Result {
        get {
            return this.cST3ResultField;
        }
        set {
            this.cST3ResultField = value;
        }
    }
    
    /// <remarks/>
    public string CST4Result {
        get {
            return this.cST4ResultField;
        }
        set {
            this.cST4ResultField = value;
        }
    }
    
    /// <remarks/>
    public string CST5Result {
        get {
            return this.cST5ResultField;
        }
        set {
            this.cST5ResultField = value;
        }
    }
    
    /// <remarks/>
    public bool ExistingCustomer {
        get {
            return this.existingCustomerField;
        }
        set {
            this.existingCustomerField = value;
        }
    }
    
    /// <remarks/>
    public ulong MobilePhone {
        get {
            return this.mobilePhoneField;
        }
        set {
            this.mobilePhoneField = value;
        }
    }
    
    /// <remarks/>
    public byte AgeOfBusiness {
        get {
            return this.ageOfBusinessField;
        }
        set {
            this.ageOfBusinessField = value;
        }
    }
    
    /// <remarks/>
    public ushort SalesTurnover {
        get {
            return this.salesTurnoverField;
        }
        set {
            this.salesTurnoverField = value;
        }
    }
    
    /// <remarks/>
    public byte NDaysInRollover {
        get {
            return this.nDaysInRolloverField;
        }
        set {
            this.nDaysInRolloverField = value;
        }
    }
    
    /// <remarks/>
    public byte NDeclinedApplicationsL3m {
        get {
            return this.nDeclinedApplicationsL3mField;
        }
        set {
            this.nDeclinedApplicationsL3mField = value;
        }
    }
    
    /// <remarks/>
    public byte RepaymentScore {
        get {
            return this.repaymentScoreField;
        }
        set {
            this.repaymentScoreField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime DateOfLastLimitChange {
        get {
            return this.dateOfLastLimitChangeField;
        }
        set {
            this.dateOfLastLimitChangeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseStrategy {
    
    private string idField;
    
    private string nameField;
    
    private string beeStrategyField;
    
    private string templateNameField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public string BeeStrategy {
        get {
            return this.beeStrategyField;
        }
        set {
            this.beeStrategyField = value;
        }
    }
    
    /// <remarks/>
    public string TemplateName {
        get {
            return this.templateNameField;
        }
        set {
            this.templateNameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseSteps {
    
    private responseStepsStep stepField;
    
    /// <remarks/>
    public responseStepsStep Step {
        get {
            return this.stepField;
        }
        set {
            this.stepField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseStepsStep {
    
    private string idField;
    
    private string nameField;
    
    private string beeStrategyField;
    
    private string templateNameField;
    
    private responseStepsStepStrategyResponse strategyResponseField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public string BeeStrategy {
        get {
            return this.beeStrategyField;
        }
        set {
            this.beeStrategyField = value;
        }
    }
    
    /// <remarks/>
    public string TemplateName {
        get {
            return this.templateNameField;
        }
        set {
            this.templateNameField = value;
        }
    }
    
    /// <remarks/>
    public responseStepsStepStrategyResponse StrategyResponse {
        get {
            return this.strategyResponseField;
        }
        set {
            this.strategyResponseField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://creditinfo.com/schemas/2012/09/MultiConnector/Connectors/INT/IdmStrategy/R" +
    "esponse")]
public partial class responseStepsStepStrategyResponse {
    
    private string statusField;
    
    private string infomsgField;
    
    /// <remarks/>
    public string status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    public string infomsg {
        get {
            return this.infomsgField;
        }
        set {
            this.infomsgField = value;
        }
    }
}

