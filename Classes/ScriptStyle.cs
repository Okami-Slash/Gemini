using System.Drawing;

namespace Gemini
{
	[System.Serializable]
	public struct ScriptStyle
	{
		public Color ForeColor;
		public Color BackColor;
		public Font Font;
		public string Name;

		public ScriptStyle(string name, Color fore, Color back, Font font)
		{
			Name = name;
			ForeColor = fore;
			BackColor = back;
			Font = font;
		}
	}
}
