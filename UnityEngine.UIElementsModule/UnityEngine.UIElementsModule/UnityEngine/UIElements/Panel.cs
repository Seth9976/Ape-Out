using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000034 RID: 52
	public class Panel : BaseVisualElementPanel
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00002A57 File Offset: 0x00000C57
		public sealed override VisualElement visualTree
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00002A64 File Offset: 0x00000C64
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x00002A71 File Offset: 0x00000C71
		public sealed override EventDispatcher dispatcher
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00002A7E File Offset: 0x00000C7E
		public TimerEventScheduler timerEventScheduler
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00008D50 File Offset: 0x00006F50
		public override IScheduler scheduler
		{
			get
			{
				return this.timerEventScheduler;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002A8B File Offset: 0x00000C8B
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002A98 File Offset: 0x00000C98
		public override ScriptableObject ownerObject
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00002AA5 File Offset: 0x00000CA5
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002AB2 File Offset: 0x00000CB2
		public override ContextType contextType
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002ABF File Offset: 0x00000CBF
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002ACC File Offset: 0x00000CCC
		public sealed override FocusController focusController
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002AD9 File Offset: 0x00000CD9
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002AE6 File Offset: 0x00000CE6
		public sealed override IEventInterpreter eventInterpreter
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002AF3 File Offset: 0x00000CF3
		public static Object LoadResource(string pathName, Type type, float dpiScaling)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002B00 File Offset: 0x00000D00
		public void Focus()
		{
			FocusController focusController = this.focusController;
			if (focusController != null)
			{
				focusController.SetFocusToLastFocusedElement();
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002B15 File Offset: 0x00000D15
		public void Blur()
		{
			FocusController focusController = this.focusController;
			if (focusController != null)
			{
				focusController.BlurLastFocusedElement();
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00002B2A File Offset: 0x00000D2A
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002B37 File Offset: 0x00000D37
		public string name
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002B44 File Offset: 0x00000D44
		public void CreateMarkers()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002B51 File Offset: 0x00000D51
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002B5E File Offset: 0x00000D5E
		public override int IMGUIContainersCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002B6B File Offset: 0x00000D6B
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002B78 File Offset: 0x00000D78
		public override IMGUIContainer rootIMGUIContainer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002B85 File Offset: 0x00000D85
		public override uint version
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002B92 File Offset: 0x00000D92
		public override uint repaintVersion
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002B9F File Offset: 0x00000D9F
		public override uint hierarchyVersion
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002BAC File Offset: 0x00000DAC
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002BB9 File Offset: 0x00000DB9
		public override Shader standardShader
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00008D68 File Offset: 0x00006F68
		public static Panel CreateEditorPanel(ScriptableObject ownerObject)
		{
			return new Panel(ownerObject, ContextType.Editor, EventDispatcher.CreateDefault());
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002BC6 File Offset: 0x00000DC6
		public override void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002BD3 File Offset: 0x00000DD3
		public static long TimeSinceStartupMs()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00008D88 File Offset: 0x00006F88
		public static long DefaultTimeSinceStartupMs()
		{
			return (long)(Time.realtimeSinceStartup * 1000f);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00008DA8 File Offset: 0x00006FA8
		public static VisualElement PickAllWithoutValidatingLayout(VisualElement root, Vector2 point)
		{
			return Panel.PickAll(root, point, null);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00008DC4 File Offset: 0x00006FC4
		public static VisualElement PickAll(VisualElement root, Vector2 point, [Optional] List<VisualElement> picked)
		{
			return Panel.PerformPick(root, point, picked);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002BE0 File Offset: 0x00000DE0
		public static VisualElement PerformPick(VisualElement root, Vector2 point, [Optional] List<VisualElement> picked)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00008DE0 File Offset: 0x00006FE0
		public override VisualElement PickAll(Vector2 point, List<VisualElement> picked)
		{
			this.ValidateLayout();
			bool flag = picked != null;
			if (flag)
			{
				picked.Clear();
			}
			return Panel.PickAll(this.visualTree, point, picked);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002BED File Offset: 0x00000DED
		public override VisualElement Pick(Vector2 point)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002BFA File Offset: 0x00000DFA
		public override void ValidateLayout()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002C07 File Offset: 0x00000E07
		public override void UpdateAnimations()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002C14 File Offset: 0x00000E14
		public override void UpdateBindings()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002C21 File Offset: 0x00000E21
		public override void ApplyStyles()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002C2E File Offset: 0x00000E2E
		public void UpdateForRepaint()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002C3B File Offset: 0x00000E3B
		public static void add_beforeAnyRepaint(Action<Panel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002C48 File Offset: 0x00000E48
		public static void remove_beforeAnyRepaint(Action<Panel> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002C55 File Offset: 0x00000E55
		public override void Repaint(Event e)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002C62 File Offset: 0x00000E62
		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002C6F File Offset: 0x00000E6F
		public override void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002C7C File Offset: 0x00000E7C
		public override IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
