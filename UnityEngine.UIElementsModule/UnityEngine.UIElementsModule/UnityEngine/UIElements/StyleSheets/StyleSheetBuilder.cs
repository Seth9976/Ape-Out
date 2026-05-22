using System;
using System.Runtime.InteropServices;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000181 RID: 385
	public class StyleSheetBuilder
	{
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x000080A7 File Offset: 0x000062A7
		public StyleProperty currentProperty
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000080B4 File Offset: 0x000062B4
		public StyleRule BeginRule(int ruleLine)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x000080C1 File Offset: 0x000062C1
		public void EndComplexSelector()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x000080CE File Offset: 0x000062CE
		public StyleProperty BeginProperty(string name, [Optional] int line)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x000080DB File Offset: 0x000062DB
		public void AddValue(float value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000080E8 File Offset: 0x000062E8
		public void AddValue(StyleValueKeyword keyword)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000080F5 File Offset: 0x000062F5
		public void AddValue(StyleValueFunction function)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00008102 File Offset: 0x00006302
		public void AddValue(string value, StyleValueType type)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0000810F File Offset: 0x0000630F
		public void AddValue(Color value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0000811C File Offset: 0x0000631C
		public void AddValue(Object value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00008129 File Offset: 0x00006329
		public void EndProperty()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00008136 File Offset: 0x00006336
		public int EndRule()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00008143 File Offset: 0x00006343
		public void BuildTo(StyleSheet writeTo)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00008150 File Offset: 0x00006350
		public void RegisterVariable(string value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0000815D File Offset: 0x0000635D
		public void RegisterValue<T>(List<T> list, StyleValueType type, T value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0000816A File Offset: 0x0000636A
		public static void Log(string msg)
		{
		}

		// Token: 0x02000217 RID: 535
		public enum BuilderState
		{
			// Token: 0x04000273 RID: 627
			Init,
			// Token: 0x04000274 RID: 628
			Rule,
			// Token: 0x04000275 RID: 629
			ComplexSelector,
			// Token: 0x04000276 RID: 630
			Property
		}
	}
}
