using System;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000020 RID: 32
	public class IMGUIContainer : VisualElement
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000025E5 File Offset: 0x000007E5
		public ObjectGUIState guiState
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000025F2 File Offset: 0x000007F2
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000025FF File Offset: 0x000007FF
		public Rect lastWorldClip
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0000260C File Offset: 0x0000080C
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002619 File Offset: 0x00000819
		public bool cullingEnabled
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

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002626 File Offset: 0x00000826
		public GUILayoutUtility.LayoutCache cache
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00008994 File Offset: 0x00006B94
		public float layoutMeasuredWidth
		{
			get
			{
				return Mathf.Ceil(this.cache.topLevel.maxWidth);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000089BC File Offset: 0x00006BBC
		public float layoutMeasuredHeight
		{
			get
			{
				return Mathf.Ceil(this.cache.topLevel.maxHeight);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002633 File Offset: 0x00000833
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002640 File Offset: 0x00000840
		public ContextType contextType
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000264D File Offset: 0x0000084D
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000265A File Offset: 0x0000085A
		public bool focusOnlyIfHasFocusableControls
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

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002667 File Offset: 0x00000867
		public override bool canGrabFocus
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002674 File Offset: 0x00000874
		public void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002681 File Offset: 0x00000881
		public void SaveGlobals()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000268E File Offset: 0x0000088E
		public void RestoreGlobals()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000269B File Offset: 0x0000089B
		public void MarkDirtyLayout()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000089E4 File Offset: 0x00006BE4
		public override void HandleEvent(EventBase evt)
		{
			base.HandleEvent(evt);
			bool flag = evt == null;
			if (!flag)
			{
				bool flag2 = evt.propagationPhase != PropagationPhase.TrickleDown && evt.propagationPhase != PropagationPhase.AtTarget && evt.propagationPhase != PropagationPhase.BubbleUp;
				if (!flag2)
				{
					bool flag3 = evt.imguiEvent == null;
					if (!flag3)
					{
						bool isPropagationStopped = evt.isPropagationStopped;
						if (!isPropagationStopped)
						{
							bool flag4 = this.SendEventToIMGUI(evt, true, true);
							if (flag4)
							{
								evt.StopPropagation();
								evt.PreventDefault();
							}
						}
					}
				}
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000026A8 File Offset: 0x000008A8
		public void DoIMGUIRepaint()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00008A6C File Offset: 0x00006C6C
		public bool SendEventToIMGUI(EventBase evt, [Optional] bool canAffectFocus, [Optional] bool verifyBounds)
		{
			bool flag = evt.TryCast<IPointerEvent>() != null;
			bool flag12;
			if (flag)
			{
				bool flag2 = evt.imguiEvent != null && evt.imguiEvent.isDirectManipulationDevice;
				if (flag2)
				{
					bool flag3 = false;
					EventType rawType = evt.imguiEvent.rawType;
					bool flag4 = evt.TryCast<PointerDownEvent>() != null;
					if (flag4)
					{
						flag3 = true;
						evt.imguiEvent.type = EventType.TouchDown;
					}
					else
					{
						bool flag5 = evt.TryCast<PointerUpEvent>() != null;
						if (flag5)
						{
							flag3 = true;
							evt.imguiEvent.type = EventType.TouchUp;
						}
						else
						{
							bool flag6 = evt.TryCast<PointerMoveEvent>() != null && evt.imguiEvent.rawType == EventType.MouseDrag;
							if (flag6)
							{
								flag3 = true;
								evt.imguiEvent.type = EventType.TouchMove;
							}
							else
							{
								bool flag7 = evt.TryCast<PointerLeaveEvent>() != null;
								if (flag7)
								{
									flag3 = true;
									evt.imguiEvent.type = EventType.TouchLeave;
								}
								else
								{
									bool flag8 = evt.TryCast<PointerEnterEvent>() != null;
									if (flag8)
									{
										flag3 = true;
										evt.imguiEvent.type = EventType.TouchEnter;
									}
									else
									{
										bool flag9 = evt.TryCast<PointerStationaryEvent>() != null;
										if (flag9)
										{
											flag3 = true;
											evt.imguiEvent.type = EventType.TouchStationary;
										}
									}
								}
							}
						}
					}
					bool flag10 = flag3;
					if (flag10)
					{
						bool flag11 = this.SendEventToIMGUIRaw(evt, canAffectFocus, verifyBounds);
						evt.imguiEvent.type = rawType;
						return flag11;
					}
				}
				flag12 = false;
			}
			else
			{
				flag12 = this.SendEventToIMGUIRaw(evt, canAffectFocus, verifyBounds);
			}
			return flag12;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00008BD8 File Offset: 0x00006DD8
		public bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds)
		{
			bool flag = verifyBounds && !this.VerifyBounds(evt);
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3;
				using (new EventDebuggerLogIMGUICall(evt))
				{
					flag3 = this.HandleIMGUIEvent(evt.imguiEvent, canAffectFocus);
				}
				flag2 = flag3;
			}
			return flag2;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00008C3C File Offset: 0x00006E3C
		public bool VerifyBounds(EventBase evt)
		{
			return this.IsContainerCapturingTheMouse() || !this.IsLocalEvent(evt) || this.IsEventInsideLocalWindow(evt);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000026B5 File Offset: 0x000008B5
		public bool IsContainerCapturingTheMouse()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000026C2 File Offset: 0x000008C2
		public bool IsLocalEvent(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000026CF File Offset: 0x000008CF
		public bool IsEventInsideLocalWindow(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000026DC File Offset: 0x000008DC
		public bool HandleIMGUIEvent(Event e, bool canAffectFocus)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000026E9 File Offset: 0x000008E9
		public override void ExecuteDefaultAction(EventBase evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000026F6 File Offset: 0x000008F6
		public override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008C6C File Offset: 0x00006E6C
		public Rect GetCurrentClipRect()
		{
			Rect rect = this.lastWorldClip;
			bool flag = rect.width == 0f || rect.height == 0f;
			if (flag)
			{
				rect = base.worldBound;
			}
			return rect;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00008CB4 File Offset: 0x00006EB4
		public static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect)
		{
			clipRect = container.GetCurrentClipRect();
			transform = container.worldTransform;
			bool flag = evt.rawType == EventType.Repaint && container.elementPanel != null;
			if (flag)
			{
				transform = container.elementPanel.repaintData.currentOffset * container.worldTransform;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002703 File Offset: 0x00000903
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002715 File Offset: 0x00000915
		public virtual void Dispose(bool disposeManaged)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002722 File Offset: 0x00000922
		public void <DoOnGUI>b__52_0()
		{
			base.IncrementVersion(VersionChangeType.Layout);
		}

		// Token: 0x020001A1 RID: 417
		public new class UxmlFactory : UxmlFactory<IMGUIContainer, IMGUIContainer.UxmlTraits>
		{
		}

		// Token: 0x020001A2 RID: 418
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x0200021B RID: 539
			public sealed class <get_uxmlChildElementsDescription>d__2
			{
			}
		}
	}
}
