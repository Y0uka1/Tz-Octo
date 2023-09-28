namespace DTT.MinigameBase.Advertisements
{
    /// <summary>
    /// Interface for ad initializers.
    /// </summary>
    public interface IAdsInitializer
    {
        /// <summary>
        /// Initializes the ads.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Called when the ads have been initialized.
        /// </summary>
        void OnInitializationComplete();
    }
}