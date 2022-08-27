using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entites {
    public class BaseEntites {
        [Key]
        public Guid? Id { get; set; }

        private DateTime? _creatAt;
        public DateTime? CreatAt {
            get { return _creatAt; }
            set { _creatAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }

    }
}
