namespace CKHud.HudComponents {
    public class HudComponent {
        public static HudComponent Parse(string str) {
            switch (str) {
                case "FPS":
                    return new FPSHudComponent();
                case "FPSCap":
                    return new FPSCapHudComponent();
                case "Position":
                    return new PositionHudComponent();
                case "CenterDistance":
                    return new CenterDistanceHudComponent();
                case "DPS":
                    return new DPSHudComponent();
                case "LocalComputerTime":
                    return new LocalComputerTimeHudComponent();
                case "MaxDPS":
                    return new MaxDPSHudComponent();
                default:
                    return null;
            }
        }
        
        public virtual string GetString() {
            return "";
        }
    }
}
