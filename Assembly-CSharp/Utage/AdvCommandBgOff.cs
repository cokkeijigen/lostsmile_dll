namespace Utage
{
	internal class AdvCommandBgOff : AdvCommand
	{
		private float fadeTime;

		public AdvCommandBgOff(StringGridRow row)
			: base(row)
		{
			fadeTime = ParseCellOptional(AdvColumnName.Arg6, 0.2f);
		}

		public override void DoCommand(AdvEngine engine)
		{
			engine.GraphicManager.BgManager.FadeOutAll(engine.Page.ToSkippedTime(fadeTime));
		}
	}
}
