namespace AspNetCoreMvcDynamicViews.Views.Shared.Components.DynamicDisplay
{
    public class DynamicDisplayModel
    {
        public int NoOfHoles { get; set; } = 2;

        public int BoxHeight { get; set; } = 100;

        public int NoOfBoxes { get; set; } = 2;

        public int BoxWidth { get; set; } = 200;

        public string GetAsStringWithPx(int value)
        {
            return $"{value}px";
        }

        public string GetDisplayHeight()
        {
            return $"{BoxHeight + 50 }px";
        }

        public string GetDisplayWidth()
        {
            return $"{BoxWidth * NoOfBoxes}px";
        }
    }
}
