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

        [Display(Name = "OCR")]
        ocr = 4,

        [Display(Name = "直行OCR")]
        lineocr = 5,

        //[Display(Name = "弯曲OCR")]
        //bendocr = 6,

        [Display(Name = "异常检测")]
        abnormalDet = 7
    }
}
