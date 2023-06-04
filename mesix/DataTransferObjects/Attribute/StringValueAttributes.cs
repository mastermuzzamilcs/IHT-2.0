namespace DataTransferObjects.Attribute
{
    public class StringValueAttributes : System.Attribute
    {
        #region Properties
        public string StringValue { get; protected set; }
        #endregion
        #region Contructor
        /// <summary>
        /// Constructor Used to init a StringValue Attribute
        /// </summary>
        /// <param name="value"></param>
        public StringValueAttributes(string value)
        {
            this.StringValue = value;
        }
        #endregion
    }
    public class DescriptionStringValueAttributes : System.Attribute
    {
        #region Properties
        public string DescriptionStringValue { get; protected set; }
        #endregion
        #region Contructor
        /// <summary>
        /// Constructor Used to init a StringValue Attribute
        /// </summary>
        /// <param name="value"></param>
        public DescriptionStringValueAttributes(string value)
        {
            this.DescriptionStringValue = value;
        }
        #endregion
    }
}
