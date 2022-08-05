using System.ComponentModel.DataAnnotations;

namespace IntellVega.CBB.Interfaces.DeepLearning
{
    public enum TaskType
    {
        [Display(Name = "分类")]
        classification = 0,

        [Display(Name = "检测")]
        detection = 1,

        [Display(Name = "分割")]
        segmentation = 2,

        [Display(Name = "定位")]
        location = 3,

        [Display(Name = "单个光学字符识别")]
        lineocr = 4,

        [Display(Name = "多个光学字符识别")]
        bendocr = 5,

        [Display(Name = "异常检测")]
        abnormalDet = 6,
    }
}
