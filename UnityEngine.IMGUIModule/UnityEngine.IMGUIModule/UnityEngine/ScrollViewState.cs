using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001B RID: 27
	public class ScrollViewState : Object
	{
		// Token: 0x06000512 RID: 1298 RVA: 0x0001461C File Offset: 0x0001281C
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollViewState()
		{
			Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "ScrollViewState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr);
			ScrollViewState.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "position");
			ScrollViewState.NativeFieldInfoPtr_visibleRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "visibleRect");
			ScrollViewState.NativeFieldInfoPtr_viewRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "viewRect");
			ScrollViewState.NativeFieldInfoPtr_scrollPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "scrollPosition");
			ScrollViewState.NativeFieldInfoPtr_apply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "apply");
			ScrollViewState.NativeFieldInfoPtr_isDuringTouchScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "isDuringTouchScroll");
			ScrollViewState.NativeFieldInfoPtr_touchScrollStartMousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "touchScrollStartMousePosition");
			ScrollViewState.NativeFieldInfoPtr_touchScrollStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "touchScrollStartPosition");
			ScrollViewState.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "velocity");
			ScrollViewState.NativeFieldInfoPtr_previousTimeSinceStartup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, "previousTimeSinceStartup");
			ScrollViewState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, 100663755);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00014728 File Offset: 0x00012928
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollViewState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollViewState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000040DC File Offset: 0x000022DC
		public ScrollViewState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00014764 File Offset: 0x00012964
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x000040E5 File Offset: 0x000022E5
		public unsafe Rect position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0001478C File Offset: 0x0001298C
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00004100 File Offset: 0x00002300
		public unsafe Rect visibleRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_visibleRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_visibleRect)) = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x000147B4 File Offset: 0x000129B4
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0000411B File Offset: 0x0000231B
		public unsafe Rect viewRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_viewRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_viewRect)) = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x000147DC File Offset: 0x000129DC
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00004136 File Offset: 0x00002336
		public unsafe Vector2 scrollPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_scrollPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_scrollPosition)) = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x00014804 File Offset: 0x00012A04
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00004151 File Offset: 0x00002351
		public unsafe bool apply
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_apply);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_apply)) = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0001482C File Offset: 0x00012A2C
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x0000416C File Offset: 0x0000236C
		public unsafe bool isDuringTouchScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_isDuringTouchScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_isDuringTouchScroll)) = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00014854 File Offset: 0x00012A54
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00004187 File Offset: 0x00002387
		public unsafe Vector2 touchScrollStartMousePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_touchScrollStartMousePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_touchScrollStartMousePosition)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0001487C File Offset: 0x00012A7C
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x000041A2 File Offset: 0x000023A2
		public unsafe Vector2 touchScrollStartPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_touchScrollStartPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_touchScrollStartPosition)) = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x000148A4 File Offset: 0x00012AA4
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x000041BD File Offset: 0x000023BD
		public unsafe Vector2 velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_velocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_velocity)) = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x000148CC File Offset: 0x00012ACC
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x000041D8 File Offset: 0x000023D8
		public unsafe float previousTimeSinceStartup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_previousTimeSinceStartup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollViewState.NativeFieldInfoPtr_previousTimeSinceStartup)) = value;
			}
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x000041F3 File Offset: 0x000023F3
		public void ScrollTo(Rect pos)
		{
			this.ScrollTowards(pos, float.PositiveInfinity);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000148F4 File Offset: 0x00012AF4
		public bool ScrollTowards(Rect pos, float maxDelta)
		{
			Vector2 vector = this.ScrollNeeded(pos);
			bool flag = vector.sqrMagnitude < 0.0001f;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = maxDelta == 0f;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = vector.magnitude > maxDelta;
					if (flag4)
					{
						vector = vector.normalized * maxDelta;
					}
					this.scrollPosition += vector;
					this.apply = true;
					flag2 = true;
				}
			}
			return flag2;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00004203 File Offset: 0x00002403
		public Vector2 ScrollNeeded(Rect pos)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeFieldInfoPtr_visibleRect;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_viewRect;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_scrollPosition;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_apply;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_isDuringTouchScroll;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeFieldInfoPtr_touchScrollStartMousePosition;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeFieldInfoPtr_touchScrollStartPosition;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeFieldInfoPtr_velocity;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeFieldInfoPtr_previousTimeSinceStartup;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
