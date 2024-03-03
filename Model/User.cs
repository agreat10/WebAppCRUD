using System.ComponentModel.DataAnnotations;

namespace WebAppCRUD.Model
{
    public class User
    {
        public int ID { get; set; }

        [Display(Name = "Задача")]
        public string Name { get; set; }

        [Display(Name = "Описание задачи")]
        public string Description { get; set; }

        [Display(Name = "Срок вполнения")]
        public DateTime Times { get; set; }

        [Display(Name = "Исполнитель")]
        public string Сontractor { get; set; }

        [Display(Name = "Состояние")]
        public string IsWork { get; set; }
    }
}
