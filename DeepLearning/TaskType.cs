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

        [Display(Name = "光学字符识别")]
        ocr = 4,

        [Display(Name = "异常检测")]
        anomalyDetection = 5,
    }
}
