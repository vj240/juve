namespace FELA.Data
{

    public enum QuestionType { Simple, RadioButton, Table, CheckBox }

    public enum AnswerType { Option, Numeric, String, Table, CheckBox }

    public enum Operation { Set, Add }

    public enum QualifierType { EqualTo, NotEqualTo, LessThan, GreaterThan, LessThanOrEqual, GreaterThanOrEqual, Between, NotBetween }

    public enum FactorType { Risk }

    public enum UserMetricState { Good, AtRisk, Unknown }

}
