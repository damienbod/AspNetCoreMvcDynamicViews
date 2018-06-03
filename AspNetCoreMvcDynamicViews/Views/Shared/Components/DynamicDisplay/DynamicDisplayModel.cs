namespace AspNetCoreMvcDynamicViews.Views.Shared.Components.DynamicDisplay
{
    public class DynamicDisplayModel
    {
        public int NoOfHoles { get; set; } = 1;

        public int Height { get; set; } = 50;

        public int NoOfBoxes { get; set; } = 1;

        public int BoxWidth { get; set; } = 50;

        public string GetAsStringWithPx(int value)
        {
            return $"{value}px";
        }
    }
}
