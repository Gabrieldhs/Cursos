using FluentValidation.Results;

namespace mp.component.business.Services
{
    public class ResultService
    {
        public bool IsSucess { get; set; }
        public string Message { get; set; }
        public ICollection<ErrosValidations> Errors { get; set; }

        public  static ResultService RequestError(string message, ValidationResult validationResult)
        {
            return new ResultService
            {
                IsSucess = false,
                Message = message,
                Errors = validationResult.Errors.Select(x => new ErrosValidations { Field = x.PropertyName, Message = x.ErrorMessage }).ToList()
            };
        }

        public static ResultServices<T> RequestError<T>(string message, ValidationResult validationResult)
        {
            return new ResultServices<T>
            {
                IsSucess = false,
                Message = message,
                Errors = validationResult.Errors.Select(x => new ErrosValidations { Field = x.PropertyName, Message = x.ErrorMessage}).ToList()
            };
        }

        public static ResultService Fail(string message) => new ResultService { IsSucess = false, Message = message };
        public static ResultServices<T> Fail<T>(string message) => new ResultServices<T> { IsSucess = false, Message = message };

        public static ResultService Ok(string message) => new ResultService { IsSucess = true, Message = message };
        public static ResultServices<T> Ok<T>(string data) => new ResultServices<T> { IsSucess = true, Message = data };

        public class ResultServices<T> : ResultService
        {
            public T Data { get; set; }
        }
    }
}
