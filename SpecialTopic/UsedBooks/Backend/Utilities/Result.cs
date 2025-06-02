namespace SpecialTopic.UsedBooks.Backend.Utilities
{
    /// <summary>
    /// 表示跨層（Repository、Service 等）返回的統一結果包裝類。
    /// 用來封裝執行成功與否、成功時的資料，以及失敗時的錯誤訊息。
    /// 
    /// 注意：
    /// - 預期性錯誤（如資料不存在、驗證失敗）請用 Failure 回傳。
    /// - 非預期錯誤（如系統錯誤、未處理例外）請 throw exception。
    /// </summary>
    /// <typeparam name="T">回傳的資料型別</typeparam>
    /// NOTE: 可考慮四元組 Result<T>(bool isSuccess, T value, string errorMessage, ErrorType? errorCode)
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public T Value { get; }
        public string ErrorMessage { get; } = string.Empty;

        /// <summary>
        /// 私有建構子，僅允許透過靜態工廠方法建立 Result 實例。
        /// </summary>
        private Result(bool isSuccess, T value, string errorMessage)
        {
            IsSuccess = isSuccess;
            Value = value;
            ErrorMessage = errorMessage;
        }

        public static Result<T> Success(T value)
        {
            return new Result<T>(true, value, string.Empty);
        }

        public static Result<T> Failure(string errorMessage)
        {
            return new Result<T>(false, default, errorMessage);
        }
    }
}