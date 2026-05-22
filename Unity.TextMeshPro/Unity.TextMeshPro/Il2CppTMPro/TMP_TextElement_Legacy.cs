using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro
{
	// Token: 0x02000055 RID: 85
	[Serializable]
	public class TMP_TextElement_Legacy : Object
	{
		// Token: 0x06000B0A RID: 2826 RVA: 0x0002F850 File Offset: 0x0002DA50
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextElement_Legacy()
		{
			Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_TextElement_Legacy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr);
			TMP_TextElement_Legacy.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "id");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "x");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "y");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "width");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "height");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_xOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "xOffset");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_yOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "yOffset");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "xAdvance");
			TMP_TextElement_Legacy.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, "scale");
			TMP_TextElement_Legacy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr, 100664566);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0002F948 File Offset: 0x0002DB48
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextElement_Legacy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextElement_Legacy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextElement_Legacy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x000072D5 File Offset: 0x000054D5
		public TMP_TextElement_Legacy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0002F984 File Offset: 0x0002DB84
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x000072DE File Offset: 0x000054DE
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x0002F9AC File Offset: 0x0002DBAC
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x000072F9 File Offset: 0x000054F9
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x0002F9D4 File Offset: 0x0002DBD4
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00007314 File Offset: 0x00005514
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0002F9FC File Offset: 0x0002DBFC
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x0000732F File Offset: 0x0000552F
		public unsafe float width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0002FA24 File Offset: 0x0002DC24
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x0000734A File Offset: 0x0000554A
		public unsafe float height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0002FA4C File Offset: 0x0002DC4C
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00007365 File Offset: 0x00005565
		public unsafe float xOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_xOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_xOffset)) = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0002FA74 File Offset: 0x0002DC74
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x00007380 File Offset: 0x00005580
		public unsafe float yOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_yOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_yOffset)) = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0002FA9C File Offset: 0x0002DC9C
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x0000739B File Offset: 0x0000559B
		public unsafe float xAdvance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_xAdvance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_xAdvance)) = value;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0002FAC4 File Offset: 0x0002DCC4
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x000073B6 File Offset: 0x000055B6
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextElement_Legacy.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeFieldInfoPtr_xOffset;

		// Token: 0x040008DD RID: 2269
		private static readonly IntPtr NativeFieldInfoPtr_yOffset;

		// Token: 0x040008DE RID: 2270
		private static readonly IntPtr NativeFieldInfoPtr_xAdvance;

		// Token: 0x040008DF RID: 2271
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
