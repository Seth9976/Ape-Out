using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001A RID: 26
	public sealed class GUIScrollGroup : GUILayoutGroup
	{
		// Token: 0x060004F3 RID: 1267 RVA: 0x0001416C File Offset: 0x0001236C
		// Note: this type is marked as 'beforefieldinit'.
		static GUIScrollGroup()
		{
			Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIScrollGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr);
			GUIScrollGroup.NativeFieldInfoPtr_calcMinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMinWidth");
			GUIScrollGroup.NativeFieldInfoPtr_calcMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMaxWidth");
			GUIScrollGroup.NativeFieldInfoPtr_calcMinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMinHeight");
			GUIScrollGroup.NativeFieldInfoPtr_calcMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMaxHeight");
			GUIScrollGroup.NativeFieldInfoPtr_clientWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "clientWidth");
			GUIScrollGroup.NativeFieldInfoPtr_clientHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "clientHeight");
			GUIScrollGroup.NativeFieldInfoPtr_allowHorizontalScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "allowHorizontalScroll");
			GUIScrollGroup.NativeFieldInfoPtr_allowVerticalScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "allowVerticalScroll");
			GUIScrollGroup.NativeFieldInfoPtr_needsHorizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "needsHorizontalScrollbar");
			GUIScrollGroup.NativeFieldInfoPtr_needsVerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "needsVerticalScrollbar");
			GUIScrollGroup.NativeFieldInfoPtr_horizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "horizontalScrollbar");
			GUIScrollGroup.NativeFieldInfoPtr_verticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "verticalScrollbar");
			GUIScrollGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663750);
			GUIScrollGroup.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663751);
			GUIScrollGroup.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663752);
			GUIScrollGroup.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663753);
			GUIScrollGroup.NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663754);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000142F0 File Offset: 0x000124F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510286, XrefRangeEnd = 510290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIScrollGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0001432C File Offset: 0x0001252C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510290, XrefRangeEnd = 510291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00014360 File Offset: 0x00012560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510291, XrefRangeEnd = 510300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetHorizontal(float x, float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000143AC File Offset: 0x000125AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510300, XrefRangeEnd = 510306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000143E0 File Offset: 0x000125E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510306, XrefRangeEnd = 510312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVertical(float y, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref y;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIScrollGroup.NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00003F87 File Offset: 0x00002187
		public GUIScrollGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x0001442C File Offset: 0x0001262C
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00003F90 File Offset: 0x00002190
		public unsafe float calcMinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMinWidth)) = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00014454 File Offset: 0x00012654
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00003FAB File Offset: 0x000021AB
		public unsafe float calcMaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMaxWidth)) = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x0001447C File Offset: 0x0001267C
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00003FC6 File Offset: 0x000021C6
		public unsafe float calcMinHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMinHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMinHeight)) = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x000144A4 File Offset: 0x000126A4
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00003FE1 File Offset: 0x000021E1
		public unsafe float calcMaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_calcMaxHeight)) = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x000144CC File Offset: 0x000126CC
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00003FFC File Offset: 0x000021FC
		public unsafe float clientWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_clientWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_clientWidth)) = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000144F4 File Offset: 0x000126F4
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00004017 File Offset: 0x00002217
		public unsafe float clientHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_clientHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_clientHeight)) = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0001451C File Offset: 0x0001271C
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00004032 File Offset: 0x00002232
		public unsafe bool allowHorizontalScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_allowHorizontalScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_allowHorizontalScroll)) = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00014544 File Offset: 0x00012744
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x0000404D File Offset: 0x0000224D
		public unsafe bool allowVerticalScroll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_allowVerticalScroll);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_allowVerticalScroll)) = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0001456C File Offset: 0x0001276C
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00004068 File Offset: 0x00002268
		public unsafe bool needsHorizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_needsHorizontalScrollbar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_needsHorizontalScrollbar)) = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00014594 File Offset: 0x00012794
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00004083 File Offset: 0x00002283
		public unsafe bool needsVerticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_needsVerticalScrollbar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_needsVerticalScrollbar)) = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x000145BC File Offset: 0x000127BC
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x0000409E File Offset: 0x0000229E
		public unsafe GUIStyle horizontalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_horizontalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_horizontalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x000145EC File Offset: 0x000127EC
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x000040BD File Offset: 0x000022BD
		public unsafe GUIStyle verticalScrollbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_verticalScrollbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIScrollGroup.NativeFieldInfoPtr_verticalScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_calcMinWidth;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_calcMaxWidth;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_calcMinHeight;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_calcMaxHeight;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr_clientWidth;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr_clientHeight;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr_allowHorizontalScroll;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr_allowVerticalScroll;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_needsHorizontalScrollbar;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr_needsVerticalScrollbar;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_horizontalScrollbar;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_verticalScrollbar;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0;
	}
}
