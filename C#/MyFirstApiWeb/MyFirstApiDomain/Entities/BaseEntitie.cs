using System;
using System.ComponentModel.DataAnnotations;

namespace MyFirstApiDomain.Entities{
    public abstract class BaseEntitie{

        [Key]
        public Guid Id { get; set; }

        private DateTime? _creatAt;
        public DateTime? CreateAt{
            get { return _creatAt; }
            set { _creatAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }
    }
}