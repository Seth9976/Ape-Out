using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired.UI.ControlMapper
{
	// Token: 0x020001F0 RID: 496
	public class CanvasScalerFitter : MonoBehaviour
	{
		// Token: 0x06003A89 RID: 14985 RVA: 0x000DA2B0 File Offset: 0x000D84B0
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasScalerFitter()
		{
			Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", "CanvasScalerFitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr);
			CanvasScalerFitter.NativeFieldInfoPtr_breakPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, "breakPoints");
			CanvasScalerFitter.NativeFieldInfoPtr_canvasScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, "canvasScaler");
			CanvasScalerFitter.NativeFieldInfoPtr_screenWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, "screenWidth");
			CanvasScalerFitter.NativeFieldInfoPtr_screenHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, "screenHeight");
			CanvasScalerFitter.NativeFieldInfoPtr_ScreenSizeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, "ScreenSizeChanged");
			CanvasScalerFitter.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, 100668266);
			CanvasScalerFitter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, 100668267);
			CanvasScalerFitter.NativeMethodInfoPtr_UpdateSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, 100668268);
			CanvasScalerFitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, 100668269);
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x000DA394 File Offset: 0x000D8594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91103, XrefRangeEnd = 91124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScalerFitter.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x000DA3C8 File Offset: 0x000D85C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91124, XrefRangeEnd = 91133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScalerFitter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x000DA3FC File Offset: 0x000D85FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91139, RefRangeEnd = 91141, XrefRangeStart = 91133, XrefRangeEnd = 91139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScalerFitter.NativeMethodInfoPtr_UpdateSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x000DA430 File Offset: 0x000D8630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasScalerFitter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScalerFitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x0002501B File Offset: 0x0002321B
		public CanvasScalerFitter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06003A8F RID: 14991 RVA: 0x000DA46C File Offset: 0x000D866C
		// (set) Token: 0x06003A90 RID: 14992 RVA: 0x00025024 File Offset: 0x00023224
		public unsafe Il2CppReferenceArray<CanvasScalerFitter.BreakPoint> breakPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_breakPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CanvasScalerFitter.BreakPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_breakPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06003A91 RID: 14993 RVA: 0x000DA49C File Offset: 0x000D869C
		// (set) Token: 0x06003A92 RID: 14994 RVA: 0x00025043 File Offset: 0x00023243
		public unsafe CanvasScalerExt canvasScaler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_canvasScaler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasScalerExt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_canvasScaler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x06003A93 RID: 14995 RVA: 0x000DA4CC File Offset: 0x000D86CC
		// (set) Token: 0x06003A94 RID: 14996 RVA: 0x00025062 File Offset: 0x00023262
		public unsafe int screenWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_screenWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_screenWidth)) = value;
			}
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x06003A95 RID: 14997 RVA: 0x000DA4F4 File Offset: 0x000D86F4
		// (set) Token: 0x06003A96 RID: 14998 RVA: 0x0002507D File Offset: 0x0002327D
		public unsafe int screenHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_screenHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_screenHeight)) = value;
			}
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06003A97 RID: 14999 RVA: 0x000DA51C File Offset: 0x000D871C
		// (set) Token: 0x06003A98 RID: 15000 RVA: 0x00025098 File Offset: 0x00023298
		public unsafe Action ScreenSizeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_ScreenSizeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.NativeFieldInfoPtr_ScreenSizeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002337 RID: 9015
		private static readonly IntPtr NativeFieldInfoPtr_breakPoints;

		// Token: 0x04002338 RID: 9016
		private static readonly IntPtr NativeFieldInfoPtr_canvasScaler;

		// Token: 0x04002339 RID: 9017
		private static readonly IntPtr NativeFieldInfoPtr_screenWidth;

		// Token: 0x0400233A RID: 9018
		private static readonly IntPtr NativeFieldInfoPtr_screenHeight;

		// Token: 0x0400233B RID: 9019
		private static readonly IntPtr NativeFieldInfoPtr_ScreenSizeChanged;

		// Token: 0x0400233C RID: 9020
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400233D RID: 9021
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400233E RID: 9022
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSize_Private_Void_0;

		// Token: 0x0400233F RID: 9023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000367 RID: 871
		[Serializable]
		public class BreakPoint : global::Il2CppSystem.Object
		{
			// Token: 0x060054BE RID: 21694 RVA: 0x0013349C File Offset: 0x0013169C
			// Note: this type is marked as 'beforefieldinit'.
			static BreakPoint()
			{
				Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanvasScalerFitter>.NativeClassPtr, "BreakPoint");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr);
				CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr, "name");
				CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_screenAspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr, "screenAspectRatio");
				CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_referenceResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr, "referenceResolution");
				CanvasScalerFitter.BreakPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr, 100668270);
			}

			// Token: 0x060054BF RID: 21695 RVA: 0x00133518 File Offset: 0x00131718
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BreakPoint()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScalerFitter.BreakPoint>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScalerFitter.BreakPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060054C0 RID: 21696 RVA: 0x0003112C File Offset: 0x0002F32C
			public BreakPoint(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001EDF RID: 7903
			// (get) Token: 0x060054C1 RID: 21697 RVA: 0x00133554 File Offset: 0x00131754
			// (set) Token: 0x060054C2 RID: 21698 RVA: 0x00031135 File Offset: 0x0002F335
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001EE0 RID: 7904
			// (get) Token: 0x060054C3 RID: 21699 RVA: 0x0013357C File Offset: 0x0013177C
			// (set) Token: 0x060054C4 RID: 21700 RVA: 0x00031154 File Offset: 0x0002F354
			public unsafe float screenAspectRatio
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_screenAspectRatio);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_screenAspectRatio)) = value;
				}
			}

			// Token: 0x17001EE1 RID: 7905
			// (get) Token: 0x060054C5 RID: 21701 RVA: 0x001335A4 File Offset: 0x001317A4
			// (set) Token: 0x060054C6 RID: 21702 RVA: 0x0003116F File Offset: 0x0002F36F
			public unsafe Vector2 referenceResolution
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_referenceResolution);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScalerFitter.BreakPoint.NativeFieldInfoPtr_referenceResolution)) = value;
				}
			}

			// Token: 0x0400380A RID: 14346
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x0400380B RID: 14347
			private static readonly IntPtr NativeFieldInfoPtr_screenAspectRatio;

			// Token: 0x0400380C RID: 14348
			private static readonly IntPtr NativeFieldInfoPtr_referenceResolution;

			// Token: 0x0400380D RID: 14349
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
