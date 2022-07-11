namespace IntellVega.CBB.Interfaces.Attributes
{
    public class SelectColorAttribute : RemarkAttribute
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="remarkLocalName">提示文字</param>
        /// <param name="isEnabled">是否可用</param>
        public SelectColorAttribute(string remarkLocalName, bool isEnabled = true) : base(remarkLocalName, isEnabled)
        {

        }
    }
}
